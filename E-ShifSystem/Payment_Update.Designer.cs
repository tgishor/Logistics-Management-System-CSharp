namespace E_ShifSystem
{
    partial class Payment_Update
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
            this.label8 = new System.Windows.Forms.Label();
            this.payTypeBox = new System.Windows.Forms.ComboBox();
            this.payAmountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jobBox = new System.Windows.Forms.ComboBox();
            this.lblSelectedPayId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.payTypeBox);
            this.groupBox1.Controls.Add(this.payAmountBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.jobBox);
            this.groupBox1.Controls.Add(this.lblSelectedPayId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.backBtn);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1147, 565);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Payment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(397, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 22);
            this.label8.TabIndex = 33;
            this.label8.Text = "Payment Type: ";
            // 
            // payTypeBox
            // 
            this.payTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.payTypeBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.payTypeBox.FormattingEnabled = true;
            this.payTypeBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.payTypeBox.Location = new System.Drawing.Point(401, 325);
            this.payTypeBox.Name = "payTypeBox";
            this.payTypeBox.Size = new System.Drawing.Size(360, 30);
            this.payTypeBox.TabIndex = 34;
            // 
            // payAmountBox
            // 
            this.payAmountBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payAmountBox.Location = new System.Drawing.Point(401, 247);
            this.payAmountBox.Name = "payAmountBox";
            this.payAmountBox.Size = new System.Drawing.Size(360, 30);
            this.payAmountBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Payment Amount:  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "Select Job ID: ";
            // 
            // jobBox
            // 
            this.jobBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jobBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.jobBox.FormattingEnabled = true;
            this.jobBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.jobBox.Location = new System.Drawing.Point(401, 171);
            this.jobBox.Name = "jobBox";
            this.jobBox.Size = new System.Drawing.Size(360, 30);
            this.jobBox.TabIndex = 30;
            // 
            // lblSelectedPayId
            // 
            this.lblSelectedPayId.AutoSize = true;
            this.lblSelectedPayId.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedPayId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.lblSelectedPayId.Location = new System.Drawing.Point(654, 85);
            this.lblSelectedPayId.Name = "lblSelectedPayId";
            this.lblSelectedPayId.Size = new System.Drawing.Size(36, 28);
            this.lblSelectedPayId.TabIndex = 28;
            this.lblSelectedPayId.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Squada One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(429, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Selected Payment ID: ";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.backBtn.FlatAppearance.BorderSize = 2;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.backBtn.Location = new System.Drawing.Point(588, 390);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(234, 55);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.updateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateBtn.Location = new System.Drawing.Point(330, 390);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(234, 55);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Payment_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 617);
            this.Controls.Add(this.groupBox1);
            this.Name = "Payment_Update";
            this.Text = "Update Payment";
            this.Load += new System.EventHandler(this.Payment_Update_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSelectedPayId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox payTypeBox;
        private System.Windows.Forms.TextBox payAmountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox jobBox;
    }
}