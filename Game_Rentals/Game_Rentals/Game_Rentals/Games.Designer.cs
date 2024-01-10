namespace Game_Rentals
{
    partial class Games
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Games));
            txtTitle = new TextBox();
            label1 = new Label();
            txtGenre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtRentalPrice = new TextBox();
            lblRentalPrice = new Label();
            label5 = new Label();
            txtRate = new TextBox();
            label6 = new Label();
            btnFirst = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnAdd = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            errProviderGames = new ErrorProvider(components);
            statusStrip1 = new StatusStrip();
            tlsStatus = new ToolStripStatusLabel();
            prbLoading = new ToolStripProgressBar();
            tlsFirst_LastRecord = new ToolStripStatusLabel();
            txtGameId = new TextBox();
            lblGameId = new Label();
            grbGamesCatalogue = new GroupBox();
            dtpReleaseDate = new DateTimePicker();
            rtxtDescription = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)errProviderGames).BeginInit();
            statusStrip1.SuspendLayout();
            grbGamesCatalogue.SuspendLayout();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(183, 119);
            txtTitle.Margin = new Padding(5, 4, 5, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(251, 29);
            txtTitle.TabIndex = 1;
            txtTitle.Tag = "Title";
            txtTitle.Validating += txt_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 94);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(183, 189);
            txtGenre.Margin = new Padding(5, 4, 5, 4);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(251, 29);
            txtGenre.TabIndex = 1;
            txtGenre.Tag = "Genre";
            txtGenre.Validating += txt_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 164);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 2;
            label2.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 253);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 21);
            label3.TabIndex = 2;
            label3.Text = "Release Date";
            // 
            // txtRentalPrice
            // 
            txtRentalPrice.Location = new Point(753, 52);
            txtRentalPrice.Margin = new Padding(5, 4, 5, 4);
            txtRentalPrice.Name = "txtRentalPrice";
            txtRentalPrice.Size = new Size(251, 29);
            txtRentalPrice.TabIndex = 1;
            txtRentalPrice.Tag = "Rental Price";
            txtRentalPrice.Validating += txt_Validating;
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.Location = new Point(753, 27);
            lblRentalPrice.Margin = new Padding(5, 0, 5, 0);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.Size = new Size(116, 21);
            lblRentalPrice.TabIndex = 2;
            lblRentalPrice.Text = "Rental Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(753, 164);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 2;
            label5.Text = "Description";
            // 
            // txtRate
            // 
            txtRate.Location = new Point(753, 119);
            txtRate.Margin = new Padding(5, 4, 5, 4);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(63, 29);
            txtRate.TabIndex = 1;
            txtRate.Tag = "Rate";
            txtRate.Validating += txt_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(757, 94);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 21);
            label6.TabIndex = 2;
            label6.Text = "Rate";
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.Black;
            btnFirst.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirst.ForeColor = Color.White;
            btnFirst.Image = Properties.Resources.firstIcon;
            btnFirst.ImageAlign = ContentAlignment.MiddleLeft;
            btnFirst.Location = new Point(432, 464);
            btnFirst.Margin = new Padding(5, 4, 5, 4);
            btnFirst.Name = "btnFirst";
            btnFirst.Padding = new Padding(6, 0, 0, 0);
            btnFirst.Size = new Size(123, 61);
            btnFirst.TabIndex = 3;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += Navigation_Handler;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Black;
            btnPrevious.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.Image = Properties.Resources.previousButton;
            btnPrevious.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrevious.Location = new Point(579, 464);
            btnPrevious.Margin = new Padding(5, 4, 5, 4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Padding = new Padding(5, 0, 10, 0);
            btnPrevious.Size = new Size(123, 61);
            btnPrevious.TabIndex = 3;
            btnPrevious.Text = "Previous";
            btnPrevious.TextAlign = ContentAlignment.MiddleRight;
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += Navigation_Handler;
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
            btnNext.Location = new Point(731, 464);
            btnNext.Margin = new Padding(5, 4, 5, 4);
            btnNext.Name = "btnNext";
            btnNext.Padding = new Padding(0, 0, 6, 0);
            btnNext.Size = new Size(121, 63);
            btnNext.TabIndex = 3;
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
            btnLast.Location = new Point(886, 464);
            btnLast.Margin = new Padding(5, 4, 5, 4);
            btnLast.Name = "btnLast";
            btnLast.Padding = new Padding(0, 0, 6, 0);
            btnLast.Size = new Size(123, 61);
            btnLast.TabIndex = 3;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += Navigation_Handler;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Chartreuse;
            btnAdd.Image = Properties.Resources.AddIcon;
            btnAdd.ImageAlign = ContentAlignment.TopCenter;
            btnAdd.Location = new Point(432, 533);
            btnAdd.Margin = new Padding(5, 4, 5, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 75);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.BottomCenter;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.Image = Properties.Resources.saveIcon;
            btnSave.ImageAlign = ContentAlignment.TopCenter;
            btnSave.Location = new Point(729, 533);
            btnSave.Margin = new Padding(5, 4, 5, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 75);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.BottomCenter;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DeepPink;
            btnDelete.Image = Properties.Resources.Delete;
            btnDelete.ImageAlign = ContentAlignment.TopCenter;
            btnDelete.Location = new Point(579, 533);
            btnDelete.Margin = new Padding(5, 4, 5, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 75);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.HotPink;
            btnCancel.Enabled = false;
            btnCancel.Image = Properties.Resources.Cancel;
            btnCancel.ImageAlign = ContentAlignment.TopCenter;
            btnCancel.Location = new Point(886, 533);
            btnCancel.Margin = new Padding(5, 4, 5, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 4, 0, 0);
            btnCancel.Size = new Size(123, 75);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.BottomCenter;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // errProviderGames
            // 
            errProviderGames.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errProviderGames.ContainerControl = this;
            // 
            // statusStrip1
            // 
            statusStrip1.AutoSize = false;
            statusStrip1.Items.AddRange(new ToolStripItem[] { tlsStatus, prbLoading, tlsFirst_LastRecord });
            statusStrip1.Location = new Point(0, 612);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 22, 0);
            statusStrip1.Size = new Size(1426, 31);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // tlsStatus
            // 
            tlsStatus.Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tlsStatus.Name = "tlsStatus";
            tlsStatus.Size = new Size(113, 26);
            tlsStatus.Text = "toolStripStatusLabel1";
            // 
            // prbLoading
            // 
            prbLoading.Name = "prbLoading";
            prbLoading.Size = new Size(158, 25);
            // 
            // tlsFirst_LastRecord
            // 
            tlsFirst_LastRecord.Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tlsFirst_LastRecord.Name = "tlsFirst_LastRecord";
            tlsFirst_LastRecord.Size = new Size(113, 26);
            tlsFirst_LastRecord.Text = "toolStripStatusLabel2";
            // 
            // txtGameId
            // 
            txtGameId.Location = new Point(183, 52);
            txtGameId.Margin = new Padding(5, 4, 5, 4);
            txtGameId.Name = "txtGameId";
            txtGameId.ReadOnly = true;
            txtGameId.Size = new Size(251, 29);
            txtGameId.TabIndex = 1;
            txtGameId.Tag = "Game Id";
            // 
            // lblGameId
            // 
            lblGameId.AutoSize = true;
            lblGameId.Location = new Point(183, 27);
            lblGameId.Margin = new Padding(5, 0, 5, 0);
            lblGameId.Name = "lblGameId";
            lblGameId.Size = new Size(75, 21);
            lblGameId.TabIndex = 2;
            lblGameId.Text = "GameId";
            // 
            // grbGamesCatalogue
            // 
            grbGamesCatalogue.BackColor = Color.Transparent;
            grbGamesCatalogue.Controls.Add(dtpReleaseDate);
            grbGamesCatalogue.Controls.Add(rtxtDescription);
            grbGamesCatalogue.Controls.Add(txtGameId);
            grbGamesCatalogue.Controls.Add(txtTitle);
            grbGamesCatalogue.Controls.Add(txtGenre);
            grbGamesCatalogue.Controls.Add(label1);
            grbGamesCatalogue.Controls.Add(lblGameId);
            grbGamesCatalogue.Controls.Add(label2);
            grbGamesCatalogue.Controls.Add(label3);
            grbGamesCatalogue.Controls.Add(lblRentalPrice);
            grbGamesCatalogue.Controls.Add(txtRentalPrice);
            grbGamesCatalogue.Controls.Add(label6);
            grbGamesCatalogue.Controls.Add(label5);
            grbGamesCatalogue.Controls.Add(txtRate);
            grbGamesCatalogue.ForeColor = Color.White;
            grbGamesCatalogue.Location = new Point(66, 60);
            grbGamesCatalogue.Margin = new Padding(5, 4, 5, 4);
            grbGamesCatalogue.Name = "grbGamesCatalogue";
            grbGamesCatalogue.Padding = new Padding(5, 4, 5, 4);
            grbGamesCatalogue.Size = new Size(1128, 395);
            grbGamesCatalogue.TabIndex = 5;
            grbGamesCatalogue.TabStop = false;
            grbGamesCatalogue.Text = "Games Catalogue";
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(183, 277);
            dtpReleaseDate.Margin = new Padding(4, 3, 4, 3);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(219, 29);
            dtpReleaseDate.TabIndex = 4;
            dtpReleaseDate.Tag = "Release Date";
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(760, 204);
            rtxtDescription.Margin = new Padding(4, 3, 4, 3);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(345, 166);
            rtxtDescription.TabIndex = 3;
            rtxtDescription.Text = "";
            // 
            // Games
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = Properties.Resources.gamesBackground;
            ClientSize = new Size(1426, 643);
            Controls.Add(btnNext);
            Controls.Add(grbGamesCatalogue);
            Controls.Add(statusStrip1);
            Controls.Add(btnLast);
            Controls.Add(btnPrevious);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(btnFirst);
            Font = new Font("Roboto Slab", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "Games";
            Text = "Games";
            FormClosing += Games_FormClosing;
            Load += Games_Load;
            ((System.ComponentModel.ISupportInitialize)errProviderGames).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            grbGamesCatalogue.ResumeLayout(false);
            grbGamesCatalogue.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtTitle;
        private Label label1;
        private TextBox txtGenre;
        private Label label2;
        private Label label3;
        private TextBox txtRentalPrice;
        private Label lblRentalPrice;
        private Label label5;
        private TextBox txtRate;
        private Label label6;
        private Button btnFirst;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Button btnAdd;
        private Button btnSave;
        private Button btnDelete;
        private Button btnCancel;
        private ErrorProvider errProviderGames;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tlsStatus;
        private ToolStripProgressBar prbLoading;
        private ToolStripStatusLabel tlsFirst_LastRecord;
        private Label lblGameId;
        private TextBox txtGameId;
        private GroupBox grbGamesCatalogue;
        private RichTextBox rtxtDescription;
        private DateTimePicker dtpReleaseDate;
    }
}