namespace E_ShifSystem
{
    partial class customer_create
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.nicBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.e_ShiftSystemDataSet = new E_ShifSystem.E_ShiftSystemDataSet();
            this.eShiftSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cusEmailBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cusDataTable = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_ShiftSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShiftSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(25, 60);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(360, 30);
            this.nameBox.TabIndex = 1;
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.phoneBox.Location = new System.Drawing.Point(25, 144);
            this.phoneBox.MaxLength = 10;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(360, 30);
            this.phoneBox.TabIndex = 3;
            this.phoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone No:";
            // 
            // addBox
            // 
            this.addBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.addBox.Location = new System.Drawing.Point(437, 60);
            this.addBox.Multiline = true;
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(360, 114);
            this.addBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "City: ";
            // 
            // cityBox
            // 
            this.cityBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cityBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.cityBox.Location = new System.Drawing.Point(437, 223);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(360, 30);
            this.cityBox.TabIndex = 7;
            // 
            // nicBox
            // 
            this.nicBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.nicBox.Location = new System.Drawing.Point(25, 223);
            this.nicBox.Name = "nicBox";
            this.nicBox.Size = new System.Drawing.Size(360, 30);
            this.nicBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "National ID:";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn.Location = new System.Drawing.Point(853, 119);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(234, 55);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cusEmailBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.resetBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.phoneBox);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addBox);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nicBox);
            this.groupBox1.Controls.Add(this.cityBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1147, 336);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Customer";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.resetBtn.FlatAppearance.BorderSize = 2;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.resetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.resetBtn.Location = new System.Drawing.Point(853, 180);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(234, 55);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Street: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cusDataTable);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.searchBox);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.Location = new System.Drawing.Point(18, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1185, 299);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(901, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Search for Customer Name";
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
            this.searchBtn.Location = new System.Drawing.Point(958, 169);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(104, 41);
            this.searchBtn.TabIndex = 17;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.searchBox.Location = new System.Drawing.Point(854, 133);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(301, 30);
            this.searchBox.TabIndex = 15;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // e_ShiftSystemDataSet
            // 
            this.e_ShiftSystemDataSet.DataSetName = "E_ShiftSystemDataSet";
            this.e_ShiftSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eShiftSystemDataSetBindingSource
            // 
            this.eShiftSystemDataSetBindingSource.DataSource = this.e_ShiftSystemDataSet;
            this.eShiftSystemDataSetBindingSource.Position = 0;
            // 
            // cusEmailBox
            // 
            this.cusEmailBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.cusEmailBox.Location = new System.Drawing.Point(258, 290);
            this.cusEmailBox.Name = "cusEmailBox";
            this.cusEmailBox.Size = new System.Drawing.Size(360, 30);
            this.cusEmailBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(254, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email:";
            // 
            // cusDataTable
            // 
            this.cusDataTable.AllowUserToAddRows = false;
            this.cusDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cusDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.cusDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cusDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.cusDataTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.cusDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Quicksand", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cusDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.cusDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Quicksand", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cusDataTable.DefaultCellStyle = dataGridViewCellStyle7;
            this.cusDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.cusDataTable.Location = new System.Drawing.Point(23, 29);
            this.cusDataTable.Name = "cusDataTable";
            this.cusDataTable.ReadOnly = true;
            this.cusDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cusDataTable.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.cusDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cusDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cusDataTable.Size = new System.Drawing.Size(810, 264);
            this.cusDataTable.TabIndex = 40;
            this.cusDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payDataTable_CellContentClick);
            // 
            // customer_create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 669);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "customer_create";
            this.Text = "Create Customer";
            this.Load += new System.EventHandler(this.customer_create_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_ShiftSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShiftSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.TextBox nicBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton searchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.BindingSource eShiftSystemDataSetBindingSource;
        private E_ShiftSystemDataSet e_ShiftSystemDataSet;
        private System.Windows.Forms.TextBox cusEmailBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView cusDataTable;
    }
}