using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace JouneyToTheCenterOfTheEarthSummative
{
    public partial class adventureGame : Form
    {
        int pageNumber = 0;
        public adventureGame()
        {
            InitializeComponent();
        }

        private void soundplayer(System.IO.UnmanagedMemoryStream)
        {
            SoundPlayer player = new SoundPlayer(System.IO.UnmanagedMemoryStream);
            player.Play();
        }

        private void starting()
        {
            beginButton.Visible = false;
            firstTitle.Visible = false;
            BackgroundImage = null;

            pictureArea.Visible = true;
            storyLabel.Visible = true;

            optionOneButton.Visible = true;
            optionTwoButton.Visible = true;

            pictureArea.Image = Properties.Resources.house;

            storyLabel.Text = "One calm day, while at the house, you get a call from someone";

            soundplayer(Properties.Resources.PhoneRing);

            optionOneButton.Text = "Answer the phone";
            optionTwoButton.Text = "Ignore it";

        }
        
        private void beginButton_Click(object sender, EventArgs e)
        {
            starting();

        }
    }
}
