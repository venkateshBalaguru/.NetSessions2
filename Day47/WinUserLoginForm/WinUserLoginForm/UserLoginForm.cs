using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUserLoginForm.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinUserLoginForm
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = txtBoxUserId.Text;
            string passWord = txtBoxPassword.Text;

            var authenticUser = new AuthenticationLogin();
            var check = authenticUser.IsValid(userId, passWord);

            while (!check)
            {
                MessageBox.Show("Invalid UserName and PassWord");
                return;
            }
            //We hiding the Current form and displaying the message box
            this.Hide();
            //MessageBox.Show($"Hi {userId}! Welcome to RRD...");
            // we hiding the current form and passing the values to another form
            Profileform profileForm = new Profileform(userId);
            profileForm.Show();
        }

        //private void btnLogin_Click_1(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Welcome to our Portal1");
        //}
    }
}
