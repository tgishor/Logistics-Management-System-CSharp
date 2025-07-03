namespace E_ShifSystem
{
    partial class JobContinuedLoadPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBtn = new FontAwesome.Sharp.IconButton();
            this.removeBtn = new FontAwesome.Sharp.IconButton();
            this.holdBtn = new FontAwesome.Sharp.IconButton();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.proceedBtn = new FontAwesome.Sharp.IconButton();
            this.lblSelectedJobID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goodBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loadDataTable = new System.Windows.Forms.DataGridView();
            this.lblSelectedLoadID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSelectedLoadID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.removeBtn);
            this.groupBox1.Controls.Add(this.holdBtn);
            this.groupBox1.Controls.Add(this.quantityBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.proceedBtn);
            this.groupBox1.Controls.Add(this.lblSelectedJobID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.goodBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 578);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Loads";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addBtn.IconColor = System.Drawing.Color.White;
            this.addBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addBtn.IconSize = 25;
            this.addBtn.Location = new System.Drawing.Point(62, 293);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(219, 67);
            this.addBtn.TabIndex = 29;
            this.addBtn.Text = "Add";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Red;
            this.removeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.removeBtn.IconColor = System.Drawing.Color.White;
            this.removeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.removeBtn.IconSize = 30;
            this.removeBtn.Location = new System.Drawing.Point(290, 293);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(219, 67);
            this.removeBtn.TabIndex = 28;
            this.removeBtn.Text = "Delete";
            this.removeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // holdBtn
            // 
            this.holdBtn.BackColor = System.Drawing.Color.Transparent;
            this.holdBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.holdBtn.FlatAppearance.BorderSize = 2;
            this.holdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.holdBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.holdBtn.ForeColor = System.Drawing.Color.Red;
            this.holdBtn.IconChar = FontAwesome.Sharp.IconChar.CirclePause;
            this.holdBtn.IconColor = System.Drawing.Color.Red;
            this.holdBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.holdBtn.IconSize = 30;
            this.holdBtn.Location = new System.Drawing.Point(62, 461);
            this.holdBtn.Name = "holdBtn";
            this.holdBtn.Size = new System.Drawing.Size(447, 67);
            this.holdBtn.TabIndex = 25;
            this.holdBtn.Text = "Hold Payment";
            this.holdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.holdBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.holdBtn.UseVisualStyleBackColor = false;
            this.holdBtn.Click += new System.EventHandler(this.holdBtn_Click);
            // 
            // quantityBox
            // 
            this.quantityBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.quantityBox.Location = new System.Drawing.Point(62, 214);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(460, 30);
            this.quantityBox.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "No of Quantity:";
            // 
            // proceedBtn
            // 
            this.proceedBtn.BackColor = System.Drawing.Color.Green;
            this.proceedBtn.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.proceedBtn.FlatAppearance.BorderSize = 0;
            this.proceedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proceedBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.proceedBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.proceedBtn.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            this.proceedBtn.IconColor = System.Drawing.SystemColors.Control;
            this.proceedBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.proceedBtn.IconSize = 30;
            this.proceedBtn.Location = new System.Drawing.Point(62, 375);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(447, 67);
            this.proceedBtn.TabIndex = 24;
            this.proceedBtn.Text = "Proceed to Pay";
            this.proceedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.proceedBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.proceedBtn.UseVisualStyleBackColor = false;
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // lblSelectedJobID
            // 
            this.lblSelectedJobID.AutoSize = true;
            this.lblSelectedJobID.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedJobID.Location = new System.Drawing.Point(227, 50);
            this.lblSelectedJobID.Name = "lblSelectedJobID";
            this.lblSelectedJobID.Size = new System.Drawing.Size(36, 28);
            this.lblSelectedJobID.TabIndex = 15;
            this.lblSelectedJobID.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select The Goods: ";
            // 
            // goodBox
            // 
            this.goodBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goodBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.goodBox.FormattingEnabled = true;
            this.goodBox.Location = new System.Drawing.Point(62, 138);
            this.goodBox.Name = "goodBox";
            this.goodBox.Size = new System.Drawing.Size(460, 30);
            this.goodBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Selected Job ID : ";
            // 
            // loadDataTable
            // 
            this.loadDataTable.AllowUserToAddRows = false;
            this.loadDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loadDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.loadDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.loadDataTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.loadDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loadDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.loadDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.loadDataTable.Location = new System.Drawing.Point(621, 55);
            this.loadDataTable.Name = "loadDataTable";
            this.loadDataTable.ReadOnly = true;
            this.loadDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loadDataTable.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.loadDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.loadDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loadDataTable.Size = new System.Drawing.Size(568, 568);
            this.loadDataTable.TabIndex = 38;
            this.loadDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadDataTable_CellDoubleClick);
            // 
            // lblSelectedLoadID
            // 
            this.lblSelectedLoadID.AutoSize = true;
            this.lblSelectedLoadID.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedLoadID.Location = new System.Drawing.Point(462, 50);
            this.lblSelectedLoadID.Name = "lblSelectedLoadID";
            this.lblSelectedLoadID.Size = new System.Drawing.Size(36, 28);
            this.lblSelectedLoadID.TabIndex = 31;
            this.lblSelectedLoadID.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 28);
            this.label3.TabIndex = 30;
            this.label3.Text = "Selected Load ID : ";
            // 
            // JobContinuedLoadPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 663);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loadDataTable);
            this.Name = "JobContinuedLoadPage";
            this.Text = "Job Added With Job";
            this.Load += new System.EventHandler(this.JobContinuedLoadPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox goodBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSelectedJobID;
        private FontAwesome.Sharp.IconButton proceedBtn;
        private FontAwesome.Sharp.IconButton holdBtn;
        private System.Windows.Forms.DataGridView loadDataTable;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton removeBtn;
        private FontAwesome.Sharp.IconButton addBtn;
        private System.Windows.Forms.Label lblSelectedLoadID;
        private System.Windows.Forms.Label label3;
    }
}