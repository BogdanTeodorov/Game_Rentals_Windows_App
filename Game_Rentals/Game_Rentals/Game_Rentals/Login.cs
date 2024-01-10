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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = $"{Application.ProductName} - Login";

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserAuthentication();
        }

        public bool UserAuthentication()
        {
            string sql = $@"SELECT UserId, UserName FROM Accounts WHERE UserName = '{txtUser.Text}' AND Password = '{txtPassword.Text}'";

            var results = DataAccess.GetData(sql);

            if (results.Rows.Count == 1)
            {
                string userName = results.Rows[0]["UserName"].ToString();

                if (userName == "GameRentalsAdmin")
                {
                    // User is admin
                    DialogResult = DialogResult.OK;
                    return true;
                }
                else 
                {
                    // User is a regular user
                    DialogResult = DialogResult.OK;
                    return false;
                }
            }

            // Authentication failed
            DialogResult = DialogResult.Abort;
            return false;
        }

    }
}
