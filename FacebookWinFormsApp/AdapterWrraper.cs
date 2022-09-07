using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class AdapterWrapper
    {
        public AdapterWrapper(User i_User)
        {
            User = i_User;
        }

        public User User { get; set; }
        private ISelectedItem SelectedItem { get; set; }

        public void SetTypeAndShowDetailes(ListBox i_ListBoxGeneral, ListBox i_ListBoxGeneralOutput, PictureBox i_PictureBoxGeneral)
        {
            if (i_ListBoxGeneral.SelectedItem is Photo)
            {
                SelectedItem = new PhotoSelected(i_PictureBoxGeneral, i_ListBoxGeneral);
            }
            else if (i_ListBoxGeneral.SelectedItem is Album)
            {
                SelectedItem = new AlbumSelected(i_ListBoxGeneralOutput, i_ListBoxGeneral);

            }
            else if (i_ListBoxGeneral.SelectedItem is User)
            {
                SelectedItem = new UserSelected(i_ListBoxGeneralOutput, i_PictureBoxGeneral, i_ListBoxGeneral);

            }
            else if (i_ListBoxGeneral.SelectedItem is Group)
            {
                SelectedItem = new GroupSelected(i_ListBoxGeneralOutput, i_PictureBoxGeneral, i_ListBoxGeneral);

            }
            else if (i_ListBoxGeneral.SelectedItem is String)
            {
                SelectedItem = new PostSelected(User, i_ListBoxGeneralOutput, i_PictureBoxGeneral, i_ListBoxGeneral);

            }
            if (SelectedItem != null)
            {
                SelectedItem.Invoke();
            }
        }

        public interface ISelectedItem
        {
            void Invoke();
        }


        private class UserSelected : ISelectedItem
        {
            private System.Windows.Forms.ListBox ListBoxGeneralOutput { get; set; }
            private System.Windows.Forms.PictureBox PictureBoxGeneral { get; set; }
            private System.Windows.Forms.ListBox ListBoxGeneral { get; set; }

            public UserSelected(ListBox i_listBoxGeneralOutput, PictureBox i_pictureBoxGeneral, ListBox i_ListBoxGeneral)
            {
                ListBoxGeneralOutput = i_listBoxGeneralOutput;
                PictureBoxGeneral = i_pictureBoxGeneral;
                ListBoxGeneral = i_ListBoxGeneral;
            }

            public void Invoke()
            {
                ListBoxGeneral.Invoke(new Action(() =>
                {
                    PictureBoxGeneral.LoadAsync((ListBoxGeneral.SelectedItem as User)
                        .PictureNormalURL);
                    ListBoxGeneralOutput.Items.Add((ListBoxGeneral.SelectedItem as User).Birthday);
                    ListBoxGeneralOutput.Items.Add((ListBoxGeneral.SelectedItem as User).Gender);
                    ListBoxGeneralOutput.Items.Add((ListBoxGeneral.SelectedItem as User).About);
                }));
            }
        }

        private class PostSelected : ISelectedItem
        {
            public PostSelected(User i_User, ListBox i_ListBoxGeneralOutput, PictureBox i_PictureBoxGeneral, ListBox i_ListBoxGeneral)
            {
                User = i_User;
                ListBoxGeneralOutput = i_ListBoxGeneralOutput;
                PictureBoxGeneral = i_PictureBoxGeneral;
                ListBoxGeneral = i_ListBoxGeneral;
            }
            private System.Windows.Forms.ListBox ListBoxGeneral { get; set; }
            private System.Windows.Forms.ListBox ListBoxGeneralOutput { get; set; }
            private System.Windows.Forms.PictureBox PictureBoxGeneral { get; set; }
            private User User { get; set; }

            public  void Invoke()
            {
                ListBoxGeneral.Invoke(new Action(() =>
                {
                    Post chosenPost = User.Posts[ListBoxGeneral.SelectedIndex];
                    foreach (Comment comment in chosenPost.Comments)
                    {
                        ListBoxGeneralOutput.Items.Add(comment);
                    }
                    if (chosenPost.Type == Post.eType.photo)
                    {
                        PictureBoxGeneral.LoadAsync(chosenPost.PictureURL);
                    }
                }));
            }
        }

        private class AlbumSelected : ISelectedItem
        {
            public AlbumSelected(ListBox i_ListBoxGeneralOutput, ListBox i_ListBoxGeneral)
            {
                ListBoxGeneralOutput = i_ListBoxGeneralOutput;
                ListBoxGeneral = i_ListBoxGeneral;
            }
            private System.Windows.Forms.ListBox ListBoxGeneral { get; set; }
            private System.Windows.Forms.ListBox ListBoxGeneralOutput { get; set; }
            public void Invoke()
            {
                ListBoxGeneral.Invoke(new Action(() =>
                {
                    foreach (Photo image in (ListBoxGeneral.SelectedItem as Album).Photos)
                    {
                        ListBoxGeneralOutput.Items.Add(image);
                    }
                }));
            }
        }

        private class PhotoSelected : ISelectedItem
        {
            public PhotoSelected(PictureBox i_PictureBoxGeneral, ListBox i_ListBoxGeneral)
            {
                PictureBoxGeneral = i_PictureBoxGeneral;
                ListBoxGeneral = i_ListBoxGeneral;
            }
            private System.Windows.Forms.ListBox ListBoxGeneral { get; set; }
            private System.Windows.Forms.PictureBox PictureBoxGeneral { get; set; }
            public void Invoke()
            {
                ListBoxGeneral.Invoke(new Action(() =>
                {
                    PictureBoxGeneral.LoadAsync((ListBoxGeneral.SelectedItem as User).Albums[1].Photos[0].PictureNormalURL);
                }));
            }
        }

        private class GroupSelected : ISelectedItem
        {
            public GroupSelected(ListBox i_ListBoxGeneralOutput, PictureBox i_PictureBoxGeneral, ListBox i_ListBoxGeneral)
            {
                ListBoxGeneralOutput = i_ListBoxGeneralOutput;
                PictureBoxGeneral = i_PictureBoxGeneral;
                ListBoxGeneral = i_ListBoxGeneral;
            }
            private System.Windows.Forms.ListBox ListBoxGeneral { get; set; }
            private System.Windows.Forms.ListBox ListBoxGeneralOutput { get; set; }
            private System.Windows.Forms.PictureBox PictureBoxGeneral { get; set; }
            public void Invoke()
            {
                ListBoxGeneral.Invoke(new Action(() =>
                {
                    PictureBoxGeneral.LoadAsync((ListBoxGeneral.SelectedItem as Group).PictureNormalURL);
                    foreach (User groupMember in (ListBoxGeneral.SelectedItem as Group).Members)
                    {
                        ListBoxGeneralOutput.Items.Add(groupMember);
                    }
                }));
            }
        }
    }
}

