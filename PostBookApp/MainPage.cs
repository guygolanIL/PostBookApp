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

        User m_LoggedInUser;
        public MainPage()
        {
            InitializeComponent();
        }

        private void loginAndInit()
        {
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

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                this.m_LoginButton.Enabled = false;
                this.m_LogoutButton.Enabled = true;
                this.m_LoggedInUser = result.LoggedInUser;
                this.m_ProfileImage.LoadAsync(this.m_LoggedInUser.PictureSmallURL);
                this.fetchFriends();
                this.fetchCheckins();
                this.fetchPosts();
            }
            else
            {
                MessageBox.Show("Error while logging in");
            }
        }

        private void logout(object sender, EventArgs e)
        {
            FacebookService.Logout(new Action(() => {
                this.clearUIData();
            }));
        }

        private void clearUIData()
        {
            this.m_ProfileImage.ImageLocation = "";
            this.m_FriendProfileImage.ImageLocation = "";
            this.m_FriendProfileImageBorder.BackColor = Color.White;
            this.m_CheckinsList.Items.Clear();
            this.m_FriendsList.Items.Clear();
            this.m_PostsList.Items.Clear();
            this.m_LogoutButton.Enabled = false;
            this.m_LoginButton.Enabled = true;
        }

        private void fetchLikedPages()
        {
            FacebookObjectCollection<Page> pages = this.m_LoggedInUser.LikedPages;
            foreach (Page p in pages)
            {
                //this.m_LikedPagesList;
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
