using System;

namespace PostBookApp
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_LoginButton = new System.Windows.Forms.Button();
            this.m_ProfileImage = new System.Windows.Forms.PictureBox();
            this.m_LogoutButton = new System.Windows.Forms.Button();
            this.m_FriendsList = new System.Windows.Forms.ListBox();
            this.m_FriendsListTitle = new System.Windows.Forms.TextBox();
            this.m_FriendProfileImage = new System.Windows.Forms.PictureBox();
            this.m_FriendProfileImageBorder = new System.Windows.Forms.PictureBox();
            this.m_CheckinsList = new System.Windows.Forms.ListBox();
            this.m_CheckinsListTitle = new System.Windows.Forms.TextBox();
            this.m_PostsList = new System.Windows.Forms.ListBox();
            this.m_PostsListTitle = new System.Windows.Forms.TextBox();
            this.m_LikedPagesList = new System.Windows.Forms.ListBox();
            this.m_LoginLoader = new System.Windows.Forms.ProgressBar();
            this.m_TabControl = new System.Windows.Forms.TabControl();
            this.m_HomeTab = new System.Windows.Forms.TabPage();
            this.m_AlbumsTab = new System.Windows.Forms.TabPage();
            this.m_MostLikedCommentFromMostLikedPhotoTextBox = new System.Windows.Forms.RichTextBox();
            this.m_MostLikedPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.m_AlbumsList = new System.Windows.Forms.ListBox();
            this.m_FriendsAndPagesTab = new System.Windows.Forms.TabPage();
            this.m_FriendsListBox = new System.Windows.Forms.ListBox();
            this.m_MutualLikedPagesListBox = new System.Windows.Forms.ListBox();
            this.m_FriendsListTitleTextBox = new System.Windows.Forms.RichTextBox();
            this.m_MutualLikedPagesTitleTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_FriendProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_FriendProfileImageBorder)).BeginInit();
            this.m_TabControl.SuspendLayout();
            this.m_HomeTab.SuspendLayout();
            this.m_AlbumsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_MostLikedPhotoPictureBox)).BeginInit();
            this.m_FriendsAndPagesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_LoginButton
            // 
            this.m_LoginButton.Location = new System.Drawing.Point(1464, 482);
            this.m_LoginButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_LoginButton.Name = "m_LoginButton";
            this.m_LoginButton.Size = new System.Drawing.Size(405, 76);
            this.m_LoginButton.TabIndex = 0;
            this.m_LoginButton.Text = "Login";
            this.m_LoginButton.UseVisualStyleBackColor = true;
            this.m_LoginButton.Click += new System.EventHandler(this.loginClicked);
            // 
            // m_ProfileImage
            // 
            this.m_ProfileImage.Location = new System.Drawing.Point(16, 24);
            this.m_ProfileImage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_ProfileImage.Name = "m_ProfileImage";
            this.m_ProfileImage.Size = new System.Drawing.Size(144, 124);
            this.m_ProfileImage.TabIndex = 1;
            this.m_ProfileImage.TabStop = false;
            // 
            // m_LogoutButton
            // 
            this.m_LogoutButton.Location = new System.Drawing.Point(203, 52);
            this.m_LogoutButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_LogoutButton.Name = "m_LogoutButton";
            this.m_LogoutButton.Size = new System.Drawing.Size(200, 55);
            this.m_LogoutButton.TabIndex = 2;
            this.m_LogoutButton.Text = "Logout";
            this.m_LogoutButton.UseVisualStyleBackColor = true;
            this.m_LogoutButton.Visible = false;
            this.m_LogoutButton.Click += new System.EventHandler(this.logout);
            // 
            // m_FriendsList
            // 
            this.m_FriendsList.FormattingEnabled = true;
            this.m_FriendsList.ItemHeight = 31;
            this.m_FriendsList.Location = new System.Drawing.Point(3099, 806);
            this.m_FriendsList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_FriendsList.Name = "m_FriendsList";
            this.m_FriendsList.Size = new System.Drawing.Size(321, 345);
            this.m_FriendsList.TabIndex = 3;
            this.m_FriendsList.Visible = false;
            this.m_FriendsList.SelectedIndexChanged += new System.EventHandler(this.displaySelectedFriend);
            // 
            // m_FriendsListTitle
            // 
            this.m_FriendsListTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_FriendsListTitle.Location = new System.Drawing.Point(3165, 770);
            this.m_FriendsListTitle.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_FriendsListTitle.Name = "m_FriendsListTitle";
            this.m_FriendsListTitle.Size = new System.Drawing.Size(147, 31);
            this.m_FriendsListTitle.TabIndex = 4;
            this.m_FriendsListTitle.Text = "Friends List";
            this.m_FriendsListTitle.Visible = false;
            // 
            // m_FriendProfileImage
            // 
            this.m_FriendProfileImage.BackColor = System.Drawing.Color.White;
            this.m_FriendProfileImage.Location = new System.Drawing.Point(3325, 720);
            this.m_FriendProfileImage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_FriendProfileImage.Name = "m_FriendProfileImage";
            this.m_FriendProfileImage.Size = new System.Drawing.Size(83, 74);
            this.m_FriendProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_FriendProfileImage.TabIndex = 5;
            this.m_FriendProfileImage.TabStop = false;
            // 
            // m_FriendProfileImageBorder
            // 
            this.m_FriendProfileImageBorder.BackColor = System.Drawing.Color.White;
            this.m_FriendProfileImageBorder.Location = new System.Drawing.Point(3315, 713);
            this.m_FriendProfileImageBorder.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_FriendProfileImageBorder.Name = "m_FriendProfileImageBorder";
            this.m_FriendProfileImageBorder.Size = new System.Drawing.Size(104, 88);
            this.m_FriendProfileImageBorder.TabIndex = 7;
            this.m_FriendProfileImageBorder.TabStop = false;
            // 
            // m_CheckinsList
            // 
            this.m_CheckinsList.FormattingEnabled = true;
            this.m_CheckinsList.ItemHeight = 31;
            this.m_CheckinsList.Location = new System.Drawing.Point(3099, 126);
            this.m_CheckinsList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_CheckinsList.Name = "m_CheckinsList";
            this.m_CheckinsList.Size = new System.Drawing.Size(321, 562);
            this.m_CheckinsList.TabIndex = 8;
            this.m_CheckinsList.Visible = false;
            // 
            // m_CheckinsListTitle
            // 
            this.m_CheckinsListTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_CheckinsListTitle.Location = new System.Drawing.Point(3141, 81);
            this.m_CheckinsListTitle.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_CheckinsListTitle.Name = "m_CheckinsListTitle";
            this.m_CheckinsListTitle.Size = new System.Drawing.Size(267, 31);
            this.m_CheckinsListTitle.TabIndex = 9;
            this.m_CheckinsListTitle.Text = "Your Checkins";
            this.m_CheckinsListTitle.Visible = false;
            // 
            // m_PostsList
            // 
            this.m_PostsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_PostsList.FormattingEnabled = true;
            this.m_PostsList.ItemHeight = 31;
            this.m_PostsList.Location = new System.Drawing.Point(1123, 172);
            this.m_PostsList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_PostsList.Name = "m_PostsList";
            this.m_PostsList.Size = new System.Drawing.Size(981, 217);
            this.m_PostsList.TabIndex = 10;
            this.m_PostsList.Visible = false;
            // 
            // m_PostsListTitle
            // 
            this.m_PostsListTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_PostsListTitle.Location = new System.Drawing.Point(1123, 126);
            this.m_PostsListTitle.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_PostsListTitle.Name = "m_PostsListTitle";
            this.m_PostsListTitle.Size = new System.Drawing.Size(635, 31);
            this.m_PostsListTitle.TabIndex = 11;
            this.m_PostsListTitle.Text = "Your Posts:";
            this.m_PostsListTitle.Visible = false;
            // 
            // m_LikedPagesList
            // 
            this.m_LikedPagesList.FormattingEnabled = true;
            this.m_LikedPagesList.ItemHeight = 31;
            this.m_LikedPagesList.Location = new System.Drawing.Point(0, 744);
            this.m_LikedPagesList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_LikedPagesList.Name = "m_LikedPagesList";
            this.m_LikedPagesList.Size = new System.Drawing.Size(433, 407);
            this.m_LikedPagesList.TabIndex = 12;
            this.m_LikedPagesList.Visible = false;
            // 
            // m_LoginLoader
            // 
            this.m_LoginLoader.Location = new System.Drawing.Point(1360, 572);
            this.m_LoginLoader.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_LoginLoader.Name = "m_LoginLoader";
            this.m_LoginLoader.Size = new System.Drawing.Size(637, 55);
            this.m_LoginLoader.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.m_LoginLoader.TabIndex = 13;
            this.m_LoginLoader.Visible = false;
            // 
            // m_TabControl
            // 
            this.m_TabControl.Controls.Add(this.m_HomeTab);
            this.m_TabControl.Controls.Add(this.m_AlbumsTab);
            this.m_TabControl.Controls.Add(this.m_FriendsAndPagesTab);
            this.m_TabControl.Location = new System.Drawing.Point(5, -2);
            this.m_TabControl.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_TabControl.Name = "m_TabControl";
            this.m_TabControl.SelectedIndex = 0;
            this.m_TabControl.Size = new System.Drawing.Size(3448, 1219);
            this.m_TabControl.TabIndex = 14;
            // 
            // m_HomeTab
            // 
            this.m_HomeTab.Controls.Add(this.m_FriendsList);
            this.m_HomeTab.Controls.Add(this.m_CheckinsListTitle);
            this.m_HomeTab.Controls.Add(this.m_LoginLoader);
            this.m_HomeTab.Controls.Add(this.m_FriendProfileImage);
            this.m_HomeTab.Controls.Add(this.m_FriendProfileImageBorder);
            this.m_HomeTab.Controls.Add(this.m_CheckinsList);
            this.m_HomeTab.Controls.Add(this.m_FriendsListTitle);
            this.m_HomeTab.Controls.Add(this.m_LogoutButton);
            this.m_HomeTab.Controls.Add(this.m_PostsList);
            this.m_HomeTab.Controls.Add(this.m_PostsListTitle);
            this.m_HomeTab.Controls.Add(this.m_LikedPagesList);
            this.m_HomeTab.Controls.Add(this.m_ProfileImage);
            this.m_HomeTab.Controls.Add(this.m_LoginButton);
            this.m_HomeTab.Location = new System.Drawing.Point(10, 48);
            this.m_HomeTab.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_HomeTab.Name = "m_HomeTab";
            this.m_HomeTab.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_HomeTab.Size = new System.Drawing.Size(3428, 1161);
            this.m_HomeTab.TabIndex = 0;
            this.m_HomeTab.Text = "Home";
            this.m_HomeTab.UseVisualStyleBackColor = true;
            // 
            // m_AlbumsTab
            // 
            this.m_AlbumsTab.Controls.Add(this.m_MostLikedCommentFromMostLikedPhotoTextBox);
            this.m_AlbumsTab.Controls.Add(this.m_MostLikedPhotoPictureBox);
            this.m_AlbumsTab.Controls.Add(this.m_AlbumsList);
            this.m_AlbumsTab.Location = new System.Drawing.Point(10, 48);
            this.m_AlbumsTab.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_AlbumsTab.Name = "m_AlbumsTab";
            this.m_AlbumsTab.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_AlbumsTab.Size = new System.Drawing.Size(3428, 1161);
            this.m_AlbumsTab.TabIndex = 1;
            this.m_AlbumsTab.Text = "Albums";
            this.m_AlbumsTab.UseVisualStyleBackColor = true;
            // 
            // m_MostLikedCommentFromMostLikedPhotoTextBox
            // 
            this.m_MostLikedCommentFromMostLikedPhotoTextBox.Location = new System.Drawing.Point(1022, 736);
            this.m_MostLikedCommentFromMostLikedPhotoTextBox.Name = "m_MostLikedCommentFromMostLikedPhotoTextBox";
            this.m_MostLikedCommentFromMostLikedPhotoTextBox.Size = new System.Drawing.Size(514, 96);
            this.m_MostLikedCommentFromMostLikedPhotoTextBox.TabIndex = 2;
            this.m_MostLikedCommentFromMostLikedPhotoTextBox.Text = "";
            // 
            // m_MostLikedPhotoPictureBox
            // 
            this.m_MostLikedPhotoPictureBox.Location = new System.Drawing.Point(1040, 224);
            this.m_MostLikedPhotoPictureBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_MostLikedPhotoPictureBox.Name = "m_MostLikedPhotoPictureBox";
            this.m_MostLikedPhotoPictureBox.Size = new System.Drawing.Size(496, 458);
            this.m_MostLikedPhotoPictureBox.TabIndex = 1;
            this.m_MostLikedPhotoPictureBox.TabStop = false;
            // 
            // m_AlbumsList
            // 
            this.m_AlbumsList.FormattingEnabled = true;
            this.m_AlbumsList.ItemHeight = 31;
            this.m_AlbumsList.Location = new System.Drawing.Point(187, 224);
            this.m_AlbumsList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_AlbumsList.Name = "m_AlbumsList";
            this.m_AlbumsList.Size = new System.Drawing.Size(655, 562);
            this.m_AlbumsList.TabIndex = 0;
            this.m_AlbumsList.SelectedIndexChanged += new System.EventHandler(this.displaySelectedAlbum);
            // 
            // m_FriendsAndPagesTab
            // 
            this.m_FriendsAndPagesTab.Controls.Add(this.m_MutualLikedPagesTitleTextBox);
            this.m_FriendsAndPagesTab.Controls.Add(this.m_FriendsListTitleTextBox);
            this.m_FriendsAndPagesTab.Controls.Add(this.m_MutualLikedPagesListBox);
            this.m_FriendsAndPagesTab.Controls.Add(this.m_FriendsListBox);
            this.m_FriendsAndPagesTab.Location = new System.Drawing.Point(10, 48);
            this.m_FriendsAndPagesTab.Name = "tabPage1";
            this.m_FriendsAndPagesTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_FriendsAndPagesTab.Size = new System.Drawing.Size(3428, 1161);
            this.m_FriendsAndPagesTab.TabIndex = 2;
            this.m_FriendsAndPagesTab.Text = "tabPage1";
            this.m_FriendsAndPagesTab.UseVisualStyleBackColor = true;
            // 
            // m_FriendsListBox
            // 
            this.m_FriendsListBox.FormattingEnabled = true;
            this.m_FriendsListBox.ItemHeight = 31;
            this.m_FriendsListBox.Location = new System.Drawing.Point(187, 233);
            this.m_FriendsListBox.Name = "listBox1";
            this.m_FriendsListBox.Size = new System.Drawing.Size(290, 376);
            this.m_FriendsListBox.TabIndex = 0;
            this.m_FriendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendSelected);
            // 
            // m_MutualLikedPagesListBox
            // 
            this.m_MutualLikedPagesListBox.FormattingEnabled = true;
            this.m_MutualLikedPagesListBox.ItemHeight = 31;
            this.m_MutualLikedPagesListBox.Location = new System.Drawing.Point(1147, 233);
            this.m_MutualLikedPagesListBox.Name = "listBox2";
            this.m_MutualLikedPagesListBox.Size = new System.Drawing.Size(300, 376);
            this.m_MutualLikedPagesListBox.TabIndex = 1;
            // 
            // m_FriendsListTitleTextBox
            // 
            this.m_FriendsListTitleTextBox.Location = new System.Drawing.Point(187, 101);
            this.m_FriendsListTitleTextBox.Name = "richTextBox1";
            this.m_FriendsListTitleTextBox.Size = new System.Drawing.Size(290, 92);
            this.m_FriendsListTitleTextBox.TabIndex = 2;
            this.m_FriendsListTitleTextBox.Text = "Friends List";
            // 
            // m_MutualLikedPagesTitleTextBox
            // 
            this.m_MutualLikedPagesTitleTextBox.Location = new System.Drawing.Point(1147, 101);
            this.m_MutualLikedPagesTitleTextBox.Name = "richTextBox2";
            this.m_MutualLikedPagesTitleTextBox.Size = new System.Drawing.Size(300, 92);
            this.m_MutualLikedPagesTitleTextBox.TabIndex = 3;
            this.m_MutualLikedPagesTitleTextBox.Text = "Mutual Liked Pages";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3204, 1216);
            this.Controls.Add(this.m_TabControl);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainPage";
            this.Text = "PostBook App";
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_FriendProfileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_FriendProfileImageBorder)).EndInit();
            this.m_TabControl.ResumeLayout(false);
            this.m_HomeTab.ResumeLayout(false);
            this.m_HomeTab.PerformLayout();
            this.m_AlbumsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_MostLikedPhotoPictureBox)).EndInit();
            this.m_FriendsAndPagesTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void loginClicked(object sender, EventArgs e)
        {
            this.loginAndInit();
        }

        #endregion

        private System.Windows.Forms.Button m_LoginButton;
        private System.Windows.Forms.PictureBox m_ProfileImage;
        private System.Windows.Forms.Button m_LogoutButton;
        private System.Windows.Forms.ListBox m_FriendsList;
        private System.Windows.Forms.TextBox m_FriendsListTitle;
        private System.Windows.Forms.PictureBox m_FriendProfileImage;
        private System.Windows.Forms.PictureBox m_FriendProfileImageBorder;
        private System.Windows.Forms.ListBox m_CheckinsList;
        private System.Windows.Forms.TextBox m_CheckinsListTitle;
        private System.Windows.Forms.ListBox m_PostsList;
        private System.Windows.Forms.TextBox m_PostsListTitle;
        private System.Windows.Forms.ListBox m_LikedPagesList;
        private System.Windows.Forms.ProgressBar m_LoginLoader;
        private System.Windows.Forms.TabControl m_TabControl;
        private System.Windows.Forms.TabPage m_HomeTab;
        private System.Windows.Forms.TabPage m_AlbumsTab;
        private System.Windows.Forms.ListBox m_AlbumsList;
        private System.Windows.Forms.PictureBox m_MostLikedPhotoPictureBox;
        private System.Windows.Forms.RichTextBox m_MostLikedCommentFromMostLikedPhotoTextBox;
        private System.Windows.Forms.TabPage m_FriendsAndPagesTab;
        private System.Windows.Forms.RichTextBox m_MutualLikedPagesTitleTextBox;
        private System.Windows.Forms.RichTextBox m_FriendsListTitleTextBox;
        private System.Windows.Forms.ListBox m_MutualLikedPagesListBox;
        private System.Windows.Forms.ListBox m_FriendsListBox;
    }
}

