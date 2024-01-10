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
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
        }
        int currentGameRecord = 0;
        int currentGameId = 0;
        int firstGameId = 0;
        int lastGameId = 0;
        int? previousGameId;
        int? nextGameId;


        #region[Form Events]
        private void Games_Load(object sender, EventArgs e)
        {

            try
            {
                if (this.MdiParent.Text == "Game Rentals - Admin Mode")
                {
                    FieldsHandler(false);
                    LoadFirstGame();
                    ProgressBar();
                    this.Text = "Games (Admin Mode)";
                }
                else
                {
                    FieldsHandler(true);
                    LoadFirstGame();
                    ProgressBar();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void LoadFirstGame()
        {

            try
            {
                object gameId = DataAccess.GetValue("SELECT TOP (1) GameId FROM Games ORDER BY Title");

                if (gameId == null)
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

                    currentGameId = Convert.ToInt32(gameId);
                    firstGameId = currentGameId;

                }

                NavigationState(true);

                firstGameId = Convert.ToInt32(gameId);
                currentGameRecord = firstGameId;
                LoadGameDetails();
                NextPreviousButtonManagement();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void NextPreviousButtonManagement()
        {
            btnPrevious.Enabled = previousGameId != null;
            btnNext.Enabled = nextGameId != null;
        }

        private void LoadGameDetails()
        {
            errProviderGames.Clear();

            string[] sqlStatement = new string[]
            {
               $"SELECT * FROM Games WHERE GameId = {currentGameId}",
               $@"
                SELECT 
                (
                    SELECT TOP(1) GameId as FirstGameId FROM Games ORDER BY Title
                ) as FirstGameId,
                q.PreviousGameId,
                q.NextGameId,
                (
                    SELECT TOP(1) GameId as LastGameId FROM Games ORDER BY Title Desc
                ) as LastGameId,
                q.RowNumber
                 FROM
                (
                    SELECT GameId, Title,
                    LEAD(GameId) OVER(ORDER BY Title) AS NextGameId,
                    LAG(GameId) OVER(ORDER BY Title) AS PreviousGameId,
                    ROW_NUMBER() OVER(ORDER BY Title) AS RowNumber
                    FROM Games
                ) AS q
                WHERE q.GameId = {currentGameId}
                ORDER BY q.Title".Replace(System.Environment.NewLine," "),
               $"SELECT COUNT(GameId) as GameCount FROM Games"
            };


            try
            {
                DataSet ds = new();

                ds = DataAccess.GetData(sqlStatement);

                if (Convert.ToInt32(ds.Tables[2].Rows[0]["GameCount"]) == 0)
                {
                    MessageBox.Show("No games in the system");
                    btnAdd_Click(null, null);
                    return;
                }

                DataRow selectedGame = ds.Tables[0].Rows[0];

                txtGameId.Text = selectedGame["GameId"].ToString();
                txtTitle.Text = selectedGame["Title"].ToString();
                txtGenre.Text = selectedGame["Genre"].ToString();
                DateTime releaseDateTime = (DateTime)selectedGame["ReleaseDate"];
                string formattedDate = releaseDateTime.ToString("yyyy-MM-dd");
                dtpReleaseDate.Text = formattedDate;
                double rentalPrice = Convert.ToDouble(selectedGame["RentalPrice"]);
                txtRentalPrice.Text = rentalPrice.ToString("c");
                txtRate.Text = selectedGame["Rate"].ToString();
                rtxtDescription.Text = selectedGame["Description"].ToString();

                firstGameId = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstGameId"]);
                previousGameId = ds.Tables[1].Rows[0]["PreviousGameId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousGameId"]) : (int?)null;
                nextGameId = ds.Tables[1].Rows[0]["NextGameId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextGameId"]) : (int?)null;
                lastGameId = Convert.ToInt32(ds.Tables[1].Rows[0]["LastGameId"]);
                currentGameRecord = Convert.ToInt32(ds.Tables[1].Rows[0]["RowNumber"]);
                if (currentGameId == firstGameId)
                {
                    tlsFirst_LastRecord.Text = $"Displaying first game in Games Catalogue";

                }
                else if (currentGameId == lastGameId)
                {
                    tlsFirst_LastRecord.Text = $"Displaying last game in Games Catalogue";
                }
                else
                {
                    tlsFirst_LastRecord.Text = string.Empty;
                }

                tlsStatus.Text = $"Displaying game {currentGameRecord} of {ds.Tables[2].Rows[0]["GameCount"]}";
                NextPreviousButtonManagement();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

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
        private void FieldsHandler(bool enable)
        {

            btnAdd.Visible = !enable;
            btnCancel.Visible = !enable;
            btnDelete.Visible = !enable;
            btnSave.Visible = !enable;
            txtTitle.ReadOnly = enable;
            txtGenre.ReadOnly = enable;
            txtRentalPrice.ReadOnly = enable;
            dtpReleaseDate.Enabled = !enable;
            rtxtDescription.ReadOnly = enable;
            txtRate.ReadOnly = enable;
            txtGameId.Visible = !enable;
            lblGameId.Visible = !enable;
        }

        /// <summary>
        /// Handle navigation button interaction
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
                    break;
                case "btnLast":
                    currentGameId = lastGameId;
                    break;
                case "btnPrevious":
                    currentGameId = previousGameId.Value;
                    break;
                case "btnNext":
                    currentGameId = nextGameId.Value;

                    break;
            }

            LoadGameDetails();
        }


        #endregion

        #region [Forms Helpers]

        /// <summary>
        /// Animate the progress bar
        /// This is ui thread blocking. Ok for this application.
        /// </summary>
        private void ProgressBar()
        {
            this.tlsStatus.Text = "Processing...";
            prbLoading.Value = 0;
            this.statusStrip1.Refresh();

            while (prbLoading.Value < prbLoading.Maximum)
            {
                Thread.Sleep(15);
                prbLoading.Value += 1;
            }

            prbLoading.Value = 100;

            this.tlsStatus.Text = "Processed";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tlsStatus.Text = "Add new game";
            tlsFirst_LastRecord.Text = string.Empty;
            UIUtilities.ClearControls(this.grbGamesCatalogue.Controls);

            btnSave.Text = "Create";
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;

            NavigationState(false);
        }

        private void Games_FormClosing(object sender, FormClosingEventArgs e)
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

            if (txt.Text == string.Empty && txt.Name != "txtDescription")
            {
                errMsg = $"{txtBoxName} is required";
                failedValidation = true;
            }

            if (txt.Name == "txtRentalPrice")
            {
                string price = txt.Text;

                
                if (price == string.Empty)
                {
                    errMsg = $"{lblRentalPrice.Text} is required";
                    failedValidation = true;
                }
                
                else if (price.Contains('$'))
                {
                   price = txt.Text.Replace('$', ' ');
                   price.Trim();
                    if (IsNumeric(price))
                    {
                        failedValidation = false;
                        txt.Text = price;
                    }
                    else
                    {
                        errMsg = $"{lblRentalPrice.Text} value must be numeric";
                        failedValidation = true;
                    }

                }
                else if (!IsNumeric(price))
                {
                    errMsg = $"{lblRentalPrice.Text} value must be numeric";
                    failedValidation = true;
                }



            }
            e.Cancel = failedValidation;

            errProviderGames.SetError(txt, errMsg);
        }

        /// <summary>
        /// Numeric validation 
        /// </summary>
        /// <param name="value">The value to validate</param>
        /// <returns>The result of the validation</returns>
        private bool IsNumeric(string value)
        {
            return Double.TryParse(value, out double a);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (txtGameId.Text == string.Empty)
                    {
                        CreateGame();
                    }
                    else
                    {
                        UpdateGame();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateGame()
        {
            string sql = $@"
       UPDATE [dbo].[Games]
       SET [Title] = '{txtTitle.Text}'
      ,[RentalPrice] = {txtRentalPrice.Text}
      ,[Genre] = '{txtGenre.Text}'
      ,[ReleaseDate] = '{dtpReleaseDate.Text}'
      ,[Description] = '{rtxtDescription.Text}'
      ,[Rate] = '{txtRate.Text}'
       WHERE GameId = {txtGameId.Text.Trim()}
            ";
            int rowsAffected = DataAccess.ExecuteNonQuery(sql);

            ProgressBar();

            if (rowsAffected == 1)
            {
                MessageBox.Show($"GameId: {txtGameId.Text} changes saved");
            }
            else
            {
                if (rowsAffected == 0)
                {
                    MessageBox.Show($"Update to GameId: {txtGameId.Text} was not updated.");

                }
                else
                {
                    MessageBox.Show("Oh oh Did you forget the WHERE clause");
                }
            }


        }

        private void CreateGame()
        {
            string sqlInsertGame = $@"
                INSERT INTO Games (Title, RentalPrice, Genre, ReleaseDate, Description, Rate)
                VALUES('{txtTitle.Text.Trim()}',{txtRentalPrice.Text.Trim()},'{txtGenre.Text.Trim()}', 
                '{dtpReleaseDate.Text.Trim()}', '{rtxtDescription.Text.Trim()}', '{txtRate.Text.Trim()}')
            ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sqlInsertGame);

            ProgressBar();

            if (rowsAffected == 1)
            {

                MessageBox.Show("Game was created");
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
                btnSave.Text = "Save";
                btnCancel_Click(null, null);
                NavigationState(true);
                LoadFirstGame();
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

            NavigationState(true);
            LoadGameDetails();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteGame();
        }

        private void DeleteGame()
        {
            string sql = $@"
            DELETE FROM [dbo].[Games] 
            WHERE GameId = {txtGameId.Text}
            ";
            int rowsAffected = DataAccess.ExecuteNonQuery(sql);

            ProgressBar();

            if (rowsAffected == 1)
            {
                MessageBox.Show($"GameId: {txtGameId.Text} was deleted");
                LoadFirstGame();
            }
            else if (rowsAffected == 0)
            {
                MessageBox.Show($"GameId: {txtGameId.Text} does not exist. May already have been deleted");
            }
            else
            {
                MessageBox.Show("Oh oh Did you forget the WHERE clause");
            }

        }
    }
}
