namespace Game_Rentals
{
    partial class Rentals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rentals));
            grpbRentalLIst = new GroupBox();
            lblNotReturned = new Label();
            lblHiddenGameId = new Label();
            btnGetPriceDetails = new Button();
            dtpReturn = new DateTimePicker();
            dtpDue = new DateTimePicker();
            dtpRent = new DateTimePicker();
            txtRate = new TextBox();
            txtPrice = new TextBox();
            cmbGames = new ComboBox();
            cmbCustomers = new ComboBox();
            lblReturnDate = new Label();
            lblDueDate = new Label();
            lblRate = new Label();
            lblRentDate = new Label();
            lblRentalPrice = new Label();
            lblTitle = new Label();
            lblCustomerName = new Label();
            errorRentals = new ErrorProvider(components);
            statusStrip1 = new StatusStrip();
            tlsStatus = new ToolStripStatusLabel();
            prbProgress = new ToolStripProgressBar();
            tlsFirst_LastRecord = new ToolStripStatusLabel();
            btnClear = new Button();
            btnRetrieveList = new Button();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblLastname = new Label();
            lblFirstName = new Label();
            btnNext = new Button();
            btnLast = new Button();
            btnPrevious = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            btnFirst = new Button();
            grpbRentalLIst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorRentals).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grpbRentalLIst
            // 
            grpbRentalLIst.AutoSize = true;
            grpbRentalLIst.BackColor = Color.Transparent;
            grpbRentalLIst.Controls.Add(lblNotReturned);
            grpbRentalLIst.Controls.Add(lblHiddenGameId);
            grpbRentalLIst.Controls.Add(btnGetPriceDetails);
            grpbRentalLIst.Controls.Add(dtpReturn);
            grpbRentalLIst.Controls.Add(dtpDue);
            grpbRentalLIst.Controls.Add(dtpRent);
            grpbRentalLIst.Controls.Add(txtRate);
            grpbRentalLIst.Controls.Add(txtPrice);
            grpbRentalLIst.Controls.Add(cmbGames);
            grpbRentalLIst.Controls.Add(cmbCustomers);
            grpbRentalLIst.Controls.Add(lblReturnDate);
            grpbRentalLIst.Controls.Add(lblDueDate);
            grpbRentalLIst.Controls.Add(lblRate);
            grpbRentalLIst.Controls.Add(lblRentDate);
            grpbRentalLIst.Controls.Add(lblRentalPrice);
            grpbRentalLIst.Controls.Add(lblTitle);
            grpbRentalLIst.Controls.Add(lblCustomerName);
            grpbRentalLIst.Font = new Font("Roboto Slab", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grpbRentalLIst.ForeColor = Color.White;
            grpbRentalLIst.Location = new Point(48, 22);
            grpbRentalLIst.Name = "grpbRentalLIst";
            grpbRentalLIst.Size = new Size(678, 272);
            grpbRentalLIst.TabIndex = 0;
            grpbRentalLIst.TabStop = false;
            grpbRentalLIst.Text = "Game Rental List";
            // 
            // lblNotReturned
            // 
            lblNotReturned.AutoSize = true;
            lblNotReturned.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotReturned.ForeColor = Color.DeepPink;
            lblNotReturned.Location = new Point(526, 228);
            lblNotReturned.Name = "lblNotReturned";
            lblNotReturned.Size = new Size(110, 19);
            lblNotReturned.TabIndex = 18;
            lblNotReturned.Text = "Is not Returned";
            lblNotReturned.Visible = false;
            // 
            // lblHiddenGameId
            // 
            lblHiddenGameId.AutoSize = true;
            lblHiddenGameId.Location = new Point(384, 82);
            lblHiddenGameId.Name = "lblHiddenGameId";
            lblHiddenGameId.Size = new Size(17, 19);
            lblHiddenGameId.TabIndex = 17;
            lblHiddenGameId.Text = "0";
            lblHiddenGameId.Visible = false;
            // 
            // btnGetPriceDetails
            // 
            btnGetPriceDetails.BackColor = Color.RoyalBlue;
            btnGetPriceDetails.ForeColor = Color.White;
            btnGetPriceDetails.Location = new Point(231, 78);
            btnGetPriceDetails.Name = "btnGetPriceDetails";
            btnGetPriceDetails.Size = new Size(103, 27);
            btnGetPriceDetails.TabIndex = 16;
            btnGetPriceDetails.Text = "Get Details";
            btnGetPriceDetails.UseVisualStyleBackColor = false;
            btnGetPriceDetails.Visible = false;
            btnGetPriceDetails.Click += btnGetDetails_Click;
            // 
            // dtpReturn
            // 
            dtpReturn.Location = new Point(213, 223);
            dtpReturn.Name = "dtpReturn";
            dtpReturn.Size = new Size(200, 25);
            dtpReturn.TabIndex = 3;
            // 
            // dtpDue
            // 
            dtpDue.Enabled = false;
            dtpDue.Location = new Point(213, 197);
            dtpDue.Name = "dtpDue";
            dtpDue.Size = new Size(200, 25);
            dtpDue.TabIndex = 3;
            // 
            // dtpRent
            // 
            dtpRent.Enabled = false;
            dtpRent.ImeMode = ImeMode.NoControl;
            dtpRent.Location = new Point(213, 171);
            dtpRent.Name = "dtpRent";
            dtpRent.Size = new Size(200, 25);
            dtpRent.TabIndex = 3;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(213, 142);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(27, 25);
            txtRate.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(213, 111);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(175, 25);
            txtPrice.TabIndex = 2;
            // 
            // cmbGames
            // 
            cmbGames.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGames.FormattingEnabled = true;
            cmbGames.Location = new Point(213, 46);
            cmbGames.Name = "cmbGames";
            cmbGames.Size = new Size(175, 26);
            cmbGames.TabIndex = 1;
            cmbGames.Tag = "GameTitle";
            cmbGames.Validating += cmb_Validating;
            // 
            // cmbCustomers
            // 
            cmbCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomers.FormattingEnabled = true;
            cmbCustomers.Location = new Point(213, 16);
            cmbCustomers.Name = "cmbCustomers";
            cmbCustomers.Size = new Size(175, 26);
            cmbCustomers.TabIndex = 1;
            cmbCustomers.Tag = "CustomerName";
            cmbCustomers.Validating += cmb_Validating;
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(84, 228);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(89, 19);
            lblReturnDate.TabIndex = 0;
            lblReturnDate.Text = "Return Date";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(84, 199);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(70, 19);
            lblDueDate.TabIndex = 0;
            lblDueDate.Text = "Due Date";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(84, 148);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(39, 19);
            lblRate.TabIndex = 0;
            lblRate.Text = "Rate";
            // 
            // lblRentDate
            // 
            lblRentDate.AutoSize = true;
            lblRentDate.Location = new Point(84, 177);
            lblRentDate.Name = "lblRentDate";
            lblRentDate.Size = new Size(74, 19);
            lblRentDate.TabIndex = 0;
            lblRentDate.Text = "Rent Date";
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.Location = new Point(84, 119);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.Size = new Size(94, 19);
            lblRentalPrice.TabIndex = 0;
            lblRentalPrice.Text = "Rental Price:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(91, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(87, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Game  Title:";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(87, 19);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(120, 19);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Customer Name:";
            // 
            // errorRentals
            // 
            errorRentals.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorRentals.ContainerControl = this;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tlsStatus, prbProgress, tlsFirst_LastRecord });
            statusStrip1.Location = new Point(0, 560);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1005, 23);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tlsStatus
            // 
            tlsStatus.Name = "tlsStatus";
            tlsStatus.Size = new Size(0, 18);
            // 
            // prbProgress
            // 
            prbProgress.Name = "prbProgress";
            prbProgress.Size = new Size(100, 17);
            // 
            // tlsFirst_LastRecord
            // 
            tlsFirst_LastRecord.Name = "tlsFirst_LastRecord";
            tlsFirst_LastRecord.Size = new Size(0, 18);
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightSteelBlue;
            btnClear.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(451, 319);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 22);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnRetrieveList
            // 
            btnRetrieveList.BackColor = Color.LightSteelBlue;
            btnRetrieveList.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetrieveList.Location = new Point(307, 319);
            btnRetrieveList.Name = "btnRetrieveList";
            btnRetrieveList.Size = new Size(75, 22);
            btnRetrieveList.TabIndex = 17;
            btnRetrieveList.Text = "Retrieve";
            btnRetrieveList.UseVisualStyleBackColor = false;
            btnRetrieveList.Click += btnRetrieveList_Click;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(540, 295);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(166, 23);
            txtLastName.TabIndex = 14;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(249, 295);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(166, 23);
            txtFirstName.TabIndex = 15;
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.BackColor = Color.Transparent;
            lblLastname.Font = new Font("Roboto Slab", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastname.ForeColor = Color.White;
            lblLastname.Location = new Point(451, 297);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(83, 19);
            lblLastname.TabIndex = 12;
            lblLastname.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Roboto Slab", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(139, 299);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(87, 19);
            lblFirstName.TabIndex = 13;
            lblFirstName.Text = "First Name:";
            // 
            // btnNext
            // 
            btnNext.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNext.BackColor = Color.Black;
            btnNext.BackgroundImageLayout = ImageLayout.Center;
            btnNext.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = SystemColors.ControlLight;
            btnNext.Image = Properties.Resources.nextButton2;
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(467, 351);
            btnNext.Margin = new Padding(5, 4, 5, 4);
            btnNext.Name = "btnNext";
            btnNext.Padding = new Padding(0, 0, 6, 0);
            btnNext.Size = new Size(123, 61);
            btnNext.TabIndex = 22;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += Navigation_Handler;
            // 
            // btnLast
            // 
            btnLast.BackColor = Color.Black;
            btnLast.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLast.ForeColor = Color.White;
            btnLast.Image = Properties.Resources.lastIcon;
            btnLast.ImageAlign = ContentAlignment.MiddleRight;
            btnLast.Location = new Point(618, 351);
            btnLast.Margin = new Padding(5, 4, 5, 4);
            btnLast.Name = "btnLast";
            btnLast.Padding = new Padding(0, 0, 6, 0);
            btnLast.Size = new Size(123, 61);
            btnLast.TabIndex = 23;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += Navigation_Handler;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Black;
            btnPrevious.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.Image = Properties.Resources.previousButton;
            btnPrevious.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrevious.Location = new Point(321, 351);
            btnPrevious.Margin = new Padding(5, 4, 5, 4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Padding = new Padding(0, 0, 10, 0);
            btnPrevious.Size = new Size(123, 61);
            btnPrevious.TabIndex = 24;
            btnPrevious.Text = "Previous";
            btnPrevious.TextAlign = ContentAlignment.MiddleRight;
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += Navigation_Handler;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DeepPink;
            btnDelete.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Image = Properties.Resources.Delete;
            btnDelete.ImageAlign = ContentAlignment.TopCenter;
            btnDelete.Location = new Point(307, 469);
            btnDelete.Margin = new Padding(5, 4, 5, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 75);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.HotPink;
            btnCancel.Enabled = false;
            btnCancel.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Image = Properties.Resources.Cancel;
            btnCancel.ImageAlign = ContentAlignment.TopCenter;
            btnCancel.Location = new Point(618, 469);
            btnCancel.Margin = new Padding(5, 4, 5, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 4, 0, 0);
            btnCancel.Size = new Size(137, 75);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.BottomCenter;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Image = Properties.Resources.saveIcon;
            btnSave.ImageAlign = ContentAlignment.TopCenter;
            btnSave.Location = new Point(467, 469);
            btnSave.Margin = new Padding(5, 4, 5, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 75);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.BottomCenter;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Chartreuse;
            btnAdd.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Image = Properties.Resources.AddIcon;
            btnAdd.ImageAlign = ContentAlignment.TopCenter;
            btnAdd.Location = new Point(150, 469);
            btnAdd.Margin = new Padding(5, 4, 5, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 75);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.BottomCenter;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.Black;
            btnFirst.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirst.ForeColor = Color.White;
            btnFirst.Image = Properties.Resources.firstIcon;
            btnFirst.ImageAlign = ContentAlignment.MiddleLeft;
            btnFirst.Location = new Point(178, 351);
            btnFirst.Margin = new Padding(5, 4, 5, 4);
            btnFirst.Name = "btnFirst";
            btnFirst.Padding = new Padding(6, 0, 0, 0);
            btnFirst.Size = new Size(123, 61);
            btnFirst.TabIndex = 29;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += Navigation_Handler;
            // 
            // Rentals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = Properties.Resources.rentalsBgjpg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1005, 583);
            Controls.Add(btnNext);
            Controls.Add(btnLast);
            Controls.Add(btnPrevious);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(btnFirst);
            Controls.Add(btnClear);
            Controls.Add(btnRetrieveList);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastname);
            Controls.Add(lblFirstName);
            Controls.Add(statusStrip1);
            Controls.Add(grpbRentalLIst);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Rentals";
            Tag = "rentals";
            Text = "Rentals";
            FormClosing += Rentals_FormClosing;
            Load += Rentals_Load;
            grpbRentalLIst.ResumeLayout(false);
            grpbRentalLIst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorRentals).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpbRentalLIst;
        private ErrorProvider errorRentals;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tlsStatus;
        private ToolStripProgressBar prbProgress;
        private ToolStripStatusLabel tlsFirst_LastRecord;
        private DateTimePicker dtpRent;
        private TextBox txtPrice;
        private ComboBox cmbGames;
        private ComboBox cmbCustomers;
        private Label lblCustomerName;
        private DateTimePicker dtpReturn;
        private DateTimePicker dtpDue;
        private Label lblReturnDate;
        private Label lblDueDate;
        private Label lblRentDate;
        private Label lblRentalPrice;
        private Label lblTitle;
        private Button btnClear;
        private Button btnRetrieveList;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblLastname;
        private Label lblFirstName;
        private Button btnGetPriceDetails;
        private TextBox txtRate;
        private Label lblRate;
        private Label lblHiddenGameId;
        private Label lblNotReturned;
        private Button btnNext;
        private Button btnLast;
        private Button btnPrevious;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnSave;
        private Button btnAdd;
        private Button btnFirst;
    }
}