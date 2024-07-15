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
    public partial class LevelsPage : Form
    {
        public LevelsPage()
        {
            InitializeComponent();
        }

        private void Backbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player_Name_Page pnp = new Player_Name_Page();
            pnp.Show();
        }

        private void Easylbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            EasyLevel el = new EasyLevel();
            el.Show();
        }

        private void Normallbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Normal_Level nl = new Normal_Level();
            nl.Show();
        }

        private void Hardlbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            HardLevel hl = new HardLevel();
            hl.Show();
        }

        private void EasyfishBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            EasyLevel el = new EasyLevel();
            el.Show();
        }

        private void NormalfishBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Normal_Level nl = new Normal_Level();
            nl.Show();
        }

        private void HardfishBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            HardLevel hl = new HardLevel();
            hl.Show();
        }

        private void lblScoreLevelPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Score_Page sp = new Score_Page();
            sp.Show();
        }
    }
}
