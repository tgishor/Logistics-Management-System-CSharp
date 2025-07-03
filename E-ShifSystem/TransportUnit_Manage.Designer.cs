namespace E_ShifSystem
{
    partial class TransportUnit_Manage
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
            this.lblSelectedTransID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.updateBtn = new FontAwesome.Sharp.IconButton();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.transportUnitDataTable = new System.Windows.Forms.DataGridView();
            this.Available = new System.Windows.Forms.Label();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.tuStatusBtn = new E_ShifSystem.CustomControls.RJToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.transportUnitDataTable)).BeginInit();
            this.controlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectedTransID
            // 
            this.lblSelectedTransID.AutoSize = true;
            this.lblSelectedTransID.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTransID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.lblSelectedTransID.Location = new System.Drawing.Point(814, 34);
            this.lblSelectedTransID.Name = "lblSelectedTransID";
            this.lblSelectedTransID.Size = new System.Drawing.Size(36, 28);
            this.lblSelectedTransID.TabIndex = 34;
            this.lblSelectedTransID.Text = "00";
            this.lblSelectedTransID.Click += new System.EventHandler(this.lblSelectedTransID_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(541, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 28);
            this.label4.TabIndex = 33;
            this.label4.Text = "Selected Transport Unit ID: ";
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
            this.deleteBtn.Location = new System.Drawing.Point(960, 303);
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
            this.updateBtn.Location = new System.Drawing.Point(960, 228);
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
            // transportUnitDataTable
            // 
            this.transportUnitDataTable.AllowUserToAddRows = false;
            this.transportUnitDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transportUnitDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.transportUnitDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.transportUnitDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.transportUnitDataTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.transportUnitDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transportUnitDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.transportUnitDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transportUnitDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.transportUnitDataTable.Location = new System.Drawing.Point(35, 79);
            this.transportUnitDataTable.Name = "transportUnitDataTable";
            this.transportUnitDataTable.ReadOnly = true;
            this.transportUnitDataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transportUnitDataTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.transportUnitDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.transportUnitDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transportUnitDataTable.Size = new System.Drawing.Size(907, 511);
            this.transportUnitDataTable.TabIndex = 39;
            this.transportUnitDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transportUnitDataTable_CellDoubleClick);
            // 
            // Available
            // 
            this.Available.AutoSize = true;
            this.Available.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Available.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.Available.Location = new System.Drawing.Point(37, 50);
            this.Available.Name = "Available";
            this.Available.Size = new System.Drawing.Size(103, 28);
            this.Available.TabIndex = 42;
            this.Available.Text = "Available";
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Controls.Add(this.Available);
            this.controlGroupBox.Controls.Add(this.tuStatusBtn);
            this.controlGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlGroupBox.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlGroupBox.Location = new System.Drawing.Point(960, 384);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(234, 124);
            this.controlGroupBox.TabIndex = 43;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Change Transport Unit Status";
            // 
            // tuStatusBtn
            // 
            this.tuStatusBtn.AutoSize = true;
            this.tuStatusBtn.Checked = true;
            this.tuStatusBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tuStatusBtn.Location = new System.Drawing.Point(146, 47);
            this.tuStatusBtn.MinimumSize = new System.Drawing.Size(60, 35);
            this.tuStatusBtn.Name = "tuStatusBtn";
            this.tuStatusBtn.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.tuStatusBtn.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tuStatusBtn.OnBackColor = System.Drawing.Color.ForestGreen;
            this.tuStatusBtn.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tuStatusBtn.Size = new System.Drawing.Size(60, 35);
            this.tuStatusBtn.TabIndex = 41;
            this.tuStatusBtn.UseVisualStyleBackColor = true;
            this.tuStatusBtn.CheckedChanged += new System.EventHandler(this.tuStatusBtn_CheckedChanged);
            this.tuStatusBtn.Click += new System.EventHandler(this.tuStatusBtn_Click);
            // 
            // TransportUnit_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 617);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.transportUnitDataTable);
            this.Controls.Add(this.lblSelectedTransID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TransportUnit_Manage";
            this.Text = "Manage Transport Unit";
            this.Load += new System.EventHandler(this.TransportUnit_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transportUnitDataTable)).EndInit();
            this.controlGroupBox.ResumeLayout(false);
            this.controlGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectedTransID;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private FontAwesome.Sharp.IconButton updateBtn;
        private FontAwesome.Sharp.IconButton searchBtn;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.DataGridView transportUnitDataTable;
        private CustomControls.RJToggleButton tuStatusBtn;
        private System.Windows.Forms.Label Available;
        private System.Windows.Forms.GroupBox controlGroupBox;
    }
}