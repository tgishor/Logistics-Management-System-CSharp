namespace E_ShifSystem
{
    partial class Asstistant_Manage
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectedAssistantID = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.assNameBox = new System.Windows.Forms.TextBox();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.assPhoneBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.assNicBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.assistantDataTable = new System.Windows.Forms.DataGridView();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assistantDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assistant Name: ";
            // 
            // lblSelectedAssistantID
            // 
            this.lblSelectedAssistantID.AutoSize = true;
            this.lblSelectedAssistantID.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedAssistantID.Location = new System.Drawing.Point(237, 52);
            this.lblSelectedAssistantID.Name = "lblSelectedAssistantID";
            this.lblSelectedAssistantID.Size = new System.Drawing.Size(30, 22);
            this.lblSelectedAssistantID.TabIndex = 26;
            this.lblSelectedAssistantID.Text = "00";
            this.lblSelectedAssistantID.Click += new System.EventHandler(this.lblSelectedAssistantID_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn.Location = new System.Drawing.Point(66, 391);
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
            this.label2.Location = new System.Drawing.Point(61, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Selected Assistant ID: ";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.updateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateBtn.Location = new System.Drawing.Point(66, 456);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(184, 58);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // assNameBox
            // 
            this.assNameBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assNameBox.Location = new System.Drawing.Point(66, 121);
            this.assNameBox.Name = "assNameBox";
            this.assNameBox.Size = new System.Drawing.Size(384, 30);
            this.assNameBox.TabIndex = 1;
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.label7);
            this.groupbox1.Controls.Add(this.genderBox);
            this.groupbox1.Controls.Add(this.label5);
            this.groupbox1.Controls.Add(this.assPhoneBox);
            this.groupbox1.Controls.Add(this.label4);
            this.groupbox1.Controls.Add(this.assNicBox);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.lblSelectedAssistantID);
            this.groupbox1.Controls.Add(this.saveBtn);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.deleteBtn);
            this.groupbox1.Controls.Add(this.updateBtn);
            this.groupbox1.Controls.Add(this.assNameBox);
            this.groupbox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupbox1.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox1.Location = new System.Drawing.Point(37, 34);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(535, 543);
            this.groupbox1.TabIndex = 29;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Functions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 22);
            this.label7.TabIndex = 35;
            this.label7.Text = "Assistant Gender: ";
            // 
            // genderBox
            // 
            this.genderBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genderBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.genderBox.Location = new System.Drawing.Point(65, 338);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(384, 30);
            this.genderBox.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Assistant Phone No: ";
            // 
            // assPhoneBox
            // 
            this.assPhoneBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assPhoneBox.Location = new System.Drawing.Point(65, 263);
            this.assPhoneBox.Name = "assPhoneBox";
            this.assPhoneBox.Size = new System.Drawing.Size(384, 30);
            this.assPhoneBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Assistant NIC: ";
            // 
            // assNicBox
            // 
            this.assNicBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assNicBox.Location = new System.Drawing.Point(66, 190);
            this.assNicBox.Name = "assNicBox";
            this.assNicBox.Size = new System.Drawing.Size(384, 30);
            this.assNicBox.TabIndex = 28;
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
            this.deleteBtn.Location = new System.Drawing.Point(268, 456);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(182, 58);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // assistantDataTable
            // 
            this.assistantDataTable.AllowUserToAddRows = false;
            this.assistantDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.assistantDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.assistantDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.assistantDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.assistantDataTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.assistantDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.assistantDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.assistantDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assistantDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.assistantDataTable.Location = new System.Drawing.Point(603, 44);
            this.assistantDataTable.Name = "assistantDataTable";
            this.assistantDataTable.ReadOnly = true;
            this.assistantDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.assistantDataTable.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.assistantDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.assistantDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assistantDataTable.Size = new System.Drawing.Size(598, 533);
            this.assistantDataTable.TabIndex = 37;
            this.assistantDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assistantDataTable_CellDoubleClick);
            // 
            // Asstistant_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 617);
            this.Controls.Add(this.assistantDataTable);
            this.Controls.Add(this.groupbox1);
            this.Name = "Asstistant_Manage";
            this.Text = "Manage Assistant";
            this.Load += new System.EventHandler(this.Asstistant_Manage_Load);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assistantDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectedAssistantID;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox assNameBox;
        private System.Windows.Forms.GroupBox groupbox1;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox assNicBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox assPhoneBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.DataGridView assistantDataTable;
    }
}