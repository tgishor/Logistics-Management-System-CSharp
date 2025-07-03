namespace E_ShifSystem
{
    partial class Admin_Manage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adminPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adminEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adminUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectedAdminID = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.updateBtn = new System.Windows.Forms.Button();
            this.adminName = new System.Windows.Forms.TextBox();
            this.adminDataTable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.adminPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.adminEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.adminUsername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSelectedAdminID);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.adminName);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 605);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "Admin Password: ";
            // 
            // adminPassword
            // 
            this.adminPassword.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPassword.Location = new System.Drawing.Point(62, 389);
            this.adminPassword.Name = "adminPassword";
            this.adminPassword.Size = new System.Drawing.Size(384, 30);
            this.adminPassword.TabIndex = 32;
            this.adminPassword.Click += new System.EventHandler(this.adminPassword_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Admin Email: ";
            // 
            // adminEmail
            // 
            this.adminEmail.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminEmail.Location = new System.Drawing.Point(63, 210);
            this.adminEmail.MaxLength = 500;
            this.adminEmail.Name = "adminEmail";
            this.adminEmail.Size = new System.Drawing.Size(384, 30);
            this.adminEmail.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Admin Username: ";
            // 
            // adminUsername
            // 
            this.adminUsername.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUsername.Location = new System.Drawing.Point(114, 298);
            this.adminUsername.Name = "adminUsername";
            this.adminUsername.Size = new System.Drawing.Size(332, 30);
            this.adminUsername.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Name: ";
            // 
            // lblSelectedAdminID
            // 
            this.lblSelectedAdminID.AutoSize = true;
            this.lblSelectedAdminID.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedAdminID.Location = new System.Drawing.Point(207, 48);
            this.lblSelectedAdminID.Name = "lblSelectedAdminID";
            this.lblSelectedAdminID.Size = new System.Drawing.Size(30, 22);
            this.lblSelectedAdminID.TabIndex = 26;
            this.lblSelectedAdminID.Text = "00";
            this.lblSelectedAdminID.Click += new System.EventHandler(this.lblSelectedAdminID_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn.Location = new System.Drawing.Point(62, 458);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(384, 50);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Selected Admin ID: ";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.deleteBtn.FlatAppearance.BorderSize = 3;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.deleteBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.deleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteBtn.IconSize = 30;
            this.deleteBtn.Location = new System.Drawing.Point(264, 523);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(182, 58);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.updateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateBtn.Location = new System.Drawing.Point(62, 523);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(184, 58);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // adminName
            // 
            this.adminName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminName.Location = new System.Drawing.Point(63, 133);
            this.adminName.Name = "adminName";
            this.adminName.Size = new System.Drawing.Size(384, 30);
            this.adminName.TabIndex = 1;
            // 
            // adminDataTable
            // 
            this.adminDataTable.AllowUserToAddRows = false;
            this.adminDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.adminDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.adminDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.adminDataTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.adminDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.adminDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.adminDataTable.Location = new System.Drawing.Point(597, 71);
            this.adminDataTable.Name = "adminDataTable";
            this.adminDataTable.ReadOnly = true;
            this.adminDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminDataTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.adminDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.adminDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adminDataTable.Size = new System.Drawing.Size(593, 595);
            this.adminDataTable.TabIndex = 40;
            this.adminDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminDataTable_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "ADM - ";
            // 
            // Admin_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 726);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.adminDataTable);
            this.Name = "Admin_Manage";
            this.Text = "Admin_Manage";
            this.Load += new System.EventHandler(this.Admin_Manage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adminPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adminEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adminUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectedAdminID;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox adminName;
        private System.Windows.Forms.DataGridView adminDataTable;
        private System.Windows.Forms.Label label3;
    }
}