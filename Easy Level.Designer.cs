
namespace COMP1551_SeaAnimal_Game
{
    partial class EasyLevel
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
            this.PlayerNet = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Nextbox = new System.Windows.Forms.PictureBox();
            this.PlayerTimerbox = new System.Windows.Forms.PictureBox();
            this.Scorebox = new System.Windows.Forms.PictureBox();
            this.Backbox = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.easyscorelbl = new System.Windows.Forms.Label();
            this.RandomSpawnEasy = new System.Windows.Forms.Timer(this.components);
            this.FishMoveEasy = new System.Windows.Forms.Timer(this.components);
            this.netSpeedEasy = new System.Windows.Forms.Timer(this.components);
            this.RandomSpawnBoom = new System.Windows.Forms.Timer(this.components);
            this.CountDown = new System.Windows.Forms.Timer(this.components);
            this.RandomSpawnLeft = new System.Windows.Forms.Timer(this.components);
            this.RandomSpawnBoom2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblEasyLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerNet)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTimerbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scorebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerNet
            // 
            this.PlayerNet.BackColor = System.Drawing.Color.Transparent;
            this.PlayerNet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlayerNet.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.Player_net;
            this.PlayerNet.Location = new System.Drawing.Point(492, 223);
            this.PlayerNet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayerNet.Name = "PlayerNet";
            this.PlayerNet.Size = new System.Drawing.Size(73, 60);
            this.PlayerNet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerNet.TabIndex = 0;
            this.PlayerNet.TabStop = false;
            this.PlayerNet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerNet_MouseDown);
            this.PlayerNet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlayerNet_MouseMove);
            this.PlayerNet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerNet_MouseUp);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.Controls.Add(this.lblEasyLevel);
            this.TopPanel.Controls.Add(this.Nextbox);
            this.TopPanel.Controls.Add(this.PlayerTimerbox);
            this.TopPanel.Controls.Add(this.Scorebox);
            this.TopPanel.Controls.Add(this.Backbox);
            this.TopPanel.Controls.Add(this.lblTimer);
            this.TopPanel.Controls.Add(this.easyscorelbl);
            this.TopPanel.Location = new System.Drawing.Point(-5, -1);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1059, 69);
            this.TopPanel.TabIndex = 1;
            // 
            // Nextbox
            // 
            this.Nextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nextbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nextbox.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.next_arrow_gold_;
            this.Nextbox.Location = new System.Drawing.Point(988, 4);
            this.Nextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nextbox.Name = "Nextbox";
            this.Nextbox.Size = new System.Drawing.Size(51, 62);
            this.Nextbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Nextbox.TabIndex = 9;
            this.Nextbox.TabStop = false;
            this.Nextbox.Click += new System.EventHandler(this.Nextbox_Click);
            // 
            // PlayerTimerbox
            // 
            this.PlayerTimerbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerTimerbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayerTimerbox.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.playertimer;
            this.PlayerTimerbox.Location = new System.Drawing.Point(639, 10);
            this.PlayerTimerbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayerTimerbox.Name = "PlayerTimerbox";
            this.PlayerTimerbox.Size = new System.Drawing.Size(56, 48);
            this.PlayerTimerbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerTimerbox.TabIndex = 8;
            this.PlayerTimerbox.TabStop = false;
            // 
            // Scorebox
            // 
            this.Scorebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scorebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Scorebox.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.scoregold;
            this.Scorebox.Location = new System.Drawing.Point(352, 4);
            this.Scorebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Scorebox.Name = "Scorebox";
            this.Scorebox.Size = new System.Drawing.Size(83, 62);
            this.Scorebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Scorebox.TabIndex = 7;
            this.Scorebox.TabStop = false;
            // 
            // Backbox
            // 
            this.Backbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Backbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backbox.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.back_arrow;
            this.Backbox.Location = new System.Drawing.Point(21, 4);
            this.Backbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Backbox.Name = "Backbox";
            this.Backbox.Size = new System.Drawing.Size(51, 62);
            this.Backbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Backbox.TabIndex = 6;
            this.Backbox.TabStop = false;
            this.Backbox.Click += new System.EventHandler(this.Backbox_Click);
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
            // easyscorelbl
            // 
            this.easyscorelbl.BackColor = System.Drawing.Color.Transparent;
            this.easyscorelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyscorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyscorelbl.ForeColor = System.Drawing.Color.Black;
            this.easyscorelbl.Location = new System.Drawing.Point(437, 20);
            this.easyscorelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.easyscorelbl.Name = "easyscorelbl";
            this.easyscorelbl.Size = new System.Drawing.Size(133, 28);
            this.easyscorelbl.TabIndex = 2;
            // 
            // RandomSpawnEasy
            // 
            this.RandomSpawnEasy.Interval = 2000;
            this.RandomSpawnEasy.Tick += new System.EventHandler(this.RandomSpawnEasy_Tick);
            // 
            // FishMoveEasy
            // 
            this.FishMoveEasy.Interval = 10;
            this.FishMoveEasy.Tick += new System.EventHandler(this.FishMoveEasy_Tick);
            // 
            // netSpeedEasy
            // 
            this.netSpeedEasy.Interval = 10;
            this.netSpeedEasy.Tick += new System.EventHandler(this.netSpeedEasy_Tick);
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.orangepurple_ball;
            this.pictureBox2.Location = new System.Drawing.Point(114, 150);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.colorcoral19;
            this.pictureBox3.Location = new System.Drawing.Point(775, 389);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(209, 108);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // lblEasyLevel
            // 
            this.lblEasyLevel.AutoSize = true;
            this.lblEasyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEasyLevel.Location = new System.Drawing.Point(117, 20);
            this.lblEasyLevel.Name = "lblEasyLevel";
            this.lblEasyLevel.Size = new System.Drawing.Size(154, 32);
            this.lblEasyLevel.TabIndex = 10;
            this.lblEasyLevel.Text = "Easy Level";
            // 
            // EasyLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COMP1551_SeaAnimal_Game.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 506);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.PlayerNet);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EasyLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy_Level";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EasyLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EasyLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerNet)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTimerbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scorebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayerNet;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label easyscorelbl;
        private System.Windows.Forms.Timer RandomSpawnEasy;
        private System.Windows.Forms.Timer FishMoveEasy;
        private System.Windows.Forms.Timer netSpeedEasy;
        private System.Windows.Forms.Timer RandomSpawnBoom;
        private System.Windows.Forms.Timer CountDown;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer RandomSpawnLeft;
        private System.Windows.Forms.Timer RandomSpawnBoom2;
        private System.Windows.Forms.PictureBox Backbox;
        private System.Windows.Forms.PictureBox PlayerTimerbox;
        private System.Windows.Forms.PictureBox Scorebox;
        private System.Windows.Forms.PictureBox Nextbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblEasyLevel;
    }
}