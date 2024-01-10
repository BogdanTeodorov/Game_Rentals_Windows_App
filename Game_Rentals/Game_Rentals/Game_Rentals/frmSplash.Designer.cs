
namespace Game_Rentals
{
    partial class frmSplash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblProduct = new Label();
            lblVersion = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            prgLoading = new ProgressBar();
            lblCompany = new Label();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.BackColor = Color.Transparent;
            lblProduct.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduct.ForeColor = SystemColors.ButtonFace;
            lblProduct.Location = new Point(543, 171);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(383, 62);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "[Product Name]";
            // 
            // lblVersion
            // 
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblVersion.ForeColor = SystemColors.ButtonFace;
            lblVersion.Location = new Point(1176, 580);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(141, 62);
            lblVersion.TabIndex = 0;
            lblVersion.Text = "[Version]";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // prgLoading
            // 
            prgLoading.Location = new Point(-1, 671);
            prgLoading.Name = "prgLoading";
            prgLoading.Size = new Size(1510, 23);
            prgLoading.TabIndex = 3;
            // 
            // lblCompany
            // 
            lblCompany.BackColor = Color.Transparent;
            lblCompany.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompany.ForeColor = SystemColors.ButtonFace;
            lblCompany.Location = new Point(131, 580);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(169, 62);
            lblCompany.TabIndex = 0;
            lblCompany.Text = "[Company]";
            // 
            // frmSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.linkedinBackgrnd;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1508, 689);
            Controls.Add(prgLoading);
            Controls.Add(lblCompany);
            Controls.Add(lblVersion);
            Controls.Add(lblProduct);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screen Splash";
            Load += Form1_Load;
            ResumeLayout(false);
        }



        #endregion

        private Label lblProduct;
        private Label lblVersion;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar prgLoading;
        private Label lblCompany;
    }
}
