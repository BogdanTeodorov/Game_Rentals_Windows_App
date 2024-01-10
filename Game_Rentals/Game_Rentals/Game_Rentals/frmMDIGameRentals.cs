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
    public partial class frmMDIGameRentals : Form

    {
        public ToolStripStatusLabel StatusStripLabel
        {
            get { return StatusLabel; }
            set { StatusLabel = value; }
        }

        private int childFormNumber = 0;

        public frmMDIGameRentals()
        {
            InitializeComponent();
            
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = null;

            object tag = ((ToolStripMenuItem)sender).Tag;

            switch (tag.ToString())
            {
                case "games":
                    childForm = new Games();
                    break;
                case "users":
                    childForm = new Users();
                    break;
                case "rentals":
                    childForm = new Rentals();
                    break;
                case "BrowseGames":
                    childForm = new BrowseGames();
                    break;
                case "BrowseCustomers":
                    childForm = new BrowseCustomers();
                    break;
                case "BrowseRentals":
                    childForm = new BrowseRentals();
                    break;


            }
            // We only allow one instance of each child form
            if (childForm != null)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == childForm.GetType())
                    {
                        f.Activate();
                        return;
                    }
                }
            }
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmMDIParent_Load(object sender, EventArgs e)
        {
            Login f = new();
            this.WindowState = FormWindowState.Minimized;



            f.StartPosition = FormStartPosition.CenterParent;

            DialogResult result = f.ShowDialog();
            bool isAdmin = f.UserAuthentication();

            if (result == DialogResult.OK && isAdmin)
            {
                MessageBox.Show("Login successfully as Admin");
                this.Text = "Game Rentals - Admin Mode";
                this.WindowState = FormWindowState.Maximized;

                StatusLabel.Text = $"Welcome Admin to Game Rentals";


            }
            else if (result == DialogResult.OK && !isAdmin)
            {
                MessageBox.Show("Login successfully");
                usersListsToolStripMenuItem.Visible = false;
                browseClientsToolStripMenuItem.Visible = false;
                browseRentalsToolStripMenuItem.Visible = false;
                this.Text = "Game Rentals";
                this.WindowState = FormWindowState.Maximized;
                StatusLabel.Text = $"Welcome to Game Rentals";


            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Login canceled");
                this.Close();
            }
            else if (result == DialogResult.Abort)
            {
                MessageBox.Show("Invalid Login or Password. Exiting application");

                this.Close();
            }

        }
    }
}
