
namespace WindowsFormsApp1
{
    partial class AddEmployee
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addEmployee_clear = new System.Windows.Forms.Button();
            this.addEmployee_delete = new System.Windows.Forms.Button();
            this.addEmployee_update = new System.Windows.Forms.Button();
            this.addEmployee_add = new System.Windows.Forms.Button();
            this.addEmployee_phoneNumber = new System.Windows.Forms.TextBox();
            this.addEmployee_status = new System.Windows.Forms.ComboBox();
            this.addEmployee_position = new System.Windows.Forms.ComboBox();
            this.addEmployee_gender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addEmployee_fullName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addEmployee_id = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 257);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 198);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee\'s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addEmployee_clear);
            this.panel2.Controls.Add(this.addEmployee_delete);
            this.panel2.Controls.Add(this.addEmployee_update);
            this.panel2.Controls.Add(this.addEmployee_add);
            this.panel2.Controls.Add(this.addEmployee_phoneNumber);
            this.panel2.Controls.Add(this.addEmployee_status);
            this.panel2.Controls.Add(this.addEmployee_position);
            this.panel2.Controls.Add(this.addEmployee_gender);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addEmployee_fullName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.addEmployee_id);
            this.panel2.Location = new System.Drawing.Point(19, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 210);
            this.panel2.TabIndex = 1;
            // 
            // addEmployee_clear
            // 
            this.addEmployee_clear.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.addEmployee_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_clear.ForeColor = System.Drawing.SystemColors.Control;
            this.addEmployee_clear.Location = new System.Drawing.Point(473, 160);
            this.addEmployee_clear.Name = "addEmployee_clear";
            this.addEmployee_clear.Size = new System.Drawing.Size(113, 33);
            this.addEmployee_clear.TabIndex = 19;
            this.addEmployee_clear.Text = "Clear";
            this.addEmployee_clear.UseVisualStyleBackColor = false;
            this.addEmployee_clear.Click += new System.EventHandler(this.addEmployee_clear_Click);
            // 
            // addEmployee_delete
            // 
            this.addEmployee_delete.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.addEmployee_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.addEmployee_delete.Location = new System.Drawing.Point(354, 160);
            this.addEmployee_delete.Name = "addEmployee_delete";
            this.addEmployee_delete.Size = new System.Drawing.Size(113, 33);
            this.addEmployee_delete.TabIndex = 18;
            this.addEmployee_delete.Text = "Delete";
            this.addEmployee_delete.UseVisualStyleBackColor = false;
            this.addEmployee_delete.Click += new System.EventHandler(this.addEmployee_delete_Click);
            // 
            // addEmployee_update
            // 
            this.addEmployee_update.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.addEmployee_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_update.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_update.ForeColor = System.Drawing.SystemColors.Control;
            this.addEmployee_update.Location = new System.Drawing.Point(235, 160);
            this.addEmployee_update.Name = "addEmployee_update";
            this.addEmployee_update.Size = new System.Drawing.Size(113, 33);
            this.addEmployee_update.TabIndex = 17;
            this.addEmployee_update.Text = "Update";
            this.addEmployee_update.UseVisualStyleBackColor = false;
            this.addEmployee_update.Click += new System.EventHandler(this.addEmployee_update_Click);
            // 
            // addEmployee_add
            // 
            this.addEmployee_add.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.addEmployee_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_add.ForeColor = System.Drawing.SystemColors.Control;
            this.addEmployee_add.Location = new System.Drawing.Point(111, 160);
            this.addEmployee_add.Name = "addEmployee_add";
            this.addEmployee_add.Size = new System.Drawing.Size(113, 33);
            this.addEmployee_add.TabIndex = 16;
            this.addEmployee_add.Text = "Add";
            this.addEmployee_add.UseVisualStyleBackColor = false;
            this.addEmployee_add.Click += new System.EventHandler(this.addEmployee_add_Click);
            // 
            // addEmployee_phoneNumber
            // 
            this.addEmployee_phoneNumber.Location = new System.Drawing.Point(436, 28);
            this.addEmployee_phoneNumber.Name = "addEmployee_phoneNumber";
            this.addEmployee_phoneNumber.Size = new System.Drawing.Size(142, 22);
            this.addEmployee_phoneNumber.TabIndex = 15;
            // 
            // addEmployee_status
            // 
            this.addEmployee_status.FormattingEnabled = true;
            this.addEmployee_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addEmployee_status.Location = new System.Drawing.Point(436, 109);
            this.addEmployee_status.Name = "addEmployee_status";
            this.addEmployee_status.Size = new System.Drawing.Size(142, 24);
            this.addEmployee_status.TabIndex = 14;
            // 
            // addEmployee_position
            // 
            this.addEmployee_position.FormattingEnabled = true;
            this.addEmployee_position.Items.AddRange(new object[] {
            "Software Developer",
            "IT",
            "Management",
            "HR"});
            this.addEmployee_position.Location = new System.Drawing.Point(436, 66);
            this.addEmployee_position.Name = "addEmployee_position";
            this.addEmployee_position.Size = new System.Drawing.Size(142, 24);
            this.addEmployee_position.TabIndex = 13;
            // 
            // addEmployee_gender
            // 
            this.addEmployee_gender.FormattingEnabled = true;
            this.addEmployee_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.addEmployee_gender.Location = new System.Drawing.Point(136, 115);
            this.addEmployee_gender.Name = "addEmployee_gender";
            this.addEmployee_gender.Size = new System.Drawing.Size(142, 24);
            this.addEmployee_gender.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(339, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Status";
            // 
            // addEmployee_fullName
            // 
            this.addEmployee_fullName.Location = new System.Drawing.Point(136, 71);
            this.addEmployee_fullName.Name = "addEmployee_fullName";
            this.addEmployee_fullName.Size = new System.Drawing.Size(142, 22);
            this.addEmployee_fullName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone Number ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID";
            // 
            // addEmployee_id
            // 
            this.addEmployee_id.Location = new System.Drawing.Point(136, 28);
            this.addEmployee_id.Name = "addEmployee_id";
            this.addEmployee_id.Size = new System.Drawing.Size(142, 22);
            this.addEmployee_id.TabIndex = 0;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(762, 539);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addEmployee_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addEmployee_fullName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addEmployee_clear;
        private System.Windows.Forms.Button addEmployee_delete;
        private System.Windows.Forms.Button addEmployee_update;
        private System.Windows.Forms.Button addEmployee_add;
        private System.Windows.Forms.TextBox addEmployee_phoneNumber;
        private System.Windows.Forms.ComboBox addEmployee_status;
        private System.Windows.Forms.ComboBox addEmployee_position;
        private System.Windows.Forms.ComboBox addEmployee_gender;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
