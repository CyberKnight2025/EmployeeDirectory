# Employee Directory Management System

## Preview
![Employee Directory Management System Screenshot](EmployeeDirectoryUI.png)

## Overview
This is a **VB.NET Windows Forms Application** that connects to a SQL Server database and manages employee records.  
It allows users to **view, add, update, and delete** employee information using a clean graphical user interface (GUI).

## Features
- Load employee data into a DataGridView.
- Display employee records with column auto-size and color-coded status.
- Add new employees.
- Update existing employee records.
- Delete selected employees.
- Structured exception handling (Try...Catch blocks).
- User-friendly UI with neatly aligned textboxes and action buttons.

## Technical Details
- Language: **VB.NET** (Visual Basic .NET)
- Framework: **.NET Framework 4.8**
- Database: **SQL Server Express** (LocalDB)
- UI Framework: **Windows Forms (WinForms)**
- Version Control: **GitHub**

## Setup Instructions
1. Clone this repository.
2. Open the solution (`EmployeeDirectory.sln`) in Visual Studio.
3. Update the database connection string if necessary.
4. Build and run the project.

## Future Improvements
- Add input validation for employee fields.
- Implement Entity Framework for database operations.
- Add authentication for admin/user roles.

## Project Comparison

| Criteria                         | Employee Directory Project                                    | Employee Form Project                                   |
|----------------------------------|---------------------------------------------------------------|---------------------------------------------------------|
| **Database Connection**          | Yes (SQL Server)                                              | No (local UI only)                                      |
| **DataGridView with Real Data**  | Yes (with sample & color coding                               | No real data, just empty table                          |
| **CRUD Operations**              | Buttons exist, functionality implied                          | Basic button layout only                                |
| **Error Handling (Try...Catch**) | Yes (structured)                                              | No                                                      |
| **Technical Complexity**         | Higher (backend + frontend)                                   | Lower (frontend)                                        |
| **Pupose**                       | Full CRUD simulation                                          | Basic UI Form layout and control positioning            |
| **UI Complexity**                | Advanced (DataGridView + TextBoxes + Buttons professionally)  | Basic (Simple TextBoxes and Buttons)                    |
| **Data Handling**                | Dynamic dummy data + Centered display + Colored rows          | No complex data handling, mainly layout                 |
| **Real-World Simulation**        | Yes, closer to real application structure                     | No, more like initial layout practice                   |
| **Skill Level Shown**            | Intermediate VB.NET Developer                                 | Beginner VB.NET Developer                               |

## Related Project
Check out the [EmployeeFormProject](https://github.com/CyberKnight2025/EmployeeFormProject) for another VB.NET Windows Forms project!

