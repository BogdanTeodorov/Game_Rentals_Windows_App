using Assignment2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Rentals
{
    public partial class BrowseGames : Form
    {
        public BrowseGames()
        {
            InitializeComponent();
        }

        private void BrowseGames_Load(object sender, EventArgs e)
        {
            string sqlGetGames = "SELECT * FROM Games ORDER BY Title";

            var dtGames= DataAccess.GetData(sqlGetGames);

            dgvGames.DataSource = dtGames;


        }
    }
}
