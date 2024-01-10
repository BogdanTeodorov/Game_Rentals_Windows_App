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
    public partial class BrowseRentals : Form
    {
        public BrowseRentals()
        {
            InitializeComponent();
        }

        private void BrowseRentals_Load(object sender, EventArgs e)
        {
            string sqlRentals = @"
        SELECT g.Title, c.FirstName + ' ' + c.LastName as FullName, 
        g.RentalPrice , g.Rate, r.RentalDate, r.DueDate, r.ReturnDate 
        FROM Games g Inner JOIN Rentals r 
        ON g.GameID = r.GameID
        INNER JOIN Customers c 
        ON r.CustomerId = c.CustomerId
        ORDER BY Title";
          var dtRentals = DataAccess.GetData(sqlRentals);
            dgvRentals.DataSource = dtRentals;
        }
    }
}
