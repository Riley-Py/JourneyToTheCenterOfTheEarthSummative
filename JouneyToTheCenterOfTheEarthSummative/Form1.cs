using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; //For images/sounds 
using System.IO; //To get directory paths

namespace JouneyToTheCenterOfTheEarthSummative
{
    
    
    public partial class adventureGame : Form
    {
        
        
        int pageNumber = 0;
        int gearChoice = 0;
        Random randomGenerator = new Random();
        string parentPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;  //Gets the directory path, regardless of what computer it is played on
        

        public adventureGame()
        {
            InitializeComponent();
               
        }

        private void soundplayer(string sound) //Function to load up sound without repeating lines
        {
            string resourcePath = Path.Combine(parentPath, "Resources");
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = Path.Combine(resourcePath, sound);

            player.Load();
            player.Play();
        }

        

        private void starting() //Starts the game up
        {
            pageNumber = 1;

            beginButton.Visible = false;
            firstTitle.Visible = false;

            BackgroundImage = null;
            BackColor = Color.DimGray;

            pictureArea.Visible = true;
            storyLabel.Visible = true;

            optionOneButton.Visible = true;
            optionTwoButton.Visible = true;

            pictureArea.Image = Properties.Resources.house;

            storyLabel.Text = "One calm day, while at the house, you get a call from someone";

            optionOneButton.Text = "Answer the phone";
            optionTwoButton.Text = "Ignore it";

            soundplayer("PhoneRing.wav");

        }
        
        private void beginButton_Click(object sender, EventArgs e) //Beginning button
        {
            starting();
        }

        private void optionOneButton_Click(object sender, EventArgs e)
        {
            if (pageNumber == 1)
            {
                pageNumber = 2;
            }
            if (pageNumber == 2)
            {
                pageNumber = 4;
            }
        }

        private void optionTwoButton_Click(object sender, EventArgs e)
        {
            if (pageNumber == 3)
            {

            }
        }
        private void death()
        {
            deathLabel.Text = "Do you want to atone for your mistakes?";
            optionOneButton.Text = "Yes";
            optionTwoButton.Text = "No";
            

        }
    }
}
