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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        int currentCuatomerRecord = 0;
        int currentCustomerId = 0;
        int firstCustomerId = 0;
        int lastCustomerId = 0;
        int? previousCustomerId;
        int? nextCustomerId;

        private void Users_Load(object sender, EventArgs e)
        {
            try
            {
                LoadFirstCustomer();
                ProgressBar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #region [Form Loaders]
        private void LoadFirstCustomer()
        {

            try
            {
                object customerId = DataAccess.GetValue("SELECT TOP (1) CustomerId FROM Customers ORDER BY FirstName, LastName");

                if (customerId == null)
                {
                    NavigationState(false);

                    btnAdd_Click(null, null);
                    btnCancel.Enabled = false;
                    return;

                }
                else
                {
                    btnFirst.Enabled = true;
                    btnNext.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnLast.Enabled = true;
                    btnCancel.Enabled = false;

                    currentCustomerId = Convert.ToInt32(customerId);
                    firstCustomerId = currentCustomerId;

                }

                NavigationState(true);

                firstCustomerId = Convert.ToInt32(customerId);
                currentCuatomerRecord = firstCustomerId;
                LoadCustomerDetails();
                NextPreviousButtonManagement();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void NextPreviousButtonManagement()
        {
            btnPrevious.Enabled = previousCustomerId != null;
            btnNext.Enabled = nextCustomerId != null;
        }

        private void LoadCustomerDetails()
        {
            errProviderCustomers.Clear();

            string[] sqlStatement = new string[]
            {
               $"SELECT * FROM Customers WHERE CustomerId = {currentCustomerId}",
               $@"
                SELECT 
                (
                    SELECT TOP(1) CustomerId as FirstCustomerId FROM Customers ORDER BY FirstName, LastName
                ) as FirstCustomerId,
                q.PreviousCustomerId,
                q.NextCustomerId,
                (
                    SELECT TOP(1) CustomerId as LastCustomerId FROM Customers ORDER BY FirstName Desc, LastName Desc
                ) as LastCustomerId,
                q.RowNumber
                 FROM
                (
                    SELECT CustomerId, FirstName, LastName,
                    LEAD(CustomerId) OVER(ORDER BY FirstName) AS NextCustomerId,
                    LAG(CustomerId) OVER(ORDER BY FirstName, LastName) AS PreviousCustomerId,
                    ROW_NUMBER() OVER(ORDER BY FirstName, LastName) AS RowNumber
                    FROM Customers
                ) AS q
                WHERE q.CustomerId = {currentCustomerId}
                ORDER BY q.FirstName, q.LastName".Replace(System.Environment.NewLine," "),
               $"SELECT COUNT(CustomerId) as CustomerCount FROM Customers"
            };


            try
            {
                DataSet ds = new();

                ds = DataAccess.GetData(sqlStatement);

                if (Convert.ToInt32(ds.Tables[2].Rows[0]["CustomerCount"]) == 0)
                {
                    MessageBox.Show("No customers in the system");
                    btnAdd_Click(null, null);
                    return;
                }

                DataRow selectedCustomer = ds.Tables[0].Rows[0];

                txtCustomerId.Text = selectedCustomer["CustomerId"].ToString();
                txtFirstName.Text = selectedCustomer["FirstName"].ToString();
                txtLastName.Text = selectedCustomer["LastName"].ToString();
                txtMiddleName.Text = selectedCustomer["MiddleName"].ToString();
                DateTime dateOfBirth = (DateTime)selectedCustomer["DateOfBirth"];
                dtpDateOfBirth.Text = dateOfBirth.ToString();
                string age = GetAge(dateOfBirth);
                txtAge.Text = age;
                txtEmail.Text = selectedCustomer["Email"].ToString();
                txtPhone.Text = selectedCustomer["Phone"].ToString();

                firstCustomerId = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstCustomerId"]);
                previousCustomerId = ds.Tables[1].Rows[0]["PreviousCustomerId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousCustomerId"]) : (int?)null;
                nextCustomerId = ds.Tables[1].Rows[0]["NextCustomerId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextCustomerId"]) : (int?)null;
                lastCustomerId = Convert.ToInt32(ds.Tables[1].Rows[0]["LastCustomerId"]);
                currentCuatomerRecord = Convert.ToInt32(ds.Tables[1].Rows[0]["RowNumber"]);
                if (currentCustomerId == firstCustomerId)
                {
                    tlsFirst_LastRecord.Text = $"Displaying first customer record in Customers List";

                }
                else if (currentCustomerId == lastCustomerId)
                {
                    tlsFirst_LastRecord.Text = $"Displaying last customer record in Customers List";
                }
                else
                {
                    tlsFirst_LastRecord.Text = string.Empty;
                }

                tlsStatus.Text = $"Displaying customer record {currentCuatomerRecord} of {ds.Tables[2].Rows[0]["CustomerCount"]}";
                NextPreviousButtonManagement();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private string GetAge(DateTime dateOfBirth)
        {
            // Calculate age
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - dateOfBirth.Year;

            // Adjust age if the birthday hasn't occurred yet this year
            if (currentDate.Month < dateOfBirth.Month || (currentDate.Month == dateOfBirth.Month && currentDate.Day < dateOfBirth.Day))
            {
                age--;
            }

            return age.ToString();
        }
        #endregion

        #region [Navigation Handler]

        private void NavigationState(bool enableState)
        {
            btnFirst.Enabled = enableState;
            btnLast.Enabled = enableState;
            btnNext.Enabled = enableState;
            btnPrevious.Enabled = enableState;
        }

        /// <summary>
        /// Hide/Show CRUD fileds and
        /// Read only on/off Text fileds
        /// If user is admin or regular user
        /// </summary>
        /// <param name="enable"></param>


        //  /// <summary>
        //  /// Handle navigation button interaction
        //  /// </summary>
        //  /// <param name="sender"></param>
        //  /// <param name="e"></param>
        private void Navigation_Handler(object sender, EventArgs e)
        {
            Button b = (Button)sender;


            switch (b.Name)
            {
                case "btnFirst":
                    currentCustomerId = firstCustomerId;
                    break;
                case "btnLast":
                    currentCustomerId = lastCustomerId;
                    break;
                case "btnPrevious":
                    currentCustomerId = previousCustomerId.Value;
                    break;
                case "btnNext":
                    currentCustomerId = nextCustomerId.Value;

                    break;
            }

            LoadCustomerDetails();
        }
        #endregion

        #region [Forms Helpers]

        //  /// <summary>
        //  /// Animate the progress bar
        //  /// This is ui thread blocking. Ok for this application.
        //  /// </summary>
        private void ProgressBar()
        {
            this.tlsStatus.Text = "Processing...";
            prbProgress.Value = 0;
            this.statusStrip1.Refresh();

            while (prbProgress.Value < prbProgress.Maximum)
            {
                Thread.Sleep(15);
                prbProgress.Value += 1;
            }

            prbProgress.Value = 100;

            this.tlsStatus.Text = "Processed";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tlsStatus.Text = "Add new Customer";
            tlsFirst_LastRecord.Text = string.Empty;
            UIUtilities.ClearControls(this.grbUsers.Controls);

            btnSave.Text = "Create";
            AgeHandler(false);
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;

            NavigationState(false);
        }

        private void Customers_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
        #endregion

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string? txtBoxName = txt.Tag.ToString();
            string errMsg = string.Empty;
            bool failedValidation = false;

            if (txt.Text == string.Empty)
            {
                errMsg = $"{txtBoxName} is required";
                failedValidation = true;
            }


            e.Cancel = failedValidation;

            errProviderCustomers.SetError(txt, errMsg);
        }

        /// <summary>
        /// Numeric validation 
        /// </summary>
        /// <param name="value">The value to validate</param>
        /// <returns>The result of the validation</returns>


        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {

                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (txtCustomerId.Text == string.Empty)
                    {
                        CreateCustomer();
                    }
                    else
                    {
                        UpdateCustomer();
                        
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateCustomer()
        {
            string sql = $@"
         UPDATE [dbo].[CUstomers]
         SET [FirstName] = '{txtFirstName.Text}'
        ,[LastName] = '{txtLastName.Text}'
        ,[MiddleName] = '{txtFirstName.Text}'
        ,[DateOfBirth] = '{dtpDateOfBirth.Text}'
        ,[Email] = '{txtEmail.Text}'
        ,[Phone] = '{txtPhone.Text}'
         WHERE CustomerId = {txtCustomerId.Text.Trim()}
              ";
            int rowsAffected = DataAccess.ExecuteNonQuery(sql);

            ProgressBar();

            if (rowsAffected == 1)
            {
                MessageBox.Show($"CustomerId: {txtCustomerId.Text} changes saved");
                AgeHandler(true);
                btnCancel.Enabled = false;
            }
            else
            {
                if (rowsAffected == 0)
                {
                    MessageBox.Show($"Update to CustomerId: {txtCustomerId.Text} was not updated.");
                    AgeHandler(true);
                    btnCancel.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Oh oh Did you forget the WHERE clause");
                    AgeHandler(true);
                    btnCancel.Enabled = false;
                }
            }


        }

        private void CreateCustomer()
        {
            string sqlInsertGame = $@"
                  INSERT INTO Customers ([FirstName]
           ,[LastName]
           ,[MiddleName]
           ,[DateOfBirth]
           ,[Email]
           ,[Phone])
            VALUES(
            '{txtFirstName.Text.Trim()}'
           ,'{txtLastName.Text.Trim()}'
           ,'{txtMiddleName.Text.Trim()}'
           ,'{dtpDateOfBirth.Text.Trim()}'
           ,'{txtEmail.Text.Trim()}'
           ,'{txtPhone.Text.Trim()}')
            ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sqlInsertGame);

            ProgressBar();

            if (rowsAffected == 1)
            {

                MessageBox.Show("Customer was created");
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
                btnSave.Text = "Save";
                AgeHandler(true);
                btnCancel_Click(null, null);
                NavigationState(true);
                LoadFirstCustomer();
            }
            else
            {
                MessageBox.Show("The database reported no rows affected");

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Save";
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;
            AgeHandler(true);

            NavigationState(true);

            LoadCustomerDetails();
        }

        private void AgeHandler(bool enable)
        {
            dtpDateOfBirth.Visible = !enable;
            lblDateOfBirth.Visible = !enable;
            lblAge.Visible = enable;
            txtAge.Visible = enable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteGame();
        }

        private void DeleteGame()
        {
            string sql = $@"
              DELETE FROM [dbo].[Customers] 
              WHERE CustomerId = {txtCustomerId.Text}
              ";
            int rowsAffected = DataAccess.ExecuteNonQuery(sql);

            ProgressBar();

            if (rowsAffected == 1)
            {
                MessageBox.Show($"CustomerId: {txtCustomerId.Text} was deleted");
                LoadFirstCustomer();
            }
            else if (rowsAffected == 0)
            {
                MessageBox.Show($"CustomerId: {txtCustomerId.Text} does not exist. May already have been deleted");
            }
            else
            {
                MessageBox.Show("Oh oh Did you forget the WHERE clause");
            }

        }

        private void txtAge_MouseClick(object sender, MouseEventArgs e)
        {
            AgeHandler(false);
            btnCancel.Enabled = true;
            
        }
    }
}
