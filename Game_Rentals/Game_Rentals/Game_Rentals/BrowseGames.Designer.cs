namespace Game_Rentals
{
    partial class BrowseGames
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseGames));
            dgvGames = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // dgvGames
            // 
            dataGridViewCellStyle1.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dgvGames.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGames.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvGames.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.EditMode = DataGridViewEditMode.EditOnF2;
            dgvGames.GridColor = Color.White;
            dgvGames.Location = new Point(26, -1);
            dgvGames.Name = "dgvGames";
            dgvGames.RowTemplate.Height = 25;
            dgvGames.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvGames.Size = new Size(1396, 802);
            dgvGames.TabIndex = 0;
            // 
            // BrowseGames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gamesBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1454, 729);
            Controls.Add(dgvGames);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BrowseGames";
            Text = "BrowseGames";
            Load += BrowseGames_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGames;
    }
}