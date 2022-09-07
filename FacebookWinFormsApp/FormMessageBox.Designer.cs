
namespace BasicFacebookFeatures
{
    partial class FormMessageBox
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
            this.buttonThreeTopLikes = new System.Windows.Forms.Button();
            this.buttonFriendsName = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonThreeTopLikes
            // 
            this.buttonThreeTopLikes.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonThreeTopLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThreeTopLikes.Location = new System.Drawing.Point(321, 93);
            this.buttonThreeTopLikes.Name = "buttonThreeTopLikes";
            this.buttonThreeTopLikes.Size = new System.Drawing.Size(174, 41);
            this.buttonThreeTopLikes.TabIndex = 0;
            this.buttonThreeTopLikes.Text = "ThreeTopLikes";
            this.buttonThreeTopLikes.UseVisualStyleBackColor = false;
            this.buttonThreeTopLikes.Click += new System.EventHandler(this.buttonThreeTopLikes_Click);
            // 
            // buttonFriendsName
            // 
            this.buttonFriendsName.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonFriendsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFriendsName.Location = new System.Drawing.Point(87, 93);
            this.buttonFriendsName.Name = "buttonFriendsName";
            this.buttonFriendsName.Size = new System.Drawing.Size(174, 41);
            this.buttonFriendsName.TabIndex = 1;
            this.buttonFriendsName.Text = "FriendsFirstName";
            this.buttonFriendsName.UseVisualStyleBackColor = false;
            this.buttonFriendsName.Click += new System.EventHandler(this.buttonFriendsName_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(12, 47);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(503, 20);
            this.labelText.TabIndex = 2;
            this.labelText.Text = "In what sort would you be interested in displaying your friends list?";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(215, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(583, 193);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonFriendsName);
            this.Controls.Add(this.buttonThreeTopLikes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMessageBox";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThreeTopLikes;
        private System.Windows.Forms.Button buttonFriendsName;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button button1;
    }
}