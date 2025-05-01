# Employee Directory - VB.NET Windows Forms Application

## Overview
This project is a VB.NET Windows Forms application that connects to a SQL Server database and manages employee records. It allows users to **view**, **add**, **update**, and **delete** employee information using a clean graphical user interface (GUI).

## Features
- Load employee data from SQL Server
- Display employee records in a DataGridView
- Add new employee records
- Update existing employee information
- Delete selected employees
- Error Handling using structured Try...Catch blocks
- Exit application gracefully
- Simple, scalable design for small to medium-sized datasets
- Structured code following VB.NET best practices

## Technical Details
- VB.NET (Visual Basic .NET)
- Windows Forms (WinForms)
- SQL Server (Local DB / SQLExpress)
- ADO.NET (SqlConnection, SqlDataAdapter)

## Setup Instructions
1. Clone this repository.
2. Open the solution file (`EmployeeDirectory.sln`) in Visual Studio.
3. Update the database connection string inside App.config if necessary.
4. Build and run the project.

## Why This Project
This project demonstrates core VB.NET developer skills, including:
- Database interaction with ADO.NET (SQL Server)
- Building clean Windows Forms (WinForms) interfaces
- Applying error handling best practices
- Structuring a maintainable VB.NET application following real-world development patterns
- It highlights key abilities needed for mid-level VB.NET Software Developer roles such as at Taylor Corporation.

## Future Improvements
- Input validation for forms (First Name, Last Name, Department, Title, Status)
- Search/filter functionality for employees
- Add pagination for larger employee datasets
- Secure database operations with parameterized queries (to prevent SQL Injection)
- Move database connection strings to a secure configuration file

