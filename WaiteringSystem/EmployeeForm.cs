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
        }

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

        #endregion
    }
}
