using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class EmployeeListingForm : Form
    {
        #region Data fields
        public bool listFormClosed = false;
        private List<Employee> employeeList;
        private Role.RoleType roleValue;
        private EmployeeController employeeController;
        #endregion

        #region Constructors
        public EmployeeListingForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(EmployeeListingForm_FormClosing);
        }

        public EmployeeListingForm(EmployeeController empController)
        {
            InitializeComponent();
            employeeController = empController;
            //this.Load += EmployeeListForm_Load;
            this.FormClosing += new FormClosingEventHandler(EmployeeListingForm_FormClosing);
        }
        #endregion
        private void EmployeeListingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            listFormClosed = true;
        }

        #region List View Control
        public void setUpEmployeeListView()
        {
            ListViewItem employeeDetails;
            HeadWaiter headW;
            Waiter waiter;
            Runner runner;
            Collection<Employee> employees = null;


            empl_lst_view.Clear(); //Clear current List View Control
            empl_lst_view.Columns.Insert(0, "ID", 120, HorizontalAlignment.Left);
            empl_lst_view.Columns.Insert(1, "EMPID", 120, HorizontalAlignment.Left);
            empl_lst_view.Columns.Insert(2, "Name", 150, HorizontalAlignment.Left);
            empl_lst_view.Columns.Insert(3, "Phone", 100, HorizontalAlignment.Left);

            switch (roleValue) //switch between different roles
            {
                case Role.RoleType.NoRole:

                    employees = employeeController.AllEmployees; // Get all the employees from the EmployeeController  
                    employees = employeeController.AllEmployees; // Get all the employees from the EmployeeController  
                    list_lbl.Text = "Listing of all employees";
                    empl_lst_view.Columns.Insert(4, "Payment", 100, HorizontalAlignment.Center);
                    break;

                //Calling a FindByRole method to the EmployeeController 
                //Set Up Columns of List View
                case Role.RoleType.Headwaiter:
                    employees = employeeController.FindByRole(employeeController.AllEmployees, Role.RoleType.Headwaiter);
                    list_lbl.Text = "Listing of all Headwaiters";
                    empl_lst_view.Columns.Insert(4, "Salary", 100, HorizontalAlignment.Center);
                    break;
                case Role.RoleType.Waiter:
                    employees = employeeController.FindByRole(employeeController.AllEmployees, Role.RoleType.Waiter);
                    list_lbl.Text = "Listing of all Waiters";

                    empl_lst_view.Columns.Insert(4, "Rate", 100, HorizontalAlignment.Center);
                    empl_lst_view.Columns.Insert(5, "Number of Shifts", 100, HorizontalAlignment.Center);
                    break;
                case Role.RoleType.Runner:
                    employees = employeeController.FindByRole(employeeController.AllEmployees, Role.RoleType.Runner);
                    list_lbl.Text = "Listing of all Runners";
                    empl_lst_view.Columns.Insert(4, "Rate", 100, HorizontalAlignment.Center);
                    empl_lst_view.Columns.Insert(5, "Number of Shifts", 100, HorizontalAlignment.Center);
                    break;
            }

            foreach (Employee employee in employees)
            {
                //create a new employeeDetails object to initialize the texts
                employeeDetails = new ListViewItem();
                employeeDetails.Text = employee.ID.ToString();
                employeeDetails.Text = employee.EmployeeID.ToString();
                employeeDetails.Text = employee.Name.ToString();
                employeeDetails.Text = employee.Telephone.ToString();
                switch (employee.role.getRoleValue)
                {
                    case Role.RoleType.Headwaiter:
                        headW = (HeadWaiter)employee.role;
                        employeeDetails.SubItems.Add(headW.SalaryAmount.ToString());
                        break;
                    case Role.RoleType.Waiter:
                        waiter = (Waiter)employee.role;
                        employeeDetails.SubItems.Add(waiter.getRate.ToString());
                        employeeDetails.SubItems.Add(waiter.getShifts.ToString());
                        break;
                    case Role.RoleType.Runner:
                        runner = (Runner)employee.role;
                        employeeDetails.SubItems.Add(runner.getRate.ToString());
                        employeeDetails.SubItems.Add(runner.getShifts.ToString());
                        break;
                }
                empl_lst_view.Items.Add(employeeDetails);
            }
            empl_lst_view.Refresh();
            empl_lst_view.GridLines = true;
        }
        #endregion
    }
}