namespace E_ShifSystem
{
    partial class Job_Report
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblReportGenDate = new System.Windows.Forms.Label();
            this.jobDataTable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.regDateStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.regDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.jobStatusBox = new System.Windows.Forms.ComboBox();
            this.trackJobBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxfilterByDate = new System.Windows.Forms.RadioButton();
            this.checkBoxfilterByAll = new System.Windows.Forms.RadioButton();
            this.filterBtn = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.pickUpStart = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.pickUpEnd = new System.Windows.Forms.DateTimePicker();
            this.cusNamBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_ShifSystem.Properties.Resources.Asset_3;
            this.pictureBox1.Location = new System.Drawing.Point(191, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminName.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdminName.Location = new System.Drawing.Point(194, 211);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(201, 26);
            this.lblAdminName.TabIndex = 3;
            this.lblAdminName.Text = "Report Generated On: ";
            // 
            // lblReportGenDate
            // 
            this.lblReportGenDate.AutoSize = true;
            this.lblReportGenDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReportGenDate.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportGenDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReportGenDate.Location = new System.Drawing.Point(386, 212);
            this.lblReportGenDate.Name = "lblReportGenDate";
            this.lblReportGenDate.Size = new System.Drawing.Size(132, 26);
            this.lblReportGenDate.TabIndex = 4;
            this.lblReportGenDate.Text = "15-July-2022";
            // 
            // jobDataTable
            // 
            this.jobDataTable.AllowUserToAddRows = false;
            this.jobDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.jobDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.jobDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.jobDataTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.jobDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.jobDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.jobDataTable.Location = new System.Drawing.Point(32, 258);
            this.jobDataTable.Name = "jobDataTable";
            this.jobDataTable.ReadOnly = true;
            this.jobDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobDataTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.jobDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.jobDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jobDataTable.Size = new System.Drawing.Size(671, 508);
            this.jobDataTable.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Squada One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(294, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 31);
            this.label2.TabIndex = 41;
            this.label2.Text = "Job Report";
            // 
            // regDateStart
            // 
            this.regDateStart.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.regDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.regDateStart.Location = new System.Drawing.Point(11, 162);
            this.regDateStart.Name = "regDateStart";
            this.regDateStart.Size = new System.Drawing.Size(183, 30);
            this.regDateStart.TabIndex = 42;
            this.regDateStart.Value = new System.DateTime(2022, 7, 10, 16, 30, 41, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(115, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 26);
            this.label3.TabIndex = 43;
            this.label3.Text = "Jobs Registered Between";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(200, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "and";
            // 
            // regDateEnd
            // 
            this.regDateEnd.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.regDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.regDateEnd.Location = new System.Drawing.Point(242, 162);
            this.regDateEnd.Name = "regDateEnd";
            this.regDateEnd.Size = new System.Drawing.Size(183, 30);
            this.regDateEnd.TabIndex = 45;
            this.regDateEnd.Value = new System.DateTime(2022, 7, 10, 16, 30, 41, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(155, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 26);
            this.label5.TabIndex = 46;
            this.label5.Text = "Jobs Status: ";
            // 
            // jobStatusBox
            // 
            this.jobStatusBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jobStatusBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.jobStatusBox.FormattingEnabled = true;
            this.jobStatusBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.jobStatusBox.Location = new System.Drawing.Point(48, 343);
            this.jobStatusBox.Name = "jobStatusBox";
            this.jobStatusBox.Size = new System.Drawing.Size(351, 30);
            this.jobStatusBox.TabIndex = 47;
            // 
            // trackJobBox
            // 
            this.trackJobBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.trackJobBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.trackJobBox.FormattingEnabled = true;
            this.trackJobBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.trackJobBox.Location = new System.Drawing.Point(48, 435);
            this.trackJobBox.Name = "trackJobBox";
            this.trackJobBox.Size = new System.Drawing.Size(351, 30);
            this.trackJobBox.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(139, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 26);
            this.label6.TabIndex = 48;
            this.label6.Text = "Tracking Status: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.Reset);
            this.groupBox1.Controls.Add(this.checkBoxfilterByDate);
            this.groupBox1.Controls.Add(this.checkBoxfilterByAll);
            this.groupBox1.Controls.Add(this.filterBtn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pickUpStart);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pickUpEnd);
            this.groupBox1.Controls.Add(this.cusNamBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.regDateStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.regDateEnd);
            this.groupBox1.Controls.Add(this.trackJobBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.jobStatusBox);
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(745, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 718);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fliters";
            // 
            // checkBoxfilterByDate
            // 
            this.checkBoxfilterByDate.AutoSize = true;
            this.checkBoxfilterByDate.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.checkBoxfilterByDate.Location = new System.Drawing.Point(242, 56);
            this.checkBoxfilterByDate.Name = "checkBoxfilterByDate";
            this.checkBoxfilterByDate.Size = new System.Drawing.Size(85, 26);
            this.checkBoxfilterByDate.TabIndex = 62;
            this.checkBoxfilterByDate.TabStop = true;
            this.checkBoxfilterByDate.Text = "By Date";
            this.checkBoxfilterByDate.UseVisualStyleBackColor = true;
            // 
            // checkBoxfilterByAll
            // 
            this.checkBoxfilterByAll.AutoSize = true;
            this.checkBoxfilterByAll.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxfilterByAll.Location = new System.Drawing.Point(125, 56);
            this.checkBoxfilterByAll.Name = "checkBoxfilterByAll";
            this.checkBoxfilterByAll.Size = new System.Drawing.Size(71, 26);
            this.checkBoxfilterByAll.TabIndex = 61;
            this.checkBoxfilterByAll.TabStop = true;
            this.checkBoxfilterByAll.Text = "By All";
            this.checkBoxfilterByAll.UseVisualStyleBackColor = true;
            // 
            // filterBtn
            // 
            this.filterBtn.BackColor = System.Drawing.Color.Transparent;
            this.filterBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.filterBtn.FlatAppearance.BorderSize = 2;
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.filterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.filterBtn.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.filterBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.filterBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.filterBtn.IconSize = 30;
            this.filterBtn.Location = new System.Drawing.Point(118, 584);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(226, 50);
            this.filterBtn.TabIndex = 60;
            this.filterBtn.Text = "Filter";
            this.filterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filterBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.filterBtn.UseVisualStyleBackColor = false;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(120, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 26);
            this.label8.TabIndex = 57;
            this.label8.Text = "Jobs Pickup Between";
            // 
            // pickUpStart
            // 
            this.pickUpStart.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.pickUpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickUpStart.Location = new System.Drawing.Point(11, 259);
            this.pickUpStart.Name = "pickUpStart";
            this.pickUpStart.Size = new System.Drawing.Size(183, 30);
            this.pickUpStart.TabIndex = 56;
            this.pickUpStart.Value = new System.DateTime(2022, 7, 10, 16, 30, 41, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Squada One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(199, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 58;
            this.label9.Text = "and";
            // 
            // pickUpEnd
            // 
            this.pickUpEnd.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.pickUpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickUpEnd.Location = new System.Drawing.Point(242, 259);
            this.pickUpEnd.Name = "pickUpEnd";
            this.pickUpEnd.Size = new System.Drawing.Size(183, 30);
            this.pickUpEnd.TabIndex = 59;
            this.pickUpEnd.Value = new System.DateTime(2022, 7, 10, 16, 30, 41, 0);
            // 
            // cusNamBox
            // 
            this.cusNamBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusNamBox.Location = new System.Drawing.Point(49, 524);
            this.cusNamBox.Name = "cusNamBox";
            this.cusNamBox.Size = new System.Drawing.Size(351, 30);
            this.cusNamBox.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(142, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 26);
            this.label7.TabIndex = 53;
            this.label7.Text = "Customer Name: ";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.Reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.Reset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reset.Location = new System.Drawing.Point(152, 640);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(149, 40);
            this.Reset.TabIndex = 63;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Job_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 788);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jobDataTable);
            this.Controls.Add(this.lblReportGenDate);
            this.Controls.Add(this.lblAdminName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Job_Report";
            this.Text = "Job Report";
            this.Load += new System.EventHandler(this.Job_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblReportGenDate;
        private System.Windows.Forms.DataGridView jobDataTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker regDateStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker regDateEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox jobStatusBox;
        private System.Windows.Forms.ComboBox trackJobBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cusNamBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker pickUpStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker pickUpEnd;
        private FontAwesome.Sharp.IconButton filterBtn;
        private System.Windows.Forms.RadioButton checkBoxfilterByDate;
        private System.Windows.Forms.RadioButton checkBoxfilterByAll;
        private System.Windows.Forms.Button Reset;
    }
}