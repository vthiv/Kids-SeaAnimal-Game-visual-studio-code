using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1551_SeaAnimal_Game
{
    public partial class Player_Name_Page : Form
    {
        public static string passingText;
        User PlayerInfo = new User();
        public Player_Name_Page()
        {
            InitializeComponent();
        }

        private void Backbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mp = new MainPage();
            mp.Show();
        }

        public void Startbox_Click(object sender, EventArgs e)
        {
            

            //Validation player name before playing the game
            if (!string.IsNullOrWhiteSpace(PlayerNametxtbox.Text))
            {
                string[] names = new string[2];
                passingText = PlayerNametxtbox.Text;
                PlayerInfo.Username = PlayerNametxtbox.Text;

                User[] user = {
                    new User(PlayerNametxtbox.Text)
                };

                for (int x = 0; x < user.Length; x++)
                {
                    MessageBox.Show(user[x].ToString());
                }

                this.Hide();
                LevelsPage lp = new LevelsPage();
                lp.Show();
            }
            else
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Please Enter User Name";
            }
        }
    }
}
