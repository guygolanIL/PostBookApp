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

namespace PostBookApp
{
    public partial class MainPage : Form
    {

        private User m_LoggedInUser;
        private string m_Token;

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

                this.showUIComponents();
            }
            else
            {
                MessageBox.Show("Error while logging in");
            }
        }

        private void showLoader(bool v)
        {
            this.m_LoginLoader.Visible = v;
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

        private void logout(object sender, EventArgs e)
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
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }
        }

        private void fetchCheckins()
        {
            foreach (Checkin checkin in this.m_LoggedInUser.Checkins)
            {
                this.m_CheckinsList.Items.Add(checkin.Place.Name);
            }
        }

        private void displaySelectedFriend(object sender, EventArgs e)
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
