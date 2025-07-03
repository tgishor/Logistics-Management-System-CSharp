namespace E_ShifSystem
{
    partial class Customer_Report
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filterBtn = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jobStatusBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerDataTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_ShifSystem.Properties.Resources.Asset_3;
            this.pictureBox1.Location = new System.Drawing.Point(190, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
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
            this.filterBtn.Location = new System.Drawing.Point(115, 306);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(226, 50);
            this.filterBtn.TabIndex = 60;
            this.filterBtn.Text = "Filter";
            this.filterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filterBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.filterBtn.UseVisualStyleBackColor = false;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.filterBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.jobStatusBox);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(750, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 394);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fliters";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(47, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 30);
            this.textBox1.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(140, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 61;
            this.label3.Text = "Customer Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(192, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 26);
            this.label5.TabIndex = 46;
            this.label5.Text = "City: ";
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
            this.jobStatusBox.Location = new System.Drawing.Point(55, 242);
            this.jobStatusBox.Name = "jobStatusBox";
            this.jobStatusBox.Size = new System.Drawing.Size(351, 30);
            this.jobStatusBox.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Squada One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(266, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 31);
            this.label2.TabIndex = 58;
            this.label2.Text = "Customer Report";
            // 
            // customerDataTable
            // 
            this.customerDataTable.AllowUserToAddRows = false;
            this.customerDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.customerDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.customerDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customerDataTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.customerDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.customerDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.customerDataTable.Location = new System.Drawing.Point(31, 258);
            this.customerDataTable.Name = "customerDataTable";
            this.customerDataTable.ReadOnly = true;
            this.customerDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.customerDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataTable.Size = new System.Drawing.Size(671, 508);
            this.customerDataTable.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(385, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 56;
            this.label1.Text = "15-July-2022";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminName.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdminName.Location = new System.Drawing.Point(193, 211);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(201, 26);
            this.lblAdminName.TabIndex = 55;
            this.lblAdminName.Text = "Report Generated On: ";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(47, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(351, 30);
            this.textBox2.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(119, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 26);
            this.label4.TabIndex = 63;
            this.label4.Text = "Search by Customer ID: ";
            // 
            // Customer_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 795);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerDataTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdminName);
            this.Name = "Customer_Report";
            this.Text = "Customer Report";
            this.Load += new System.EventHandler(this.Customer_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton filterBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView customerDataTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox jobStatusBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}