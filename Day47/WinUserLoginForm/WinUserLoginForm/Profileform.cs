using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinUserLoginForm
{
    public partial class Profileform : Form
    {
        private string name;
        public Profileform(string username)
        {
            InitializeComponent();
            this.name = username;
            this.Load += new EventHandler(Profileform_load);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hi {name}! Welcome to RRD!!!");
        }



        private void Profileform_load(object sender, EventArgs e)
        {
            label1.Text = $"Hi {name}! welcome... ";
        }
    }
}
