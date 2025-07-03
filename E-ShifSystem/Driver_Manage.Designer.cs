namespace E_ShifSystem
{
    partial class Driver_Manage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectedDriverID = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.driNameBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.driLicenseNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.driPhoneNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.driNIC = new System.Windows.Forms.TextBox();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.driverDataTable = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driver Name: ";
            // 
            // lblSelectedDriverID
            // 
            this.lblSelectedDriverID.AutoSize = true;
            this.lblSelectedDriverID.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDriverID.Location = new System.Drawing.Point(207, 48);
            this.lblSelectedDriverID.Name = "lblSelectedDriverID";
            this.lblSelectedDriverID.Size = new System.Drawing.Size(30, 22);
            this.lblSelectedDriverID.TabIndex = 26;
            this.lblSelectedDriverID.Text = "00";
            this.lblSelectedDriverID.Click += new System.EventHandler(this.lblSelectedDriverID_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn.Location = new System.Drawing.Point(62, 469);
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
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Selected Driver ID: ";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.updateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateBtn.Location = new System.Drawing.Point(62, 534);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(184, 58);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // driNameBox
            // 
            this.driNameBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driNameBox.Location = new System.Drawing.Point(65, 119);
            this.driNameBox.Name = "driNameBox";
            this.driNameBox.Size = new System.Drawing.Size(384, 30);
            this.driNameBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.genderBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.driLicenseNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.driPhoneNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.driNIC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSelectedDriverID);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.driNameBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 605);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Driver Gender: ";
            // 
            // genderBox
            // 
            this.genderBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genderBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.genderBox.Location = new System.Drawing.Point(62, 415);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(384, 30);
            this.genderBox.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "Driver License No: ";
            // 
            // driLicenseNo
            // 
            this.driLicenseNo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driLicenseNo.Location = new System.Drawing.Point(65, 343);
            this.driLicenseNo.Name = "driLicenseNo";
            this.driLicenseNo.Size = new System.Drawing.Size(384, 30);
            this.driLicenseNo.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Driver Phone No: ";
            // 
            // driPhoneNo
            // 
            this.driPhoneNo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driPhoneNo.Location = new System.Drawing.Point(65, 195);
            this.driPhoneNo.MaxLength = 10;
            this.driPhoneNo.Name = "driPhoneNo";
            this.driPhoneNo.Size = new System.Drawing.Size(384, 30);
            this.driPhoneNo.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Driver NIC: ";
            // 
            // driNIC
            // 
            this.driNIC.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driNIC.Location = new System.Drawing.Point(65, 268);
            this.driNIC.Name = "driNIC";
            this.driNIC.Size = new System.Drawing.Size(384, 30);
            this.driNIC.TabIndex = 28;
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
            this.deleteBtn.Location = new System.Drawing.Point(264, 534);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(182, 58);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // driverDataTable
            // 
            this.driverDataTable.AllowUserToAddRows = false;
            this.driverDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.driverDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.driverDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.driverDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.driverDataTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.driverDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.driverDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.driverDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driverDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.driverDataTable.Location = new System.Drawing.Point(596, 25);
            this.driverDataTable.Name = "driverDataTable";
            this.driverDataTable.ReadOnly = true;
            this.driverDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.driverDataTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.driverDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.driverDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.driverDataTable.Size = new System.Drawing.Size(593, 595);
            this.driverDataTable.TabIndex = 38;
            this.driverDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.driverDataTable_CellDoubleClick);
            // 
            // Driver_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 634);
            this.Controls.Add(this.driverDataTable);
            this.Controls.Add(this.groupBox1);
            this.Name = "Driver_Manage";
            this.Text = "Manage Driver";
            this.Load += new System.EventHandler(this.Driver_Manage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectedDriverID;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox driNameBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox driLicenseNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox driPhoneNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox driNIC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.DataGridView driverDataTable;
    }
}