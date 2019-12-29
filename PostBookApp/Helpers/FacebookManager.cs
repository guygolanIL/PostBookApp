using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using PostBookApp.AppSettings;

namespace PostBookApp.Helpers
{
    class FacebookManager
    {
        private User m_LoggedInUser;
        private string m_Token;
        private FacebookObjectCollection<User> m_FriendsList;
        private List<string> m_CheckinsList;
        private List<string> m_PostsList;
        private List<string> m_AlbumsList;
        public FacebookManager()
        {
            LoginResult result = FacebookService.Login(AppProperties.getAppId(), AppProperties.getAppPermissions());
            this.m_Token = result.AccessToken;
            if (!string.IsNullOrEmpty(this.m_Token))
            {
                this.m_LoggedInUser = result.LoggedInUser;
            } 
            else
            {
                this.m_LoggedInUser = null;
            }

            this.m_FriendsList = new FacebookObjectCollection<User>();
            this.m_CheckinsList = new List<string>();
            this.m_PostsList = new List<string>();
            this.m_AlbumsList = new List<string>();
        }

        private void fetchFriends()
        {
            foreach (User friend in m_LoggedInUser.Friends)
            {
                this.m_FriendsList.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }
        }

        private void fetchCheckins()
        {
            foreach (Checkin checkin in this.m_LoggedInUser.Checkins)
            {
                this.m_CheckinsList.Add(checkin.Place.Name);
            }
        }

        private void fetchPosts()
        {
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    this.m_PostsList.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    this.m_PostsList.Add(post.Caption);
                }
                else
                {
                    this.m_PostsList.Add(string.Format("[{0}]", post.Type));
                }
            }
        }

        private void fetchAlbums()
        {
            foreach (Album album in this.m_LoggedInUser.Albums)
            {
                this.m_AlbumsList.Add(album.Name);
            }
        }
    }
}
