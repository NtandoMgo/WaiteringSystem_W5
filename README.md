# **Waitering System - Employee Management Application**

## **Project Description**

The **Waitering System - Employee Management Application** is a Windows Forms application designed to manage the employees of a waitering business. The system allows users to add, list, and manage employees based on different roles such as Head Waiter, Waiter, and Runner. It utilizes a simple, intuitive interface where only one instance of an employee form can be open at a time.

The system also supports multiple views, such as listing employees by role, and integrates with a database for persistent data storage. The project is built using Object-Oriented Programming principles and utilizes the Model-View-Controller (MVC) pattern to separate concerns between UI, business logic, and data management.

---

## **Features**

- **Add Employees**: The system supports adding employees with details such as name, phone number, role, pay, and shifts, depending on the employee's role (Head Waiter, Waiter, Runner).
- **Employee Listing**: Allows users to view a list of all employees or filter employees by their roles.
- **Data Persistence**: The system stores employee data in a database, ensuring the records are saved and can be retrieved later.
- **MDI Parent Form**: Uses a Multi-Document Interface (MDI) that allows multiple forms (like `EmployeeForm` and `EmployeeListingForm`) to open within the main application window.
- **Role-Specific Details**: Captures and displays role-specific information such as salary for Head Waiters, pay rate, shifts, and tips for Waiters and Runners.
- **Employee Search by Role**: Supports filtering employees by their roles using the `FindByRole` method in the `EmployeeController` class.

---

## **Project Structure**

The project is divided into three main layers:

1. **Presentation Layer (Forms)**:
    - `EmployeeMDIParent`: Main parent form, from which child forms are launched.
    - `EmployeeForm`: Used to add a new employee. Displays fields depending on the role selected.
    - `EmployeeListingForm`: Lists all employees or employees filtered by role.

2. **Business Layer (Controllers and Logic)**:
    - `EmployeeController`: Manages the interaction between forms and the database. Contains methods like `DataMaintenance`, `FinalizeChanges`, and `FindByRole`.
    - `Role`: Defines the roles that employees can have, such as Head Waiter, Waiter, and Runner.

3. **Data Layer (Database Communication)**:
    - `EmployeeDB`: Handles the communication with the database, ensuring data persistence.

---

## **Installation and Setup**

### **Prerequisites**
- .NET Framework (4.7.2 or higher)
- Visual Studio (or any other IDE supporting Windows Forms and .NET development)

### **Setup Instructions**

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/waitering-system.git
   ```
2. **Open in Visual Studio**:
   - Open the `WaiteringSystem.sln` solution file in Visual Studio.

3. **Build the Project**:
   - Select `Build > Build Solution` to compile the project and ensure there are no errors.

4. **Set the Startup Form**:
   - Open `Program.cs` and ensure the startup form is set to `EmployeeMDIParent`.

5. **Run the Application**:
   - Press `F5` or select `Debug > Start Debugging` to run the application.

---

## **Usage Guide**

### **Adding an Employee**

1. Open the `EmployeeMDIParent` form.
2. Select **Add Employee** from the menu.
3. Choose a role (Head Waiter, Waiter, or Runner) using the radio buttons.
4. Fill in the required employee details:
   - **Head Waiter**: Name, Phone, Salary.
   - **Waiter/Runner**: Name, Phone, Rate, Shifts, Tips.
5. Click **Submit** to save the employee's details into the database.

### **Listing Employees**

1. From the `EmployeeMDIParent` form, select **List Employees** from the menu.
2. You can view all employees or filter by role using the listing options.

---

## **Key Methods**

### **EmployeeController Class**

- **`FindByRole(Collection<Employee> emps, Role.RoleType roleVal)`**:
   - Filters the employees by their role.
   - Returns a collection of employees whose roles match the specified role type.

- **`DataMaintenance(Employee anEmp)`**:
   - Adds a new employee to the collection and performs the required database operation.

- **`FinalizeChanges(Employee employee)`**:
   - Commits changes to the database.

---

## **Technologies Used**

- **Language**: C# (.NET Framework)
- **Platform**: Windows Forms
- **Architecture**: Model-View-Controller (MVC)
- **Database**: SQL (via `EmployeeDB` class)
  
---

## **Contributing**

If you'd like to contribute to the project, feel free to fork the repository and submit a pull request. For major changes, please open an issue to discuss what you would like to change.

---

## **License**

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
