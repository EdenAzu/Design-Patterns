using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace BasicFacebookFeatures
{
    public class Visitor
    {
        public void changeColorAndCloseForm(Form i_Form)
        {
            i_Form.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.FullColor;
            i_Form.BackgroundImageLayout = ImageLayout.Stretch;
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            i_Form.ForeColor = Color.FromArgb(one, two, three);
            i_Form.Refresh();
            Thread.Sleep(2000);
            i_Form.Close();

        }

    }

  
}
