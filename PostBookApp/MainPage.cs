using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PostBookApp.Util;

namespace PostBookApp
{
    public partial class MainPage : Form
    {
        private User m_LoggedInUser;
        private string m_Token;
        private FacebookObjectCollection<Album> m_SavedAlbums;
        private FacebookObjectCollection<MockPage> m_SavedLikedPages = MockHelper.getMockedPages(5);
        private FacebookObjectCollection<User> m_SavedFriends = new FacebookObjectCollection<User>();

       
        public MainPage()
        {
            InitializeComponent();
        }

        private void loginAndInit()
        {
            this.showLoader(true);
            LoginResult result = FacebookService.Login("817562982032756",

                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown"
                );

            this.m_Token = result.AccessToken;

            if (!string.IsNullOrEmpty(this.m_Token))
            {
                this.m_LoggedInUser = result.LoggedInUser;

                this.fetchFriends();
                this.fetchCheckins();
                this.fetchPosts();
                this.fetchLikedPages();
                this.fetchAlbums();

                this.showUIComponents();
            }
            else
            {
                MessageBox.Show("Error while logging in");
            }
        }

        private void showLoader(bool i_v)
        {
            this.m_LoginLoader.Visible = i_v;
        }

        private void showUIComponents()
        {
            this.showLoader(false);

            this.m_LoginButton.Visible = false;
            this.m_LogoutButton.Visible = true;

            this.m_PostsListTitle.Visible = true;
            this.m_PostsList.Visible = true;

            this.m_FriendsList.Visible = true;
            this.m_FriendsListTitle.Visible = true;

            this.m_CheckinsList.Visible = true;
            this.m_CheckinsListTitle.Visible = true;

            this.m_LikedPagesList.Visible = true;

            this.m_ProfileImage.LoadAsync(this.m_LoggedInUser.PictureSmallURL);
        }

        private void logout(object i_sender, EventArgs i_e)
        {
            this.showLoader(true);
            FacebookService.Logout(new Action(() => {
                this.showLoader(false);
                this.clearUIComponents();
            }));
        }

        private void clearUIComponents()
        {
            this.m_ProfileImage.ImageLocation = "";
            this.m_FriendProfileImage.ImageLocation = "";
            this.m_FriendProfileImageBorder.BackColor = Color.White;

            this.m_CheckinsList.Items.Clear();
            this.m_CheckinsList.Visible = false;
            this.m_CheckinsListTitle.Visible = false;

            this.m_FriendsList.Items.Clear();
            this.m_FriendsList.Visible = false;
            this.m_FriendsListTitle.Visible = false;

            this.m_PostsList.Items.Clear();
            this.m_PostsList.Visible = false;
            this.m_PostsListTitle.Visible = false;

            this.m_LikedPagesList.Items.Clear();
            this.m_LikedPagesList.Visible = false;

            this.m_LogoutButton.Visible = false;
            this.m_LoginButton.Visible = true;
        }

        private void fetchLikedPages()
        {
            this.m_LikedPagesList.Items.Clear();
            this.m_LikedPagesList.DisplayMember = "Name";
            //FacebookObjectCollection<Page> pages = this.m_LoggedInUser.LikedPages; // this doesnt work so i fetch the data without the wrapper
            string query = string.Format("https://graph.facebook.com/v5.0/{0}/likes/?access_token={1}", this.m_LoggedInUser.Id, this.m_Token);
            dynamic a = new Facebook.FacebookClient().Get(query);
            
            foreach (dynamic item in a.data)
            {
                this.m_LikedPagesList.Items.Add(item.name);
            }
        }

        private void fetchPosts()
        {
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    this.m_PostsList.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    this.m_PostsList.Items.Add(post.Caption);
                }
                else
                {
                    this.m_PostsList.Items.Add(string.Format("[{0}]", post.Type));
                }
            }
        }

        private void fetchFriends()
        {
            this.m_FriendsList.Items.Clear();
            this.m_FriendsList.DisplayMember = "Name";
            foreach (User friend in m_LoggedInUser.Friends)
            {
                this.m_FriendsList.Items.Add(friend);
                this.m_FriendsListBox.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                this.m_SavedFriends.Add(friend);
            }
        }

        private void fetchAlbums()
        {
            this.m_SavedAlbums = this.m_LoggedInUser.Albums;

            foreach (Album album in this.m_SavedAlbums)
            {
                this.m_AlbumsList.Items.Add(album.Name);
            }
        }

        private void friendSelected(object i_sender, EventArgs i_e)
        {
            if(this.m_FriendsList.SelectedItems.Count == 1)
            {
                User selectedFriend = this.m_FriendsList.SelectedItem as User;
                /*FacebookObjectCollection<Page> friendLikedPages = selectedFriend.LikedPages;*/ // fetching the selected friend Liked pages threw OAuth exception for some reason, im mocking out the Intersected Pages

                IEnumerable<MockPage> intersectedPages = MockHelper.getMockedPages(2); // friendLikedPages.Intersect(this.m_SavedLikedPages, new PageEqualityComparer());

                foreach (var page in intersectedPages)
                {
                    this.m_MutualLikedPagesListBox.Items.Add(page.Name);
                }
            }
        }

        private void displaySelectedAlbum(object i_sender, EventArgs i_e)
        {
            if (this.m_AlbumsList.SelectedItems.Count == 1)
            {
                string selectedAlbumName = this.m_AlbumsList.SelectedItem as string;
                // TODO - Change all lambdas to regular functions
                Album selectedAlbum = this.m_SavedAlbums.Find((album) => album.Name == selectedAlbumName);
                FacebookObjectCollection<Photo> photos = selectedAlbum.Photos;
                IOrderedEnumerable<Photo> ordered = photos.OrderBy(this.getLikedByCount);
                Photo topLikedPhoto = ordered.Last();

                Comment mostLikedCommentFromTopLikedPhoto = getMostLikedCommentFromPhoto(topLikedPhoto);

                this.m_MostLikedPhotoPictureBox.LoadAsync(topLikedPhoto.PictureThumbURL);
                if (mostLikedCommentFromTopLikedPhoto != null) 
                {
                    this.m_MostLikedCommentFromMostLikedPhotoTextBox.Text = mostLikedCommentFromTopLikedPhoto.Message;
                }
                else
                {
                    this.m_MostLikedCommentFromMostLikedPhotoTextBox.Text = "No Comments...";
                }

            }
        }

        private Comment getMostLikedCommentFromPhoto(Photo photo)
        {
            Comment result = null;
            FacebookObjectCollection<Comment> comments = photo.Comments;

            if(comments.Count > 0)
            {
                IOrderedEnumerable<Comment> orderedCommentsByLikes = comments.OrderBy(this.getLikedByCount);
                Comment c = orderedCommentsByLikes.Last();
                result = c;
            }

            return result;
        }

        private int getLikedByCount(PostedItem postedItem)
        {
            int count = postedItem.LikedBy.Count;
            return count;
        }

        private void fetchCheckins()
        {
            foreach (Checkin checkin in this.m_LoggedInUser.Checkins)
            {
                this.m_CheckinsList.Items.Add(checkin.Place.Name);
            }
        }

        private void displaySelectedFriend(object i_sender, EventArgs i_e)
        {
            if (this.m_FriendsList.SelectedItems.Count == 1)
            {
                User selectedFriend = this.m_FriendsList.SelectedItem as User;
                User.eOnlineStatus? status = selectedFriend.OnlineStatus;
                if (selectedFriend.PictureNormalURL != null)
                {
                    this.m_FriendProfileImage.LoadAsync(selectedFriend.PictureSmallURL);
                    if(status != null)
                    {
                        if(status == User.eOnlineStatus.active)
                        {
                            this.m_FriendProfileImageBorder.BackColor = Color.LawnGreen;
                        } 
                        else
                        {
                            this.m_FriendProfileImageBorder.BackColor = Color.Red;
                        }
                    }
                    else // since getting online status always return null i'll color it red 
                    {
                       this.m_FriendProfileImageBorder.BackColor = Color.Red;        
                    }
                }
            }
        }
    }
}
