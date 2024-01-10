using Assignment2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Rentals
{
    public partial class Rentals : Form
    {
        public Rentals()
        {
            InitializeComponent();
        }

        #region [Navigation Variables]

        private int currentCustomerId;
        private int currentGameId;

        private int firstCustomerId;
        private int firstGameId;


        private int lastCustomerId;
        private int lastGameId;

        private int? previousCustomerId;
        private int? previousGameId;

        private int? nextCustomerId;
        private int? nextGameId;

        private int rowsCount = 0;

        private int rowsTotal;

        int currentRentalRecord = 0;


        #endregion





        private void Rentals_Load(object sender, EventArgs e)
        {

            try
            {
                if (this.MdiParent.Text == "Game Rentals - Admin Mode")
                {

                    this.Text = "Rentals (Admin Mode)";
                    ProgressBar();
                    dtpRent.Enabled = true;
                    dtpDue.Enabled = true;
                    lblFirstName.Visible = false;
                    lblLastname.Visible = false;
                    txtFirstName.Visible = false;
                    txtLastName.Visible = false;
                    btnRetrieveList.Visible = false;
                    btnClear.Visible = false;
                    //Load Customers combo box
                    LoadCustomers();

                    //Load Games combo box
                    LoadGames();

                    //Load the first record in the rentals tabel
                    LoadFirstRental();
                }
                else
                {
                    MessageBox.Show("Please enter your first name and last name in order to retrieve your rentals information");
                    HideGroupFields(true);
                    FieldsAndButtonsHandler(true);
                    lblFirstName.Visible = true;
                    lblLastname.Visible = true;
                    txtFirstName.Visible = true;
                    txtLastName.Visible = true;
                    btnDelete.Visible = false;
                    NavigationControl(true);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



        private void NavigationControl(bool enable)
        {
            btnFirst.Enabled = !enable;
            btnLast.Enabled = !enable;
            btnPrevious.Enabled = !enable;
            btnNext.Enabled = !enable;
            btnAdd.Enabled = !enable;
            btnSave.Enabled = !enable;
        }

        private void HideGroupFields(bool enable)
        {
            lblCustomerName.Visible = !enable;
            cmbCustomers.Visible = !enable;

            lblTitle.Visible = !enable;
            cmbGames.Visible = !enable;

            lblRentalPrice.Visible = !enable;
            txtPrice.Visible = !enable;

            lblRentDate.Visible = !enable;
            dtpRent.Visible = !enable;

            lblDueDate.Visible = !enable;
            dtpDue.Visible = !enable;

            lblReturnDate.Visible = !enable;
            dtpReturn.Visible = !enable;

            lblRate.Visible = !enable;
            txtRate.Visible = !enable;




        }
        private void FieldsAndButtonsHandler(bool enable)
        {

            btnAdd.Enabled = !enable;
            btnSave.Enabled = !enable;
            txtPrice.ReadOnly = enable;
            txtRate.ReadOnly = enable;
        }
        private void LoadFirstRental()
        {
            DataTable dt = DataAccess.GetData("SELECT TOP 1 * FROM Rentals");

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                currentCustomerId = Convert.ToInt32(dr["CustomerId"]);
                currentGameId = Convert.ToInt32(dr["GameId"]);

                firstCustomerId = currentCustomerId;
                firstGameId = currentGameId;

                LoadRentalsDetails();
                NextPreviousButtonManagement();

            }

        }

        private void LoadRentalsDetails()
        {
            errorRentals.Clear();

            string[] sqlStatements = new string[]
            {
                 $@"
                   SELECT r.GameID, r.CustomerId, r.RentalDate, r.DueDate, r.ReturnDate, g.RentalPrice, g.Rate FROM Rentals r Inner JOIN Games g 
				   ON r.GameID = g.GameID
                   WHERE r.GameId = {currentGameId}
                    AND CustomerId = {currentCustomerId}
                ",
                $@"
                     SELECT 
                    (
                        SELECT TOP(1) GameId as FirstCustomerId FROM Rentals
                    ) as FirstGameId,
                    (
                        SELECT TOP(1) CustomerId as FirstCustomerId FROM Rentals
                    ) as FirstCustomerId,
                    q.PreviousGameId,
                    q.PreviousCustomerId,
                    q.NextGameId,
                    q.NextCustomerId,
                    (
                        SELECT TOP(1) GameId as LastGameId FROM Rentals ORDER BY GameId Desc
                    ) as LastGameId,
                    (
                        SELECT TOP(1) CustomerId as LastCustomerId FROM Rentals ORDER BY GameId Desc
                    ) as LastCustomerId,
                    q.RowNumber
                    FROM
                    (
                        SELECT GameId, CustomerId,
	                    LEAD(GameId) OVER(ORDER BY GameId) AS NextGameId,
	                    LEAD(CustomerId) OVER(ORDER BY GameId) AS NextCustomerId,  
	                    LAG(GameId) OVER(ORDER BY GameId) AS PreviousGameId,
	                    LAG(CustomerId) OVER(ORDER BY GameId) AS PreviousCustomerId,
                        ROW_NUMBER() OVER(ORDER BY GameId) AS 'RowNumber'
                        FROM Rentals
                    ) AS q
                    WHERE q.GameId = {currentGameId}
                    AND q.CustomerId = {currentCustomerId} 
                    ORDER BY q.GameId, q.CustomerId",
                $@"SELECT COUNT(*) as RentalsCount FROM Rentals"
            };

            DataSet dsData = DataAccess.GetData(sqlStatements);

            if (dsData.Tables[0].Rows.Count == 1)
            {
                DataRow selectedRentals = dsData.Tables[0].Rows[0];
                DataRow navMeta = dsData.Tables[1].Rows[0];


                int customerId = Convert.ToInt32(selectedRentals["CustomerId"]);
                int gameId = Convert.ToInt32(selectedRentals["GameId"]);

                cmbCustomers.SelectedValue = customerId;
                cmbGames.SelectedValue = gameId;

                double price = Convert.ToDouble(selectedRentals["RentalPrice"]);
                txtPrice.Text = price.ToString("c");
                txtRate.Text = selectedRentals["Rate"].ToString();
                dtpRent.Text = selectedRentals["RentalDate"].ToString();
                dtpDue.Text = selectedRentals["DueDate"].ToString();
                if (selectedRentals["ReturnDate"] != DBNull.Value)
                {
                    dtpReturn.Text = selectedRentals["ReturnDate"].ToString();
                    lblNotReturned.Visible = false;

                }
                else
                {

                    dtpReturn.Text = DateTime.Now.ToString();
                    lblNotReturned.Visible = true;
                }


                firstGameId = Convert.ToInt32(navMeta["FirstGameId"]);
                firstCustomerId = Convert.ToInt32(navMeta["FirstCustomerId"]);


                lastGameId = Convert.ToInt32(navMeta["LastGameId"]);
                lastCustomerId = Convert.ToInt32(navMeta["LastCustomerId"]);

                currentRentalRecord = Convert.ToInt32(dsData.Tables[1].Rows[0]["RowNumber"]);

                previousGameId = navMeta["PreviousGameId"] != DBNull.Value ? Convert.ToInt32(navMeta["PreviousGameId"]) : (int?)null;
                previousCustomerId = navMeta["PreviousCustomerId"] != DBNull.Value ? Convert.ToInt32(navMeta["PreviousCustomerId"]) : (int?)null;

                nextGameId = navMeta["NextGameId"] != DBNull.Value ? Convert.ToInt32(navMeta["NextGameId"]) : (int?)null;
                nextCustomerId = navMeta["NextCustomerId"] != DBNull.Value ? Convert.ToInt32(navMeta["NextCustomerId"]) : (int?)null;


                if (currentCustomerId == firstCustomerId && currentGameId == firstGameId)
                {
                    tlsFirst_LastRecord.Text = $"Displaying first customer record in Rental List";

                }
                else if (currentCustomerId == lastCustomerId && currentGameId == lastGameId)
                {
                    tlsFirst_LastRecord.Text = $"Displaying last customer record in Customers List";
                }
                else
                {
                    tlsFirst_LastRecord.Text = string.Empty;
                }
                string message;
                if (selectedRentals["ReturnDate"] != DBNull.Value &&
                   Convert.ToDateTime(selectedRentals["ReturnDate"].ToString()) < Convert.ToDateTime(dtpDue.Text))
                {
                    ((frmMDIGameRentals)this.MdiParent).StatusStripLabel.ForeColor = System.Drawing.Color.Green;
                    message = $@"{cmbCustomers.Text}  has rented {cmbGames.Text}. Game has been returned.";
                }
                else if (selectedRentals["ReturnDate"] == DBNull.Value && DateTime.Now < Convert.ToDateTime(dtpDue.Text))
                {

                    ((frmMDIGameRentals)this.MdiParent).StatusStripLabel.ForeColor = System.Drawing.Color.Yellow;
                    message = $@"{cmbCustomers.Text}  has rented {cmbGames.Text}. No Overdue. Game is not returned";

                }
                else if (selectedRentals["ReturnDate"] != DBNull.Value &&
                   Convert.ToDateTime(selectedRentals["ReturnDate"].ToString()) > Convert.ToDateTime(dtpDue.Text))
                {
                    ((frmMDIGameRentals)this.MdiParent).StatusStripLabel.ForeColor = System.Drawing.Color.Red;
                    message = $@"{cmbCustomers.Text}  has rented {cmbGames.Text}. Overdue. Penalty {price * 2:c}";
                }

                else
                {
                    ((frmMDIGameRentals)this.MdiParent).StatusStripLabel.ForeColor = System.Drawing.Color.Red;
                    message = $@"{cmbCustomers.Text}  has rented {cmbGames.Text}. Overdue. Penalty {price * 2:c}. Game is not returned";
                }



                if (message.Contains("Penalty"))
                {

                    ((frmMDIGameRentals)this.MdiParent).StatusStripLabel.Text = message;

                }
                else
                {

                    ((frmMDIGameRentals)this.MdiParent).StatusStripLabel.Text = message;
                }


                tlsStatus.Text = $"Displaying rental record {currentRentalRecord} of {dsData.Tables[2].Rows[0]["RentalsCount"]}";





            }
            else
            {
                object assignmentCount = DataAccess.GetValue("SELECT COUNT(*) FROM Rentals");

                if (assignmentCount == DBNull.Value)
                {
                    MessageBox.Show("No rentals in the system");
                }
                else
                {
                    MessageBox.Show("The rental no longer exists");
                    LoadFirstRental();
                }
            }


        }

        private void LoadGames()
        {
            string sql = @"
            SELECT GameId, Title
                FROM Games
                ORDER BY Title
            ";
            DataTable dtGames = DataAccess.GetData(sql);

            cmbGames.Bind(dtGames, "Title", "GameId", "--Choose a Game--");
        }

        private void LoadCustomers()
        {
            string sql = @"
                SELECT CustomerId, FirstName + ' ' +LastName as FullName
                FROM Customers
                ORDER BY LastName, FirstName
            ";
            DataTable dtCustomers = DataAccess.GetData(sql);
            cmbCustomers.Bind(dtCustomers, "FullName", "CustomerId", "--Select a Customer--");
        }

        private void LoadCustomer(string firstName, string LastName)
        {
            string sqlFullNameValidation = @$"
            SELECT FirstName, LastName
            FROM Customers
            WHERE FirstName = '{txtFirstName.Text}'
            AND LastName = '{txtLastName.Text}'
            ";
            DataTable dtValidCustomer = DataAccess.GetData(sqlFullNameValidation);
            if (dtValidCustomer.Rows.Count == 1)
            {

                string sqlCmbBind = $@"
                SELECT CustomerId, FirstName + ' ' +LastName as FullName
                FROM Customers
                WHERE  FirstName = '{txtFirstName.Text}'
                AND LastName = '{txtLastName.Text}'
                ORDER BY LastName, FirstName
                ";

                DataTable dtCustomer = DataAccess.GetData(sqlCmbBind);
                cmbCustomers.Bind(dtCustomer, "FullName", "CustomerId");
                lblFirstName.Visible = false;
                lblLastname.Visible = false;
                txtLastName.Visible = false;
                txtFirstName.Visible = false;
                btnRetrieveList.Visible = false;
                btnClear.Visible = false;
                NavigationControl(false);
                HideGroupFields(false);
                FieldsAndButtonsHandler(false);
                LoadGames();
            }
            else
            {
                MessageBox.Show($"Can't find customer with a name {txtFirstName.Text} {txtLastName.Text}.");
                txtFirstName.Clear();
                txtLastName.Clear();
            }
        }

        private void btnRetrieveList_Click(object sender, EventArgs e)
        {

            try
            {
                ProgressBar();
                LoadCustomer(txtFirstName.Text, txtLastName.Text);
                LoadGames();
                LoadFirstCustomerRental();
                txtPrice.ReadOnly = true;
                txtRate.ReadOnly = true;
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void LoadFirstCustomerRental()
        {
            DataTable dt = DataAccess.GetData(
                    $@"SELECT TOP 1 r.GameID, r.CustomerId, c.FirstName, c.LastName
                    FROM Rentals r INNER JOIN Customers c 
                    ON r.CustomerId = c.CustomerId
                    WHERE c.FirstName = '{txtFirstName.Text}' AND c.LastName = '{txtLastName.Text}'
                    ORDER BY r.GameID");

            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];

                currentCustomerId = Convert.ToInt32(dr["CustomerId"]);
                currentGameId = Convert.ToInt32(dr["GameId"]);

                firstCustomerId = currentCustomerId;
                firstGameId = currentGameId;

                dtpRent.Enabled = false;
                dtpDue.Enabled = false;
                dtpReturn.Enabled = false;


                LoadRentalDetails();
                NextPreviousButtonManagement();

            }
            else
            {
                MessageBox.Show($"No rentals found for customer {txtFirstName.Text} {txtLastName.Text}. You can make your first rental. Click Add button.");
                btnFirst.Enabled = false;
                btnLast.Enabled = false;
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
                dtpReturn.Visible = false;
            }

        }

        private void LoadRentalDetails()
        {
            errorRentals.Clear();

            string[] sqlStatements = new string[]
            {
                 $@"
                   SELECT r.GameID, r.CustomerId, r.RentalDate, r.DueDate, r.ReturnDate, g.RentalPrice, g.Rate FROM Games g  Inner JOIN Rentals r
				   ON r.GameID = g.GameID INNER JOIN Customers c ON c.CustomerId = r.CustomerId
                   WHERE c.FirstName = '{txtFirstName.Text}'
                    AND c.LastName = '{txtLastName.Text}'
                ",
                $@"
                SELECT 
                (
                 SELECT TOP(1) r.GameId
                 FROM Rentals r
                 INNER JOIN Customers c ON r.CustomerId = c.CustomerId
                 WHERE c.LastName = '{txtLastName.Text}' AND c.FirstName = '{txtFirstName.Text}'
                ) as FirstGameId,
                (
                 SELECT TOP(1) c.CustomerId
                 FROM Rentals r
                 INNER JOIN Customers c ON r.CustomerId = c.CustomerId
                 WHERE c.LastName = '{txtLastName.Text}' AND c.FirstName = '{txtFirstName.Text}'
                ) as FirstCustomerId,
                q.PreviousGameId,
                q.PreviousCustomerId,
                q.NextGameId,
                q.NextCustomerId,
                (
                SELECT TOP(1) r.GameId
                FROM Rentals r
                INNER JOIN Customers c ON r.CustomerId = c.CustomerId
                WHERE c.LastName = '{txtLastName.Text}' AND c.FirstName = '{txtFirstName.Text}'
                ORDER BY r.GameID Desc
                ) as LastGameId,
                (
                SELECT TOP(1) c.CustomerId
                FROM Rentals r
                INNER JOIN Customers c ON r.CustomerId = c.CustomerId
                WHERE c.LastName = '{txtLastName.Text}' AND c.FirstName = '{txtFirstName.Text}'
                ORDER BY r.GameID Desc
                ) as LastCustomerId 
                FROM
                (
                SELECT r.GameId, r.CustomerId,
                LEAD(r.GameId) OVER(ORDER BY r.GameId) AS NextGameId,
                LEAD(r.CustomerId) OVER(ORDER BY r.GameId) AS NextCustomerId,  
                LAG(r.GameId) OVER(ORDER BY r.GameId) AS PreviousGameId,
                LAG(r.CustomerId) OVER(ORDER BY r.GameId) AS PreviousCustomerId,
                ROW_NUMBER() OVER(ORDER BY r.GameId) AS 'RowNumber'
                FROM Rentals r
                INNER JOIN Customers c ON r.CustomerId = c.CustomerId
                WHERE c.LastName = '{txtLastName.Text}' AND c.FirstName = '{txtFirstName.Text}'
                ) AS q 
                WHERE q.GameId = {currentGameId}
                AND q.CustomerId = {currentCustomerId} 
                ORDER BY q.GameId, q.CustomerId;
                 "
            };

            DataSet dsData = DataAccess.GetData(sqlStatements);

            if (dsData.Tables[0].Rows.Count > 0)
            {
                rowsTotal = dsData.Tables[0].Rows.Count - 1;
                DataRow selectedRental = dsData.Tables[0].Rows[rowsCount];
                DataRow navMeta = dsData.Tables[1].Rows[0];


                int customerId = Convert.ToInt32(selectedRental["CustomerId"]);
                int gameId = Convert.ToInt32(selectedRental["GameId"]);

                cmbCustomers.SelectedValue = customerId;
                cmbGames.SelectedValue = gameId;

                double price = Convert.ToDouble(selectedRental["RentalPrice"]);
                txtRate.Text = selectedRental["Rate"].ToString();
                txtPrice.Text = price.ToString("c");
                dtpRent.Text = selectedRental["RentalDate"].ToString();
                dtpDue.Text = selectedRental["DueDate"].ToString();
                if (selectedRental["ReturnDate"] != DBNull.Value)
                {
                    dtpReturn.Visible = true;
                    dtpReturn.Text = selectedRental["ReturnDate"].ToString();

                }
                else
                {
                    dtpReturn.Visible = false;
                }


                firstGameId = Convert.ToInt32(navMeta["FirstGameId"]);
                firstCustomerId = Convert.ToInt32(navMeta["FirstCustomerId"]);


                lastGameId = Convert.ToInt32(navMeta["LastGameId"]);
                lastCustomerId = Convert.ToInt32(navMeta["LastCustomerId"]);

                previousGameId = navMeta["PreviousGameId"] != DBNull.Value ? Convert.ToInt32(navMeta["PreviousGameId"]) : (int?)null;
                previousCustomerId = navMeta["PreviousCustomerId"] != DBNull.Value ? Convert.ToInt32(navMeta["PreviousCustomerId"]) : (int?)null;

                nextGameId = navMeta["NextGameId"] != DBNull.Value ? Convert.ToInt32(navMeta["NextGameId"]) : (int?)null;
                nextCustomerId = navMeta["NextCustomerId"] != DBNull.Value ? Convert.ToInt32(navMeta["NextCustomerId"]) : (int?)null;

                if (currentCustomerId == firstCustomerId && currentGameId == firstGameId)
                {
                    tlsFirst_LastRecord.Text = $"Displaying first customer record in Rental List";

                }
                else if (currentCustomerId == lastCustomerId && currentGameId == lastGameId)
                {
                    tlsFirst_LastRecord.Text = $"Displaying last customer record in Customers List";
                }
                else
                {
                    tlsFirst_LastRecord.Text = string.Empty;
                }

                string message;
                if (selectedRental["ReturnDate"] != DBNull.Value &&
                   Convert.ToDateTime(selectedRental["ReturnDate"].ToString()) < Convert.ToDateTime(dtpDue.Text))
                {
                    ((frmMDIGameRentals)this.MdiParent).StatusStripLabel.ForeColor = System.Drawing.Color.Green;
                    message = $@"{cmbCustomers.Text}  has rented {cmbGames.Text}. Game has been returned.";
                }
                else if (selectedRental["ReturnDate"] == DBNull.Value && DateTime.Now < Convert.ToDateTime(dtpDue.Text))
                {

                    ((frmMDIGameRentals)this.MdiParent).StatusStripLabel.ForeColor = System.Drawing.Color.Yellow;
                    message = $@"{cmbCustomers.Text}  has rented {cmbGames.Text}. No Overdue. Game is not returned";

                }
                else if (selectedRental["ReturnDate"] != DBNull.Value &&
                   Convert.ToDateTime(selectedRental["ReturnDate"].ToString()) > Convert.ToDateTime(dtpDue.Text))
                {
                    ((frmMDIGameRentals)this.MdiParent).StatusStripLabel.ForeColor = System.Drawing.Color.Red;
                    message = $@"{cmbCustomers.Text}  has rented {cmbGames.Text}. Overdue. Penalty {price * 2:c}";
                }

                else
                {
                    ((frmMDIGameRentals)this.MdiParent).StatusStripLabel.ForeColor = System.Drawing.Color.Red;
                    message = $@"{cmbCustomers.Text}  has rented {cmbGames.Text}. Overdue. Penalty {price * 2:c}. Game is not returned";
                }



                if (message.Contains("Penalty"))
                {

                    ((frmMDIGameRentals)this.MdiParent).StatusStripLabel.Text = message;

                }
                else
                {

                    ((frmMDIGameRentals)this.MdiParent).StatusStripLabel.Text = message;
                }

                tlsStatus.Text = $"Displaying rental record {rowsCount + 1} of {rowsTotal + 1}";


            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
        }

        private void NextPreviousButtonManagement()
        {
            btnPrevious.Enabled = previousGameId != null;
            btnNext.Enabled = nextGameId != null;
        }

        /// <summary>
        /// Navigation button handling
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Navigation_Handler(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            switch (b.Name)
            {
                case "btnFirst":
                    currentGameId = firstGameId;
                    currentCustomerId = firstCustomerId;
                    rowsCount = 0;
                    break;

                case "btnLast":
                    currentGameId = lastGameId;
                    currentCustomerId = lastCustomerId;
                    rowsCount = rowsTotal;
                    break;
                case "btnPrevious":
                    currentGameId = previousGameId.Value;
                    currentCustomerId = previousCustomerId.Value;
                    rowsCount--;
                    break;
                case "btnNext":
                    currentGameId = nextGameId.Value;
                    currentCustomerId = nextCustomerId.Value;
                    rowsCount++;
                    break;
            }
            if (isAdmin())
            {
                LoadRentalsDetails();
            }
            else
            {
                LoadRentalDetails();
            }
            NextPreviousButtonManagement();
        }

        private bool isAdmin()
        {
            return this.MdiParent.Text == "Game Rentals - Admin Mode";
        }

        /// <summary>
        /// ComboBox Validating Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            string cmbName = cmb.Tag.ToString();

            string errMsg = null;
            bool failedValidation = false;

            if (cmb.SelectedIndex == -1 || string.IsNullOrEmpty(cmb.SelectedValue.ToString()))
            {
                errMsg = $"{cmbName} is required";
                failedValidation = true;
            }

            e.Cancel = failedValidation;
            errorRentals.SetError(cmb, errMsg);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                tlsStatus.Text = "Add new Rental";
                tlsFirst_LastRecord.Text = string.Empty;
                ((frmMDIGameRentals)this.MdiParent).StatusStripLabel.Text = string.Empty;

                if (isAdmin())
                {
                    UIUtilities.ClearControls(this.Controls);
                    LoadCustomers();
                    LoadGames();

                    NavigationControl(true);


                    btnGetPriceDetails.Visible = true;
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    btnSave.Enabled = true;
                    btnSave.Text = "Create";


                }
                else
                {

                    LoadCustomer(txtFirstName.Text, txtLastName.Text);
                    LoadGames();
                    NavigationControl(true);

                    //Date handlers
                    dtpRent.Text = DateTime.Now.ToString();
                    dtpReturn.Visible = false;
                    lblReturnDate.Visible = false;

                    //Details handler
                    btnGetPriceDetails.Visible = true;

                    //Save handler
                    btnSave.Text = "Create";
                    btnSave.Enabled = true;

                    //CRUD Handler
                    btnAdd.Enabled = false;
                    btnCancel.Enabled = true;

                    txtPrice.ReadOnly = true;
                    txtRate.ReadOnly = true;


                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (isAdmin())
                {
                    if (!btnAdd.Enabled)
                    {
                        if (ValidateChildren(ValidationConstraints.Enabled))
                        {
                            CreateRental();
                        }
                    }
                    else if (RentalExists(currentGameId, currentCustomerId) && btnAdd.Enabled)
                    {
                        UpdateRental();
                    }
                    else
                    {
                        MessageBox.Show("Such combination of CustomerId and UserId not found");
                    }
                }
                else
                {
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                        CreateRental();


                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateRental()
        {
            string sqlUpdate = $@"UPDATE [dbo].[Rentals]
        SET [GameId] = {currentGameId}
        ,[CustomerId] = {currentCustomerId}
        ,[RentalDate] = '{dtpRent.Text}'
        ,[DueDate] = '{dtpDue.Text}'
        ,[ReturnDate] = '{dtpReturn.Text}'
        WHERE GameId = {currentGameId}
        AND  CustomerId = {currentCustomerId}
        ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sqlUpdate);

            if (rowsAffected == 1)
            {
                ProgressBar();
                MessageBox.Show($"Successfully updated record with GameId {currentGameId} and CustomerId {currentCustomerId}");
            }
            else
            {
                MessageBox.Show("Failed to update the record");
            }
        }

        private bool RentalExists(int gameId, int customerId)
        {
            bool result = false;


            string sql = $@"SELECT GameId, CustomerId 
                   FROM Rentals WHERE GameId = {gameId}  
                   AND CustomerId = {customerId}";
            var dtExist = DataAccess.GetData(sql);


            if (dtExist.Rows.Count == 1)
            {
                result = true;

                return result;
            }
            else
            {


                MessageBox.Show("Such combination of GameId and CustomerId doesn't exist");
                return result;

            }
        }

        private void CreateRental()
        {
            int gameId = Convert.ToInt32(cmbGames.SelectedValue);
            int customerId = Convert.ToInt32(cmbCustomers.SelectedValue);

            if (CanAddRental(gameId, customerId))
            {
                string sqlInsert = $"Insert INTO Rentals VALUES({gameId}, {customerId}, '{dtpRent.Text}', '{dtpDue.Text}', NULL)";
                int rowsAffected = DataAccess.ExecuteNonQuery(sqlInsert);

                if (rowsAffected == 1)
                {
                    ProgressBar();
                    MessageBox.Show($" A rental for customer {cmbCustomers.Text}  was created");
                    currentGameId = gameId;
                    currentCustomerId = customerId;
                    rowsCount = 0;
                    if (isAdmin())
                    {
                        LoadFirstRental();
                        NavigationControl(false);
                        NextPreviousButtonManagement();
                        btnDelete.Enabled = true;
                        btnSave.Text = "Save";
                        btnCancel.Enabled = false;

                    }
                    else
                    {
                        LoadFirstCustomerRental();
                        NavigationControl(false);
                        NextPreviousButtonManagement();

                        btnAdd.Enabled = true;
                        btnSave.Text = "Save";

                        btnSave.Enabled = false;
                        btnCancel.Enabled = false;

                        txtPrice.ReadOnly = true;
                        txtRate.ReadOnly = true;


                    }

                }
                else
                {
                    MessageBox.Show("Database error. No record inserted.");
                }
            }
            else
            {
                MessageBox.Show("Creation failed");
            }
        }

        private bool CanAddRental(int gameId, int customerId)
        {
            bool result = false;



            string sqlAge = $"SELECT DateofBirth FROM Customers Where CustomerId = {customerId}";

            var dtAge = DataAccess.GetData(sqlAge);
            double age;

            if (dtAge == null)
            {
                throw new Exception("No customer found");

                return result;
            }
            else
            {
                DateTime dateOfBirth = (DateTime)dtAge.Rows[0]["DateOfBirth"];

                age = GetAge(dateOfBirth);
            }

            if (gameId == Convert.ToInt32(lblHiddenGameId.Text))
            {
                if (age < 18 && txtRate.Text == "M")
                {
                    if (isAdmin())
                    {
                        MessageBox.Show($"{cmbCustomers.Text} can't rent this game with rate 'M'. Because {cmbCustomers.Text} is under 18 years old");

                    }
                    else
                    {
                        MessageBox.Show("You can't rent this game with rate 'M'. Because you are under 18 years old");

                    }

                    return result;
                }

                result = true;

                return result;
            }
            else
            {
                MessageBox.Show("Error occured. Please update the price by clicking Get Details button");



                return result;
            }


        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            if (cmbGames.SelectedIndex == 0)
            {
                txtPrice.Text = string.Empty;
            }
            else
            {
                int gameId = Convert.ToInt32(cmbGames.SelectedValue);

                string sql = $"SELECT GameId, Title, Rate, RentalPrice FROM Games WHERE GameId = {gameId}";




                DataTable dt = DataAccess.GetData(sql);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No game found");
                }
                else
                {
                    dtpDue.Text = DateTime.Now.AddDays(10).ToString();
                    double price = Convert.ToDouble(dt.Rows[0]["RentalPrice"]);
                    lblHiddenGameId.Text = dt.Rows[0]["GameId"].ToString();
                    txtRate.Text = dt.Rows[0]["Rate"].ToString();
                    txtPrice.Text = price.ToString("c");
                    lblRentalPrice.Visible = true;
                    txtPrice.Visible = true;
                    lblRate.Visible = true;
                    txtRate.Visible = true;

                }
            }
        }

        private double GetAge(DateTime dateOfBirth)
        {
            // Calculate age
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - dateOfBirth.Year;

            // Adjust age if the birthday hasn't occurred yet this year
            if (currentDate.Month < dateOfBirth.Month || (currentDate.Month == dateOfBirth.Month && currentDate.Day < dateOfBirth.Day))
            {
                age--;
            }

            return age;
        }

        private double GetPrice(int gameId)
        {
            string sql = $"SELECT Title, RentalPrice FROM Games WHERE GameId = {gameId}";



            DataTable dt = DataAccess.GetData(sql);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No game found");

                return 0;
            }
            else
            {

                double price = Convert.ToDouble(dt.Rows[0]["RentalPrice"]);

                return price;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            try
            {
                if (isAdmin())
                {
                    LoadRentalsDetails();
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;
                    btnSave.Text = "Save";
                    btnGetPriceDetails.Visible = false;
                    NavigationControl(false);
                    NextPreviousButtonManagement();
                }
                else
                {
                    LoadRentalDetails();
                    btnGetPriceDetails.Visible = false;
                    btnAdd.Enabled = true;
                    btnCancel.Enabled = false;
                    NavigationControl(false);
                    NextPreviousButtonManagement();
                    btnSave.Text = "Save";
                    btnSave.Enabled = false;


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                string sqlDelete = $@"
                DELETE 
                FROM Rentals 
                WHERE GameId = {currentGameId}
                AND CustomerId = {currentCustomerId}
                ";

                int rowsAffected = DataAccess.ExecuteNonQuery(sqlDelete);

                if (rowsAffected == 1)
                {
                    ProgressBar();
                    MessageBox.Show("Rental was deleted. Click Ok to load first rental");
                    LoadFirstRental();
                }
                else if (rowsAffected > 1)
                {
                    ProgressBar();
                    MessageBox.Show("Multiple deletions was reported");
                }
                else
                {
                    ProgressBar();
                    MessageBox.Show("No deletion was performed");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

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

        private void Rentals_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (isAdmin())
            {
                ((frmMDIGameRentals)this.MdiParent).StatusStripLabel.Text = "Weldome Admin to Game Rentals";
                ((frmMDIGameRentals)this.MdiParent).StatusStripLabel.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                ((frmMDIGameRentals)this.MdiParent).StatusStripLabel.Text = "Weldome to Game Rentals";
                ((frmMDIGameRentals)this.MdiParent).StatusStripLabel.ForeColor = System.Drawing.Color.Black;
            }
           
        }
    }
}
