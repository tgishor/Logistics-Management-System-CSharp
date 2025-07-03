namespace E_ShifSystem
{
    partial class Job_Manage
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
            this.lblSelectedJobID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.generateReportBtn = new FontAwesome.Sharp.IconButton();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.updateBtn = new FontAwesome.Sharp.IconButton();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.jobDataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectedJobID
            // 
            this.lblSelectedJobID.AutoSize = true;
            this.lblSelectedJobID.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedJobID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.lblSelectedJobID.Location = new System.Drawing.Point(709, 33);
            this.lblSelectedJobID.Name = "lblSelectedJobID";
            this.lblSelectedJobID.Size = new System.Drawing.Size(36, 28);
            this.lblSelectedJobID.TabIndex = 34;
            this.lblSelectedJobID.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(541, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 28);
            this.label4.TabIndex = 33;
            this.label4.Text = "Selected Job ID: ";
            // 
            // generateReportBtn
            // 
            this.generateReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.generateReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateReportBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.generateReportBtn.ForeColor = System.Drawing.Color.White;
            this.generateReportBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.generateReportBtn.IconColor = System.Drawing.Color.White;
            this.generateReportBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.generateReportBtn.IconSize = 30;
            this.generateReportBtn.Location = new System.Drawing.Point(962, 363);
            this.generateReportBtn.Name = "generateReportBtn";
            this.generateReportBtn.Size = new System.Drawing.Size(234, 58);
            this.generateReportBtn.TabIndex = 32;
            this.generateReportBtn.Text = "Generate Report";
            this.generateReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generateReportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.generateReportBtn.UseVisualStyleBackColor = false;
            this.generateReportBtn.Click += new System.EventHandler(this.generateReportBtn_Click);
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
            this.deleteBtn.Location = new System.Drawing.Point(962, 284);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(234, 58);
            this.deleteBtn.TabIndex = 31;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.updateBtn.Location = new System.Drawing.Point(962, 209);
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
            // 
            // jobDataTable
            // 
            this.jobDataTable.AllowUserToAddRows = false;
            this.jobDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.jobDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jobDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.jobDataTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.jobDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.jobDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.jobDataTable.Location = new System.Drawing.Point(30, 81);
            this.jobDataTable.Name = "jobDataTable";
            this.jobDataTable.ReadOnly = true;
            this.jobDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.jobDataTable.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobDataTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.jobDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.jobDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jobDataTable.Size = new System.Drawing.Size(903, 513);
            this.jobDataTable.TabIndex = 40;
            this.jobDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jobDataTable_CellDoubleClick);
            // 
            // Job_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 617);
            this.Controls.Add(this.jobDataTable);
            this.Controls.Add(this.lblSelectedJobID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.generateReportBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchBox);
            this.Name = "Job_Manage";
            this.Text = "Manage Job";
            this.Load += new System.EventHandler(this.Job_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectedJobID;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton generateReportBtn;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private FontAwesome.Sharp.IconButton updateBtn;
        private FontAwesome.Sharp.IconButton searchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView jobDataTable;
    }
}