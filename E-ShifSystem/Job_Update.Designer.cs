namespace E_ShifSystem
{
    partial class Job_Update
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.transUnitBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.jobStatusBox = new System.Windows.Forms.ComboBox();
            this.totalPayable = new System.Windows.Forms.TextBox();
            this.dropAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pickAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pickDateTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSelectedJobID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cusNameBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackStatusBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trackStatusBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cusNameBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.transUnitBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.jobStatusBox);
            this.groupBox1.Controls.Add(this.totalPayable);
            this.groupBox1.Controls.Add(this.dropAddress);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pickAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pickDateTime);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblSelectedJobID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.back_btn);
            this.groupBox1.Controls.Add(this.update_btn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1147, 566);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Job";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(590, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 22);
            this.label11.TabIndex = 39;
            this.label11.Text = "Select the Transport Unit: ";
            // 
            // transUnitBox
            // 
            this.transUnitBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.transUnitBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.transUnitBox.FormattingEnabled = true;
            this.transUnitBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.transUnitBox.Location = new System.Drawing.Point(594, 404);
            this.transUnitBox.Name = "transUnitBox";
            this.transUnitBox.Size = new System.Drawing.Size(360, 30);
            this.transUnitBox.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(590, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 22);
            this.label10.TabIndex = 30;
            this.label10.Text = "Select the Job Status: ";
            // 
            // jobStatusBox
            // 
            this.jobStatusBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jobStatusBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.jobStatusBox.FormattingEnabled = true;
            this.jobStatusBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.jobStatusBox.Location = new System.Drawing.Point(594, 207);
            this.jobStatusBox.Name = "jobStatusBox";
            this.jobStatusBox.Size = new System.Drawing.Size(360, 30);
            this.jobStatusBox.TabIndex = 34;
            // 
            // totalPayable
            // 
            this.totalPayable.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.totalPayable.Location = new System.Drawing.Point(210, 404);
            this.totalPayable.Name = "totalPayable";
            this.totalPayable.Size = new System.Drawing.Size(360, 30);
            this.totalPayable.TabIndex = 31;
            // 
            // dropAddress
            // 
            this.dropAddress.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.dropAddress.Location = new System.Drawing.Point(594, 281);
            this.dropAddress.Multiline = true;
            this.dropAddress.Name = "dropAddress";
            this.dropAddress.Size = new System.Drawing.Size(360, 78);
            this.dropAddress.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(590, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 22);
            this.label9.TabIndex = 37;
            this.label9.Text = "Drop Address: ";
            // 
            // pickAddress
            // 
            this.pickAddress.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.pickAddress.Location = new System.Drawing.Point(210, 281);
            this.pickAddress.Multiline = true;
            this.pickAddress.Name = "pickAddress";
            this.pickAddress.Size = new System.Drawing.Size(360, 78);
            this.pickAddress.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Pickup Street ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "Total Payable: ";
            // 
            // pickDateTime
            // 
            this.pickDateTime.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.pickDateTime.Location = new System.Drawing.Point(210, 207);
            this.pickDateTime.Name = "pickDateTime";
            this.pickDateTime.Size = new System.Drawing.Size(360, 30);
            this.pickDateTime.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 22);
            this.label8.TabIndex = 29;
            this.label8.Text = "Pickup Date and Time: ";
            // 
            // lblSelectedJobID
            // 
            this.lblSelectedJobID.AutoSize = true;
            this.lblSelectedJobID.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedJobID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.lblSelectedJobID.Location = new System.Drawing.Point(636, 56);
            this.lblSelectedJobID.Name = "lblSelectedJobID";
            this.lblSelectedJobID.Size = new System.Drawing.Size(36, 28);
            this.lblSelectedJobID.TabIndex = 28;
            this.lblSelectedJobID.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(470, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Selected Job ID: ";
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.back_btn.FlatAppearance.BorderSize = 2;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.back_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.back_btn.Location = new System.Drawing.Point(594, 475);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(234, 55);
            this.back_btn.TabIndex = 12;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.update_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.update_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_btn.Location = new System.Drawing.Point(336, 475);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(234, 55);
            this.update_btn.TabIndex = 10;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 22);
            this.label3.TabIndex = 41;
            this.label3.Text = "Select the Customer: ";
            // 
            // cusNameBox
            // 
            this.cusNameBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cusNameBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.cusNameBox.FormattingEnabled = true;
            this.cusNameBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.cusNameBox.Location = new System.Drawing.Point(210, 132);
            this.cusNameBox.Name = "cusNameBox";
            this.cusNameBox.Size = new System.Drawing.Size(360, 30);
            this.cusNameBox.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(590, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Select the Track Status: ";
            // 
            // trackStatusBox
            // 
            this.trackStatusBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.trackStatusBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.trackStatusBox.FormattingEnabled = true;
            this.trackStatusBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.trackStatusBox.Location = new System.Drawing.Point(594, 132);
            this.trackStatusBox.Name = "trackStatusBox";
            this.trackStatusBox.Size = new System.Drawing.Size(360, 30);
            this.trackStatusBox.TabIndex = 44;
            // 
            // Job_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 617);
            this.Controls.Add(this.groupBox1);
            this.Name = "Job_Update";
            this.Text = "Job_Update";
            this.Load += new System.EventHandler(this.Job_Update_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSelectedJobID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox transUnitBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox jobStatusBox;
        private System.Windows.Forms.TextBox totalPayable;
        private System.Windows.Forms.TextBox dropAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pickAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker pickDateTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cusNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox trackStatusBox;
    }
}