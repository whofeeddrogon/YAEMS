
namespace WindowsFormsApp1
{
    partial class RegisterForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.signup_show_Pass = new System.Windows.Forms.CheckBox();
            this.signup_signupBtn = new System.Windows.Forms.Button();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.signup_signinBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signup_show_Pass
            // 
            this.signup_show_Pass.AutoSize = true;
            this.signup_show_Pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_show_Pass.Location = new System.Drawing.Point(455, 294);
            this.signup_show_Pass.Name = "signup_show_Pass";
            this.signup_show_Pass.Size = new System.Drawing.Size(129, 21);
            this.signup_show_Pass.TabIndex = 17;
            this.signup_show_Pass.Text = "Show Password";
            this.signup_show_Pass.UseVisualStyleBackColor = true;
            this.signup_show_Pass.CheckedChanged += new System.EventHandler(this.signup_show_Pass_CheckedChanged);
            // 
            // signup_signupBtn
            // 
            this.signup_signupBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.signup_signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_signupBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_signupBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.signup_signupBtn.Location = new System.Drawing.Point(309, 348);
            this.signup_signupBtn.Name = "signup_signupBtn";
            this.signup_signupBtn.Size = new System.Drawing.Size(123, 44);
            this.signup_signupBtn.TabIndex = 16;
            this.signup_signupBtn.Text = " SIGNUP";
            this.signup_signupBtn.UseVisualStyleBackColor = false;
            this.signup_signupBtn.Click += new System.EventHandler(this.signup_signupBtn_Click_1);
            // 
            // signup_password
            // 
            this.signup_password.Location = new System.Drawing.Point(323, 258);
            this.signup_password.Multiline = true;
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(261, 30);
            this.signup_password.TabIndex = 15;
            // 
            // signup_username
            // 
            this.signup_username.Location = new System.Drawing.Point(323, 154);
            this.signup_username.Multiline = true;
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(261, 30);
            this.signup_username.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Register Account";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(612, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 10;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.signup_signinBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 450);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.pngkey_com_pepsico_logo_png_500989;
            this.pictureBox1.Location = new System.Drawing.Point(46, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(11, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Employee Management System";
            // 
            // signup_signinBtn
            // 
            this.signup_signinBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.signup_signinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_signinBtn.FlatAppearance.BorderSize = 0;
            this.signup_signinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.signup_signinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.signup_signinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_signinBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_signinBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.signup_signinBtn.Location = new System.Drawing.Point(30, 393);
            this.signup_signinBtn.Name = "signup_signinBtn";
            this.signup_signinBtn.Size = new System.Drawing.Size(206, 44);
            this.signup_signinBtn.TabIndex = 9;
            this.signup_signinBtn.Text = "SIGN IN";
            this.signup_signinBtn.UseVisualStyleBackColor = false;
            this.signup_signinBtn.Click += new System.EventHandler(this.signup_signinBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(51, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Login Your Account";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.signup_show_Pass);
            this.Controls.Add(this.signup_signupBtn);
            this.Controls.Add(this.signup_password);
            this.Controls.Add(this.signup_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox signup_show_Pass;
        private System.Windows.Forms.Button signup_signupBtn;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button signup_signinBtn;
        private System.Windows.Forms.Label label5;
    }
}