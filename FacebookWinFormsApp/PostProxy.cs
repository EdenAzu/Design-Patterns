using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class PostProxy
    {
        public Post Post { get; set; }

        public override string ToString()
        {
            string msg;
            if (Post.Message != null)
            {
                msg = Post.Message;
            }
            else if (Post.Caption != null)
            {
                msg = Post.Caption;
            }
            else
            {
                msg = string.Format("[{0}]", Post.Type);
            }

            return msg;
        }
    }
}
