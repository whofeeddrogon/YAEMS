
namespace WindowsFormsApp1
{
    partial class Dashboard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dashboard_TE = new System.Windows.Forms.Label();
            this.dashboard_AE = new System.Windows.Forms.Label();
            this.dashboard_IE = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(26, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 151);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(26, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 315);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dashboard_TE);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(25, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 115);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dashboard_AE);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(252, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 115);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Indigo;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dashboard_IE);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(479, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 115);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(26, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Active Employees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inactive Employees";
            // 
            // dashboard_TE
            // 
            this.dashboard_TE.AutoSize = true;
            this.dashboard_TE.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_TE.ForeColor = System.Drawing.SystemColors.Control;
            this.dashboard_TE.Location = new System.Drawing.Point(152, 16);
            this.dashboard_TE.Name = "dashboard_TE";
            this.dashboard_TE.Size = new System.Drawing.Size(30, 34);
            this.dashboard_TE.TabIndex = 2;
            this.dashboard_TE.Text = "0";
            // 
            // dashboard_AE
            // 
            this.dashboard_AE.AutoSize = true;
            this.dashboard_AE.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_AE.ForeColor = System.Drawing.SystemColors.Control;
            this.dashboard_AE.Location = new System.Drawing.Point(149, 16);
            this.dashboard_AE.Name = "dashboard_AE";
            this.dashboard_AE.Size = new System.Drawing.Size(30, 34);
            this.dashboard_AE.TabIndex = 3;
            this.dashboard_AE.Text = "0";
            // 
            // dashboard_IE
            // 
            this.dashboard_IE.AutoSize = true;
            this.dashboard_IE.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_IE.ForeColor = System.Drawing.SystemColors.Control;
            this.dashboard_IE.Location = new System.Drawing.Point(156, 16);
            this.dashboard_IE.Name = "dashboard_IE";
            this.dashboard_IE.Size = new System.Drawing.Size(30, 34);
            this.dashboard_IE.TabIndex = 4;
            this.dashboard_IE.Text = "0";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(762, 539);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dashboard_IE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dashboard_AE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dashboard_TE;
        private System.Windows.Forms.Label label1;
    }
}
