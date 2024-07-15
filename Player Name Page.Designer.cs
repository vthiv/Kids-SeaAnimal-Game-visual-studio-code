
namespace COMP1551_SeaAnimal_Game
{
    partial class Player_Name_Page
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
            this.PlayerNamelbl = new System.Windows.Forms.Label();
            this.PlayerNametxtbox = new System.Windows.Forms.TextBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.Backbox = new System.Windows.Forms.PictureBox();
            this.Startbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Backbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Startbox)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerNamelbl
            // 
            this.PlayerNamelbl.AutoSize = true;
            this.PlayerNamelbl.BackColor = System.Drawing.Color.Transparent;
            this.PlayerNamelbl.Font = new System.Drawing.Font("Wide Latin", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNamelbl.Location = new System.Drawing.Point(231, 89);
            this.PlayerNamelbl.Name = "PlayerNamelbl";
            this.PlayerNamelbl.Size = new System.Drawing.Size(322, 33);
            this.PlayerNamelbl.TabIndex = 0;
            this.PlayerNamelbl.Text = "Player Name";
            // 
            // PlayerNametxtbox
            // 
            this.PlayerNametxtbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PlayerNametxtbox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNametxtbox.Location = new System.Drawing.Point(258, 189);
            this.PlayerNametxtbox.Name = "PlayerNametxtbox";
            this.PlayerNametxtbox.Size = new System.Drawing.Size(269, 32);
            this.PlayerNametxtbox.TabIndex = 1;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(254, 236);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(66, 24);
            this.lblErrorMessage.TabIndex = 6;
            this.lblErrorMessage.Text = "label1";
            this.lblErrorMessage.Visible = false;
            // 
            // Backbox
            // 
            this.Backbox.BackColor = System.Drawing.Color.Transparent;
            this.Backbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backbox.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.back_arrow;
            this.Backbox.Location = new System.Drawing.Point(12, 12);
            this.Backbox.Name = "Backbox";
            this.Backbox.Size = new System.Drawing.Size(59, 59);
            this.Backbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Backbox.TabIndex = 7;
            this.Backbox.TabStop = false;
            this.Backbox.Click += new System.EventHandler(this.Backbox_Click);
            // 
            // Startbox
            // 
            this.Startbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Startbox.BackColor = System.Drawing.Color.Transparent;
            this.Startbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Startbox.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.play_btn_gold_;
            this.Startbox.Location = new System.Drawing.Point(551, 173);
            this.Startbox.Name = "Startbox";
            this.Startbox.Size = new System.Drawing.Size(78, 68);
            this.Startbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Startbox.TabIndex = 8;
            this.Startbox.TabStop = false;
            this.Startbox.Click += new System.EventHandler(this.Startbox_Click);
            // 
            // Player_Name_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COMP1551_SeaAnimal_Game.Properties.Resources.manyfishoceanback_700x476_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.Startbox);
            this.Controls.Add(this.Backbox);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.PlayerNametxtbox);
            this.Controls.Add(this.PlayerNamelbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Player_Name_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Backbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Startbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerNamelbl;
        private System.Windows.Forms.TextBox PlayerNametxtbox;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.PictureBox Backbox;
        private System.Windows.Forms.PictureBox Startbox;
    }
}