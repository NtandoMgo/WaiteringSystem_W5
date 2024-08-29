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

namespace WaiteringSystem
{
    public partial class EmployeeForm : Form
    {
        #region Data fields
        public Employee empl;
        public EmployeeController controller;
        private Role.RoleType roleValue;
        #endregion
        public EmployeeForm()
        {
            InitializeComponent();

            this.Activated += EmployeeForm_Activated;
        }

        #region Form Events
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            ShowAll(false, roleValue);

            controller = new EmployeeController();
        }

        private void EmployeeForm_Activated(object sender, EventArgs e)
        {
            HW_rad_btn.Checked = false; //

            ShowAll(false, roleValue);
        }
        #endregion

        #region Utility Methods
        public void ShowAll(bool value, Role.RoleType roleType)
        {
            id_lbl.Visible = value;
            emplID_lbl.Visible = value;
            name_lbl.Visible = value;
            //do this for all controls
            phone_lbl.Visible = value;
            pay_lbl.Visible = value;
            hrz_lbl.Visible = value;
            tips_lbl.Visible = value;

            id_tbx.Visible = value;
            e_id_tbx.Visible = value;
            name_tbx.Visible = value;
            phone_tbx.Visible = value;
            pay_tbx.Visible = value;

            // Set radio buttons visibility
            if (!value)
            {
                HW_rad_btn.Checked = false;
                W_rad_btn.Checked = false;
                run_rd_btn.Checked = false;
            }

            // Check for Waiter or Runner roles and set visibility for specific controls
            if (roleType == Role.RoleType.Waiter || roleType == Role.RoleType.Runner)
            {
                pay_lbl.Visible = false;
                pay_tbx.Visible = false;

                tips_lbl.Visible = value;
                tips_tbx.Visible = value;
                hrz_lbl.Visible = value;
                hours_tbx.Visible = value;
            }
            else
            {
                // Hide tips and hours for non-Waiter/Runner roles
                tips_lbl.Visible = false;
                tips_tbx.Visible = false;
                hrz_lbl.Visible = false;
                hours_tbx.Visible = false;
            }
        }

        private void ClearAll()
        { 
            id_tbx.Clear();
            e_id_tbx.Clear();
            name_tbx.Clear();
            phone_tbx.Clear();
            pay_tbx.Clear();
            hours_tbx.Clear();
            tips_tbx.Clear();
        }

        private void PopulateObject(Role.RoleType roleType)
        {
            HeadWaiter headW;
            Waiter waiter;
            Runner runner;

            Employee employee = new Employee(roleType);

            employee.ID = id_tbx.Text;
            employee.EmployeeID = e_id_tbx.Text;
            employee.Name = name_tbx.Text;
            employee.Telephone = phone_tbx.Text;

            switch (employee.role.getRoleValue)
            {
                case Role.RoleType.Headwaiter:
                    headW = (HeadWaiter)(employee.role);
                    headW.SalaryAmount = decimal.Parse(pay_tbx.Text);
                    break;

                case Role.RoleType.Waiter:
                    waiter = (Waiter)(employee.role);
                    waiter.getTips = decimal.Parse(tips_tbx.Text);
                    waiter.getShifts = int.Parse(hours_tbx.Text);
                    break;

                case Role.RoleType.Runner:
                    runner = (Runner)(employee.role);
                    runner.getShifts = int.Parse(hours_tbx.Text);
                    break;
            }
        }

        #endregion

        #region Radio Button CheckChanged Events
        private void HW_rad_btn_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Add Head Waiter";

            roleValue = Role.RoleType.Headwaiter;

            pay_lbl.Text = "Salary";

            ShowAll(true, roleValue);

            id_tbx.Focus();
        }

        private void W_rad_btn_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Add Waiter";

            roleValue = Role.RoleType.Waiter;

            hrz_lbl.Text = "Hours Worked";

            ShowAll(true, roleValue);

            id_tbx.Focus();
        }

        private void run_rd_btn_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Add Runner";

            roleValue = Role.RoleType.Runner;

            hrz_lbl.Text = "Hours Worked";

            ShowAll(true, roleValue);

            id_tbx.Focus();
        }

        #endregion

        #region Action Buttons Events

        // SUBMIT BUTTON
        private void sub_btn_Click(object sender, EventArgs e)
        {
            PopulateObject(roleValue);

            MessageBox.Show("The record will be submitted to the database.", "Submission", MessageBoxButtons.OK, MessageBoxIcon.Information);

            controller.DataMaintenance(empl);

            controller.FinalizeChanges(empl);

            ClearAll();

            ShowAll(false, roleValue);
        }

        // CANCEL BUTTON
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            ClearAll();
            ShowAll(false, roleValue);
        }

        // EXIT BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
