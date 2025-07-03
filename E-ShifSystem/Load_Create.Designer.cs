namespace E_ShifSystem
{
    partial class Load_Create
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
            this.label1 = new System.Windows.Forms.Label();
            this.goodBox = new System.Windows.Forms.ComboBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.jobBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.loadDataTable = new System.Windows.Forms.DataGridView();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quantityBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.goodBox);
            this.groupBox1.Controls.Add(this.resetBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.jobBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1147, 226);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Load";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 57);
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
            this.goodBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.goodBox.Location = new System.Drawing.Point(432, 82);
            this.goodBox.Name = "goodBox";
            this.goodBox.Size = new System.Drawing.Size(360, 30);
            this.goodBox.TabIndex = 14;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.resetBtn.FlatAppearance.BorderSize = 2;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.resetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.resetBtn.Location = new System.Drawing.Point(846, 120);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(234, 55);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn.Location = new System.Drawing.Point(846, 59);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(234, 55);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Job: ";
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
            this.jobBox.Location = new System.Drawing.Point(53, 82);
            this.jobBox.Name = "jobBox";
            this.jobBox.Size = new System.Drawing.Size(360, 30);
            this.jobBox.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loadDataTable);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.searchBar);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.Location = new System.Drawing.Point(20, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1185, 306);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(934, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Search for Load ID";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBtn.IconColor = System.Drawing.Color.White;
            this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBtn.IconSize = 25;
            this.searchBtn.Location = new System.Drawing.Point(958, 183);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(104, 41);
            this.searchBtn.TabIndex = 17;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.searchBar.Location = new System.Drawing.Point(854, 147);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(301, 30);
            this.searchBar.TabIndex = 15;
            this.searchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loadDataTable
            // 
            this.loadDataTable.AllowUserToAddRows = false;
            this.loadDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loadDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.loadDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.loadDataTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.loadDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loadDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.loadDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.loadDataTable.Location = new System.Drawing.Point(17, 39);
            this.loadDataTable.Name = "loadDataTable";
            this.loadDataTable.ReadOnly = true;
            this.loadDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loadDataTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.loadDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.loadDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loadDataTable.Size = new System.Drawing.Size(801, 252);
            this.loadDataTable.TabIndex = 41;
            // 
            // quantityBox
            // 
            this.quantityBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.quantityBox.Location = new System.Drawing.Point(255, 159);
            this.quantityBox.MaxLength = 10;
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(360, 30);
            this.quantityBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Quantity";
            // 
            // Load_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 617);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Load_Create";
            this.Text = "New Laod";
            this.Load += new System.EventHandler(this.Load_Create_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox jobBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox goodBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton searchBtn;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.DataGridView loadDataTable;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label label2;
    }
}