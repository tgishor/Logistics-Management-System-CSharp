namespace E_ShifSystem
{
    partial class TransportUnit_Create
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
            this.label3 = new System.Windows.Forms.Label();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.transportUnitDataTable = new System.Windows.Forms.DataGridView();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.containerBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.assistantBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.driverBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lorryBox = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportUnitDataTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(895, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Search for Transport Unit ID";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.transportUnitDataTable);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.searchBar);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.Location = new System.Drawing.Point(20, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1185, 299);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Area";
            // 
            // transportUnitDataTable
            // 
            this.transportUnitDataTable.AllowUserToAddRows = false;
            this.transportUnitDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transportUnitDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.transportUnitDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.transportUnitDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.transportUnitDataTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.transportUnitDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transportUnitDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.transportUnitDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transportUnitDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.transportUnitDataTable.Location = new System.Drawing.Point(20, 30);
            this.transportUnitDataTable.Name = "transportUnitDataTable";
            this.transportUnitDataTable.ReadOnly = true;
            this.transportUnitDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transportUnitDataTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.transportUnitDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.transportUnitDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transportUnitDataTable.Size = new System.Drawing.Size(789, 253);
            this.transportUnitDataTable.TabIndex = 38;
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.searchBar.Location = new System.Drawing.Point(854, 133);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(301, 30);
            this.searchBar.TabIndex = 15;
            this.searchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.resetBtn.FlatAppearance.BorderSize = 2;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.resetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.resetBtn.Location = new System.Drawing.Point(856, 164);
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
            this.saveBtn.Location = new System.Drawing.Point(856, 103);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(234, 55);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.descBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.containerBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.assistantBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.driverBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lorryBox);
            this.groupBox1.Controls.Add(this.resetBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1147, 293);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Transport Unit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Description: ";
            // 
            // descBox
            // 
            this.descBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.descBox.Location = new System.Drawing.Point(24, 209);
            this.descBox.Multiline = true;
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(765, 67);
            this.descBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Select the Container: ";
            // 
            // containerBox
            // 
            this.containerBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.containerBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.containerBox.FormattingEnabled = true;
            this.containerBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.containerBox.Location = new System.Drawing.Point(429, 78);
            this.containerBox.Name = "containerBox";
            this.containerBox.Size = new System.Drawing.Size(360, 30);
            this.containerBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Select the Assistant: ";
            // 
            // assistantBox
            // 
            this.assistantBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.assistantBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.assistantBox.FormattingEnabled = true;
            this.assistantBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.assistantBox.Location = new System.Drawing.Point(429, 144);
            this.assistantBox.Name = "assistantBox";
            this.assistantBox.Size = new System.Drawing.Size(360, 30);
            this.assistantBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select the Driver: ";
            // 
            // driverBox
            // 
            this.driverBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.driverBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.driverBox.FormattingEnabled = true;
            this.driverBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.driverBox.Location = new System.Drawing.Point(24, 144);
            this.driverBox.Name = "driverBox";
            this.driverBox.Size = new System.Drawing.Size(360, 30);
            this.driverBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select the Lorry: ";
            // 
            // lorryBox
            // 
            this.lorryBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lorryBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.lorryBox.FormattingEnabled = true;
            this.lorryBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.lorryBox.Location = new System.Drawing.Point(24, 78);
            this.lorryBox.Name = "lorryBox";
            this.lorryBox.Size = new System.Drawing.Size(360, 30);
            this.lorryBox.TabIndex = 14;
            // 
            // TransportUnit_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 617);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TransportUnit_Create";
            this.Text = "Create Transport Unit";
            this.Load += new System.EventHandler(this.TransportUnit_Create_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportUnitDataTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton searchBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox containerBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox assistantBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox driverBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lorryBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.DataGridView transportUnitDataTable;
    }
}