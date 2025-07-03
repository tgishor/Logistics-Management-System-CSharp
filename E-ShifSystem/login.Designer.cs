namespace E_ShifSystem
{
    partial class login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.forgetPassword = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.userBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::E_ShifSystem.Properties.Resources.Asset_2username;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.forgetPassword);
            this.panel1.Controls.Add(this.passBox);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.userBox);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(86, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 745);
            this.panel1.TabIndex = 0;
            // 
            // forgetPassword
            // 
            this.forgetPassword.AutoSize = true;
            this.forgetPassword.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetPassword.Location = new System.Drawing.Point(207, 673);
            this.forgetPassword.Name = "forgetPassword";
            this.forgetPassword.Size = new System.Drawing.Size(128, 15);
            this.forgetPassword.TabIndex = 11;
            this.forgetPassword.Text = "Forget Password ?";
            this.forgetPassword.Click += new System.EventHandler(this.forgetPassword_Click);
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.passBox.Location = new System.Drawing.Point(144, 565);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(308, 32);
            this.passBox.TabIndex = 5;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Image = global::E_ShifSystem.Properties.Resources.LoginBtn;
            this.loginBtn.Location = new System.Drawing.Point(170, 619);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(204, 48);
            this.loginBtn.TabIndex = 10;
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userBox
            // 
            this.userBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.userBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userBox.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.userBox.Location = new System.Drawing.Point(144, 503);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(308, 32);
            this.userBox.TabIndex = 4;
            this.userBox.Enter += new System.EventHandler(this.userBox_Enter);
            this.userBox.Leave += new System.EventHandler(this.userBox_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::E_ShifSystem.Properties.Resources.Asset_5username;
            this.pictureBox2.Location = new System.Drawing.Point(82, 495);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(384, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Squada One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(220, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome Back";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Squada One", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(173, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "USER LOGIN";
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
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconPictureBox1.IconColor = System.Drawing.Color.OrangeRed;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 37;
            this.iconPictureBox1.Location = new System.Drawing.Point(668, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(37, 45);
            this.iconPictureBox1.TabIndex = 9;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_ShifSystem.Properties.Resources.Asset_1username;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(717, 789);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label forgetPassword;
        private System.Windows.Forms.Button loginBtn;
    }
}