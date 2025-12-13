## YAEMS (Yet Another Employee Management System)

Simple **Windows Forms** employee management app. You can register/sign in users, add/update/delete employees, and edit salary information.

### Features

- User registration and sign-in
- Add / update / “soft delete” employees (via `delete_date`)
- Basic counters on the dashboard
- Salary updates

### Requirements

- Windows
- Visual Studio 2019/2022
- .NET Framework 4.7.2 (target framework)
- SQL Server LocalDB (or SQL Server)

### Setup & Run

1) Open the solution: [YAEMS.sln](YAEMS.sln)
2) There are no NuGet packages; you can build directly.
3) Set the start-up project to: **YAEMS.WinForms**
4) Run.

### Database

The app uses the `users` and `employees` tables. Example (minimal) schema:

```sql
CREATE TABLE users (
	id INT IDENTITY(1,1) PRIMARY KEY,
	username NVARCHAR(50) NOT NULL UNIQUE,
	password NVARCHAR(255) NOT NULL,
	date_register DATE NOT NULL
);

CREATE TABLE employees (
	id INT IDENTITY(1,1) PRIMARY KEY,
	employee_id NVARCHAR(50) NOT NULL UNIQUE,
	full_name NVARCHAR(100) NOT NULL,
	gender NVARCHAR(20) NOT NULL,
	contact_number NVARCHAR(30) NOT NULL,
	position NVARCHAR(50) NOT NULL,
	salary DECIMAL(18,2) NOT NULL DEFAULT 0,
	insert_date DATE NULL,
	update_date DATE NULL,
	delete_date DATE NULL,
	status NVARCHAR(20) NOT NULL
);
```

### Connection String (Important)

The connection string is managed in a single place: [YAEMS.WinForms/App.config](YAEMS.WinForms/App.config)

Update the `YaemsDb` connection string for your machine (especially `AttachDbFilename=...`).

### Notes

- This project is for learning purposes. Passwords are currently stored as plain text; in a real project, use hashing + salting.
