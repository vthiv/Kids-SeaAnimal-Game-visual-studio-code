using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace COMP1551_SeaAnimal_Game
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            IUser d;
            d = new User();
            d.interfacesMessage();
            d = new User();
            d.errorCheck();
            d = new User();
            d.greetingToUser();
            d = new User();
            d.meaningOfGame();
            d = new User();
            d.exitLine();

            playaudio();
        }

        string s = "Sea Animal Symbols Hidden Game";
        string[] l;
        int i = 0, j = 0;

        private void playaudio() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(COMP1551_SeaAnimal_Game.Properties.Resources.IntroAudio);
            audio.Play();
        }

        private void Titlelbltimer_Tick(object sender, EventArgs e)
        {
            if (i < s.Length - 1)
                Titlelbl2.Text += l[i].ToString();

            if(i >= 2 && i <= 35)
            {
                if (i <= s.Length + 1)
                    Titlelbl3.Text += l[j].ToString();
                j++;
            }

            if (j <= s.Length)
                i++;
            else
            {
                i = j = 0;
                Titlelbl3.Text = Titlelbl2.Text = " ";
            }
        }

        private void Startlbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player_Name_Page pn = new Player_Name_Page();
            pn.Show();
        }

        private void Exitlbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e) // Start
        {
            this.Hide();
            Player_Name_Page pn = new Player_Name_Page();
            pn.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e) //Exit
        {
            this.Close();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            Titlelbl1.Text = s;
            l = new string[s.Length];
            for (int i = 0; i < s.Length; i++)
                l[i] = s[i].ToString();

            Titlelbl1.Location = Titlelbl2.Location = Titlelbl3.Location = new Point(53, 53);

            Titlelbl1.Font = Titlelbl2.Font = Titlelbl3.Font = new System.Drawing.Font("Stencil", 30F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));

            this.Titlelbl2.ForeColor = System.Drawing.Color.White;
            Titlelbl2.Text = Titlelbl3.Text = " ";
            Titlelbltimer.Start();
        }
    }
}
