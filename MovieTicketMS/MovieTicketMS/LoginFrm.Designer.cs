namespace MovieTicketMS
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.lbl_X = new System.Windows.Forms.Label();
            this.Login_lblLogAcc = new System.Windows.Forms.Label();
            this.Login_lblUserName = new System.Windows.Forms.Label();
            this.Login_txtUserName = new System.Windows.Forms.TextBox();
            this.Login_txtPass = new System.Windows.Forms.TextBox();
            this.Login_lblPass = new System.Windows.Forms.Label();
            this.Login_chkShowPass = new System.Windows.Forms.CheckBox();
            this.Login_btnLogin = new System.Windows.Forms.Button();
            this.Login_lblCreateAcc = new System.Windows.Forms.Label();
            this.Login_btnSignup = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_X.Location = new System.Drawing.Point(367, 11);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(19, 20);
            this.lbl_X.TabIndex = 0;
            this.lbl_X.Text = "X";
            this.lbl_X.Click += new System.EventHandler(this.lbl_X_Click);
            // 
            // Login_lblLogAcc
            // 
            this.Login_lblLogAcc.AutoSize = true;
            this.Login_lblLogAcc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_lblLogAcc.ForeColor = System.Drawing.Color.White;
            this.Login_lblLogAcc.Location = new System.Drawing.Point(54, 41);
            this.Login_lblLogAcc.Name = "Login_lblLogAcc";
            this.Login_lblLogAcc.Size = new System.Drawing.Size(196, 23);
            this.Login_lblLogAcc.TabIndex = 1;
            this.Login_lblLogAcc.Text = "LOGIN ACCOUNT";
            // 
            // Login_lblUserName
            // 
            this.Login_lblUserName.AutoSize = true;
            this.Login_lblUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_lblUserName.ForeColor = System.Drawing.Color.White;
            this.Login_lblUserName.Location = new System.Drawing.Point(54, 109);
            this.Login_lblUserName.Name = "Login_lblUserName";
            this.Login_lblUserName.Size = new System.Drawing.Size(96, 20);
            this.Login_lblUserName.TabIndex = 2;
            this.Login_lblUserName.Text = "UserName";
            // 
            // Login_txtUserName
            // 
            this.Login_txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_txtUserName.Location = new System.Drawing.Point(58, 132);
            this.Login_txtUserName.Name = "Login_txtUserName";
            this.Login_txtUserName.Size = new System.Drawing.Size(301, 30);
            this.Login_txtUserName.TabIndex = 1;
            // 
            // Login_txtPass
            // 
            this.Login_txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_txtPass.Location = new System.Drawing.Point(58, 211);
            this.Login_txtPass.Name = "Login_txtPass";
            this.Login_txtPass.PasswordChar = '*';
            this.Login_txtPass.Size = new System.Drawing.Size(301, 30);
            this.Login_txtPass.TabIndex = 2;
            // 
            // Login_lblPass
            // 
            this.Login_lblPass.AutoSize = true;
            this.Login_lblPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_lblPass.ForeColor = System.Drawing.Color.White;
            this.Login_lblPass.Location = new System.Drawing.Point(54, 188);
            this.Login_lblPass.Name = "Login_lblPass";
            this.Login_lblPass.Size = new System.Drawing.Size(90, 20);
            this.Login_lblPass.TabIndex = 4;
            this.Login_lblPass.Text = "Password";
            // 
            // Login_chkShowPass
            // 
            this.Login_chkShowPass.AutoSize = true;
            this.Login_chkShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_chkShowPass.ForeColor = System.Drawing.Color.White;
            this.Login_chkShowPass.Location = new System.Drawing.Point(58, 247);
            this.Login_chkShowPass.Name = "Login_chkShowPass";
            this.Login_chkShowPass.Size = new System.Drawing.Size(151, 24);
            this.Login_chkShowPass.TabIndex = 3;
            this.Login_chkShowPass.Text = "Show Password";
            this.Login_chkShowPass.UseVisualStyleBackColor = true;
            this.Login_chkShowPass.CheckedChanged += new System.EventHandler(this.Login_chkShowPass_CheckedChanged);
            // 
            // Login_btnLogin
            // 
            this.Login_btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Login_btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.Login_btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.Login_btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btnLogin.ForeColor = System.Drawing.Color.White;
            this.Login_btnLogin.Location = new System.Drawing.Point(58, 293);
            this.Login_btnLogin.Name = "Login_btnLogin";
            this.Login_btnLogin.Size = new System.Drawing.Size(301, 44);
            this.Login_btnLogin.TabIndex = 4;
            this.Login_btnLogin.Text = "LOGIN";
            this.Login_btnLogin.UseVisualStyleBackColor = false;
            this.Login_btnLogin.Click += new System.EventHandler(this.Login_btnLogin_Click);
            // 
            // Login_lblCreateAcc
            // 
            this.Login_lblCreateAcc.AutoSize = true;
            this.Login_lblCreateAcc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_lblCreateAcc.ForeColor = System.Drawing.Color.White;
            this.Login_lblCreateAcc.Location = new System.Drawing.Point(131, 570);
            this.Login_lblCreateAcc.Name = "Login_lblCreateAcc";
            this.Login_lblCreateAcc.Size = new System.Drawing.Size(169, 20);
            this.Login_lblCreateAcc.TabIndex = 8;
            this.Login_lblCreateAcc.Text = "Create an account?";
            // 
            // Login_btnSignup
            // 
            this.Login_btnSignup.BackColor = System.Drawing.Color.Navy;
            this.Login_btnSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.Login_btnSignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.Login_btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btnSignup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btnSignup.ForeColor = System.Drawing.Color.White;
            this.Login_btnSignup.Location = new System.Drawing.Point(58, 593);
            this.Login_btnSignup.Name = "Login_btnSignup";
            this.Login_btnSignup.Size = new System.Drawing.Size(301, 44);
            this.Login_btnSignup.TabIndex = 5;
            this.Login_btnSignup.Text = "SIGN UP";
            this.Login_btnSignup.UseVisualStyleBackColor = false;
            this.Login_btnSignup.Click += new System.EventHandler(this.Login_btnSignup_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(83)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.Login_lblLogAcc);
            this.panel1.Controls.Add(this.lbl_X);
            this.panel1.Controls.Add(this.Login_btnSignup);
            this.panel1.Controls.Add(this.Login_lblUserName);
            this.panel1.Controls.Add(this.Login_lblCreateAcc);
            this.panel1.Controls.Add(this.Login_txtUserName);
            this.panel1.Controls.Add(this.Login_btnLogin);
            this.panel1.Controls.Add(this.Login_lblPass);
            this.panel1.Controls.Add(this.Login_chkShowPass);
            this.panel1.Controls.Add(this.Login_txtPass);
            this.panel1.Location = new System.Drawing.Point(919, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 674);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(888, 675);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // LoginFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1330, 698);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginFr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Label Login_lblLogAcc;
        private System.Windows.Forms.Label Login_lblUserName;
        private System.Windows.Forms.TextBox Login_txtUserName;
        private System.Windows.Forms.TextBox Login_txtPass;
        private System.Windows.Forms.Label Login_lblPass;
        private System.Windows.Forms.CheckBox Login_chkShowPass;
        private System.Windows.Forms.Button Login_btnLogin;
        private System.Windows.Forms.Label Login_lblCreateAcc;
        private System.Windows.Forms.Button Login_btnSignup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}