using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\berkayb\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public AddEmployee()
        {
            InitializeComponent();

            //TO DISPLAY THE DATA FROM DATABASE TO DATA GRID VIEW
            displayEmployeeData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEmployee_add_Click(object sender, EventArgs e)
        {
            if (addEmployee_id.Text == "" ||
                addEmployee_fullName.Text == "" ||
                addEmployee_gender.Text == "" ||
                addEmployee_phoneNumber.Text == "" ||
                addEmployee_position.Text == "" ||
                addEmployee_status.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmID = "SELECT COUNT(*) FROM employees WHERE employee_id = @emID";
                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            int count = (int)checkEm.ExecuteScalar();

                            if (count > 1)
                            {
                                MessageBox.Show(addEmployee_id.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO employees (employee_id, full_name, gender, contact_number, position, insert_date, status) VALUES (@employeeID, @fullName, @gender, @contactNumber, @position, @insertDate, @status)";
                                
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeId", addEmployee_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@full_name", addEmployee_fullName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addEmployee_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contact_number", addEmployee_phoneNumber.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@insert_date", today);
                                    cmd.Parameters.AddWithValue("@status", addEmployee_status.Text.Trim());

                                    cmd.ExecuteNonQuery();
                                    displayEmployeeData();
                                    MessageBox.Show("Added successfully", "Information Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {

                    }
                    finally
                    {

                    }
                }
            }
        }

        public void displayEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.employeeListData();

            dataGridView1.DataSource = listData;
        }
    }
}
