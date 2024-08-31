using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaiteringSystem.Business;

namespace WaiteringSystem.Presentation
{
    public partial class EmployessMDIParent : Form
    {
        #region Variables
        private int childFormNumber = 0;
        private EmployeeForm employeeForm;
        private EmployeeListingForm employeeListForm;
        private EmployeeController employeeController;
        #endregion

        #region Constructor
        public EmployessMDIParent()
        {
            InitializeComponent();
            employeeController = new EmployeeController();

            this.WindowState = FormWindowState.Maximized;
        }
        #endregion

        #region Defaults
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
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
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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
        #endregion

        #region ToolstripMenus
        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (employeeForm == null || employeeForm.IsDisposed)
            {
                employeeForm = new EmployeeForm(employeeController);
                employeeForm.MdiParent = this;
                employeeForm.Show();
            }
            else
            {
                employeeForm.BringToFront();
            }
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Employee ToolStrip Menus for Listing
        //List all
        private void listAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // List Headwaiter
        private void listHeadWaitersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // List Waiters
        private void listWaitersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // List Runner
        private void listRunnersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Create a New ChildForm (EmployeeForm & EmployeeListForm)

        private void CreateNewEmployeeForm()
        {
            if (employeeForm == null || employeeForm.employeeFormClosed)
            {
                employeeForm = new EmployeeForm(employeeController);
                employeeForm.MdiParent = this;
                employeeForm.StartPosition = FormStartPosition.CenterScreen;
                employeeForm.Show();
                employeeForm.employeeFormClosed = false;  // Reset form state
            }
            else
            {
                employeeForm.BringToFront();  // Bring the form to the front if already open
            }
        }

        private void CreateNewEmployeeListForm()
        {
            if (employeeListForm == null || employeeListForm.listFormClosed)
            {
                employeeListForm = new EmployeeListingForm(employeeController);
                employeeListForm.MdiParent = this;
                employeeListForm.StartPosition = FormStartPosition.CenterScreen;
                employeeListForm.Show();
                employeeListForm.listFormClosed = false;  // Reset form state
            }
            else
            {
                employeeListForm.BringToFront();  // Bring the form to the front if already open
            }
        }

        #endregion
    }
}
