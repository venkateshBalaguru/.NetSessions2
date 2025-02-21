namespace WinUserLoginForm
{
    partial class UserLoginForm
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
            lblUserId = new Label();
            lblUserPassword = new Label();
            txtBoxUserId = new TextBox();
            txtBoxPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(158, 75);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(41, 15);
            lblUserId.TabIndex = 0;
            lblUserId.Text = "UserID";
            // 
            // lblUserPassword
            // 
            lblUserPassword.AutoSize = true;
            lblUserPassword.Location = new Point(158, 116);
            lblUserPassword.Name = "lblUserPassword";
            lblUserPassword.Size = new Size(57, 15);
            lblUserPassword.TabIndex = 1;
            lblUserPassword.Text = "Password";
            // 
            // txtBoxUserId
            // 
            txtBoxUserId.Location = new Point(233, 67);
            txtBoxUserId.Name = "txtBoxUserId";
            txtBoxUserId.Size = new Size(126, 23);
            txtBoxUserId.TabIndex = 2;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(233, 108);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(126, 23);
            txtBoxPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(222, 172);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(137, 33);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            //btnLogin.Click += btnLogin_Click_1;
            // 
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxUserId);
            Controls.Add(lblUserPassword);
            Controls.Add(lblUserId);
            Name = "UserLoginForm";
            Text = "UserLoginForm";
            //Click += btnLogin_Click_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserId;
        private Label lblUserPassword;
        private TextBox txtBoxUserId;
        private TextBox txtBoxPassword;
        private Button btnLogin;
    }
}