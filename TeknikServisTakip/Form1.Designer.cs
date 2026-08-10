namespace TeknikServisTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pcrboxYoutube = new PictureBox();
            pcrboxInstagram = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pcrbxClose = new PictureBox();
            pcrbxMin = new PictureBox();
            pcrbxMax = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            btnGirisYap = new Button();
            panel4 = new Panel();
            pictureBox6 = new PictureBox();
            txtSifre = new TextBox();
            label8 = new Label();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            txtKullanıcıAdı = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcrboxYoutube).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcrboxInstagram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcrbxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcrbxMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcrbxMax).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 109, 41);
            panel1.Controls.Add(pcrboxYoutube);
            panel1.Controls.Add(pcrboxInstagram);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 392);
            panel1.TabIndex = 0;
            // 
            // pcrboxYoutube
            // 
            pcrboxYoutube.Image = (Image)resources.GetObject("pcrboxYoutube.Image");
            pcrboxYoutube.Location = new Point(89, 359);
            pcrboxYoutube.Name = "pcrboxYoutube";
            pcrboxYoutube.Size = new Size(30, 30);
            pcrboxYoutube.SizeMode = PictureBoxSizeMode.Zoom;
            pcrboxYoutube.TabIndex = 6;
            pcrboxYoutube.TabStop = false;
            pcrboxYoutube.Click += pcrboxYoutube_Click;
            // 
            // pcrboxInstagram
            // 
            pcrboxInstagram.Image = (Image)resources.GetObject("pcrboxInstagram.Image");
            pcrboxInstagram.Location = new Point(124, 359);
            pcrboxInstagram.Name = "pcrboxInstagram";
            pcrboxInstagram.Size = new Size(30, 30);
            pcrboxInstagram.SizeMode = PictureBoxSizeMode.Zoom;
            pcrboxInstagram.TabIndex = 5;
            pcrboxInstagram.TabStop = false;
            pcrboxInstagram.Click += pcrboxInstagram_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(28, 238);
            label4.Name = "label4";
            label4.Size = new Size(91, 27);
            label4.TabIndex = 4;
            label4.Text = "Onarım";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 189);
            label3.Name = "label3";
            label3.Size = new Size(133, 27);
            label3.TabIndex = 3;
            label3.Text = "Arıza Tespit";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(7, 144);
            label1.Name = "label1";
            label1.Size = new Size(146, 27);
            label1.TabIndex = 1;
            label1.Text = "Teknik Servis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(48, 109, 41);
            label2.Location = new Point(159, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 27);
            label2.TabIndex = 2;
            label2.Text = "Hoşgeldiniz";
            // 
            // pcrbxClose
            // 
            pcrbxClose.Image = (Image)resources.GetObject("pcrbxClose.Image");
            pcrbxClose.Location = new Point(656, 0);
            pcrbxClose.Name = "pcrbxClose";
            pcrbxClose.Size = new Size(24, 24);
            pcrbxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pcrbxClose.TabIndex = 6;
            pcrbxClose.TabStop = false;
            pcrbxClose.Click += pcrbxClose_Click;
            // 
            // pcrbxMin
            // 
            pcrbxMin.Image = (Image)resources.GetObject("pcrbxMin.Image");
            pcrbxMin.Location = new Point(602, 0);
            pcrbxMin.Name = "pcrbxMin";
            pcrbxMin.Size = new Size(24, 24);
            pcrbxMin.SizeMode = PictureBoxSizeMode.Zoom;
            pcrbxMin.TabIndex = 7;
            pcrbxMin.TabStop = false;
            pcrbxMin.Click += pcrbxMin_Click;
            // 
            // pcrbxMax
            // 
            pcrbxMax.Image = (Image)resources.GetObject("pcrbxMax.Image");
            pcrbxMax.Location = new Point(629, 0);
            pcrbxMax.Name = "pcrbxMax";
            pcrbxMax.Size = new Size(24, 24);
            pcrbxMax.SizeMode = PictureBoxSizeMode.Zoom;
            pcrbxMax.TabIndex = 8;
            pcrbxMax.TabStop = false;
            pcrbxMax.Click += pcrbxMax_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.FromArgb(48, 109, 41);
            label5.Location = new Point(159, 67);
            label5.Name = "label5";
            label5.Size = new Size(153, 21);
            label5.TabIndex = 9;
            label5.Text = "Giriş yapmak için ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.FromArgb(48, 109, 41);
            label6.Location = new Point(207, 88);
            label6.Name = "label6";
            label6.Size = new Size(158, 21);
            label6.TabIndex = 10;
            label6.Text = "Bilgilerinizi giriniz";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnGirisYap);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label7);
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            panel2.Location = new Point(162, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 237);
            panel2.TabIndex = 11;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.Lime;
            btnGirisYap.FlatAppearance.BorderColor = Color.MintCream;
            btnGirisYap.FlatAppearance.BorderSize = 3;
            btnGirisYap.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnGirisYap.FlatAppearance.MouseOverBackColor = Color.YellowGreen;
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Font = new Font("Cambria", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnGirisYap.Location = new Point(110, 175);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(105, 37);
            btnGirisYap.TabIndex = 3;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox6);
            panel4.Controls.Add(txtSifre);
            panel4.Location = new Point(28, 124);
            panel4.Name = "panel4";
            panel4.Size = new Size(231, 38);
            panel4.TabIndex = 9;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(2, 6);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(28, 25);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(31, 7);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(195, 27);
            txtSifre.TabIndex = 2;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.FromArgb(48, 109, 41);
            label8.Location = new Point(28, 101);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 8;
            label8.Text = "Şifre:";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(txtKullanıcıAdı);
            panel3.Location = new Point(28, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 38);
            panel3.TabIndex = 7;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(2, 7);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(28, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // txtKullanıcıAdı
            // 
            txtKullanıcıAdı.Location = new Point(31, 7);
            txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            txtKullanıcıAdı.Size = new Size(195, 27);
            txtKullanıcıAdı.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FromArgb(48, 109, 41);
            label7.Location = new Point(28, 22);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 3;
            label7.Text = "Kullanıcı Adı:";
            // 
            // Form1
            // 
            AcceptButton = btnGirisYap;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 225, 177);
            ClientSize = new Size(680, 392);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pcrbxMax);
            Controls.Add(pcrbxMin);
            Controls.Add(pcrbxClose);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcrboxYoutube).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcrboxInstagram).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcrbxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcrbxMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcrbxMax).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pcrboxInstagram;
        private Label label4;
        private PictureBox pcrboxYoutube;
        private PictureBox pcrbxClose;
        private PictureBox pcrbxMin;
        private PictureBox pcrbxMax;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private Label label7;
        private Panel panel3;
        private TextBox txtKullanıcıAdı;
        private Panel panel4;
        private PictureBox pictureBox6;
        private TextBox txtSifre;
        private Label label8;
        private PictureBox pictureBox5;
        private Button btnGirisYap;
    }
}
