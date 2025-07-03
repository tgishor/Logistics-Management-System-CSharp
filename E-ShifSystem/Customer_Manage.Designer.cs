namespace E_ShifSystem
{
    partial class Customer_Manage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customerIDLoad = new System.Windows.Forms.Label();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.updateBtn = new FontAwesome.Sharp.IconButton();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.customerDataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.searchBox.Location = new System.Drawing.Point(105, 30);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(301, 30);
            this.searchBox.TabIndex = 18;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(545, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Selected Customer ID: ";
            // 
            // customerIDLoad
            // 
            this.customerIDLoad.AutoSize = true;
            this.customerIDLoad.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.customerIDLoad.Location = new System.Drawing.Point(772, 32);
            this.customerIDLoad.Name = "customerIDLoad";
            this.customerIDLoad.Size = new System.Drawing.Size(36, 28);
            this.customerIDLoad.TabIndex = 26;
            this.customerIDLoad.Text = "00";
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
            this.deleteBtn.Location = new System.Drawing.Point(976, 324);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(234, 58);
            this.deleteBtn.TabIndex = 23;
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
            this.updateBtn.Location = new System.Drawing.Point(976, 249);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(234, 58);
            this.updateBtn.TabIndex = 22;
            this.updateBtn.Text = "Update";
            this.updateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateNavBtn_Click);
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
            this.searchBtn.Location = new System.Drawing.Point(412, 30);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(81, 30);
            this.searchBtn.TabIndex = 19;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // customerDataTable
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customerDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.customerDataTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.customerDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customerDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.customerDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.customerDataTable.Location = new System.Drawing.Point(26, 84);
            this.customerDataTable.Name = "customerDataTable";
            this.customerDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.customerDataTable.Size = new System.Drawing.Size(925, 505);
            this.customerDataTable.TabIndex = 27;
            this.customerDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataTable_CellDoubleClick);
            // 
            // Customer_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 617);
            this.Controls.Add(this.customerDataTable);
            this.Controls.Add(this.customerIDLoad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchBox);
            this.Name = "Customer_Manage";
            this.Text = "Manage Customer ";
            this.Load += new System.EventHandler(this.Customer_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton searchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private FontAwesome.Sharp.IconButton updateBtn;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label customerIDLoad;
        private System.Windows.Forms.DataGridView customerDataTable;
    }
}