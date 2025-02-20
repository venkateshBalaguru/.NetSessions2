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
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUserPassword);
            Controls.Add(lblUserId);
            Name = "UserLoginForm";
            Text = "UserLoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserId;
        private Label lblUserPassword;
    }
}