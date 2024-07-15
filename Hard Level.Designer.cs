
namespace COMP1551_SeaAnimal_Game
{
    partial class HardLevel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.HardScorelbl = new System.Windows.Forms.Label();
            this.ScoreWord = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtPlayername = new System.Windows.Forms.Label();
            this.lblHardLevel = new System.Windows.Forms.Label();
            this.Playertimer = new System.Windows.Forms.PictureBox();
            this.HardTimelbl = new System.Windows.Forms.Label();
            this.Scorebox = new System.Windows.Forms.PictureBox();
            this.Nextbox = new System.Windows.Forms.PictureBox();
            this.Backbox = new System.Windows.Forms.PictureBox();
            this.PlayerNet = new System.Windows.Forms.PictureBox();
            this.BallBox = new System.Windows.Forms.PictureBox();
            this.HatBox = new System.Windows.Forms.PictureBox();
            this.PinkcrabBox = new System.Windows.Forms.PictureBox();
            this.AlgaeBox = new System.Windows.Forms.PictureBox();
            this.Coral2box = new System.Windows.Forms.PictureBox();
            this.Coral1box = new System.Windows.Forms.PictureBox();
            this.RandomSpawnHard = new System.Windows.Forms.Timer(this.components);
            this.FishMoveHard = new System.Windows.Forms.Timer(this.components);
            this.NetSpeedHard = new System.Windows.Forms.Timer(this.components);
            this.RandomSpawnBoom = new System.Windows.Forms.Timer(this.components);
            this.HardCountDown = new System.Windows.Forms.Timer(this.components);
            this.RandomSpawnLeftHard = new System.Windows.Forms.Timer(this.components);
            this.RandomSpawnBoom2Hard = new System.Windows.Forms.Timer(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Playertimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scorebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerNet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HatBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinkcrabBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlgaeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coral2box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coral1box)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.Controls.Add(this.HardScorelbl);
            this.TopPanel.Controls.Add(this.ScoreWord);
            this.TopPanel.Controls.Add(this.lblScore);
            this.TopPanel.Controls.Add(this.txtPlayername);
            this.TopPanel.Controls.Add(this.lblHardLevel);
            this.TopPanel.Controls.Add(this.Playertimer);
            this.TopPanel.Controls.Add(this.HardTimelbl);
            this.TopPanel.Controls.Add(this.Scorebox);
            this.TopPanel.Controls.Add(this.Nextbox);
            this.TopPanel.Controls.Add(this.Backbox);
            this.TopPanel.Location = new System.Drawing.Point(-5, -1);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1059, 68);
            this.TopPanel.TabIndex = 3;
            // 
            // HardScorelbl
            // 
            this.HardScorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardScorelbl.Location = new System.Drawing.Point(510, 20);
            this.HardScorelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HardScorelbl.Name = "HardScorelbl";
            this.HardScorelbl.Size = new System.Drawing.Size(83, 38);
            this.HardScorelbl.TabIndex = 16;
            this.HardScorelbl.Click += new System.EventHandler(this.HardScorelbl_Click);
            // 
            // ScoreWord
            // 
            this.ScoreWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreWord.Location = new System.Drawing.Point(438, 20);
            this.ScoreWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreWord.Name = "ScoreWord";
            this.ScoreWord.Size = new System.Drawing.Size(91, 38);
            this.ScoreWord.TabIndex = 22;
            this.ScoreWord.Text = "Score";
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(296, 40);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(14, 23);
            this.lblScore.TabIndex = 21;
            this.lblScore.Visible = false;
            // 
            // txtPlayername
            // 
            this.txtPlayername.BackColor = System.Drawing.Color.Transparent;
            this.txtPlayername.Location = new System.Drawing.Point(293, 20);
            this.txtPlayername.Name = "txtPlayername";
            this.txtPlayername.Size = new System.Drawing.Size(17, 23);
            this.txtPlayername.TabIndex = 14;
            this.txtPlayername.Visible = false;
            // 
            // lblHardLevel
            // 
            this.lblHardLevel.AutoSize = true;
            this.lblHardLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardLevel.Location = new System.Drawing.Point(117, 20);
            this.lblHardLevel.Name = "lblHardLevel";
            this.lblHardLevel.Size = new System.Drawing.Size(152, 32);
            this.lblHardLevel.TabIndex = 20;
            this.lblHardLevel.Text = "Hard Level";
            // 
            // Playertimer
            // 
            this.Playertimer.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.playertimer;
            this.Playertimer.Location = new System.Drawing.Point(639, 10);
            this.Playertimer.Margin = new System.Windows.Forms.Padding(4);
            this.Playertimer.Name = "Playertimer";
            this.Playertimer.Size = new System.Drawing.Size(56, 48);
            this.Playertimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Playertimer.TabIndex = 19;
            this.Playertimer.TabStop = false;
            // 
            // HardTimelbl
            // 
            this.HardTimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardTimelbl.Location = new System.Drawing.Point(696, 20);
            this.HardTimelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HardTimelbl.Name = "HardTimelbl";
            this.HardTimelbl.Size = new System.Drawing.Size(123, 38);
            this.HardTimelbl.TabIndex = 18;
            // 
            // Scorebox
            // 
            this.Scorebox.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.scoregold;
            this.Scorebox.Location = new System.Drawing.Point(352, 4);
            this.Scorebox.Margin = new System.Windows.Forms.Padding(4);
            this.Scorebox.Name = "Scorebox";
            this.Scorebox.Size = new System.Drawing.Size(83, 62);
            this.Scorebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Scorebox.TabIndex = 17;
            this.Scorebox.TabStop = false;
            // 
            // Nextbox
            // 
            this.Nextbox.BackColor = System.Drawing.Color.Transparent;
            this.Nextbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nextbox.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.next_arrow_gold_;
            this.Nextbox.Location = new System.Drawing.Point(984, 4);
            this.Nextbox.Margin = new System.Windows.Forms.Padding(4);
            this.Nextbox.Name = "Nextbox";
            this.Nextbox.Size = new System.Drawing.Size(51, 62);
            this.Nextbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Nextbox.TabIndex = 15;
            this.Nextbox.TabStop = false;
            this.Nextbox.Click += new System.EventHandler(this.Nextbox_Click);
            // 
            // Backbox
            // 
            this.Backbox.BackColor = System.Drawing.Color.Transparent;
            this.Backbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backbox.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.back_arrow;
            this.Backbox.Location = new System.Drawing.Point(21, 4);
            this.Backbox.Margin = new System.Windows.Forms.Padding(4);
            this.Backbox.Name = "Backbox";
            this.Backbox.Size = new System.Drawing.Size(51, 62);
            this.Backbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Backbox.TabIndex = 14;
            this.Backbox.TabStop = false;
            this.Backbox.Click += new System.EventHandler(this.Backbox_Click);
            // 
            // PlayerNet
            // 
            this.PlayerNet.BackColor = System.Drawing.Color.Transparent;
            this.PlayerNet.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.Player_net;
            this.PlayerNet.Location = new System.Drawing.Point(492, 223);
            this.PlayerNet.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerNet.Name = "PlayerNet";
            this.PlayerNet.Size = new System.Drawing.Size(73, 60);
            this.PlayerNet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerNet.TabIndex = 4;
            this.PlayerNet.TabStop = false;
            this.PlayerNet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerNet_MouseDown);
            this.PlayerNet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlayerNet_MouseMove);
            this.PlayerNet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerNet_MouseUp);
            // 
            // BallBox
            // 
            this.BallBox.BackColor = System.Drawing.Color.Transparent;
            this.BallBox.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.red_ball;
            this.BallBox.Location = new System.Drawing.Point(641, 239);
            this.BallBox.Margin = new System.Windows.Forms.Padding(4);
            this.BallBox.Name = "BallBox";
            this.BallBox.Size = new System.Drawing.Size(157, 132);
            this.BallBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BallBox.TabIndex = 6;
            this.BallBox.TabStop = false;
            // 
            // HatBox
            // 
            this.HatBox.BackColor = System.Drawing.Color.Transparent;
            this.HatBox.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.grey_hat;
            this.HatBox.Location = new System.Drawing.Point(235, 115);
            this.HatBox.Margin = new System.Windows.Forms.Padding(4);
            this.HatBox.Name = "HatBox";
            this.HatBox.Size = new System.Drawing.Size(124, 113);
            this.HatBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HatBox.TabIndex = 7;
            this.HatBox.TabStop = false;
            // 
            // PinkcrabBox
            // 
            this.PinkcrabBox.BackColor = System.Drawing.Color.Transparent;
            this.PinkcrabBox.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.colorcrab8;
            this.PinkcrabBox.Location = new System.Drawing.Point(642, 451);
            this.PinkcrabBox.Margin = new System.Windows.Forms.Padding(4);
            this.PinkcrabBox.Name = "PinkcrabBox";
            this.PinkcrabBox.Size = new System.Drawing.Size(85, 42);
            this.PinkcrabBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PinkcrabBox.TabIndex = 8;
            this.PinkcrabBox.TabStop = false;
            // 
            // AlgaeBox
            // 
            this.AlgaeBox.BackColor = System.Drawing.Color.Transparent;
            this.AlgaeBox.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.ColorAlgae1;
            this.AlgaeBox.Location = new System.Drawing.Point(439, 404);
            this.AlgaeBox.Margin = new System.Windows.Forms.Padding(4);
            this.AlgaeBox.Name = "AlgaeBox";
            this.AlgaeBox.Size = new System.Drawing.Size(189, 135);
            this.AlgaeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AlgaeBox.TabIndex = 9;
            this.AlgaeBox.TabStop = false;
            // 
            // Coral2box
            // 
            this.Coral2box.BackColor = System.Drawing.Color.Transparent;
            this.Coral2box.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.coral1;
            this.Coral2box.Location = new System.Drawing.Point(735, 335);
            this.Coral2box.Margin = new System.Windows.Forms.Padding(4);
            this.Coral2box.Name = "Coral2box";
            this.Coral2box.Size = new System.Drawing.Size(316, 218);
            this.Coral2box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coral2box.TabIndex = 12;
            this.Coral2box.TabStop = false;
            // 
            // Coral1box
            // 
            this.Coral1box.BackColor = System.Drawing.Color.Transparent;
            this.Coral1box.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.coralrock__2_;
            this.Coral1box.Location = new System.Drawing.Point(16, 320);
            this.Coral1box.Margin = new System.Windows.Forms.Padding(4);
            this.Coral1box.Name = "Coral1box";
            this.Coral1box.Size = new System.Drawing.Size(313, 233);
            this.Coral1box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coral1box.TabIndex = 13;
            this.Coral1box.TabStop = false;
            // 
            // RandomSpawnHard
            // 
            this.RandomSpawnHard.Interval = 2000;
            this.RandomSpawnHard.Tick += new System.EventHandler(this.RandomSpawnHard_Tick);
            // 
            // FishMoveHard
            // 
            this.FishMoveHard.Interval = 10;
            this.FishMoveHard.Tick += new System.EventHandler(this.FishMoveHard_Tick);
            // 
            // NetSpeedHard
            // 
            this.NetSpeedHard.Interval = 10;
            this.NetSpeedHard.Tick += new System.EventHandler(this.NetSpeedHard_Tick);
            // 
            // RandomSpawnBoom
            // 
            this.RandomSpawnBoom.Interval = 2000;
            this.RandomSpawnBoom.Tick += new System.EventHandler(this.RandomSpawnBoom_Tick);
            // 
            // HardCountDown
            // 
            this.HardCountDown.Interval = 1000;
            this.HardCountDown.Tick += new System.EventHandler(this.HardCountDown_Tick);
            // 
            // RandomSpawnLeftHard
            // 
            this.RandomSpawnLeftHard.Interval = 2000;
            this.RandomSpawnLeftHard.Tick += new System.EventHandler(this.RandomSpawnLeftHard_Tick);
            // 
            // RandomSpawnBoom2Hard
            // 
            this.RandomSpawnBoom2Hard.Interval = 2000;
            this.RandomSpawnBoom2Hard.Tick += new System.EventHandler(this.RandomSpawnBoom2Hard_Tick);
            // 
            // HardLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COMP1551_SeaAnimal_Game.Properties.Resources.Background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 506);
            this.Controls.Add(this.BallBox);
            this.Controls.Add(this.HatBox);
            this.Controls.Add(this.Coral1box);
            this.Controls.Add(this.Coral2box);
            this.Controls.Add(this.AlgaeBox);
            this.Controls.Add(this.PinkcrabBox);
            this.Controls.Add(this.PlayerNet);
            this.Controls.Add(this.TopPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HardLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hard_Level";
            this.Load += new System.EventHandler(this.HardLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HardLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HardLevel_KeyUp);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Playertimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scorebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerNet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HatBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinkcrabBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlgaeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coral2box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coral1box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox PlayerNet;
        private System.Windows.Forms.PictureBox BallBox;
        private System.Windows.Forms.PictureBox HatBox;
        private System.Windows.Forms.PictureBox PinkcrabBox;
        private System.Windows.Forms.PictureBox AlgaeBox;
        private System.Windows.Forms.PictureBox Coral2box;
        private System.Windows.Forms.PictureBox Coral1box;
        private System.Windows.Forms.PictureBox Backbox;
        private System.Windows.Forms.Label HardScorelbl;
        private System.Windows.Forms.PictureBox Nextbox;
        private System.Windows.Forms.PictureBox Scorebox;
        private System.Windows.Forms.PictureBox Playertimer;
        private System.Windows.Forms.Label HardTimelbl;
        private System.Windows.Forms.Timer RandomSpawnHard;
        private System.Windows.Forms.Timer FishMoveHard;
        private System.Windows.Forms.Timer NetSpeedHard;
        private System.Windows.Forms.Timer RandomSpawnBoom;
        private System.Windows.Forms.Timer HardCountDown;
        private System.Windows.Forms.Timer RandomSpawnLeftHard;
        private System.Windows.Forms.Timer RandomSpawnBoom2Hard;
        private System.Windows.Forms.Label lblHardLevel;
        private System.Windows.Forms.Label txtPlayername;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label ScoreWord;
    }
}