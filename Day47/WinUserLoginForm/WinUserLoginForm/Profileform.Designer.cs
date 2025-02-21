namespace WinUserLoginForm
{
    partial class Profileform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profileform));
            imageBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            SuspendLayout();
            // 
            // imageBox1
            // 
            imageBox1.BackColor = SystemColors.ActiveCaption;
            imageBox1.Image = (Image)resources.GetObject("imageBox1.Image");
            imageBox1.Location = new Point(289, 73);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(240, 137);
            imageBox1.TabIndex = 0;
            imageBox1.TabStop = false;
            imageBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(289, 9);
            label1.Name = "label1";
            label1.Size = new Size(294, 37);
            label1.TabIndex = 0;
            
            // 
            // Profileform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(imageBox1);
            Name = "Profileform";
            Text = "Profileform";
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imageBox1;
        private Label label1;
    }
}