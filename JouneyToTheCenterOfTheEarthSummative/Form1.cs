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
using System.Threading; //To get thread.sleep()

namespace JouneyToTheCenterOfTheEarthSummative
{
    
    
    public partial class adventureGame : Form
    {
        
        
        int pageNumber = 0;
        int gearChoice = 0;
        int goOn = 0;
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

        private void justText()
        {
            optionOneButton.Visible = false;
            optionTwoButton.Visible = false;
            optionThreeButton.Visible = false;

            continueButton.Visible = true;
        }

        private void revert()
        {
            continueButton.Visible = false;

            optionOneButton.Visible = true;
            optionTwoButton.Visible = true;
        }


        private void closing()
        {
            int closingSequence = 5;
            optionOneButton.Visible = false;
            optionTwoButton.Visible = false;
            while (closingSequence != 0)
            {
                storyLabel.Text = $"No? Very surprising indeed!\n  Well, you never will know what you could have done differently!\n Shutting down in {closingSequence}";
                Refresh();
                Thread.Sleep(1000);
                closingSequence--;
                if (closingSequence == 0)
                {
                    this.Close();
                }

            }
            
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

            storyLabel.Text = "One calm day, while at your house, you get a call from someone";

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

           if (pageNumber == 5)
            {
                gearChoice = 1;
                pageNumber = 6;
            }

            if (pageNumber == 3)
            {
                starting();
            }

            displayPage();

        }

        private void optionTwoButton_Click(object sender, EventArgs e)
        {
            if (pageNumber == 0)
            {
                closing();
            }
            
            if (pageNumber == 1)
            {
                pageNumber = 3;
            }
            if (pageNumber == 5)
            {
                gearChoice = 2;
                pageNumber = 6;
            }
            displayPage();
            
        }

        private void displayPage()
        {
            switch (pageNumber)
            {
                case 2:
                    storyLabel.Text = "You answer the call and the person tells you that you can be part of an adventure to\n get down to the centre of the Earth!  Question is: do you go on the adventure?";
                    optionOneButton.Text = "Yes";
                    optionTwoButton.Text = "No";
                    pictureArea.Image = Properties.Resources.earthcenter;
                    break;
                case 3:
                    storyLabel.Text = "You continue on with your everyday routine and accomplish nothing special!";
                    pictureArea.Image = Properties.Resources.nothingspecial;
                    justText();
                    break;
                case 4:
                    storyLabel.Text = "The guy on the phone tells you to pack up your belongings and come to Iceland";
                    pictureArea.Image = Properties.Resources.iceland;
                    justText();
                    break;
                case 6:
                    storyLabel.Text = "You pack up the chosen item and head on your way to the airport";
                    pictureArea.Image = Properties.Resources.airport;
                    justText();
                    break;

            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (pageNumber == 3)
            {
                revert();
                storyLabel.Text = "Do you want to continue and atone?";
                optionOneButton.Text = "Yes, I want to change!";
                optionTwoButton.Text = "Nah, I quit because I am a loser!";
                pictureArea.Image = Properties.Resources.tryagain;
                pageNumber = 0;
                
                
                
            }
            if (pageNumber == 4)
            {
                storyLabel.Text = "After packing everything that you need for the trip, you realize that you have space for one extra item.\n Choose either a swiss army knife, a flashlight, or a mask";
                pictureArea.Image = Properties.Resources.suitcase;
                revert();

                optionThreeButton.Visible = true;
                optionOneButton.Text = "Swiss army knife";
                optionTwoButton.Text = "A flashlight";
                optionThreeButton.Text = "A mask";

                pageNumber++;



            }
        }

        private void optionThreeButton_Click(object sender, EventArgs e)
        {
            if (pageNumber == 5)
            {
                gearChoice = 3;
                pageNumber++;
            }
            displayPage();
        }
    }
}
