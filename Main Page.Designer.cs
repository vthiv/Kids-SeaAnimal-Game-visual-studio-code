
namespace COMP1551_SeaAnimal_Game
{
    partial class MainPage
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
            this.Titlelbl1 = new System.Windows.Forms.Label();
            this.Titlelbl2 = new System.Windows.Forms.Label();
            this.Titlelbl3 = new System.Windows.Forms.Label();
            this.Titlelbltimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Startlbl = new System.Windows.Forms.Label();
            this.Exitlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlelbl1
            // 
            this.Titlelbl1.AutoSize = true;
            this.Titlelbl1.BackColor = System.Drawing.Color.Transparent;
            this.Titlelbl1.Location = new System.Drawing.Point(501, 124);
            this.Titlelbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titlelbl1.Name = "Titlelbl1";
            this.Titlelbl1.Size = new System.Drawing.Size(46, 17);
            this.Titlelbl1.TabIndex = 0;
            this.Titlelbl1.Text = "label1";
            // 
            // Titlelbl2
            // 
            this.Titlelbl2.AutoSize = true;
            this.Titlelbl2.BackColor = System.Drawing.Color.Transparent;
            this.Titlelbl2.Location = new System.Drawing.Point(505, 145);
            this.Titlelbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titlelbl2.Name = "Titlelbl2";
            this.Titlelbl2.Size = new System.Drawing.Size(46, 17);
            this.Titlelbl2.TabIndex = 1;
            this.Titlelbl2.Text = "label1";
            // 
            // Titlelbl3
            // 
            this.Titlelbl3.AutoSize = true;
            this.Titlelbl3.BackColor = System.Drawing.Color.Transparent;
            this.Titlelbl3.Location = new System.Drawing.Point(505, 166);
            this.Titlelbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titlelbl3.Name = "Titlelbl3";
            this.Titlelbl3.Size = new System.Drawing.Size(46, 17);
            this.Titlelbl3.TabIndex = 2;
            this.Titlelbl3.Text = "label1";
            // 
            // Titlelbltimer
            // 
            this.Titlelbltimer.Tick += new System.EventHandler(this.Titlelbltimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.blue_fish;
            this.pictureBox1.Location = new System.Drawing.Point(146, 332);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::COMP1551_SeaAnimal_Game.Properties.Resources.blue_fish;
            this.pictureBox3.Location = new System.Drawing.Point(582, 332);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(140, 140);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Startlbl
            // 
            this.Startlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Startlbl.BackColor = System.Drawing.Color.Transparent;
            this.Startlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Startlbl.Font = new System.Drawing.Font("Impact", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.Startlbl.Location = new System.Drawing.Point(250, 272);
            this.Startlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Startlbl.Name = "Startlbl";
            this.Startlbl.Size = new System.Drawing.Size(250, 92);
            this.Startlbl.TabIndex = 9;
            this.Startlbl.Text = "START";
            this.Startlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Startlbl.Click += new System.EventHandler(this.Startlbl_Click);
            // 
            // Exitlbl
            // 
            this.Exitlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exitlbl.BackColor = System.Drawing.Color.Transparent;
            this.Exitlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exitlbl.Font = new System.Drawing.Font("Impact", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.Exitlbl.Location = new System.Drawing.Point(696, 272);
            this.Exitlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exitlbl.Name = "Exitlbl";
            this.Exitlbl.Size = new System.Drawing.Size(201, 86);
            this.Exitlbl.TabIndex = 11;
            this.Exitlbl.Text = "EXIT";
            this.Exitlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exitlbl.Click += new System.EventHandler(this.Exitlbl_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COMP1551_SeaAnimal_Game.Properties.Resources._3D_underwater;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Exitlbl);
            this.Controls.Add(this.Startlbl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Titlelbl3);
            this.Controls.Add(this.Titlelbl2);
            this.Controls.Add(this.Titlelbl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelbl1;
        private System.Windows.Forms.Label Titlelbl2;
        private System.Windows.Forms.Label Titlelbl3;
        private System.Windows.Forms.Timer Titlelbltimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Startlbl;
        private System.Windows.Forms.Label Exitlbl;
    }
}

