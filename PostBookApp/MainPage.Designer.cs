﻿using System;

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
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_FriendProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_FriendProfileImageBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // m_LoginButton
            // 
            this.m_LoginButton.Location = new System.Drawing.Point(557, 181);
            this.m_LoginButton.Name = "m_LoginButton";
            this.m_LoginButton.Size = new System.Drawing.Size(152, 32);
            this.m_LoginButton.TabIndex = 0;
            this.m_LoginButton.Text = "Login";
            this.m_LoginButton.UseVisualStyleBackColor = true;
            this.m_LoginButton.Click += new System.EventHandler(this.loginClicked);
            // 
            // m_ProfileImage
            // 
            this.m_ProfileImage.Location = new System.Drawing.Point(12, 12);
            this.m_ProfileImage.Name = "m_ProfileImage";
            this.m_ProfileImage.Size = new System.Drawing.Size(54, 52);
            this.m_ProfileImage.TabIndex = 1;
            this.m_ProfileImage.TabStop = false;
            // 
            // m_LogoutButton
            // 
            this.m_LogoutButton.Location = new System.Drawing.Point(86, 23);
            this.m_LogoutButton.Name = "m_LogoutButton";
            this.m_LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.m_LogoutButton.TabIndex = 2;
            this.m_LogoutButton.Text = "Logout";
            this.m_LogoutButton.UseVisualStyleBackColor = true;
            this.m_LogoutButton.Visible = false;
            this.m_LogoutButton.Click += new System.EventHandler(this.logout);
            // 
            // m_FriendsList
            // 
            this.m_FriendsList.FormattingEnabled = true;
            this.m_FriendsList.Location = new System.Drawing.Point(1172, 311);
            this.m_FriendsList.Name = "m_FriendsList";
            this.m_FriendsList.Size = new System.Drawing.Size(123, 199);
            this.m_FriendsList.TabIndex = 3;
            this.m_FriendsList.Visible = false;
            this.m_FriendsList.SelectedIndexChanged += new System.EventHandler(this.displaySelectedFriend);
            // 
            // m_FriendsListTitle
            // 
            this.m_FriendsListTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_FriendsListTitle.Location = new System.Drawing.Point(1196, 296);
            this.m_FriendsListTitle.Name = "m_FriendsListTitle";
            this.m_FriendsListTitle.Size = new System.Drawing.Size(55, 13);
            this.m_FriendsListTitle.TabIndex = 4;
            this.m_FriendsListTitle.Text = "Friends List";
            this.m_FriendsListTitle.Visible = false;
            // 
            // m_FriendProfileImage
            // 
            this.m_FriendProfileImage.BackColor = System.Drawing.Color.White;
            this.m_FriendProfileImage.Location = new System.Drawing.Point(1258, 275);
            this.m_FriendProfileImage.Name = "m_FriendProfileImage";
            this.m_FriendProfileImage.Size = new System.Drawing.Size(31, 31);
            this.m_FriendProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_FriendProfileImage.TabIndex = 5;
            this.m_FriendProfileImage.TabStop = false;
            // 
            // m_FriendProfileImageBorder
            // 
            this.m_FriendProfileImageBorder.BackColor = System.Drawing.Color.White;
            this.m_FriendProfileImageBorder.Location = new System.Drawing.Point(1254, 272);
            this.m_FriendProfileImageBorder.Name = "m_FriendProfileImageBorder";
            this.m_FriendProfileImageBorder.Size = new System.Drawing.Size(39, 37);
            this.m_FriendProfileImageBorder.TabIndex = 7;
            this.m_FriendProfileImageBorder.TabStop = false;
            // 
            // m_CheckinsList
            // 
            this.m_CheckinsList.FormattingEnabled = true;
            this.m_CheckinsList.Location = new System.Drawing.Point(1172, 23);
            this.m_CheckinsList.Name = "m_CheckinsList";
            this.m_CheckinsList.Size = new System.Drawing.Size(123, 238);
            this.m_CheckinsList.TabIndex = 8;
            this.m_CheckinsList.Visible = false;
            // 
            // m_CheckinsListTitle
            // 
            this.m_CheckinsListTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_CheckinsListTitle.Location = new System.Drawing.Point(1193, 8);
            this.m_CheckinsListTitle.Name = "m_CheckinsListTitle";
            this.m_CheckinsListTitle.Size = new System.Drawing.Size(100, 13);
            this.m_CheckinsListTitle.TabIndex = 9;
            this.m_CheckinsListTitle.Text = "Your Checkins";
            this.m_CheckinsListTitle.Visible = false;
            // 
            // m_PostsList
            // 
            this.m_PostsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_PostsList.FormattingEnabled = true;
            this.m_PostsList.Location = new System.Drawing.Point(439, 93);
            this.m_PostsList.Name = "m_PostsList";
            this.m_PostsList.Size = new System.Drawing.Size(368, 91);
            this.m_PostsList.TabIndex = 10;
            this.m_PostsList.Visible = false;
            // 
            // m_PostsListTitle
            // 
            this.m_PostsListTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_PostsListTitle.Location = new System.Drawing.Point(436, 70);
            this.m_PostsListTitle.Name = "m_PostsListTitle";
            this.m_PostsListTitle.Size = new System.Drawing.Size(238, 13);
            this.m_PostsListTitle.TabIndex = 11;
            this.m_PostsListTitle.Text = "Your Posts:";
            this.m_PostsListTitle.Visible = false;
            // 
            // m_LikedPagesList
            // 
            this.m_LikedPagesList.FormattingEnabled = true;
            this.m_LikedPagesList.Location = new System.Drawing.Point(2, 326);
            this.m_LikedPagesList.Name = "m_LikedPagesList";
            this.m_LikedPagesList.Size = new System.Drawing.Size(165, 173);
            this.m_LikedPagesList.TabIndex = 12;
            this.m_LikedPagesList.Visible = false;
            // 
            // m_LoginLoader
            // 
            this.m_LoginLoader.Location = new System.Drawing.Point(517, 219);
            this.m_LoginLoader.Name = "LoginLoader";
            this.m_LoginLoader.Size = new System.Drawing.Size(239, 23);
            this.m_LoginLoader.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.m_LoginLoader.TabIndex = 13;
            this.m_LoginLoader.Visible = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 510);
            this.Controls.Add(this.m_LoginLoader);
            this.Controls.Add(this.m_LikedPagesList);
            this.Controls.Add(this.m_PostsListTitle);
            this.Controls.Add(this.m_PostsList);
            this.Controls.Add(this.m_CheckinsListTitle);
            this.Controls.Add(this.m_CheckinsList);
            this.Controls.Add(this.m_FriendProfileImage);
            this.Controls.Add(this.m_FriendsListTitle);
            this.Controls.Add(this.m_FriendsList);
            this.Controls.Add(this.m_LogoutButton);
            this.Controls.Add(this.m_ProfileImage);
            this.Controls.Add(this.m_LoginButton);
            this.Controls.Add(this.m_FriendProfileImageBorder);
            this.Name = "MainPage";
            this.Text = "PostBook App";
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_FriendProfileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_FriendProfileImageBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

