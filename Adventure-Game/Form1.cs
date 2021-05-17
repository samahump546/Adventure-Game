using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Adventure_Game
{
    public partial class gameForm : Form
    {
        // Track page user is on
        int page = 1;
        SoundPlayer musicPlayer;

        public gameForm()
        {
            InitializeComponent();
            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2) { page = 4; }
            else if (page == 3) { page = 6; }
            else if (page == 4) { page = 1; }
            else if (page == 5) { page = 8; }
            else if (page == 6) { page = 1; }
            else if (page == 7) { page = 10; }
            else if (page == 8) { page = 12; }
            else if (page == 9) { page = 1; }
            else if (page == 10) { page = 20; }
            else if (page == 11) { page = 16; }
            else if (page == 12) { page = 1; }
            else if (page == 13) { page = 14; }
            else if (page == 14) { page = 1; }
            else if (page == 15) { page = 18; }
            else if (page == 16) { page = 1; }
            else if (page == 17) { page = 1; }
            else if (page == 18) { page = 1; }
            else if (page == 19) { page = 1; }
            else if (page == 20) { page = 1; }
            else if (page == 21) { page = 1; }

            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2) { page = 5; }
            else if (page == 3) { page = 7; }
            else if (page == 4) { page = 50; }
            else if (page == 5) { page = 9; }
            else if (page == 6) { page = 50; }
            else if (page == 7) { page = 11; }
            else if (page == 8) { page = 13; }
            else if (page == 9) { page = 50; }
            else if (page == 10) { page = 21; }
            else if (page == 11) { page = 17; }
            else if (page == 12) { page = 50; }
            else if (page == 13) { page = 15; }
            else if (page == 14) { page = 50; }
            else if (page == 15) { page = 19; }
            else if (page == 16) { page = 50; }
            else if (page == 17) { page = 50; }
            else if (page == 18) { page = 50; }
            else if (page == 19) { page = 50; }
            else if (page == 20) { page = 50; }
            else if (page == 21) { page = 50; }

            DisplayPage();
        }


        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    musicPlayer = new SoundPlayer(Properties.Resources.opening);
                    musicPlayer.Play();

                    imageBox.Image = Properties.Resources.lake_mountain;

                    outputLabel.Text = "You have landed in the vast world of the Fairy Tales. Shall you:";
                    option1Label.Text = "Adventure the SilverLake Forest";
                    option2Label.Text = "Explore Winged Mountain";
                    break;
                case 2:
                    musicPlayer = new SoundPlayer(Properties.Resources.Silverlake);
                    musicPlayer.Play();

                    imageBox.Image = Properties.Resources.silver_lake;

                    outputLabel.Text = "You come upon the infamous Silver Lake. Do you take a drink?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 3:
                    imageBox.Image = Properties.Resources.winged_men;

                    outputLabel.Text = "You come across a group of Winged Men, do you follow them to their King?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 4:
                    imageBox.Image = Properties.Resources.died;

                    outputLabel.Text = "You have died! The Sirens dragged you to the bottom of the lake. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 5:
                    imageBox.Image = Properties.Resources.picnic;

                    outputLabel.Text = "You came upon a group of faeries and dwarves having a picnic! They ask you to join them!";
                    option1Label.Text = "Accept";
                    option2Label.Text = "Decline";
                    break;
                case 6:
                    imageBox.Image = Properties.Resources.win;

                    outputLabel.Text = "You are saved! The King has allowed you to take refuge in his castle. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 7:
                    imageBox.Image = Properties.Resources.lake_mountain;

                    outputLabel.Text = "As you wander up the mountain you come across various creatures with wings. Do you try to ride one?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 8:
                    imageBox.Image = Properties.Resources.picnic;

                    outputLabel.Text = "You have a lovely meal with the group and are exhuasted from the delicious food Do you:";
                    option1Label.Text = "Build your own shelter to sleep in";
                    option2Label.Text = "Ask the faeries and dwarves if you can rest in their village";
                    break;
                case 9:
                    imageBox.Image = Properties.Resources.died;

                    outputLabel.Text = "Oh no! You have died of starvation! Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 10:
                    imageBox.Image = Properties.Resources.riding_dragon;

                    outputLabel.Text = "Success! You were able to ride one of the creatures and are soaring in the sky! Do you try to do a loop-de-loop?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 11:
                    imageBox.Image = Properties.Resources.dragons;

                    outputLabel.Text = "Oh dear! The winged creatures closer to the peak of the mountain are dragons! Do you:";
                    option1Label.Text = "Attempt to get closer to them";
                    option2Label.Text = "Run for your life!";
                    break;
                case 12:
                    imageBox.Image = Properties.Resources.died;

                    outputLabel.Text = "You have died! Your shelter collasped and crushed you! Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 13:
                    imageBox.Image = Properties.Resources.village;

                    outputLabel.Text = "The dwarves take you to their village and find you a guest house. They offer you a permanent residence in the village";
                    option1Label.Text = "Accept";
                    option2Label.Text = "Accept for the night and continue adventuring the forest";
                    break;
                case 14:
                    imageBox.Image = Properties.Resources.win;

                    outputLabel.Text = " You live a happy life in the village of the Forest Folk. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 15:
                    imageBox.Image = Properties.Resources.wolves;

                    outputLabel.Text = "You bid your new friends goodbye and continue to explore the forest. You come upon a pack of werewolves, they offer to turn you!";
                    option1Label.Text = "Become a werewolf";
                    option2Label.Text = "Decline";
                    break;
                case 16:
                    musicPlayer = new SoundPlayer(Properties.Resources.dragonFire);
                    musicPlayer.Play();

                    imageBox.Image = Properties.Resources.died;

                    outputLabel.Text = "The dragons notice you and shoot fire, burning you! Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 17:
                    imageBox.Image = Properties.Resources.died;

                    outputLabel.Text = "As you run away you slip on a loose rock and fall over the side of the cliff! Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 18:
                    musicPlayer = new SoundPlayer(Properties.Resources.werewolf);
                    musicPlayer.Play();

                    imageBox.Image = Properties.Resources.win;

                    outputLabel.Text = "You have successfully become a werewolf and are now a member of the pack! Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 19:
                    imageBox.Image = Properties.Resources.died;

                    outputLabel.Text = "You have died! During your journy you fell into a sinkhole! Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 20:
                    imageBox.Image = Properties.Resources.died;

                    outputLabel.Text = "The creature shakes you off its back! You fall to your death. Play Again";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 21:
                    imageBox.Image = Properties.Resources.died;

                    outputLabel.Text = "Oh no1 You lost your grip and fell off! Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 50:
                    imageBox.Image = Properties.Resources.thankYou;

                    outputLabel.Text = "Thank You For Playing!";
                    option1Label.Text = "";
                    option2Label.Text = "";

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
