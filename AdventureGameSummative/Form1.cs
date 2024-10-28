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

namespace AdventureGameSummative
{
    public partial class Form1 : Form
    {
        //Track the page of the story you are at
        int page = 1;
        SoundPlayer soundPlayer = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
            DisplayPage();
        }

        private void optionButton1_Click(object sender, EventArgs e)
        {
            //Check page, then flip based on if you selected Option 1
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 1;
            }

            DisplayPage();
        }

        private void optionButton2_Click(object sender, EventArgs e)
        {
            //Check page, then flip based on if you selected Option 2
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 7;
            }
            else if (page == 3)
            {
                page = 113;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 5)
            {
                page = 113;
            }
            else if (page == 6)
            {
                page = 113;
            }
            else if (page == 7)
            {
                Random randomGenerator = new Random();
                int randomNumber = randomGenerator.Next(1, 101);

                if (randomNumber >= 50)
                {
                    page = 9;
                }

                else
                {
                    page = 10;
                }
            }
            else if (page == 8)
            {
                page = 113;
            }
            else if (page == 9)
            {
                page = 113;
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 11)
            {
                page = 14;
            }
            else if (page == 12)
            {
                page = 113;
            }
            else if (page == 13)
            {
                page = 113;
            }
            else if (page == 14)
            {
                page = 113;
            }

            DisplayPage();
        }

        public void DisplayPage()
        {
            //Display text, options, images and sounds based on the current page
            switch (page)
            {
                case 1:
                    imageBox.Image = Properties.Resources.houseExterior;

                    outputLabel.Text = "You get up to go to work. You are tired. Do you get a coffee to feel more awake?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 2:
                    soundPlayer = new SoundPlayer(Properties.Resources.coffeePouring_wav);
                    soundPlayer.Play();

                    imageBox.Image = Properties.Resources.houseExterior;

                    outputLabel.Text = "You make yourself a coffee and leave the house. Do you take your car or public transportation?";
                    optionLabel1.Text = "Car";
                    optionLabel2.Text = "Public transportation";
                    break;
                case 3:
                    soundPlayer = new SoundPlayer(Properties.Resources.snoring_wav);
                    soundPlayer.Play();

                    imageBox.Image = Properties.Resources.houseExterior;

                    outputLabel.Text = "You call in sick and go back to bed. Another day of relaxation... Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 4:
                    soundPlayer = new SoundPlayer(Properties.Resources.carEngineStart_wav);
                    soundPlayer.Play();

                    imageBox.Image = Properties.Resources.trafficJam;

                    outputLabel.Text = "You get stuck in traffic thanks to road works. Do you take a detour or wait?";
                    optionLabel1.Text = "Deviate";
                    optionLabel2.Text = "Wait";
                    break;
                case 5:
                    soundPlayer = new SoundPlayer(Properties.Resources.carHorns_wav);
                    soundPlayer.Play();

                    imageBox.Image = Properties.Resources.officeBuilding;

                    outputLabel.Text = "You take a detour and get to work on time. The boss is pleased you've arrived on schedule. Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 6:
                    soundPlayer = new SoundPlayer(Properties.Resources.carHorns_wav);
                    soundPlayer.Play();

                    imageBox.Image = Properties.Resources.officeBuilding;

                    outputLabel.Text = "You arrive late for work. The boss isn't happy about it. Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 7:
                    imageBox.Image = Properties.Resources.busTrainStation;

                    outputLabel.Text = "You walk over to a junction and see a bus station and a train station. Which do you choose?";
                    optionLabel1.Text = "Bus";
                    optionLabel2.Text = "Train";
                    Refresh();
                    break;
                case 8:
                    soundPlayer = new SoundPlayer(Properties.Resources.failSoundEffect_wav);
                    soundPlayer.Play();

                    imageBox.Image = Properties.Resources.busPulledOver;

                    outputLabel.Text = "The bus gets a flat on the highway. Looks like you're walking the rest of the way... Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 9:
                    soundPlayer = new SoundPlayer(Properties.Resources.trainHorn_wav);
                    soundPlayer.Play();

                    imageBox.Image = Properties.Resources.officeBuilding;

                    outputLabel.Text = "The train takes you straight to work. You're early! Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 10:
                    soundPlayer = new SoundPlayer(Properties.Resources.trainHorn_wav);
                    soundPlayer.Play();

                    imageBox.Image = Properties.Resources.viaTrain;

                    outputLabel.Text = "The train breaks down en-route. The conductor asks for assistance in fixing the train. Do you help or not?";
                    optionLabel1.Text = "Assist";
                    optionLabel2.Text = "Sit tight";
                    break;
                case 11:
                    imageBox.Image = Properties.Resources.viaTrain;

                    outputLabel.Text = "The conductor leads you to the power car. The engine seems to not be working. What do you try doing?";
                    optionLabel1.Text = "Restart the engine";
                    optionLabel2.Text = "Find broken parts";
                    break;
                case 12:
                    imageBox.Image = Properties.Resources.officeBuilding;

                    outputLabel.Text = "Another passenger assists with fixing the train. You arrive for work late, but your boss is understanding about the incident. Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 13:
                    soundPlayer = new SoundPlayer(Properties.Resources.trainPassingWithEngine_wav);
                    soundPlayer.Play();

                    imageBox.Image = Properties.Resources.officeBuilding;

                    outputLabel.Text = "You restart the engine, and it works fine. It must've shut off somehow. You arrive for work on time. Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 14:
                    soundPlayer = new SoundPlayer(Properties.Resources.trainPassingWithEngine_wav);
                    soundPlayer.Play();

                    imageBox.Image = Properties.Resources.officeBuilding;

                    outputLabel.Text = "Nothing seems to be broken. So you restart the engine. And its running again. You eventually arrive at work... on time, thankfully. Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 113:
                    outputLabel.Text = "Thanks for playing";
                    optionLabel1.Text = "";
                    optionLabel2.Text = "";
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
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
