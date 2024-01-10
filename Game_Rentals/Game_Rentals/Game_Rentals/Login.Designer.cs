namespace Game_Rentals
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblUserName = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.ForeColor = SystemColors.ButtonHighlight;
            lblUserName.Location = new Point(24, 30);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(52, 29);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.ForeColor = SystemColors.ButtonFace;
            lblPassword.Location = new Point(24, 97);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 21);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(24, 133);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(286, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(24, 62);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(286, 23);
            txtUser.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSteelBlue;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(28, 162);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(83, 37);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightSteelBlue;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(195, 166);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(89, 37);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkShowPassword.ForeColor = SystemColors.ButtonHighlight;
            chkShowPassword.Location = new Point(28, 236);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(138, 25);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Login_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(465, 348);
            Controls.Add(chkShowPassword);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtUser);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtUser;
        private Button btnLogin;
        private Button btnCancel;
        private CheckBox chkShowPassword;
    }
}