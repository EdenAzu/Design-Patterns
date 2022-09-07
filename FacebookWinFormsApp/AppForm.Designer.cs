namespace BasicFacebookFeatures
{
    partial class AppForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label religionLabel;
            this.buttonLogout = new System.Windows.Forms.Button();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.listBoxGeneral = new System.Windows.Forms.ListBox();
            this.listBoxGeneralOutput = new System.Windows.Forms.ListBox();
            this.textBoxManu = new System.Windows.Forms.TextBox();
            this.pictureBoxNew = new System.Windows.Forms.PictureBox();
            this.pictureBoxPosts = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxGroups = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlbums = new System.Windows.Forms.PictureBox();
            this.pictureBoxGeneral = new System.Windows.Forms.PictureBox();
            this.pictureBoxTop3Likes = new System.Windows.Forms.PictureBox();
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.pictureBoxMyApp = new System.Windows.Forms.PictureBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.panelFriends = new System.Windows.Forms.Panel();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.religionTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.wallPostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonCloseApplication = new System.Windows.Forms.Button();
            birthdayLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            religionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop3Likes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyApp)).BeginInit();
            this.panelFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallPostsBindingSource)).BeginInit();
            this.SuspendLayout();
            this.buttonPost.Click += postButton_Click;
            this.pictureBoxFriends.DoubleClick += pictureBoxFriends_DoubleClick;
            this.pictureBoxTop3Likes.DoubleClick += pictureBoxTop3Likes_DoubleClick;
            this.pictureBoxAlbums.DoubleClick += pictureBoxAlbums_DoubleClick;
            this.pictureBoxGroups.DoubleClick += pictureBoxGroups_DoubleClick;
            this.pictureBoxPosts.DoubleClick += pictureBoxPosts_DoubleClick;
            this.pictureBoxNew.DoubleClick += pictureBoxNew_DoubleClick;
            this.listBoxGeneralOutput.SelectedIndexChanged += listBoxGeneralOutput_SelectedIndexChanged;
            this.listBoxGeneral.SelectedIndexChanged += listBoxGeneral_SelectedIndexChanged;
            this.buttonLogin.Click += buttonLogin_Click;
            this.buttonLogout.Click += buttonLogout_Click;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(14, 54);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(64, 17);
            birthdayLabel.TabIndex = 2;
            birthdayLabel.Text = "Birthday:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(14, 21);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(14, 91);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(94, 17);
            middleNameLabel.TabIndex = 7;
            middleNameLabel.Text = "Middle Name:";
            // 
            // religionLabel
            // 
            religionLabel.AutoSize = true;
            religionLabel.Location = new System.Drawing.Point(15, 129);
            religionLabel.Name = "religionLabel";
            religionLabel.Size = new System.Drawing.Size(63, 17);
            religionLabel.TabIndex = 9;
            religionLabel.Text = "Religion:";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(15, 585);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(399, 39);
            this.buttonLogout.TabIndex = 56;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(16, 631);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(118, 21);
            this.checkBoxRememberMe.TabIndex = 67;
            this.checkBoxRememberMe.Text = "RememberMe";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(15, 533);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(399, 39);
            this.buttonLogin.TabIndex = 55;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // listBoxGeneral
            // 
            this.listBoxGeneral.FormattingEnabled = true;
            this.listBoxGeneral.ItemHeight = 16;
            this.listBoxGeneral.Location = new System.Drawing.Point(435, 50);
            this.listBoxGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxGeneral.Name = "listBoxGeneral";
            this.listBoxGeneral.Size = new System.Drawing.Size(644, 148);
            this.listBoxGeneral.TabIndex = 59;
            // 
            // listBoxGeneralOutput
            // 
            this.listBoxGeneralOutput.FormattingEnabled = true;
            this.listBoxGeneralOutput.ItemHeight = 16;
            this.listBoxGeneralOutput.Location = new System.Drawing.Point(747, 208);
            this.listBoxGeneralOutput.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxGeneralOutput.Name = "listBoxGeneralOutput";
            this.listBoxGeneralOutput.Size = new System.Drawing.Size(335, 164);
            this.listBoxGeneralOutput.TabIndex = 60;
            // 
            // textBoxManu
            // 
            this.textBoxManu.Enabled = false;
            this.textBoxManu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBoxManu.Location = new System.Drawing.Point(513, 208);
            this.textBoxManu.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxManu.Name = "textBoxManu";
            this.textBoxManu.Size = new System.Drawing.Size(149, 22);
            this.textBoxManu.TabIndex = 62;
            this.textBoxManu.Text = "Double click on image";
            // 
            // pictureBoxNew
            // 
            this.pictureBoxNew.Image = global::BasicFacebookFeatures.Properties.Resources.new_icon;
            this.pictureBoxNew.Location = new System.Drawing.Point(593, 240);
            this.pictureBoxNew.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxNew.Name = "pictureBoxNew";
            this.pictureBoxNew.Size = new System.Drawing.Size(145, 145);
            this.pictureBoxNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNew.TabIndex = 63;
            this.pictureBoxNew.TabStop = false;
            // 
            // pictureBoxPosts
            // 
            this.pictureBoxPosts.Image = global::BasicFacebookFeatures.Properties.Resources.post_icon;
            this.pictureBoxPosts.Location = new System.Drawing.Point(437, 240);
            this.pictureBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPosts.Name = "pictureBoxPosts";
            this.pictureBoxPosts.Size = new System.Drawing.Size(148, 145);
            this.pictureBoxPosts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPosts.TabIndex = 61;
            this.pictureBoxPosts.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(16, 178);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(399, 347);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 6;
            this.pictureBoxProfile.TabStop = false;
            // 
            // pictureBoxGroups
            // 
            this.pictureBoxGroups.Image = global::BasicFacebookFeatures.Properties.Resources.group_icon;
            this.pictureBoxGroups.Location = new System.Drawing.Point(435, 544);
            this.pictureBoxGroups.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxGroups.Name = "pictureBoxGroups";
            this.pictureBoxGroups.Size = new System.Drawing.Size(147, 139);
            this.pictureBoxGroups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGroups.TabIndex = 4;
            this.pictureBoxGroups.TabStop = false;
            // 
            // pictureBoxAlbums
            // 
            this.pictureBoxAlbums.Image = global::BasicFacebookFeatures.Properties.Resources.albums_icon;
            this.pictureBoxAlbums.Location = new System.Drawing.Point(437, 393);
            this.pictureBoxAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAlbums.Name = "pictureBoxAlbums";
            this.pictureBoxAlbums.Size = new System.Drawing.Size(147, 144);
            this.pictureBoxAlbums.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbums.TabIndex = 3;
            this.pictureBoxAlbums.TabStop = false;
            // 
            // pictureBoxGeneral
            // 
            this.pictureBoxGeneral.Location = new System.Drawing.Point(748, 380);
            this.pictureBoxGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxGeneral.Name = "pictureBoxGeneral";
            this.pictureBoxGeneral.Size = new System.Drawing.Size(334, 303);
            this.pictureBoxGeneral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGeneral.TabIndex = 2;
            this.pictureBoxGeneral.TabStop = false;
            // 
            // pictureBoxTop3Likes
            // 
            this.pictureBoxTop3Likes.Image = global::BasicFacebookFeatures.Properties.Resources.top3_icon;
            this.pictureBoxTop3Likes.Location = new System.Drawing.Point(589, 544);
            this.pictureBoxTop3Likes.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxTop3Likes.Name = "pictureBoxTop3Likes";
            this.pictureBoxTop3Likes.Size = new System.Drawing.Size(149, 139);
            this.pictureBoxTop3Likes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTop3Likes.TabIndex = 1;
            this.pictureBoxTop3Likes.TabStop = false;
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.Image = global::BasicFacebookFeatures.Properties.Resources.Friends_icon;
            this.pictureBoxFriends.Location = new System.Drawing.Point(592, 393);
            this.pictureBoxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(148, 144);
            this.pictureBoxFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriends.TabIndex = 0;
            this.pictureBoxFriends.TabStop = false;
            // 
            // pictureBoxMyApp
            // 
            this.pictureBoxMyApp.Image = global::BasicFacebookFeatures.Properties.Resources.app_icon;
            this.pictureBoxMyApp.Location = new System.Drawing.Point(16, 37);
            this.pictureBoxMyApp.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxMyApp.Name = "pictureBoxMyApp";
            this.pictureBoxMyApp.Size = new System.Drawing.Size(400, 134);
            this.pictureBoxMyApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMyApp.TabIndex = 58;
            this.pictureBoxMyApp.TabStop = false;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(437, 20);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(644, 22);
            this.textBoxPost.TabIndex = 64;
            this.textBoxPost.Text = "Write somthing";
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(1006, 19);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 66;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            // 
            // panelFriends
            // 
            this.panelFriends.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelFriends.Controls.Add(this.listBoxFriends);
            this.panelFriends.Controls.Add(religionLabel);
            this.panelFriends.Controls.Add(this.religionTextBox);
            this.panelFriends.Controls.Add(middleNameLabel);
            this.panelFriends.Controls.Add(this.middleNameTextBox);
            this.panelFriends.Controls.Add(birthdayLabel);
            this.panelFriends.Controls.Add(this.birthdayTextBox);
            this.panelFriends.Controls.Add(this.imageNormalPictureBox);
            this.panelFriends.Controls.Add(nameLabel);
            this.panelFriends.Controls.Add(this.nameLabel1);
            this.panelFriends.Location = new System.Drawing.Point(1093, 20);
            this.panelFriends.Name = "panelFriends";
            this.panelFriends.Size = new System.Drawing.Size(310, 351);
            this.panelFriends.TabIndex = 0;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.userBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(15, 158);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(271, 180);
            this.listBoxFriends.TabIndex = 68;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // religionTextBox
            // 
            this.religionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Religion", true));
            this.religionTextBox.Location = new System.Drawing.Point(114, 130);
            this.religionTextBox.Name = "religionTextBox";
            this.religionTextBox.Size = new System.Drawing.Size(100, 22);
            this.religionTextBox.TabIndex = 10;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "MiddleName", true));
            this.middleNameTextBox.Location = new System.Drawing.Point(114, 91);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.middleNameTextBox.TabIndex = 8;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(114, 54);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(100, 22);
            this.birthdayTextBox.TabIndex = 3;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(233, 21);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(70, 71);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 5;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(111, 21);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 7;
            this.nameLabel1.Text = "label1";
            // 
            // wallPostsBindingSource
            // 
            this.wallPostsBindingSource.DataMember = "WallPosts";
            this.wallPostsBindingSource.DataSource = this.userBindingSource;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1093, 377);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 308);
            this.listBox1.TabIndex = 70;
            // 
            // buttonCloseApplication
            // 
            this.buttonCloseApplication.Location = new System.Drawing.Point(16, 658);
            this.buttonCloseApplication.Name = "buttonCloseApplication";
            this.buttonCloseApplication.Size = new System.Drawing.Size(400, 38);
            this.buttonCloseApplication.TabIndex = 71;
            this.buttonCloseApplication.Text = "Close Application";
            this.buttonCloseApplication.UseVisualStyleBackColor = true;
            this.buttonCloseApplication.Click += new System.EventHandler(this.buttonCloseApplication_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 708);
            this.Controls.Add(this.buttonCloseApplication);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panelFriends);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.pictureBoxNew);
            this.Controls.Add(this.textBoxManu);
            this.Controls.Add(this.pictureBoxPosts);
            this.Controls.Add(this.listBoxGeneralOutput);
            this.Controls.Add(this.listBoxGeneral);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.pictureBoxGroups);
            this.Controls.Add(this.pictureBoxAlbums);
            this.Controls.Add(this.pictureBoxGeneral);
            this.Controls.Add(this.pictureBoxTop3Likes);
            this.Controls.Add(this.pictureBoxFriends);
            this.Controls.Add(this.pictureBoxMyApp);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AppForm";
            this.Text = "MyApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop3Likes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyApp)).EndInit();
            this.panelFriends.ResumeLayout(false);
            this.panelFriends.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallPostsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }





        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxTop3Likes;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.PictureBox pictureBoxGeneral;
        private System.Windows.Forms.PictureBox pictureBoxAlbums;
        private System.Windows.Forms.PictureBox pictureBoxGroups;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxMyApp;
        private System.Windows.Forms.ListBox listBoxGeneral;
        private System.Windows.Forms.ListBox listBoxGeneralOutput;
        private System.Windows.Forms.PictureBox pictureBoxPosts;
        private System.Windows.Forms.TextBox textBoxManu;
        private System.Windows.Forms.PictureBox pictureBoxNew;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Panel panelFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.BindingSource wallPostsBindingSource;
        private System.Windows.Forms.TextBox religionTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonCloseApplication;
    }
}
