using System;
using System.Configuration;
using System.Data.SqlClient;

namespace YAEMS.WinForms
{
    internal static class DatabaseBootstrapper
    {
        internal static void EnsureSchema()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["YaemsDb"]?.ConnectionString;
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ConfigurationErrorsException(
                    "Missing connection string 'YaemsDb'. Check App.config <connectionStrings>."
                );
            }

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"
IF OBJECT_ID(N'dbo.users', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.users (
        id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        username NVARCHAR(50) NOT NULL UNIQUE,
        password NVARCHAR(255) NOT NULL,
        date_register DATE NOT NULL
    );
END;

IF OBJECT_ID(N'dbo.employees', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.employees (
        id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        employee_id NVARCHAR(50) NOT NULL UNIQUE,
        full_name NVARCHAR(100) NOT NULL,
        gender NVARCHAR(20) NOT NULL,
        contact_number NVARCHAR(30) NOT NULL,
        position NVARCHAR(50) NOT NULL,
        salary INT NOT NULL CONSTRAINT DF_employees_salary DEFAULT (0),
        insert_date DATE NULL,
        update_date DATE NULL,
        delete_date DATE NULL,
        status NVARCHAR(20) NOT NULL
    );
END;
";
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
