namespace E_ShifSystem
{
    partial class Payment_Manage
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
            this.lblSelectedPayID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deletBtn = new FontAwesome.Sharp.IconButton();
            this.updateBtn = new FontAwesome.Sharp.IconButton();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.printBillBtn = new FontAwesome.Sharp.IconButton();
            this.payDataTable = new System.Windows.Forms.DataGridView();
            this.lblJobID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.payDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectedPayID
            // 
            this.lblSelectedPayID.AutoSize = true;
            this.lblSelectedPayID.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedPayID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.lblSelectedPayID.Location = new System.Drawing.Point(757, 34);
            this.lblSelectedPayID.Name = "lblSelectedPayID";
            this.lblSelectedPayID.Size = new System.Drawing.Size(36, 28);
            this.lblSelectedPayID.TabIndex = 34;
            this.lblSelectedPayID.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(541, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 28);
            this.label4.TabIndex = 33;
            this.label4.Text = "Selected Payment ID: ";
            // 
            // deletBtn
            // 
            this.deletBtn.BackColor = System.Drawing.Color.Transparent;
            this.deletBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.deletBtn.FlatAppearance.BorderSize = 3;
            this.deletBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.deletBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.deletBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.deletBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.deletBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deletBtn.IconSize = 30;
            this.deletBtn.Location = new System.Drawing.Point(962, 286);
            this.deletBtn.Name = "deletBtn";
            this.deletBtn.Size = new System.Drawing.Size(234, 58);
            this.deletBtn.TabIndex = 31;
            this.deletBtn.Text = "Delete";
            this.deletBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deletBtn.UseVisualStyleBackColor = false;
            this.deletBtn.Click += new System.EventHandler(this.deletBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.updateBtn.IconColor = System.Drawing.Color.White;
            this.updateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateBtn.IconSize = 30;
            this.updateBtn.Location = new System.Drawing.Point(962, 214);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(234, 58);
            this.updateBtn.TabIndex = 30;
            this.updateBtn.Text = "Update";
            this.updateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Squada One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBtn.IconColor = System.Drawing.Color.White;
            this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBtn.IconSize = 20;
            this.searchBtn.Location = new System.Drawing.Point(408, 31);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(81, 30);
            this.searchBtn.TabIndex = 29;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.searchBox.Location = new System.Drawing.Point(101, 31);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(301, 30);
            this.searchBox.TabIndex = 28;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // printBillBtn
            // 
            this.printBillBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.printBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBillBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.printBillBtn.ForeColor = System.Drawing.Color.White;
            this.printBillBtn.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.printBillBtn.IconColor = System.Drawing.Color.White;
            this.printBillBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.printBillBtn.IconSize = 30;
            this.printBillBtn.Location = new System.Drawing.Point(962, 361);
            this.printBillBtn.Name = "printBillBtn";
            this.printBillBtn.Size = new System.Drawing.Size(234, 58);
            this.printBillBtn.TabIndex = 35;
            this.printBillBtn.Text = "Generate Bill";
            this.printBillBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printBillBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.printBillBtn.UseVisualStyleBackColor = false;
            this.printBillBtn.Click += new System.EventHandler(this.printBillBtn_Click);
            // 
            // payDataTable
            // 
            this.payDataTable.AllowUserToAddRows = false;
            this.payDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.payDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.payDataTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.payDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.payDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.payDataTable.Location = new System.Drawing.Point(25, 78);
            this.payDataTable.Name = "payDataTable";
            this.payDataTable.ReadOnly = true;
            this.payDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payDataTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.payDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.payDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payDataTable.Size = new System.Drawing.Size(903, 513);
            this.payDataTable.TabIndex = 39;
            this.payDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payDataTable_CellDoubleClick);
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.lblJobID.Location = new System.Drawing.Point(990, 35);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(36, 28);
            this.lblJobID.TabIndex = 41;
            this.lblJobID.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(824, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 28);
            this.label2.TabIndex = 40;
            this.label2.Text = "Selected Job ID: ";
            // 
            // Payment_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 617);
            this.Controls.Add(this.lblJobID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.payDataTable);
            this.Controls.Add(this.printBillBtn);
            this.Controls.Add(this.lblSelectedPayID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deletBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchBox);
            this.Name = "Payment_Manage";
            this.Text = "Payment_Manage";
            this.Load += new System.EventHandler(this.Payment_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectedPayID;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton deletBtn;
        private FontAwesome.Sharp.IconButton updateBtn;
        private FontAwesome.Sharp.IconButton searchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private FontAwesome.Sharp.IconButton printBillBtn;
        private System.Windows.Forms.DataGridView payDataTable;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.Label label2;
    }
}