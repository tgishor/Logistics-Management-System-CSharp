namespace E_ShifSystem
{
    partial class resetPassword
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resetPasswordBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconPictureBox1.IconColor = System.Drawing.Color.OrangeRed;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 37;
            this.iconPictureBox1.Location = new System.Drawing.Point(642, 21);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(37, 45);
            this.iconPictureBox1.TabIndex = 10;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::E_ShifSystem.Properties.Resources.Asset_2username;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.resetPasswordBtn);
            this.panel1.Controls.Add(this.usernameBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(73, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 745);
            this.panel1.TabIndex = 11;
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.usernameBox.Location = new System.Drawing.Point(108, 524);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(337, 34);
            this.usernameBox.TabIndex = 4;
            this.usernameBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Squada One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(129, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the Username used in Registration: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Squada One", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(124, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reset Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_ShifSystem.Properties.Resources.Asset_3username;
            this.pictureBox1.Location = new System.Drawing.Point(119, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // resetPasswordBtn
            // 
            this.resetPasswordBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.resetPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetPasswordBtn.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resetPasswordBtn.Location = new System.Drawing.Point(171, 578);
            this.resetPasswordBtn.Name = "resetPasswordBtn";
            this.resetPasswordBtn.Size = new System.Drawing.Size(202, 43);
            this.resetPasswordBtn.TabIndex = 5;
            this.resetPasswordBtn.Text = "Reset the Password";
            this.resetPasswordBtn.UseVisualStyleBackColor = false;
            this.resetPasswordBtn.Click += new System.EventHandler(this.resetPasswordBtn_Click);
            // 
            // resetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_ShifSystem.Properties.Resources.Asset_1username;
            this.ClientSize = new System.Drawing.Size(701, 750);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "resetPassword";
            this.Text = "resetPassword";
            this.Load += new System.EventHandler(this.resetPassword_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resetPassword_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button resetPasswordBtn;
    }
}