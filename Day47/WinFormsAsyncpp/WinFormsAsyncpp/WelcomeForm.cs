using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAsyncpp.Services;

namespace WinFormsAsyncpp
{
    public partial class WelcomeForm : Form
    {
        private PrintService _printService;
        public WelcomeForm()
        {
            _printService = new PrintService();
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            _printService.Print();
        }
        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Event Handler2");
        }
        private void btnMyHelloClick_Handler(object sender, EventArgs e)
        {
            MessageBox.Show("Event Handler1");
        }

        private void btnPrintviaThread_Click(object sender, EventArgs e)
        {
            _printService.PrintviaThread();
            MessageBox.Show("Theard is Completed");
        }

        private void btnPrintviaTask_Click(object sender, EventArgs e)
        {
            _printService.PrintviaTask();
            MessageBox.Show("Task completed");
        }

        private async void btnPrintviaTaskAwait_ClickAsync(object sender, EventArgs e)
        {
            await _printService.PrintviaTaskAwaitable();
            MessageBox.Show("Awaitable task completed after 10 seconds ");
        }

        private async void btnPrintviaTaskAwaitResult_Click(object sender, EventArgs e)
        {
            string result = await _printService.PrintviaTaskAwaitableResult();
            MessageBox.Show("task completed after 10 second result is:" + result);
        }
    }
}
