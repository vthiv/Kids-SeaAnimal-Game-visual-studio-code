
namespace COMP1551_SeaAnimal_Game
{
    partial class Normal_Level
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lblNormalLevel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Nextbox = new System.Windows.Forms.PictureBox();
            this.Scorebox = new System.Windows.Forms.PictureBox();
            this.Backbox = new System.Windows.Forms.PictureBox();
            this.Crabcoral = new System.Windows.Forms.PictureBox();
            this.PlayerNetNormal = new System.Windows.Forms.PictureBox();
            this.RandomSpawnRight = new System.Windows.Forms.Timer(this.components);
            this.RandomSpawnBoom = new System.Windows.Forms.Timer(this.components);
            this.CountDown = new System.Windows.Forms.Timer(this.components);
            this.RandomSpawnLeft = new System.Windows.Forms.Timer(this.components);
            this.RandomSpawnBoom2 = new System.Windows.Forms.Timer(this.components);
            this.FishMoveNormal = new System.Windows.Forms.Timer(this.components);
            this.netSpeedNormal = new System.Windows.Forms.Timer(this.components);
            this.Diamond = new System.Windows.Forms.PictureBox();
            this.GiftBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.normalscorelbl = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scorebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crabcoral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerNetNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diamond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiftBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 54);
            this.panel1.TabIndex = 13;
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Black;
            this.lblTimer.Location = new System.Drawing.Point(696, 20);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(133, 28);
            this.lblTimer.TabIndex = 5;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.Controls.Add(this.normalscorelbl);
            this.TopPanel.Controls.Add(this.lblNormalLevel);
            this.TopPanel.Controls.Add(this.pictureBox3);
            this.TopPanel.Controls.Add(this.Nextbox);
            this.TopPanel.Controls.Add(this.Scorebox);
            this.TopPanel.Controls.Add(this.lblTimer);
            this.TopPanel.Controls.Add(this.Backbox);
            this.TopPanel.Location = new System.Drawing.Point(-5, -1);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1059, 68);
            this.TopPanel.TabIndex = 15;
            // 
            // lblNormalLevel
            // 
            this.lblNormalLevel.AutoSize = true;
            this.lblNormalLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormalLevel.Location = new System.Drawing.Point(117, 20);
            this.lblNormalLevel.Name = "lblNormalLevel";
            this.lblNormalLevel.Size = new System.Drawing.Size(182, 32);
            this.lblNormalLevel.TabIndex = 21;
            this.lblNormalLevel.Text = "Normal Level";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.playertimer;
            this.pictureBox3.Location = new System.Drawing.Point(639, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
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
            this.Nextbox.TabIndex = 20;
            this.Nextbox.TabStop = false;
            this.Nextbox.Click += new System.EventHandler(this.Nextbox_Click);
            // 
            // Scorebox
            // 
            this.Scorebox.BackColor = System.Drawing.Color.Transparent;
            this.Scorebox.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.scoregold;
            this.Scorebox.Location = new System.Drawing.Point(352, 4);
            this.Scorebox.Margin = new System.Windows.Forms.Padding(4);
            this.Scorebox.Name = "Scorebox";
            this.Scorebox.Size = new System.Drawing.Size(83, 62);
            this.Scorebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Scorebox.TabIndex = 18;
            this.Scorebox.TabStop = false;
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
            this.Backbox.TabIndex = 17;
            this.Backbox.TabStop = false;
            this.Backbox.Click += new System.EventHandler(this.Backbox_Click);
            // 
            // Crabcoral
            // 
            this.Crabcoral.BackColor = System.Drawing.Color.Transparent;
            this.Crabcoral.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.Crab_On_The_Beach;
            this.Crabcoral.Location = new System.Drawing.Point(16, 335);
            this.Crabcoral.Margin = new System.Windows.Forms.Padding(4);
            this.Crabcoral.Name = "Crabcoral";
            this.Crabcoral.Size = new System.Drawing.Size(313, 220);
            this.Crabcoral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Crabcoral.TabIndex = 16;
            this.Crabcoral.TabStop = false;
            // 
            // PlayerNetNormal
            // 
            this.PlayerNetNormal.BackColor = System.Drawing.Color.Transparent;
            this.PlayerNetNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlayerNetNormal.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.Player_net;
            this.PlayerNetNormal.Location = new System.Drawing.Point(492, 223);
            this.PlayerNetNormal.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerNetNormal.Name = "PlayerNetNormal";
            this.PlayerNetNormal.Size = new System.Drawing.Size(73, 60);
            this.PlayerNetNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerNetNormal.TabIndex = 14;
            this.PlayerNetNormal.TabStop = false;
            this.PlayerNetNormal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerNetNormal_MouseDown);
            this.PlayerNetNormal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlayerNetNormal_MouseMove);
            this.PlayerNetNormal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerNetNormal_MouseUp);
            // 
            // RandomSpawnRight
            // 
            this.RandomSpawnRight.Interval = 2000;
            this.RandomSpawnRight.Tick += new System.EventHandler(this.RandomSpawnRight_Tick);
            // 
            // RandomSpawnBoom
            // 
            this.RandomSpawnBoom.Interval = 2000;
            this.RandomSpawnBoom.Tick += new System.EventHandler(this.RandomSpawnBoom_Tick);
            // 
            // CountDown
            // 
            this.CountDown.Interval = 1000;
            this.CountDown.Tick += new System.EventHandler(this.CountDown_Tick);
            // 
            // RandomSpawnLeft
            // 
            this.RandomSpawnLeft.Interval = 2000;
            this.RandomSpawnLeft.Tick += new System.EventHandler(this.RandomSpawnLeft_Tick);
            // 
            // RandomSpawnBoom2
            // 
            this.RandomSpawnBoom2.Interval = 2000;
            this.RandomSpawnBoom2.Tick += new System.EventHandler(this.RandomSpawnBoom2_Tick);
            // 
            // FishMoveNormal
            // 
            this.FishMoveNormal.Interval = 10;
            this.FishMoveNormal.Tick += new System.EventHandler(this.FishMoveNormal_Tick);
            // 
            // netSpeedNormal
            // 
            this.netSpeedNormal.Interval = 10;
            this.netSpeedNormal.Tick += new System.EventHandler(this.netSpeedNormal_Tick);
            // 
            // Diamond
            // 
            this.Diamond.BackColor = System.Drawing.Color.Transparent;
            this.Diamond.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.diamond_coral__2_;
            this.Diamond.Location = new System.Drawing.Point(681, 335);
            this.Diamond.Margin = new System.Windows.Forms.Padding(4);
            this.Diamond.Name = "Diamond";
            this.Diamond.Size = new System.Drawing.Size(175, 159);
            this.Diamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Diamond.TabIndex = 17;
            this.Diamond.TabStop = false;
            // 
            // GiftBox
            // 
            this.GiftBox.BackColor = System.Drawing.Color.Transparent;
            this.GiftBox.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.object4;
            this.GiftBox.Location = new System.Drawing.Point(112, 101);
            this.GiftBox.Margin = new System.Windows.Forms.Padding(4);
            this.GiftBox.Name = "GiftBox";
            this.GiftBox.Size = new System.Drawing.Size(69, 65);
            this.GiftBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GiftBox.TabIndex = 18;
            this.GiftBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.shoes__2_;
            this.pictureBox1.Location = new System.Drawing.Point(830, 161);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // normalscorelbl
            // 
            this.normalscorelbl.BackColor = System.Drawing.Color.Transparent;
            this.normalscorelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normalscorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalscorelbl.ForeColor = System.Drawing.Color.Black;
            this.normalscorelbl.Location = new System.Drawing.Point(437, 20);
            this.normalscorelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.normalscorelbl.Name = "normalscorelbl";
            this.normalscorelbl.Size = new System.Drawing.Size(133, 28);
            this.normalscorelbl.TabIndex = 22;
            // 
            // Normal_Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COMP1551_SeaAnimal_Game.Properties.Resources.Background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GiftBox);
            this.Controls.Add(this.Diamond);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.Crabcoral);
            this.Controls.Add(this.PlayerNetNormal);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Normal_Level";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Normal_Level";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Normal_Level_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Normal_Level_KeyUp);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scorebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crabcoral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerNetNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diamond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiftBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Button back1btn;
        //private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox Crabcoral;
        private System.Windows.Forms.PictureBox PlayerNetNormal;
        private System.Windows.Forms.Timer RandomSpawnRight;
        private System.Windows.Forms.Timer RandomSpawnBoom;
        private System.Windows.Forms.Timer CountDown;
        private System.Windows.Forms.Timer RandomSpawnLeft;
        private System.Windows.Forms.Timer RandomSpawnBoom2;
        private System.Windows.Forms.Timer FishMoveNormal;
        private System.Windows.Forms.Timer netSpeedNormal;
        private System.Windows.Forms.PictureBox Backbox;
        private System.Windows.Forms.PictureBox Scorebox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Nextbox;
        private System.Windows.Forms.PictureBox Diamond;
        private System.Windows.Forms.PictureBox GiftBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNormalLevel;
        private System.Windows.Forms.Label normalscorelbl;
    }
}