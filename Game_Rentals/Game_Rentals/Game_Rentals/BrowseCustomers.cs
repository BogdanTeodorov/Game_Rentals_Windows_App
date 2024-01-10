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
    public partial class BrowseCustomers : Form
    {
        public BrowseCustomers()
        {
            InitializeComponent();
        }

        private void BrowseCustomers_Load(object sender, EventArgs e)
        {

            string sqlCusomers = "SELECT * FROM Customers ORDER BY FirstName, LastName";

            var dtCustomers = DataAccess.GetData(sqlCusomers);

            dgvCustomers.DataSource = dtCustomers;
        }
    }
}
