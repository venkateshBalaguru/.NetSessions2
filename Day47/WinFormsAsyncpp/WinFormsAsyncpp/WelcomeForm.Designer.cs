namespace WinFormsAsyncpp
{
    partial class WelcomeForm
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
            btnPrint = new Button();
            btnHello = new Button();
            btnPrintviaThread = new Button();
            btnPrintviaTask = new Button();
            btnPrintviaTaskAwait = new Button();
            btnPrintviaTaskAwaitResult = new Button();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(350, 51);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnHello
            // 
            btnHello.Location = new Point(350, 22);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(75, 23);
            btnHello.TabIndex = 1;
            btnHello.Text = "Hello";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnHello_Click;
            btnHello.Click += btnMyHelloClick_Handler;
            // 
            // btnPrintviaThread
            // 
            btnPrintviaThread.Location = new Point(350, 80);
            btnPrintviaThread.Name = "btnPrintviaThread";
            btnPrintviaThread.Size = new Size(106, 25);
            btnPrintviaThread.TabIndex = 2;
            btnPrintviaThread.Text = "PrintViaThread";
            btnPrintviaThread.UseVisualStyleBackColor = true;
            btnPrintviaThread.Click += btnPrintviaThread_Click;
            // 
            // btnPrintviaTask
            // 
            btnPrintviaTask.Location = new Point(350, 111);
            btnPrintviaTask.Name = "btnPrintviaTask";
            btnPrintviaTask.Size = new Size(106, 24);
            btnPrintviaTask.TabIndex = 3;
            btnPrintviaTask.Text = "PrintViaTask";
            btnPrintviaTask.UseVisualStyleBackColor = true;
            btnPrintviaTask.Click += btnPrintviaTask_Click;
            // 
            // btnPrintviaTaskAwait
            // 
            btnPrintviaTaskAwait.Location = new Point(350, 141);
            btnPrintviaTaskAwait.Name = "btnPrintviaTaskAwait";
            btnPrintviaTaskAwait.Size = new Size(130, 24);
            btnPrintviaTaskAwait.TabIndex = 4;
            btnPrintviaTaskAwait.Text = "PrintViaTaskAwait";
            btnPrintviaTaskAwait.UseVisualStyleBackColor = true;
            btnPrintviaTaskAwait.Click += btnPrintviaTaskAwait_ClickAsync;
            // 
            // btnPrintviaTaskAwaitResult
            // 
            btnPrintviaTaskAwaitResult.Location = new Point(350, 171);
            btnPrintviaTaskAwaitResult.Name = "btnPrintviaTaskAwaitResult";
            btnPrintviaTaskAwaitResult.Size = new Size(148, 32);
            btnPrintviaTaskAwaitResult.TabIndex = 5;
            btnPrintviaTaskAwaitResult.Text = "PrintViaTaskAwaitResult";
            btnPrintviaTaskAwaitResult.UseVisualStyleBackColor = true;
            btnPrintviaTaskAwaitResult.Click += btnPrintviaTaskAwaitResult_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrintviaTaskAwaitResult);
            Controls.Add(btnPrintviaTaskAwait);
            Controls.Add(btnPrintviaTask);
            Controls.Add(btnPrintviaThread);
            Controls.Add(btnHello);
            Controls.Add(btnPrint);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrint;
        private Button btnHello;
        private Button btnPrintviaThread;
        private Button btnPrintviaTask;
        private Button btnPrintviaTaskAwait;
        private Button btnPrintviaTaskAwaitResult;
    }
}