namespace bookshop
{
    partial class splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            Percentage = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Myprogress = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Percentage.ForeColor = Color.IndianRed;
            Percentage.Location = new Point(204, 364);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(32, 30);
            Percentage.TabIndex = 14;
            Percentage.Text = "%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(31, 364);
            label2.Name = "label2";
            label2.Size = new Size(130, 30);
            label2.TabIndex = 13;
            label2.Text = "Loading...";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(241, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 235);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(215, 15);
            label1.Name = "label1";
            label1.Size = new Size(383, 30);
            label1.TabIndex = 10;
            label1.Text = "Book Shop Managment System";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Myprogress
            // 
            Myprogress.Location = new Point(31, 409);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(745, 29);
            Myprogress.TabIndex = 15;
            // 
            // splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(Myprogress);
            Controls.Add(Percentage);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "splash";
            Load += splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Percentage;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar Myprogress;
    }
}