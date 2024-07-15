using System;
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
using System.Data.OleDb;
using System.Media;

namespace COMP1551_SeaAnimal_Game
{
    public partial class HardLevel : Form
    {

        private Thread[] threads = null;
        private Random random = new Random();
        int PlayerNetSpeed = 10;
        PlayerGetSetScore totalScore = new PlayerGetSetScore();
        int time = 60; // time limit
        private bool MouseNet = false;

        List<PictureBox> fishFromLeft = new List<PictureBox>();
        List<PictureBox> fishFromRight = new List<PictureBox>();
        List<PictureBox> boomUp = new List<PictureBox>();

        Image[] bfish = { Properties.Resources.colorseahorse13, Properties.Resources.colorprawn14, Properties.Resources.colorseahorse15, Properties.Resources.coloroctop9, Properties.Resources.blackfish26 };
        Image[] cfish = { Properties.Resources.colorfish16, Properties.Resources.blackdolphin18, Properties.Resources.blackfish16, Properties.Resources.blackfish20, Properties.Resources.blackfish20, Properties.Resources.blackcrab11 };

        bool goUp, goDown, goLeft, goRight;

        private OleDbConnection con = null;
        OleDbConnection conn = new OleDbConnection(Properties.Resources.DB_Connection);

        public HardLevel()
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
            RandomSpawnLeftHard.Start();
            RandomSpawnHard.Start();
            FishMoveHard.Start();
            NetSpeedHard.Start();
            RandomSpawnBoom.Start();
            RandomSpawnBoom2Hard.Start();
            HardCountDown.Start();
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


            await Task.Delay(1250); // delay 1.25 second effect
            leftFish.Visible = false;
            await Task.Delay(1500); // delay 1.5 second effect
            leftFish.Visible = true;
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


            await Task.Delay(random.Next(1, 2) * 1000); // delay 1 or 2 second effect
            rightFish.Visible = false;
            await Task.Delay(random.Next(2, 3) * 1000); // delay 2 or 3 second effect
            rightFish.Visible = true;
        }

        private void RandomSpawnLeftHard_Tick(object sender, EventArgs e)
        {
            RandomSpawnLeftHard.Interval = (random.Next(2, 4) * 1000); // Fish come out ever 2 to 4 second
            LeftFishPictureBox();
            HardScorelbl.Text = totalScore.Score.ToString();
            HardTimelbl.Text = "Time: " + time;
        }

        private void RandomSpawnHard_Tick(object sender, EventArgs e)
        {
            RandomSpawnHard.Interval = (random.Next(2, 5) * 1000); // Fish come out ever 2 to 5 second
            RightFishPictureBox();
            HardScorelbl.Text = totalScore.Score.ToString();
            HardTimelbl.Text = "Time: " + time;
        }

        private void RandomSpawnBoom_Tick(object sender, EventArgs e)
        {
            RandomSpawnBoom.Interval = (random.Next(7, 9) * 1000); // Boom come out ever 7 to 9 second
            BoomPictureBox();
        }

        private void RandomSpawnBoom2Hard_Tick(object sender, EventArgs e)
        {
            RandomSpawnBoom2Hard.Interval = (random.Next(5, 7) * 1000); // Boom come out ever 5 to 7 second
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

        private void HardCountDown_Tick(object sender, EventArgs e)
        {
            int A = (random.Next(2, 5)); ;

            time = time - 1;
            HardTimelbl.Text = "Time: " + time;

            if (time <= 10) // if timer reach 10 or below, word color change to red
            {
                HardTimelbl.ForeColor = Color.Red;
                playaudio();
            }

            if (time == 0) // if timer reach 0, all process stop
            {
                RandomSpawnLeftHard.Stop();
                RandomSpawnHard.Stop();
                FishMoveHard.Stop();
                NetSpeedHard.Stop();
                RandomSpawnBoom.Stop();
                RandomSpawnBoom2Hard.Stop();
                HardCountDown.Stop();
                stopaudio();

                foreach (Thread t in threads)
                {
                    t.Abort();
                }

                OleDbCommand command = new OleDbCommand("INSERT INTO [Game] ( [PlayerName], [Score] ) VALUES (@playerName,@score)", conn);
                conn.Open();
                command.Parameters.AddWithValue("@playerName", txtPlayername.Text);
                command.Parameters.AddWithValue("@score", HardScorelbl.Text);
                command.ExecuteNonQuery();
                string playerName = txtPlayername.Text.Trim();
                string score = HardScorelbl.Text.Trim();

                this.Hide();
                Score_Page sp = new Score_Page();
                sp.Show();
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

        private void HardLevel_KeyUp(object sender, KeyEventArgs e)
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

        private void HardLevel_KeyDown(object sender, KeyEventArgs e)
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

        private void FishMoveHard_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox leftFish in fishFromLeft)
            {
                leftFish.Left += (random.Next(4, 7)); // fish speed to left change from 4 - 7
            }
            foreach (PictureBox rightFish in fishFromRight)
            {
                rightFish.Left -= (random.Next(4, 7)); // fish speed to left change from 4 - 7
            }
            foreach (PictureBox newGoUpBoom in boomUp)
            {
                newGoUpBoom.Top -= (random.Next(1, 2)); // boom speed to left change from 1 - 2
            }
        }

        private void NetSpeedHard_Tick(object sender, EventArgs e)
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


            foreach (PictureBox leftFish in fishFromLeft.ToList()) //For fish from left
            {
                if (PlayerNet.Bounds.IntersectsWith(leftFish.Bounds)) //Fish add score by 2 if touch
                {
                    fishFromLeft.Remove(leftFish);
                    this.Controls.Remove(leftFish);
                    totalScore.Score = totalScore.Score + 2;
                    HardScorelbl.Text = totalScore.Score.ToString();
                }
            }

            foreach (PictureBox rightFish in fishFromRight.ToList()) //For fish from right
            {
                if (PlayerNet.Bounds.IntersectsWith(rightFish.Bounds)) //Fish add score by 2 if touch
                {
                    fishFromRight.Remove(rightFish);
                    this.Controls.Remove(rightFish);
                    totalScore.Score = totalScore.Score + 2;
                    HardScorelbl.Text = totalScore.Score.ToString();
                }
            }

            foreach (PictureBox newGoUpBoom in boomUp.ToList()) //Boom minus score by 3 if touch
            {
                if (PlayerNet.Bounds.IntersectsWith(newGoUpBoom.Bounds))
                {
                    boomUp.Remove(newGoUpBoom);
                    this.Controls.Remove(newGoUpBoom);
                    if (totalScore.Score <= 3)
                    {
                        totalScore.Score = 0;
                        HardScorelbl.Text = totalScore.Score.ToString();
                    }
                    else
                    {
                        totalScore.Score = totalScore.Score - 3;
                        HardScorelbl.Text = totalScore.Score.ToString();
                    }
                }
            }
        }

        private void HardLevel_Load(object sender, EventArgs e)
        {
            txtPlayername.Text = Player_Name_Page.passingText;
        }

        private void HardScorelbl_Click(object sender, EventArgs e)
        {

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



        private void Backbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            LevelsPage lp = new LevelsPage();
            lp.Show();
        }

        private void Nextbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Score_Page sp = new Score_Page();
            sp.Show();
        }
    }
}
