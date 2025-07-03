namespace E_ShifSystem
{
    partial class Goods_Manage
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
            this.goodDataTable = new System.Windows.Forms.DataGridView();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.lblSelectedGoodID = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.goodNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.goodTypeBox = new System.Windows.Forms.ComboBox();
            this.initalAmountBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.goodDataTable)).BeginInit();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // goodDataTable
            // 
            this.goodDataTable.AllowUserToAddRows = false;
            this.goodDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goodDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.goodDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.goodDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.goodDataTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.goodDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goodDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.goodDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.goodDataTable.Location = new System.Drawing.Point(596, 35);
            this.goodDataTable.Name = "goodDataTable";
            this.goodDataTable.ReadOnly = true;
            this.goodDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goodDataTable.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.goodDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.goodDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.goodDataTable.Size = new System.Drawing.Size(598, 542);
            this.goodDataTable.TabIndex = 39;
            this.goodDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goodDataTable_CellDoubleClick);
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.initalAmountBox);
            this.groupbox1.Controls.Add(this.label7);
            this.groupbox1.Controls.Add(this.goodTypeBox);
            this.groupbox1.Controls.Add(this.label6);
            this.groupbox1.Controls.Add(this.goodNameBox);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.lblSelectedGoodID);
            this.groupbox1.Controls.Add(this.saveBtn);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.deleteBtn);
            this.groupbox1.Controls.Add(this.updateBtn);
            this.groupbox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupbox1.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox1.Location = new System.Drawing.Point(30, 25);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(535, 552);
            this.groupbox1.TabIndex = 38;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Functions";
            // 
            // lblSelectedGoodID
            // 
            this.lblSelectedGoodID.AutoSize = true;
            this.lblSelectedGoodID.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedGoodID.Location = new System.Drawing.Point(218, 78);
            this.lblSelectedGoodID.Name = "lblSelectedGoodID";
            this.lblSelectedGoodID.Size = new System.Drawing.Size(30, 22);
            this.lblSelectedGoodID.TabIndex = 26;
            this.lblSelectedGoodID.Text = "00";
            this.lblSelectedGoodID.Click += new System.EventHandler(this.lblSelectedGoodID_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn.Location = new System.Drawing.Point(71, 360);
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
            this.label2.Location = new System.Drawing.Point(67, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Selected Goods ID: ";
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
            this.deleteBtn.Location = new System.Drawing.Point(273, 425);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(182, 58);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.updateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateBtn.Location = new System.Drawing.Point(71, 425);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(184, 58);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Initial Amount";
            // 
            // goodNameBox
            // 
            this.goodNameBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodNameBox.Location = new System.Drawing.Point(71, 144);
            this.goodNameBox.Name = "goodNameBox";
            this.goodNameBox.Size = new System.Drawing.Size(384, 30);
            this.goodNameBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Good Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 37;
            this.label7.Text = "Good Type:";
            // 
            // goodTypeBox
            // 
            this.goodTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goodTypeBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.goodTypeBox.FormattingEnabled = true;
            this.goodTypeBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.goodTypeBox.Location = new System.Drawing.Point(71, 297);
            this.goodTypeBox.Name = "goodTypeBox";
            this.goodTypeBox.Size = new System.Drawing.Size(384, 30);
            this.goodTypeBox.TabIndex = 38;
            // 
            // initalAmountBox
            // 
            this.initalAmountBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initalAmountBox.Location = new System.Drawing.Point(71, 221);
            this.initalAmountBox.Name = "initalAmountBox";
            this.initalAmountBox.Size = new System.Drawing.Size(384, 30);
            this.initalAmountBox.TabIndex = 39;
            // 
            // Goods_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 617);
            this.Controls.Add(this.goodDataTable);
            this.Controls.Add(this.groupbox1);
            this.Name = "Goods_Manage";
            this.Text = "Manage Goods";
            this.Load += new System.EventHandler(this.Goods_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodDataTable)).EndInit();
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView goodDataTable;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Label lblSelectedGoodID;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox goodNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox goodTypeBox;
        private System.Windows.Forms.TextBox initalAmountBox;
    }
}