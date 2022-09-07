using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using DesktopApplication;
using SortLikesPostThatLikedByUser;
using FacebookAPIHandler;

using Message = System.Windows.Forms.Message;

namespace BasicFacebookFeatures
{
    public partial class AppForm : Form
    {
        private Visitor visitor;
        public AppForm()
        {
            FacebookAPILogic = new FacebookAPI();
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 50;
            visitor = new Visitor();
        }

        private AdapterWrapper m_AdapterWrapper;
        public FacebookAPI FacebookAPILogic { get; set; }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            loadAppToFile();
        }

        private void loadAppToFile()
        {
            ApplicationSettings.Instance.LastWindowState = this.WindowState;
            ApplicationSettings.Instance.LastWindowSize = this.ClientSize;
            ApplicationSettings.Instance.LastWindowLocation = this.Location;
            ApplicationSettings.Instance.AutoLogin = this.checkBoxRememberMe.Checked;
            ApplicationSettings.Instance.Save();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            loadFileToApp();

            if (ApplicationSettings.Instance.AutoLogin)
            {
                new Thread(this.autoLogin).Start();
            }
        }

        private void loadFileToApp()
        {
            this.ClientSize = ApplicationSettings.Instance.LastWindowSize;
            this.WindowState = ApplicationSettings.Instance.LastWindowState;
            this.Location = ApplicationSettings.Instance.LastWindowLocation;
            this.checkBoxRememberMe.Checked = ApplicationSettings.Instance.AutoLogin;
        }

        private void autoLogin()
        {
            try
            {
                FacebookAPILogic.LoginResult = FacebookService.Connect(ApplicationSettings.Instance.AccessToken);
                FacebookAPILogic.LoggedInUser = FacebookAPILogic.LoginResult.LoggedInUser;
                new Thread(fetchPosts).Start();
                new Thread(fetchFriends).Start();

                fetchUserInfo();
            }
            catch (Exception ex)
            {
                ///(OAuthException - #190) Error validating access token: Session has expired..
                if (ex.Message.Contains("#190"))
                {
                    this.Invoke((Action)loginAndInit);
                }
                else
                {
                    this.Invoke(new Action(() => MessageBox.Show("Could not connect to Facebook server. Please try again later..")));
                }
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void loginAndInit()
        {
            Clipboard.SetText("eliranshimonov@gmail.com"); /// the current password for Eliran
            FacebookAPILogic.FacebookLogin();
            if (!string.IsNullOrEmpty(FacebookAPILogic.LoginResult.AccessToken))
            {
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show("Log-in Field");
            }


        }

        private void fetchUserInfo()
        {
            new Thread(() =>
            {
                this.Invoke(new Action(() =>
                {
                    ApplicationSettings.Instance.AccessToken = FacebookAPILogic.LoginResult.AccessToken;
                    m_AdapterWrapper = new AdapterWrapper(FacebookAPILogic.LoggedInUser);
                    pictureBoxProfile.LoadAsync(FacebookAPILogic.LoggedInUser.PictureLargeURL);
                    buttonLogin.Enabled = false;
                }));
            }).Start();
        }
        
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            resetAllForm();
        }

        private void resetAllForm()
        {
            buttonLogin.Enabled = true;
            pictureBoxProfile.Image = null;
            pictureBoxGeneral.Image = null;
            listBoxGeneral.Items.Clear();
            listBoxGeneralOutput.Items.Clear();
            FacebookAPILogic.LoggedInUser = null;
        }

        private void pictureBoxFriends_DoubleClick(object sender, System.EventArgs e)
        {
            fetchFriends();
        }

        private void fetchFriends()
        {
            if (loginHandler())
            {
                try
                {
                    if (!listBoxFriends.InvokeRequired)
                    {
                        userBindingSource.DataSource = FacebookAPILogic.LoggedInUser.Friends;
                    }
                    else
                    {
                        listBoxFriends.Invoke(new Action(() =>
                            userBindingSource.DataSource = FacebookAPILogic.LoggedInUser.Friends));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (listBoxFriends.Items.Count == 0)
                {
                    MessageBox.Show("No albums to retrieve :(");
                }
            }
        }

        private void pictureBoxAlbums_DoubleClick(object sender, System.EventArgs e)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            pictureBoxGeneral.Image = null;
            listBoxGeneral.Items.Clear();
            listBoxGeneralOutput.Items.Clear();
            if (loginHandler())
            {
                try
                {
                    foreach (Album chosenAlbum in FacebookAPILogic.LoggedInUser.Albums)
                    {
                        listBoxGeneral.Items.Add(chosenAlbum);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (listBoxGeneral.Items.Count == 0)
                {
                    MessageBox.Show("No albums to retrieve :(");
                }
            }
        }

        private void pictureBoxGroups_DoubleClick(object sender, System.EventArgs e)
        {
            fetchGroups();
        }

        private void fetchGroups()
        {
            pictureBoxGeneral.Image = null;
            listBoxGeneral.Items.Clear();
            listBoxGeneralOutput.Items.Clear();
            if (loginHandler())
            {
                try
                {
                    foreach (Group chosenGroup in FacebookAPILogic.LoggedInUser.Groups)
                    {
                        pictureBoxGeneral.Visible = true;
                        listBoxGeneral.Items.Add(chosenGroup);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (listBoxGeneral.Items.Count == 0)
                {
                    MessageBox.Show("No groups to retrieve :(");
                }
            }

        }

        private void pictureBoxNew_DoubleClick(object sender, System.EventArgs e)
        {
            playGameFourInARow();
        }

        private void playGameFourInARow()
        {
            pictureBoxGeneral.Image = null;
            listBoxGeneralOutput.Items.Clear();
            listBoxGeneral.Items.Clear();

            if (loginHandler())
            {
                FormGame desktopGame = new FormGame();
                desktopGame.RunGameSettings(FacebookAPILogic.LoggedInUser.FirstName);
            }
        }

        private void pictureBoxPosts_DoubleClick(object sender, System.EventArgs e)
        {
            new Thread(fetchPosts).Start();
        }

        private void fetchPosts()
        {
            pictureBoxGeneral.Image = null;
            listBoxGeneral.Items.Clear();
            listBoxGeneralOutput.Items.Clear();
            FacebookObjectCollection<Post> posts = FacebookAPILogic.LoggedInUser.Posts;
            if (loginHandler())
            {
                this.Invoke(new Action(() =>
                {
                    try
                    {
                        foreach (Post chosenPost in posts)
                        {
                            listBoxGeneral.Items.Add(new PostProxy() {Post = chosenPost}.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (listBoxGeneral.Items.Count == 0)
                    {
                        MessageBox.Show("No Posts to retrieve :(");
                    }
                }));
            }
        }
        
        private void listBoxGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxGeneral.Image = null;
            listBoxGeneralOutput.Items.Clear();
            m_AdapterWrapper.SetTypeAndShowDetailes(listBoxGeneral , listBoxGeneralOutput, pictureBoxGeneral);

        }

        private void pictureBoxTop3Likes_DoubleClick(object sender, System.EventArgs e)
        {
            if (loginHandler())
            {
                FormMessageBox newMessageBox = new FormMessageBox();
                try
                {
                    addLikeToUsersWhoLikedYou();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                newMessageBox.ShowDialog();
            if (newMessageBox.buttonFriendsNameClicked)
                {
                    fetchFriendsByFirstNameSorted();
                }
                else if (newMessageBox.buttonThreeTopLikesClicked)
                {
                    fetchTop3Likes();
                }
            }
        }

       /* private void buttonLikes_Click(object sender, EventArgs e)
        {
            fetchTop3Likes();
        }

        private void buttonNames_Click(object sender, EventArgs e)
        {
            fetchFriendsByFirstNameSorted();
        }*/

        private void fetchTop3Likes()
        {

            if (loginHandler())
            {

                try
                {
                    BaseSort baseSort = new SortByLikes();
                    baseSort.BaseSortMethod(FacebookAPILogic,listBoxGeneral);
                    showTop3Friends();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Top3Likes to retrieve :(");
                }

            }
        }

        private void fetchFriendsByFirstNameSorted()
        {
            if (loginHandler())
            {

                try
                {
                    BaseSort baseSort = new SortByName();
                    baseSort.BaseSortMethod(FacebookAPILogic, listBoxGeneral);
                    showFriendList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Friends to retrieve :(");
                }

            }
        }

        private void showFriendList()
        {
            foreach (UserLikesCounter user in FacebookAPILogic.UserLikesCounterList.CountersList)
            {
                listBoxGeneral.Items.Add(user.LikedByUser.FirstName);
            }
        }


        private void listBoxGeneralOutput_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listBoxGeneralOutput.SelectedItem is Photo)
            {
                loadPhoto((listBoxGeneralOutput.SelectedItem as Photo).PictureNormalURL);
            }
        }

        private void loadPhoto(string i_Picture)
        {
            pictureBoxGeneral.LoadAsync(i_Picture);
        }

        private void showTop3Friends()
        {
            int countToThree = 0;

            foreach (UserLikesCounter user in FacebookAPILogic.UserLikesCounterList.CountersList)
            {
                listBoxGeneral.Items.Add(user.LikedByUser);
                listBoxGeneral.Items.Add(user.Likes);
                countToThree++;

                if (countToThree == 3)
                {
                    break;
                }
            }
        }

        private void addLikeToUsersWhoLikedYou()
        {
            foreach (Post post in FacebookAPILogic.LoggedInUser.Posts)
            {
                foreach (User user in post.LikedBy)
                {
                    UserLikesCounter userLikesCounter = FacebookAPILogic.UserLikesCounterList.UserExistInList(user);

                    if (userLikesCounter != null)
                    {
                        FacebookAPILogic.UserLikesCounterList.addALikeCountsToUser(userLikesCounter);
                    }
                    else
                    {
                        FacebookAPILogic.UserLikesCounterList.addNewUserToLikeCountsList(user);
                    }
                }
            }
        }

        private bool loginHandler()
        {
            bool userLogedin = true;
            if (FacebookAPILogic.LoggedInUser == null)
            {
                MessageBox.Show("Please log-in first");
                userLogedin = false;
            }

            return userLogedin;
        }

        private void postButton_Click(object sender, System.EventArgs e)
        {
            if (loginHandler())
            {
                try
                {
                    Status postedStatus = FacebookAPILogic.LoggedInUser.PostStatus(textBoxPost.Text);
                    MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonCloseApplication_Click(object sender, EventArgs e)
        {
            visitor.changeColorAndCloseForm(this);
        }
    }

    public abstract class BaseSort
    {
        protected abstract int sort(UserLikesCounter i_UserOne, UserLikesCounter i_UserTwo);

        public void BaseSortMethod(FacebookAPI FacebookAPILogic,ListBox listBoxGeneral)
        {
            Comparison<UserLikesCounter> comparison =
                new Comparison<UserLikesCounter>(sort); //ToDo rename the function
            FacebookAPILogic.UserLikesCounterList.CountersList.Sort(comparison);
            listBoxGeneral.Items.Clear();
        }


    }

    public class SortByLikes:BaseSort
    {
        protected override int sort(UserLikesCounter i_UserOne, UserLikesCounter i_UserTwo)
        {
            return i_UserOne.Likes - i_UserTwo.Likes;
        }

    }

    public class SortByName:BaseSort
    {
        protected override int sort(UserLikesCounter i_UserOne, UserLikesCounter i_UserTwo)
        {
            return string.Compare(i_UserOne.LikedByUser.FirstName,i_UserTwo.LikedByUser.FirstName);
        }
    }

}
