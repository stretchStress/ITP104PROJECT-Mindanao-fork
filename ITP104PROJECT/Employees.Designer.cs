﻿namespace ITP104PROJECT
{
    partial class Employees
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblGender = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmployeeDep = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDelemployee = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSideProj = new System.Windows.Forms.Button();
            this.btnSideEmp = new System.Windows.Forms.Button();
            this.btnSideDep = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnViewEmployees = new System.Windows.Forms.Button();
            this.panelDepFooter = new System.Windows.Forms.Panel();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDepFooter.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.lblAddEmployee);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(832, 34);
            this.panel4.TabIndex = 7;
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.ForeColor = System.Drawing.Color.White;
            this.lblAddEmployee.Location = new System.Drawing.Point(339, 6);
            this.lblAddEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(211, 26);
            this.lblAddEmployee.TabIndex = 2;
            this.lblAddEmployee.Text = "Add a New Employee";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblGender);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.txtGender);
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.lblEmployeeDep);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lblSalary);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.lblPosition);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.lblAddress);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.lblAge);
            this.panel3.Controls.Add(this.txtAge);
            this.panel3.Controls.Add(this.lblEmployeeName);
            this.panel3.Controls.Add(this.txtEmployeeName);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(206, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1041, 214);
            this.panel3.TabIndex = 9;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(202, 131);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 18);
            this.lblGender.TabIndex = 21;
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(99)))), ((int)(((byte)(126)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(728, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.button1.Size = new System.Drawing.Size(168, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Department";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.White;
            this.txtGender.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(206, 145);
            this.txtGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(136, 24);
            this.txtGender.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(202, 62);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 18);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(206, 81);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 24);
            this.txtEmail.TabIndex = 20;
            // 
            // lblEmployeeDep
            // 
            this.lblEmployeeDep.AutoSize = true;
            this.lblEmployeeDep.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDep.Location = new System.Drawing.Point(544, 127);
            this.lblEmployeeDep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeDep.Name = "lblEmployeeDep";
            this.lblEmployeeDep.Size = new System.Drawing.Size(84, 18);
            this.lblEmployeeDep.TabIndex = 18;
            this.lblEmployeeDep.Text = "Department";
            this.lblEmployeeDep.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(548, 145);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 26);
            this.comboBox1.TabIndex = 17;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(544, 67);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(44, 18);
            this.lblSalary.TabIndex = 14;
            this.lblSalary.Text = "Salary";
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(548, 81);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 24);
            this.textBox3.TabIndex = 15;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(370, 131);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(59, 18);
            this.lblPosition.TabIndex = 12;
            this.lblPosition.Text = "Position";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(373, 145);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 24);
            this.textBox2.TabIndex = 13;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(370, 62);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 18);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(373, 81);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 24);
            this.textBox1.TabIndex = 11;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(32, 131);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 18);
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.White;
            this.txtAge.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(35, 146);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(136, 24);
            this.txtAge.TabIndex = 9;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(32, 67);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(43, 18);
            this.lblEmployeeName.TabIndex = 3;
            this.lblEmployeeName.Text = "Name";
            this.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.White;
            this.txtEmployeeName.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(35, 82);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(136, 24);
            this.txtEmployeeName.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btnDelemployee);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(832, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 212);
            this.panel2.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(205, 33);
            this.panel6.TabIndex = 7;
            // 
            // btnDelemployee
            // 
            this.btnDelemployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.btnDelemployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(99)))), ((int)(((byte)(126)))));
            this.btnDelemployee.FlatAppearance.BorderSize = 3;
            this.btnDelemployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelemployee.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelemployee.ForeColor = System.Drawing.Color.White;
            this.btnDelemployee.Location = new System.Drawing.Point(22, 103);
            this.btnDelemployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelemployee.Name = "btnDelemployee";
            this.btnDelemployee.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDelemployee.Size = new System.Drawing.Size(168, 41);
            this.btnDelemployee.TabIndex = 6;
            this.btnDelemployee.Text = "Delete Employee";
            this.btnDelemployee.UseVisualStyleBackColor = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(76, 174);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(49, 18);
            this.lblAdmin.TabIndex = 8;
            this.lblAdmin.Text = "Admin";
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 494);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(193, 42);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 440);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(193, 42);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnSideProj
            // 
            this.btnSideProj.FlatAppearance.BorderSize = 0;
            this.btnSideProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideProj.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSideProj.ForeColor = System.Drawing.Color.White;
            this.btnSideProj.Location = new System.Drawing.Point(0, 387);
            this.btnSideProj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSideProj.Name = "btnSideProj";
            this.btnSideProj.Size = new System.Drawing.Size(193, 42);
            this.btnSideProj.TabIndex = 5;
            this.btnSideProj.Text = "Projects";
            this.btnSideProj.UseVisualStyleBackColor = true;
            // 
            // btnSideEmp
            // 
            this.btnSideEmp.FlatAppearance.BorderSize = 0;
            this.btnSideEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideEmp.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSideEmp.ForeColor = System.Drawing.Color.White;
            this.btnSideEmp.Location = new System.Drawing.Point(0, 333);
            this.btnSideEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSideEmp.Name = "btnSideEmp";
            this.btnSideEmp.Size = new System.Drawing.Size(193, 42);
            this.btnSideEmp.TabIndex = 4;
            this.btnSideEmp.Text = "Employees";
            this.btnSideEmp.UseVisualStyleBackColor = true;
            // 
            // btnSideDep
            // 
            this.btnSideDep.FlatAppearance.BorderSize = 0;
            this.btnSideDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideDep.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSideDep.ForeColor = System.Drawing.Color.White;
            this.btnSideDep.Location = new System.Drawing.Point(2, 280);
            this.btnSideDep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSideDep.Name = "btnSideDep";
            this.btnSideDep.Size = new System.Drawing.Size(190, 42);
            this.btnSideDep.TabIndex = 3;
            this.btnSideDep.Text = "Departments";
            this.btnSideDep.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 226);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(190, 42);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(48, 155);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Jessa Cariñaga";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnViewEmployees);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 214);
            this.panel1.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(206, 35);
            this.panel5.TabIndex = 5;
            // 
            // btnViewEmployees
            // 
            this.btnViewEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.btnViewEmployees.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(99)))), ((int)(((byte)(126)))));
            this.btnViewEmployees.FlatAppearance.BorderSize = 3;
            this.btnViewEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewEmployees.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEmployees.ForeColor = System.Drawing.Color.White;
            this.btnViewEmployees.Location = new System.Drawing.Point(22, 103);
            this.btnViewEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewEmployees.Name = "btnViewEmployees";
            this.btnViewEmployees.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnViewEmployees.Size = new System.Drawing.Size(168, 41);
            this.btnViewEmployees.TabIndex = 4;
            this.btnViewEmployees.Text = "View Employees";
            this.btnViewEmployees.UseVisualStyleBackColor = false;
            // 
            // panelDepFooter
            // 
            this.panelDepFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.panelDepFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDepFooter.Controls.Add(this.panel3);
            this.panelDepFooter.Controls.Add(this.panel1);
            this.panelDepFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDepFooter.Location = new System.Drawing.Point(194, 394);
            this.panelDepFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDepFooter.Name = "panelDepFooter";
            this.panelDepFooter.Size = new System.Drawing.Size(1249, 216);
            this.panelDepFooter.TabIndex = 6;
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.panelSideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSideBar.Controls.Add(this.lblAdmin);
            this.panelSideBar.Controls.Add(this.btnLogout);
            this.panelSideBar.Controls.Add(this.btnSettings);
            this.panelSideBar.Controls.Add(this.btnSideProj);
            this.panelSideBar.Controls.Add(this.btnSideEmp);
            this.panelSideBar.Controls.Add(this.btnSideDep);
            this.panelSideBar.Controls.Add(this.btnDashboard);
            this.panelSideBar.Controls.Add(this.lblName);
            this.panelSideBar.Controls.Add(this.pictureBox1);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(194, 610);
            this.panelSideBar.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(46, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(1443, 610);
            this.dgvEmployees.TabIndex = 5;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Bold);
            this.lblEmployees.ForeColor = System.Drawing.Color.White;
            this.lblEmployees.Location = new System.Drawing.Point(16, 6);
            this.lblEmployees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(384, 43);
            this.lblEmployees.TabIndex = 2;
            this.lblEmployees.Text = "Employee Management";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lblEmployees);
            this.panel7.Controls.Add(this.btnSearch);
            this.panel7.Controls.Add(this.textBox4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(194, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1249, 61);
            this.panel7.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnSearch.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.btnSearch.Location = new System.Drawing.Point(1177, 17);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(992, 19);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 26);
            this.textBox4.TabIndex = 0;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1443, 610);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panelDepFooter);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.dgvEmployees);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Employees";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Employees";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelDepFooter.ResumeLayout(false);
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSideProj;
        private System.Windows.Forms.Button btnSideEmp;
        private System.Windows.Forms.Button btnSideDep;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDelemployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewEmployees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDepFooter;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEmployeeDep;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox4;
    }
}