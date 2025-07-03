namespace E_ShifSystem
{
    partial class Load_Manage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSelectedLoad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.removeBtn = new FontAwesome.Sharp.IconButton();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.addBtn = new FontAwesome.Sharp.IconButton();
            this.loadDataTable = new System.Windows.Forms.DataGridView();
            this.updateBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectedLoad
            // 
            this.lblSelectedLoad.AutoSize = true;
            this.lblSelectedLoad.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.lblSelectedLoad.Location = new System.Drawing.Point(725, 33);
            this.lblSelectedLoad.Name = "lblSelectedLoad";
            this.lblSelectedLoad.Size = new System.Drawing.Size(36, 28);
            this.lblSelectedLoad.TabIndex = 34;
            this.lblSelectedLoad.Text = "00";
            this.lblSelectedLoad.Click += new System.EventHandler(this.lblSelectedLoad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(541, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 28);
            this.label4.TabIndex = 33;
            this.label4.Text = "Selected Load ID: ";
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Transparent;
            this.removeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.removeBtn.FlatAppearance.BorderSize = 3;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.removeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.removeBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.removeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.removeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.removeBtn.IconSize = 30;
            this.removeBtn.Location = new System.Drawing.Point(966, 388);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(234, 58);
            this.removeBtn.TabIndex = 31;
            this.removeBtn.Text = "Delete";
            this.removeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
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
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.searchBar.Location = new System.Drawing.Point(101, 31);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(301, 30);
            this.searchBar.TabIndex = 28;
            this.searchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addBtn.IconColor = System.Drawing.Color.White;
            this.addBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addBtn.IconSize = 28;
            this.addBtn.Location = new System.Drawing.Point(966, 230);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(234, 58);
            this.addBtn.TabIndex = 30;
            this.addBtn.Text = "Add";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // loadDataTable
            // 
            this.loadDataTable.AllowUserToAddRows = false;
            this.loadDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loadDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.loadDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.loadDataTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.loadDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loadDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.loadDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.loadDataTable.Location = new System.Drawing.Point(24, 79);
            this.loadDataTable.Name = "loadDataTable";
            this.loadDataTable.ReadOnly = true;
            this.loadDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loadDataTable.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.loadDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.loadDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loadDataTable.Size = new System.Drawing.Size(924, 511);
            this.loadDataTable.TabIndex = 40;
            this.loadDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadDataTable_CellDoubleClick);
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
            this.updateBtn.Location = new System.Drawing.Point(966, 308);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(234, 58);
            this.updateBtn.TabIndex = 41;
            this.updateBtn.Text = "Update";
            this.updateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Load_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 617);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.loadDataTable);
            this.Controls.Add(this.lblSelectedLoad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchBar);
            this.Name = "Load_Manage";
            this.Text = "Manage Load";
            this.Load += new System.EventHandler(this.Load_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectedLoad;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton removeBtn;
        private FontAwesome.Sharp.IconButton searchBtn;
        private System.Windows.Forms.TextBox searchBar;
        private FontAwesome.Sharp.IconButton addBtn;
        private System.Windows.Forms.DataGridView loadDataTable;
        private FontAwesome.Sharp.IconButton updateBtn;
    }
}