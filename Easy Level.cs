﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace COMP1551_SeaAnimal_Game
{
    public partial class EasyLevel : Form
    {
        private Thread[] threads = null;
        private Random random = new Random();
        int PlayerNetSpeed = 10;
        int score = 0;
        int time = 60; // time limit
        int PlayerID;
        private bool MouseNet = false;

        List<PictureBox> fishFromLeft = new List<PictureBox>();
        List<PictureBox> fishFromRight = new List<PictureBox>();
        List<PictureBox> boomUp = new List<PictureBox>();

        Image[] bfish = { Properties.Resources.blackoctopus14, Properties.Resources.blackwhale3, Properties.Resources.colorfish10, Properties.Resources.colorfish11, Properties.Resources.blackturtle17, Properties.Resources.colorprawn14 };
        Image[] cfish = { Properties.Resources.colorseahorse13, Properties.Resources.colorfish3, Properties.Resources.colorfish16, Properties.Resources.blackprawn5, Properties.Resources.blackjelly10 };

        bool goUp, goDown, goLeft, goRight;

        public EasyLevel()
        {
            threads = new Thread[]
            {
                new Thread(LeftFishPictureBox),
                new Thread(RightFishPictureBox),
                new Thread(BoomPictureBox)
            };
            foreach (Thread t in threads)
            {
                t.Start();
            }

            InitializeComponent();
            RandomSpawnLeft.Start();
            RandomSpawnEasy.Start();
            FishMoveEasy.Start();
            netSpeedEasy.Start();
            RandomSpawnBoom.Start();
            RandomSpawnBoom2.Start();
            CountDown.Start();
        }

        private async void LeftFishPictureBox()
        {
            PictureBox leftFish = new PictureBox();
            leftFish.Width = 70;
            leftFish.Height = 35;
            leftFish.Image = bfish[random.Next(0, bfish.Length)];
            leftFish.BackColor = Color.Transparent;
            leftFish.SizeMode = PictureBoxSizeMode.StretchImage;
            leftFish.Left = 0;
            leftFish.Top = (random.Next(61, 365));
            fishFromLeft.Add(leftFish);
            this.Controls.Add(leftFish);
        }

        private async void RightFishPictureBox()
        {
            PictureBox rightFish = new PictureBox();
            rightFish.Width = 70;
            rightFish.Height = 35;
            rightFish.Image = cfish[random.Next(0, cfish.Length)];
            rightFish.BackColor = Color.Transparent;
            rightFish.SizeMode = PictureBoxSizeMode.StretchImage;
            rightFish.Left = 750;
            rightFish.Top = (random.Next(61, 365));
            fishFromRight.Add(rightFish);
            this.Controls.Add(rightFish);
        }

        private void BoomPictureBox()
        {
            PictureBox newGoUpBoom = new PictureBox();

            newGoUpBoom.Width = 55;
            newGoUpBoom.Height = 63;
            newGoUpBoom.Image = Properties.Resources.bomb;
            newGoUpBoom.BackColor = Color.Transparent;
            newGoUpBoom.SizeMode = PictureBoxSizeMode.StretchImage;
            newGoUpBoom.Left = (random.Next(0, 730));
            newGoUpBoom.Top = 380;
            boomUp.Add(newGoUpBoom);
            this.Controls.Add(newGoUpBoom);
        }

        private void RandomSpawnLeft_Tick(object sender, EventArgs e)
        {
            RandomSpawnLeft.Interval = (random.Next(2, 4) * 1000); // Fish come out ever 2 to 4 second
            LeftFishPictureBox();
            easyscorelbl.Text = "Score: " + score;
            lblTimer.Text = "Time: " + time;
        }

        private void RandomSpawnEasy_Tick(object sender, EventArgs e)
        {
            RandomSpawnEasy.Interval = (random.Next(2, 5) * 1000); // Fish come out ever 2 to 5 second
            RightFishPictureBox();
            easyscorelbl.Text = "Score: " + score;
            lblTimer.Text = "Time: " + time;
        }

        private void RandomSpawnBoom_Tick(object sender, EventArgs e)
        {
            RandomSpawnBoom.Interval = (random.Next(7, 9) * 1000); // Boom come out ever 7 to 9 second
            BoomPictureBox();
        }

        private void RandomSpawnBoom2_Tick(object sender, EventArgs e)
        {
            RandomSpawnBoom2.Interval = (random.Next(5, 7) * 1000); // Boom come out ever 5 to 7 second
            BoomPictureBox();
        }

        private void playaudio() // play audio
        {
            SoundPlayer audio = new SoundPlayer(COMP1551_SeaAnimal_Game.Properties.Resources.CountDown);
            audio.Play();
        }

        private void stopaudio() // stop audio
        {
            SoundPlayer audio = new SoundPlayer(COMP1551_SeaAnimal_Game.Properties.Resources.CountDown);
            audio.Stop();
        }
        private void CountDown_Tick(object sender, EventArgs e)
        {
            int A = (random.Next(2, 5)); ;

            time = time - 1;
            lblTimer.Text = "Time: " + time;

            if (time <= 10) // if timer reach 10 or below, word color change to red
            {
                lblTimer.ForeColor = Color.Red;
                playaudio();
            }

            if (time == 0) // if timer reach 0, all process stop
            {
                RandomSpawnLeft.Stop();
                RandomSpawnEasy.Stop();
                FishMoveEasy.Stop();
                netSpeedEasy.Stop();
                RandomSpawnBoom.Stop();
                RandomSpawnBoom2.Stop();
                CountDown.Stop();
                stopaudio();

                foreach (Thread t in threads)
                {
                    t.Abort();
                }
            }
        }

        private void PlayerNet_MouseUp(object sender, MouseEventArgs e)
        {
            MouseNet = false;
        }

        private void PlayerNet_MouseDown(object sender, MouseEventArgs e)
        {
            MouseNet = true;
            if (time == 0)
            {
                MouseNet = false;
            }
        }

        private void PlayerNet_MouseMove(object sender, MouseEventArgs e)
        {
            if (!MouseNet) return;
            int oldX = PlayerNet.Location.X;
            int oldY = PlayerNet.Location.Y;
            int newX = oldX + e.X;
            int newY = oldY + e.Y;
            PlayerNet.Location = new Point(newX, newY);
        }

        private void EasyLevel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space)
            {
                PlayerNet.Width = 73;
                PlayerNet.Height = 60;
            }
        }

        private void Backbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            LevelsPage lp = new LevelsPage();
            lp.Show();
        }

        private void Nextbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Normal_Level nl = new Normal_Level();
            nl.Show();
        }

        private void EasyLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }

            if (e.KeyCode == Keys.Space)
            {
                PlayerNet.Width = 146;
                PlayerNet.Height = 120;
            }
        }

        private void FishMoveEasy_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox leftFish in fishFromLeft)
            {
                leftFish.Left += (random.Next(2, 5)); // fish speed to left change from 2 - 5
            }
            foreach (PictureBox rightFish in fishFromRight)
            {
                rightFish.Left -= (random.Next(2, 5)); // fish speed to left change from 2 - 5
            }
            foreach (PictureBox newGoUpBoom in boomUp)
            {
                newGoUpBoom.Top -= (random.Next(1, 2)); // boom speed to left change from 1 - 2
            }
        }

        private void netSpeedEasy_Tick(object sender, EventArgs e)
        {
            if (goLeft == true && PlayerNet.Left > 2)
            {
                PlayerNet.Left -= PlayerNetSpeed;
            }
            if (goRight == true && PlayerNet.Left < 705)
            {
                PlayerNet.Left += PlayerNetSpeed;
            }
            if (goUp == true && PlayerNet.Top > 60)
            {
                PlayerNet.Top -= PlayerNetSpeed;
            }
            if (goDown == true && PlayerNet.Top < 350)
            {
                PlayerNet.Top += PlayerNetSpeed;
            }


            foreach (PictureBox leftFish in fishFromLeft.ToList()) //For fish from left to right
            {
                if (PlayerNet.Bounds.IntersectsWith(leftFish.Bounds)) //Fish add score by 2
                {
                    fishFromLeft.Remove(leftFish);
                    this.Controls.Remove(leftFish);
                    score = score + 2;
                    easyscorelbl.Text = "Score: " + score;
                }
            }

            foreach (PictureBox rightFish in fishFromRight.ToList()) //For fish from right to left
            {
                if (PlayerNet.Bounds.IntersectsWith(rightFish.Bounds)) //Fish add score by 2
                {
                    fishFromRight.Remove(rightFish);
                    this.Controls.Remove(rightFish);
                    score = score + 2;
                    easyscorelbl.Text = "Score: " + score;
                }
            }

            foreach (PictureBox newGoUpBoom in boomUp.ToList()) //Boom minus score by 3
            {
                if (PlayerNet.Bounds.IntersectsWith(newGoUpBoom.Bounds))
                {
                    boomUp.Remove(newGoUpBoom);
                    this.Controls.Remove(newGoUpBoom);
                    if (score <= 3)
                    {
                        score = 0;
                        easyscorelbl.Text = "Score: " + score;
                    }
                    else
                    {
                        score = score - 3;
                        easyscorelbl.Text = "Score: " + score;
                    }
                }
            }
        }
    }
}
