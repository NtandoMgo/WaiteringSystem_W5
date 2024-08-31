using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WaiteringSystem.Business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WaiteringSystem.Data;

namespace WaiteringSystem.Presentation
{
    public partial class EmployeeForm : Form
    {
        #region Data fields
        private Employee empl;
        private EmployeeController controller;
        private Role.RoleType roleVal;

        public bool employeeFormClosed = false;
        #endregion

        #region Constructor
        public EmployeeForm(EmployeeController aController)
        {
            InitializeComponent();
            controller = aController;
        }
        #endregion

        #region Utility Methods
        private void ShowAll(bool value, Role.RoleType roleType)
        {
            id_lbl.Visible = value;
            empl_id_lbl.Visible = value;
            name_lbl.Visible = value;
            phone_lbl.Visible = value;
            pay_lbl.Visible = value;

            //text boxes
            id_tbx.Visible = value;
            eml_ID_tbx.Visible = value;
            name_tbx.Visible = value;
            phone_tbx.Visible = value;
            pay_tbx.Visible = value;

            // action buttns
            sub_btn.Visible = value;
            cancel_btn.Visible = value;
            
            //label2.Visible = value;

            if (!(value))
            {
                HwRbtn.Checked = false;
                waiterRbtn.Checked = false;
                runnerRbtn.Checked = false;
            }
            if ((roleType == Role.RoleType.Waiter) || (roleType == Role.RoleType.Runner) && value)
            {
                hrz_lbl.Visible = value;
                hrx_tbx.Visible = value;
                tips_lbl.Visible = value;
                tips_tbx.Visible = value;
            }
            else
            {
                hrz_lbl.Visible = false;
                hrx_tbx.Visible = false;
                tips_lbl.Visible = false;
                tips_tbx.Visible = false;
            }
        }
        private void ClearAll()
        {
            id_tbx.Text = "";
            eml_ID_tbx.Text = "";
            name_tbx.Text = "";
            phone_tbx.Text = "";
            pay_tbx.Text = "";
        }

        private void PopulateObject(Role.RoleType roleType)
        {
            HeadWaiter headW;
            Waiter waiter;
            Runner runner;
            empl = new Employee(roleType);
            empl.ID = id_tbx.Text;
            empl.EmployeeID = empl_id_lbl.Text;
            empl.Name = name_tbx.Text;
            empl.Telephone = phone_tbx.Text;

            switch (empl.role.getRoleValue)
            {
                case Role.RoleType.Headwaiter:
                    headW = (HeadWaiter)(empl.role);
                    headW.SalaryAmount = decimal.Parse(pay_tbx.Text);
                    break;
                case Role.RoleType.Waiter:
                    waiter = (Waiter)(empl.role);
                    waiter.getRate = decimal.Parse(pay_tbx.Text);
                    waiter.getShifts = int.Parse(hrx_tbx.Text);
                    waiter.getTips = decimal.Parse(tips_tbx.Text);
                    break;
                case Role.RoleType.Runner:
                    runner = (Runner)(empl.role);
                    runner.getRate = decimal.Parse(pay_tbx.Text);
                    runner.getShifts = int.Parse(hrx_tbx.Text);
                    runner.getTips = decimal.Parse(tips_tbx.Text);
                    break;
            }
        }


        #endregion

        #region Radio Button CheckChanged Events
        private void HwRbtn_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Add Head Waiter";
            roleVal = Role.RoleType.Headwaiter;
            pay_lbl.Text = "Salary";
            ShowAll(true, roleVal);
            id_tbx.Focus();
        }

        private void waiterRbtn_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Add Waiter";
            roleVal = Role.RoleType.Waiter;
            pay_lbl.Text = "Rate";
            ShowAll(true, roleVal);
            id_tbx.Focus();
        }

        private void runnerRbtn_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Add Runner";
            roleVal = Role.RoleType.Runner;
            pay_lbl.Text = "Rate";
            ShowAll(true, roleVal);
            id_tbx.Focus();
        }
        #endregion

        #region submit button/control
        private void sub_btn_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())  // Perform validation first
            {
                PopulateObject(roleVal);
                MessageBox.Show("The record will be submitted to the Database!");
                controller.DataMaintenance(empl);  // Add to DB
                controller.FinalizeChanges(empl);  // Finalize
                ClearAll();
                ShowAll(false, roleVal);  // Reset form
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.");
            }
        }


        #endregion

        #region Input validation
        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(id_tbx.Text) || string.IsNullOrEmpty(name_tbx.Text))
            {
                return false;  // Required fields are empty
            }
            if (roleVal == Role.RoleType.Waiter || roleVal == Role.RoleType.Runner)
            {
                if (string.IsNullOrEmpty(hrx_tbx.Text) || string.IsNullOrEmpty(tips_tbx.Text))
                {
                    return false;  // Waiter/Runner specific fields are empty
                }
            }
            return true;
        }
        #endregion

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            ShowAll(false, roleVal);
            //controller = new EmployeeController();
        }

        private void EmployeeForm_Activated(object sender, EventArgs e)
        {
            ShowAll(false, roleVal);
        }

        #region Cancel button/control
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            ClearAll();
            ShowAll(false, roleVal);
        }

        #endregion

        private void exit_btn_Click(object sender, EventArgs e)
        {
            employeeFormClosed = true;
            this.Close();
        }
    }
}
