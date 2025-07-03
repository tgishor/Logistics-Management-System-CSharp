namespace E_ShifSystem
{
    partial class login_admin
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
            this.userBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // userBox
            // 
            this.userBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.userBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userBox.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userBox.Location = new System.Drawing.Point(160, 320);
            this.userBox.Margin = new System.Windows.Forms.Padding(2);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(281, 26);
            this.userBox.TabIndex = 2;
            this.userBox.Text = "Username";
            this.userBox.TextChanged += new System.EventHandler(this.userBox_TextChanged);
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.passBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passBox.Location = new System.Drawing.Point(160, 396);
            this.passBox.Margin = new System.Windows.Forms.Padding(2);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(292, 26);
            this.passBox.TabIndex = 5;
            this.passBox.Text = "Password";
            this.passBox.TextChanged += new System.EventHandler(this.passBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Squada One", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Login to E-Shift System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Forget Password ?";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonShadow;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 37;
            this.iconPictureBox1.Location = new System.Drawing.Point(533, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(37, 45);
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Image = global::E_ShifSystem.Properties.Resources.LoginBtn;
            this.loginBtn.Location = new System.Drawing.Point(190, 468);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(191, 48);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::E_ShifSystem.Properties.Resources.password;
            this.pictureBox3.Location = new System.Drawing.Point(112, 380);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(352, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_ShifSystem.Properties.Resources.Asset_1;
            this.pictureBox1.Location = new System.Drawing.Point(112, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::E_ShifSystem.Properties.Resources.Username;
            this.pictureBox2.Location = new System.Drawing.Point(112, 303);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(352, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // login_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "login_admin";
            this.Text = "Admin Login";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.login_admin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_admin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
    }
}