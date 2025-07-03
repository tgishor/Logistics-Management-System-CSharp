namespace E_ShifSystem
{
    partial class Payment_Create
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
            this.label4 = new System.Windows.Forms.Label();
            this.jobBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRemainAmount = new System.Windows.Forms.Label();
            this.lblTotalPayAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.payBtn = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.payTypeBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.finalPayBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.payDataTable = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Job ID: ";
            // 
            // jobBox
            // 
            this.jobBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jobBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.jobBox.FormattingEnabled = true;
            this.jobBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.jobBox.Location = new System.Drawing.Point(35, 68);
            this.jobBox.Name = "jobBox";
            this.jobBox.Size = new System.Drawing.Size(360, 30);
            this.jobBox.TabIndex = 7;
            this.jobBox.SelectedIndexChanged += new System.EventHandler(this.jobBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRemainAmount);
            this.groupBox1.Controls.Add(this.lblTotalPayAmount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.payBtn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.payTypeBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.finalPayBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.resetBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.jobBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1147, 293);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make a Payment";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblRemainAmount
            // 
            this.lblRemainAmount.AutoSize = true;
            this.lblRemainAmount.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainAmount.ForeColor = System.Drawing.Color.Red;
            this.lblRemainAmount.Location = new System.Drawing.Point(664, 164);
            this.lblRemainAmount.Name = "lblRemainAmount";
            this.lblRemainAmount.Size = new System.Drawing.Size(72, 28);
            this.lblRemainAmount.TabIndex = 18;
            this.lblRemainAmount.Text = "00000";
            // 
            // lblTotalPayAmount
            // 
            this.lblTotalPayAmount.AutoSize = true;
            this.lblTotalPayAmount.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayAmount.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblTotalPayAmount.Location = new System.Drawing.Point(638, 119);
            this.lblTotalPayAmount.Name = "lblTotalPayAmount";
            this.lblTotalPayAmount.Size = new System.Drawing.Size(72, 28);
            this.lblTotalPayAmount.TabIndex = 17;
            this.lblTotalPayAmount.Text = "00000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label6.Location = new System.Drawing.Point(602, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 28);
            this.label6.TabIndex = 24;
            this.label6.Text = "Rs. ";
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            this.payBtn.IconColor = System.Drawing.Color.White;
            this.payBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.payBtn.IconSize = 30;
            this.payBtn.Location = new System.Drawing.Point(841, 89);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(234, 58);
            this.payBtn.TabIndex = 23;
            this.payBtn.Text = "Pay";
            this.payBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.payBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "Payment Type: ";
            // 
            // payTypeBox
            // 
            this.payTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.payTypeBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.payTypeBox.FormattingEnabled = true;
            this.payTypeBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.payTypeBox.Location = new System.Drawing.Point(35, 222);
            this.payTypeBox.Name = "payTypeBox";
            this.payTypeBox.Size = new System.Drawing.Size(360, 30);
            this.payTypeBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(457, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Remaining Payment: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Location = new System.Drawing.Point(457, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total Paybale:  ";
            // 
            // finalPayBox
            // 
            this.finalPayBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalPayBox.Location = new System.Drawing.Point(35, 144);
            this.finalPayBox.Name = "finalPayBox";
            this.finalPayBox.Size = new System.Drawing.Size(360, 30);
            this.finalPayBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Payment Amount:  ";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.resetBtn.FlatAppearance.BorderSize = 2;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.resetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.resetBtn.Location = new System.Drawing.Point(841, 158);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(234, 55);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // payDataTable
            // 
            this.payDataTable.AllowUserToAddRows = false;
            this.payDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.payDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.payDataTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.payDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.payDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.payDataTable.Location = new System.Drawing.Point(40, 325);
            this.payDataTable.Name = "payDataTable";
            this.payDataTable.ReadOnly = true;
            this.payDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payDataTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.payDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.payDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payDataTable.Size = new System.Drawing.Size(1147, 264);
            this.payDataTable.TabIndex = 38;
            // 
            // Payment_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 617);
            this.Controls.Add(this.payDataTable);
            this.Controls.Add(this.groupBox1);
            this.Name = "Payment_Create";
            this.Text = "Payment_Create";
            this.Load += new System.EventHandler(this.Payment_Create_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox jobBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox payTypeBox;
        private System.Windows.Forms.Label lblRemainAmount;
        private System.Windows.Forms.Label lblTotalPayAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox finalPayBox;
        private FontAwesome.Sharp.IconButton payBtn;
        private System.Windows.Forms.DataGridView payDataTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button resetBtn;
    }
}