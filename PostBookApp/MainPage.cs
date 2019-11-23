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
                this.m_LoggedInUser = result.LoggedInUser;
                this.m_ProfileImage.LoadAsync(this.m_LoggedInUser.PictureSmallURL);
                MessageBox.Show(string.Format("Hello {0} {1}", this.m_LoggedInUser.FirstName, this.m_LoggedInUser.LastName));
            }
            else
            {
                MessageBox.Show("Error while logging in");
            }
        }


    }
}
