namespace Game_Rentals
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            grbUsers = new GroupBox();
            dtpDateOfBirth = new DateTimePicker();
            label6 = new Label();
            lblDateOfBirth = new Label();
            lblAge = new Label();
            lblCustomerId = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMiddleName = new TextBox();
            txtAge = new TextBox();
            txtCustomerId = new TextBox();
            txtFirstName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            lblHeader = new Label();
            errProviderCustomers = new ErrorProvider(components);
            statusStrip1 = new StatusStrip();
            tlsStatus = new ToolStripStatusLabel();
            prbProgress = new ToolStripProgressBar();
            tlsFirst_LastRecord = new ToolStripStatusLabel();
            btnNext = new Button();
            btnLast = new Button();
            btnPrevious = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            btnFirst = new Button();
            grbUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProviderCustomers).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grbUsers
            // 
            grbUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grbUsers.BackColor = Color.Transparent;
            grbUsers.BackgroundImageLayout = ImageLayout.Center;
            grbUsers.Controls.Add(dtpDateOfBirth);
            grbUsers.Controls.Add(label6);
            grbUsers.Controls.Add(lblDateOfBirth);
            grbUsers.Controls.Add(lblAge);
            grbUsers.Controls.Add(lblCustomerId);
            grbUsers.Controls.Add(label4);
            grbUsers.Controls.Add(label3);
            grbUsers.Controls.Add(label2);
            grbUsers.Controls.Add(label1);
            grbUsers.Controls.Add(txtMiddleName);
            grbUsers.Controls.Add(txtAge);
            grbUsers.Controls.Add(txtCustomerId);
            grbUsers.Controls.Add(txtFirstName);
            grbUsers.Controls.Add(txtPhone);
            grbUsers.Controls.Add(txtEmail);
            grbUsers.Controls.Add(txtLastName);
            grbUsers.Controls.Add(lblHeader);
            grbUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grbUsers.ForeColor = Color.Black;
            grbUsers.Location = new Point(163, 26);
            grbUsers.Name = "grbUsers";
            grbUsers.Size = new Size(826, 474);
            grbUsers.TabIndex = 12;
            grbUsers.TabStop = false;
            grbUsers.Text = "List of Customers";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(262, 295);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(200, 29);
            dtpDateOfBirth.TabIndex = 38;
            dtpDateOfBirth.Tag = "Date of Birth";
            dtpDateOfBirth.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(198, 210);
            label6.Name = "label6";
            label6.Size = new Size(114, 21);
            label6.TabIndex = 32;
            label6.Text = "Middle Name";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.ForeColor = Color.White;
            lblDateOfBirth.Location = new Point(262, 270);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(101, 21);
            lblDateOfBirth.TabIndex = 33;
            lblDateOfBirth.Text = "DateOfBirth";
            lblDateOfBirth.Visible = false;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.ForeColor = Color.White;
            lblAge.Location = new Point(203, 270);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(40, 21);
            lblAge.TabIndex = 33;
            lblAge.Text = "Age";
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Font = new Font("Roboto Slab", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomerId.Location = new Point(198, 36);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(114, 21);
            lblCustomerId.TabIndex = 34;
            lblCustomerId.Text = "Customer Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 90);
            label4.Name = "label4";
            label4.Size = new Size(92, 21);
            label4.TabIndex = 34;
            label4.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(203, 389);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 35;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(203, 330);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 36;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 150);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 37;
            label1.Text = "Last Name";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(198, 236);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(443, 29);
            txtMiddleName.TabIndex = 26;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(203, 295);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(51, 29);
            txtAge.TabIndex = 27;
            txtAge.MouseClick += txtAge_MouseClick;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtCustomerId.Location = new Point(198, 60);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.ReadOnly = true;
            txtCustomerId.Size = new Size(56, 25);
            txtCustomerId.TabIndex = 28;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(198, 116);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(443, 29);
            txtFirstName.TabIndex = 28;
            txtFirstName.Tag = "First Name";
            txtFirstName.Validating += txt_Validating;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(203, 415);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(443, 29);
            txtPhone.TabIndex = 29;
            txtPhone.Tag = "Phone";
            txtPhone.Validating += txt_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(203, 355);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(443, 29);
            txtEmail.TabIndex = 30;
            txtEmail.Tag = "Email";
            txtEmail.Validating += txt_Validating;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(198, 176);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(443, 29);
            txtLastName.TabIndex = 31;
            txtLastName.Tag = "Last Name";
            txtLastName.Validating += txt_Validating;
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(358, 50);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(154, 32);
            lblHeader.TabIndex = 25;
            // 
            // errProviderCustomers
            // 
            errProviderCustomers.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errProviderCustomers.ContainerControl = this;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tlsStatus, prbProgress, tlsFirst_LastRecord });
            statusStrip1.Location = new Point(0, 812);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1366, 22);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // tlsStatus
            // 
            tlsStatus.Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tlsStatus.Name = "tlsStatus";
            tlsStatus.Size = new Size(113, 17);
            tlsStatus.Text = "toolStripStatusLabel1";
            // 
            // prbProgress
            // 
            prbProgress.Name = "prbProgress";
            prbProgress.Size = new Size(100, 16);
            // 
            // tlsFirst_LastRecord
            // 
            tlsFirst_LastRecord.Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tlsFirst_LastRecord.Name = "tlsFirst_LastRecord";
            tlsFirst_LastRecord.Size = new Size(113, 17);
            tlsFirst_LastRecord.Text = "toolStripStatusLabel2";
            // 
            // btnNext
            // 
            btnNext.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNext.BackColor = Color.Black;
            btnNext.BackgroundImageLayout = ImageLayout.Center;
            btnNext.Font = new Font("Roboto Slab", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = SystemColors.ControlLight;
            btnNext.Image = Properties.Resources.nextButton2;
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(619, 521);
            btnNext.Margin = new Padding(5, 4, 5, 4);
            btnNext.Name = "btnNext";
            btnNext.Padding = new Padding(0, 0, 6, 0);
            btnNext.Size = new Size(123, 61);
            btnNext.TabIndex = 14;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += Navigation_Handler;
            // 
            // btnLast
            // 
            btnLast.BackColor = Color.Black;
            btnLast.Font = new Font("Roboto Slab", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLast.ForeColor = Color.White;
            btnLast.Image = Properties.Resources.lastIcon;
            btnLast.ImageAlign = ContentAlignment.MiddleRight;
            btnLast.Location = new Point(770, 521);
            btnLast.Margin = new Padding(5, 4, 5, 4);
            btnLast.Name = "btnLast";
            btnLast.Padding = new Padding(0, 0, 6, 0);
            btnLast.Size = new Size(123, 61);
            btnLast.TabIndex = 15;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += Navigation_Handler;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Black;
            btnPrevious.Font = new Font("Roboto Slab", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.Image = Properties.Resources.previousButton;
            btnPrevious.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrevious.Location = new Point(473, 521);
            btnPrevious.Margin = new Padding(5, 4, 5, 4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Padding = new Padding(0, 0, 10, 0);
            btnPrevious.Size = new Size(123, 61);
            btnPrevious.TabIndex = 16;
            btnPrevious.Text = "Previous";
            btnPrevious.TextAlign = ContentAlignment.MiddleRight;
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += Navigation_Handler;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DeepPink;
            btnDelete.Font = new Font("Roboto Slab", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Image = Properties.Resources.Delete;
            btnDelete.ImageAlign = ContentAlignment.TopCenter;
            btnDelete.Location = new Point(459, 639);
            btnDelete.Margin = new Padding(5, 4, 5, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 75);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.HotPink;
            btnCancel.Enabled = false;
            btnCancel.Font = new Font("Roboto Slab", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Image = Properties.Resources.Cancel;
            btnCancel.ImageAlign = ContentAlignment.TopCenter;
            btnCancel.Location = new Point(770, 639);
            btnCancel.Margin = new Padding(5, 4, 5, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 4, 0, 0);
            btnCancel.Size = new Size(137, 75);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.BottomCenter;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.Font = new Font("Roboto Slab", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Image = Properties.Resources.saveIcon;
            btnSave.ImageAlign = ContentAlignment.TopCenter;
            btnSave.Location = new Point(619, 639);
            btnSave.Margin = new Padding(5, 4, 5, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 75);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.BottomCenter;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Chartreuse;
            btnAdd.Font = new Font("Roboto Slab", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Image = Properties.Resources.AddIcon;
            btnAdd.ImageAlign = ContentAlignment.TopCenter;
            btnAdd.Location = new Point(302, 639);
            btnAdd.Margin = new Padding(5, 4, 5, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 75);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.BottomCenter;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.Black;
            btnFirst.Font = new Font("Roboto Slab", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirst.ForeColor = Color.White;
            btnFirst.Image = Properties.Resources.firstIcon;
            btnFirst.ImageAlign = ContentAlignment.MiddleLeft;
            btnFirst.Location = new Point(330, 521);
            btnFirst.Margin = new Padding(5, 4, 5, 4);
            btnFirst.Name = "btnFirst";
            btnFirst.Padding = new Padding(6, 0, 0, 0);
            btnFirst.Size = new Size(123, 61);
            btnFirst.TabIndex = 21;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += Navigation_Handler;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = Properties.Resources.CustomersBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1366, 834);
            Controls.Add(btnNext);
            Controls.Add(btnLast);
            Controls.Add(btnPrevious);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(btnFirst);
            Controls.Add(statusStrip1);
            Controls.Add(grbUsers);
            Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Users";
            Text = "Users";
            FormClosing += Customers_FormClosing;
            Load += Users_Load;
            grbUsers.ResumeLayout(false);
            grbUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProviderCustomers).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox grbUsers;
        private Label label6;
        private Label lblAge;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMiddleName;
        private TextBox txtAge;
        private TextBox txtFirstName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private Label lblHeader;
        private ErrorProvider errProviderCustomers;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tlsStatus;
        private ToolStripProgressBar prbProgress;
        private ToolStripStatusLabel tlsFirst_LastRecord;
        private Label lblCustomerId;
        private TextBox txtCustomerId;
        private DateTimePicker dtpDateOfBirth;
        private Label lblDateOfBirth;
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