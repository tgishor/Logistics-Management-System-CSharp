namespace E_ShifSystem
{
    partial class Lorry_Manage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lorryNumBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lorryTypeBox = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSelectedLorryID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.lorryDataTable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lorryNameBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lorryDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lorryNumBox
            // 
            this.lorryNumBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lorryNumBox.Location = new System.Drawing.Point(65, 205);
            this.lorryNumBox.Name = "lorryNumBox";
            this.lorryNumBox.Size = new System.Drawing.Size(384, 30);
            this.lorryNumBox.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn.Location = new System.Drawing.Point(65, 352);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(384, 50);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lorry Number: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lorry Type: ";
            // 
            // lorryTypeBox
            // 
            this.lorryTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lorryTypeBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.lorryTypeBox.FormattingEnabled = true;
            this.lorryTypeBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.lorryTypeBox.Location = new System.Drawing.Point(65, 285);
            this.lorryTypeBox.Name = "lorryTypeBox";
            this.lorryTypeBox.Size = new System.Drawing.Size(384, 30);
            this.lorryTypeBox.TabIndex = 7;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.updateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateBtn.Location = new System.Drawing.Point(65, 417);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(184, 58);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Selected Lorry ID: ";
            // 
            // lblSelectedLorryID
            // 
            this.lblSelectedLorryID.AutoSize = true;
            this.lblSelectedLorryID.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedLorryID.Location = new System.Drawing.Point(201, 68);
            this.lblSelectedLorryID.Name = "lblSelectedLorryID";
            this.lblSelectedLorryID.Size = new System.Drawing.Size(30, 22);
            this.lblSelectedLorryID.TabIndex = 26;
            this.lblSelectedLorryID.Text = "00";
            this.lblSelectedLorryID.Click += new System.EventHandler(this.lblSelectedLorryID_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lorryNameBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSelectedLorryID);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.lorryTypeBox);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.lorryNumBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 528);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
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
            this.deleteBtn.Location = new System.Drawing.Point(267, 417);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(182, 58);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // lorryDataTable
            // 
            this.lorryDataTable.AllowUserToAddRows = false;
            this.lorryDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lorryDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.lorryDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lorryDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.lorryDataTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.lorryDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lorryDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.lorryDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lorryDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.lorryDataTable.Location = new System.Drawing.Point(592, 67);
            this.lorryDataTable.Name = "lorryDataTable";
            this.lorryDataTable.ReadOnly = true;
            this.lorryDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lorryDataTable.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.lorryDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lorryDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lorryDataTable.Size = new System.Drawing.Size(598, 481);
            this.lorryDataTable.TabIndex = 38;
            this.lorryDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lorryDataTable_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Lorry Name: ";
            // 
            // lorryNameBox
            // 
            this.lorryNameBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lorryNameBox.Location = new System.Drawing.Point(65, 137);
            this.lorryNameBox.Name = "lorryNameBox";
            this.lorryNameBox.Size = new System.Drawing.Size(384, 30);
            this.lorryNameBox.TabIndex = 28;
            // 
            // Lorry_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 617);
            this.Controls.Add(this.lorryDataTable);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lorry_Manage";
            this.Text = "Lorry_Manage";
            this.Load += new System.EventHandler(this.Lorry_Manage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lorryDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox lorryNumBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lorryTypeBox;
        private System.Windows.Forms.Button updateBtn;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelectedLorryID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView lorryDataTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lorryNameBox;
    }
}