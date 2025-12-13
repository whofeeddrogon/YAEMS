# YAEMS (Yet Another Employee Management System)

A simple **Windows Forms** employee management application built to explore the .NET ecosystem and WinForms development.

## Overview

This project serves as a learning exercise for .NET Framework and Windows Forms applications. It provides basic functionality to manage employees, users, and salaries.

## Features

- **User Management**: Registration and Sign-in functionality.
- **Employee Management**: Add, update, and "soft delete" employees.
- **Dashboard**: View basic statistics and counters.
- **Salary Management**: Edit and update employee salary information.
- **Auto-Schema Initialization**: The application automatically checks and creates necessary database tables on startup.

## Requirements

- Windows OS
- Visual Studio 2019 or 2022
- .NET Framework 4.7.2
- SQL Server LocalDB (or full SQL Server instance)

## Setup & Installation

1.  **Clone or Download** the repository.
2.  Open the solution file: YAEMS.sln in Visual Studio.
3.  **Database Configuration**:
    - The project includes a DatabaseBootstrapper that automatically creates the required tables (users, employees) if they do not exist.
    - Ensure the connection string in YAEMS.WinForms/App.config points to a valid SQL Server instance or LocalDB file.
4.  **Build & Run**:
    - Set YAEMS.WinForms as the startup project.
    - Build the solution.
    - Run the application. The database schema will be initialized automatically.

## Database Schema

The application manages the schema automatically via DatabaseBootstrapper.cs.

### Users Table (users)

| Column | Type | Constraints | Description |
| :--- | :--- | :--- | :--- |
| id | INT | PK, Identity | Unique record identifier |
| username | NVARCHAR(50) | Unique, Not Null | User login name |
| password | NVARCHAR(255) | Not Null | User password (plain text for demo) |
| date_register | DATE | Not Null | Registration date |

### Employees Table (employees)

| Column | Type | Constraints | Description |
| :--- | :--- | :--- | :--- |
| id | INT | PK, Identity | Unique record identifier |
| employee_id | NVARCHAR(50) | Unique, Not Null | Employee public ID |
| Full_name | NVARCHAR(100) | Not Null | Full name |
| gender | NVARCHAR(20) | Not Null | Gender |
| contact_number | NVARCHAR(30) | Not Null | Contact phone number |
| position | NVARCHAR(50) | Not Null | Job position |
| salary | INT | Default 0 | Monthly salary |
| insert_date | DATE | Nullable | Record creation date |
| update_date | DATE | Nullable | Last update date |
| delete_date | DATE | Nullable | Soft delete date |
| status | NVARCHAR(20) | Not Null | Employment status |

## Notes

- **Security Warning**: Passwords are currently stored as plain text for simplicity. In a production environment, always use hashing and salting.
