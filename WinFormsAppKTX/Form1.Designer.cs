namespace WinFormsAppKTX
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            txtSignup = new Guna.UI2.WinForms.Guna2Button();
            LogoutDN = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(98, 47);
            label1.Name = "label1";
            label1.Size = new Size(514, 38);
            label1.TabIndex = 0;
            label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ KÝ TÚC XÁ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(63, 193);
            label2.Name = "label2";
            label2.Size = new Size(176, 25);
            label2.TabIndex = 1;
            label2.Text = "*Vui lòng đăng nhập";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(266, 107);
            label3.Name = "label3";
            label3.Size = new Size(188, 38);
            label3.TabIndex = 2;
            label3.Text = "ĐĂNG NHẬP";
            label3.Click += label3_Click;
            // 
            // txtUsername
            // 
            txtUsername.BorderColor = Color.Silver;
            txtUsername.BorderRadius = 15;
            txtUsername.CustomizableEdges = customizableEdges1;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.Black;
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Location = new Point(98, 241);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderText = "Tên tài khoản";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUsername.Size = new Size(514, 69);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += guna2TextBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BorderColor = Color.Silver;
            txtPassword.BorderRadius = 15;
            txtPassword.CustomizableEdges = customizableEdges3;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.Black;
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(98, 345);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Mật khẩu";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPassword.Size = new Size(514, 69);
            txtPassword.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(63, 549);
            label4.Name = "label4";
            label4.Size = new Size(310, 25);
            label4.TabIndex = 5;
            label4.Text = "Quên mật khẩu? Không có tài khoản?";
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 10;
            btnLogin.BorderThickness = 1;
            btnLogin.CustomizableEdges = customizableEdges5;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.HoverState.BorderColor = Color.Black;
            btnLogin.HoverState.FillColor = Color.Cyan;
            btnLogin.Location = new Point(242, 445);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLogin.Size = new Size(225, 56);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.Click += btnLogin_Click;
            // 
            // txtSignup
            // 
            txtSignup.CustomizableEdges = customizableEdges7;
            txtSignup.DisabledState.BorderColor = Color.DarkGray;
            txtSignup.DisabledState.CustomBorderColor = Color.DarkGray;
            txtSignup.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            txtSignup.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            txtSignup.FillColor = Color.LightGray;
            txtSignup.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtSignup.ForeColor = Color.Black;
            txtSignup.Location = new Point(487, 531);
            txtSignup.Name = "txtSignup";
            txtSignup.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSignup.Size = new Size(166, 43);
            txtSignup.TabIndex = 7;
            txtSignup.Text = "Đăng ký";
            // 
            // LogoutDN
            // 
            LogoutDN.CustomizableEdges = customizableEdges9;
            LogoutDN.DisabledState.BorderColor = Color.DarkGray;
            LogoutDN.DisabledState.CustomBorderColor = Color.DarkGray;
            LogoutDN.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LogoutDN.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LogoutDN.FillColor = Color.LightGray;
            LogoutDN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutDN.ForeColor = Color.White;
            LogoutDN.Image = (Image)resources.GetObject("LogoutDN.Image");
            LogoutDN.ImageSize = new Size(30, 30);
            LogoutDN.Location = new Point(660, 3);
            LogoutDN.Name = "LogoutDN";
            LogoutDN.ShadowDecoration.CustomizableEdges = customizableEdges10;
            LogoutDN.Size = new Size(54, 39);
            LogoutDN.TabIndex = 8;
            LogoutDN.Click += LogoutDN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(715, 642);
            Controls.Add(LogoutDN);
            Controls.Add(txtSignup);
            Controls.Add(btnLogin);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button txtSignup;
        private Guna.UI2.WinForms.Guna2Button LogoutDN;
    }
}
