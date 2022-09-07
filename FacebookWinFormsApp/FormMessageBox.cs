using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMessageBox : Form
    {
        public bool buttonFriendsNameClicked { get; set; }
        public bool buttonThreeTopLikesClicked { get; set; }
        private Visitor visitor;

        public FormMessageBox()
        {
            InitializeComponent();
            visitor = new Visitor();
        }

        private void buttonFriendsName_Click(object sender, EventArgs e)
        {
            buttonFriendsNameClicked = true;
            Close();
        }

        private void buttonThreeTopLikes_Click(object sender, EventArgs e)
        {
            buttonThreeTopLikesClicked = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visitor.changeColorAndCloseForm(this);
        }
    }
}
