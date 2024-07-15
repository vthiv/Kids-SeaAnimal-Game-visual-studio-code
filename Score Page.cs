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
    public partial class Score_Page : Form
    {
        public Score_Page()
        {
            InitializeComponent();
        }

        private void gobackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LevelsPage lp = new LevelsPage();
            lp.Show();
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void Score_Page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database4DataSet.Game' table. You can move, or remove it, as needed.
            this.gameTableAdapter.Fill(this.database4DataSet.Game);

        }

        private void chartLoad_Click(object sender, EventArgs e)
        {
            chartScore_Hard_Bar.DataSource = database4DataSet.Game;
            chartScore_Hard_Bar.DataBind();
            chartScore_Hard.DataSource = database4DataSet.Game;
            chartScore_Hard.DataBind();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Hide();
            Score_Page sp = new Score_Page();
            sp.Show();
        }
    }
}
