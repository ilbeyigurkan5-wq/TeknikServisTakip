namespace TeknikServisTakip
{
    partial class ServisKayitForm
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
            dataGridViewServisKayit = new DataGridView();
            txtServisKayitAra = new TextBox();
            panel1 = new Panel();
            chckTeslimedildiMi = new CheckBox();
            btnTeslimEt = new Button();
            label8 = new Label();
            cmbxDurum = new ComboBox();
            label3 = new Label();
            cmbxCihazlarKayit = new ComboBox();
            btnServisTemizle = new Button();
            label7 = new Label();
            cmbxMusterilerKayit = new ComboBox();
            txtServisID = new TextBox();
            label6 = new Label();
            btnServisSil = new Button();
            btnServisGuncelle = new Button();
            btnServisEkle = new Button();
            txtKesinÜcret = new TextBox();
            label4 = new Label();
            txtTahminiÜcret = new TextBox();
            label2 = new Label();
            txtArizaAçıklama = new TextBox();
            label1 = new Label();
            label5 = new Label();
            btnServisKayitAra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServisKayit).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewServisKayit
            // 
            dataGridViewServisKayit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServisKayit.Location = new Point(25, 23);
            dataGridViewServisKayit.Name = "dataGridViewServisKayit";
            dataGridViewServisKayit.RowHeadersWidth = 51;
            dataGridViewServisKayit.Size = new Size(1015, 439);
            dataGridViewServisKayit.TabIndex = 0;
            dataGridViewServisKayit.CellClick += dataGridViewServisKayit_CellClick;
            // 
            // txtServisKayitAra
            // 
            txtServisKayitAra.Location = new Point(1031, 517);
            txtServisKayitAra.Name = "txtServisKayitAra";
            txtServisKayitAra.Size = new Size(179, 27);
            txtServisKayitAra.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.Controls.Add(chckTeslimedildiMi);
            panel1.Controls.Add(btnTeslimEt);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cmbxDurum);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbxCihazlarKayit);
            panel1.Controls.Add(btnServisTemizle);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmbxMusterilerKayit);
            panel1.Controls.Add(txtServisID);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnServisSil);
            panel1.Controls.Add(btnServisGuncelle);
            panel1.Controls.Add(btnServisEkle);
            panel1.Controls.Add(txtKesinÜcret);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTahminiÜcret);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtArizaAçıklama);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 481);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 229);
            panel1.TabIndex = 21;
            // 
            // chckTeslimedildiMi
            // 
            chckTeslimedildiMi.AutoSize = true;
            chckTeslimedildiMi.Enabled = false;
            chckTeslimedildiMi.Location = new Point(438, 172);
            chckTeslimedildiMi.Name = "chckTeslimedildiMi";
            chckTeslimedildiMi.Size = new Size(143, 24);
            chckTeslimedildiMi.TabIndex = 24;
            chckTeslimedildiMi.Text = "Teslim edildi mi?";
            chckTeslimedildiMi.UseVisualStyleBackColor = true;
            // 
            // btnTeslimEt
            // 
            btnTeslimEt.BackColor = Color.FromArgb(165, 214, 167);
            btnTeslimEt.FlatAppearance.BorderColor = Color.Gray;
            btnTeslimEt.FlatAppearance.BorderSize = 3;
            btnTeslimEt.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnTeslimEt.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnTeslimEt.FlatStyle = FlatStyle.Flat;
            btnTeslimEt.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnTeslimEt.Location = new Point(636, 179);
            btnTeslimEt.Name = "btnTeslimEt";
            btnTeslimEt.Size = new Size(163, 47);
            btnTeslimEt.TabIndex = 23;
            btnTeslimEt.Text = "Teslim Et";
            btnTeslimEt.UseVisualStyleBackColor = false;
            btnTeslimEt.Click += btnTeslimEt_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.Location = new Point(660, 22);
            label8.Name = "label8";
            label8.Size = new Size(62, 26);
            label8.TabIndex = 22;
            label8.Text = "Durum";
            // 
            // cmbxDurum
            // 
            cmbxDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxDurum.FormattingEnabled = true;
            cmbxDurum.Location = new Point(658, 51);
            cmbxDurum.Name = "cmbxDurum";
            cmbxDurum.Size = new Size(151, 28);
            cmbxDurum.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(286, 22);
            label3.Name = "label3";
            label3.Size = new Size(72, 26);
            label3.TabIndex = 20;
            label3.Text = "Cihazlar";
            // 
            // cmbxCihazlarKayit
            // 
            cmbxCihazlarKayit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxCihazlarKayit.FormattingEnabled = true;
            cmbxCihazlarKayit.Location = new Point(284, 51);
            cmbxCihazlarKayit.Name = "cmbxCihazlarKayit";
            cmbxCihazlarKayit.Size = new Size(151, 28);
            cmbxCihazlarKayit.TabIndex = 19;
            // 
            // btnServisTemizle
            // 
            btnServisTemizle.BackColor = Color.FromArgb(165, 214, 167);
            btnServisTemizle.FlatAppearance.BorderColor = Color.Gray;
            btnServisTemizle.FlatAppearance.BorderSize = 3;
            btnServisTemizle.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnServisTemizle.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnServisTemizle.FlatStyle = FlatStyle.Flat;
            btnServisTemizle.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnServisTemizle.Location = new Point(825, 122);
            btnServisTemizle.Name = "btnServisTemizle";
            btnServisTemizle.Size = new Size(163, 47);
            btnServisTemizle.TabIndex = 18;
            btnServisTemizle.Text = "Temizle";
            btnServisTemizle.UseVisualStyleBackColor = false;
            btnServisTemizle.Click += btnServisTemizle_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label7.Location = new Point(475, 22);
            label7.Name = "label7";
            label7.Size = new Size(86, 26);
            label7.TabIndex = 17;
            label7.Text = "Müşteriler";
            // 
            // cmbxMusterilerKayit
            // 
            cmbxMusterilerKayit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxMusterilerKayit.FormattingEnabled = true;
            cmbxMusterilerKayit.Location = new Point(475, 51);
            cmbxMusterilerKayit.Name = "cmbxMusterilerKayit";
            cmbxMusterilerKayit.Size = new Size(151, 28);
            cmbxMusterilerKayit.TabIndex = 16;
            cmbxMusterilerKayit.SelectedIndexChanged += cmbxMusterilerKayit_SelectedIndexChanged;
            // 
            // txtServisID
            // 
            txtServisID.Location = new Point(15, 42);
            txtServisID.Name = "txtServisID";
            txtServisID.ReadOnly = true;
            txtServisID.Size = new Size(179, 27);
            txtServisID.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label6.Location = new Point(15, 13);
            label6.Name = "label6";
            label6.Size = new Size(80, 26);
            label6.TabIndex = 14;
            label6.Text = "Servis ID:";
            // 
            // btnServisSil
            // 
            btnServisSil.BackColor = Color.FromArgb(165, 214, 167);
            btnServisSil.FlatAppearance.BorderColor = Color.Gray;
            btnServisSil.FlatAppearance.BorderSize = 3;
            btnServisSil.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnServisSil.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnServisSil.FlatStyle = FlatStyle.Flat;
            btnServisSil.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnServisSil.Location = new Point(825, 179);
            btnServisSil.Name = "btnServisSil";
            btnServisSil.Size = new Size(163, 47);
            btnServisSil.TabIndex = 13;
            btnServisSil.Text = "Kayıt Sil";
            btnServisSil.UseVisualStyleBackColor = false;
            btnServisSil.Click += btnServisSil_Click;
            // 
            // btnServisGuncelle
            // 
            btnServisGuncelle.BackColor = Color.FromArgb(165, 214, 167);
            btnServisGuncelle.FlatAppearance.BorderColor = Color.Gray;
            btnServisGuncelle.FlatAppearance.BorderSize = 3;
            btnServisGuncelle.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnServisGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnServisGuncelle.FlatStyle = FlatStyle.Flat;
            btnServisGuncelle.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnServisGuncelle.Location = new Point(825, 69);
            btnServisGuncelle.Name = "btnServisGuncelle";
            btnServisGuncelle.Size = new Size(163, 47);
            btnServisGuncelle.TabIndex = 11;
            btnServisGuncelle.Text = "Kayıt Güncelle";
            btnServisGuncelle.UseVisualStyleBackColor = false;
            btnServisGuncelle.Click += btnServisGuncelle_Click;
            // 
            // btnServisEkle
            // 
            btnServisEkle.BackColor = Color.FromArgb(165, 214, 167);
            btnServisEkle.FlatAppearance.BorderColor = Color.Gray;
            btnServisEkle.FlatAppearance.BorderSize = 3;
            btnServisEkle.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnServisEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnServisEkle.FlatStyle = FlatStyle.Flat;
            btnServisEkle.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnServisEkle.Location = new Point(825, 7);
            btnServisEkle.Name = "btnServisEkle";
            btnServisEkle.Size = new Size(163, 54);
            btnServisEkle.TabIndex = 10;
            btnServisEkle.Text = "Kayıt Ekle";
            btnServisEkle.UseVisualStyleBackColor = false;
            btnServisEkle.Click += btnServisEkle_Click;
            // 
            // txtKesinÜcret
            // 
            txtKesinÜcret.Location = new Point(233, 170);
            txtKesinÜcret.Name = "txtKesinÜcret";
            txtKesinÜcret.Size = new Size(179, 27);
            txtKesinÜcret.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(233, 141);
            label4.Name = "label4";
            label4.Size = new Size(98, 26);
            label4.TabIndex = 6;
            label4.Text = "Kesin Ücret:";
            // 
            // txtTahminiÜcret
            // 
            txtTahminiÜcret.Location = new Point(15, 170);
            txtTahminiÜcret.Name = "txtTahminiÜcret";
            txtTahminiÜcret.Size = new Size(179, 27);
            txtTahminiÜcret.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(15, 141);
            label2.Name = "label2";
            label2.Size = new Size(118, 26);
            label2.TabIndex = 2;
            label2.Text = "Tahmini Ücret:";
            // 
            // txtArizaAçıklama
            // 
            txtArizaAçıklama.Location = new Point(15, 106);
            txtArizaAçıklama.Name = "txtArizaAçıklama";
            txtArizaAçıklama.Size = new Size(179, 27);
            txtArizaAçıklama.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(15, 77);
            label1.Name = "label1";
            label1.Size = new Size(124, 26);
            label1.TabIndex = 0;
            label1.Text = "Arıza Açıklama:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(1031, 488);
            label5.Name = "label5";
            label5.Size = new Size(85, 26);
            label5.TabIndex = 23;
            label5.Text = "Kayıt Ara:";
            // 
            // btnServisKayitAra
            // 
            btnServisKayitAra.BackColor = Color.FromArgb(165, 214, 167);
            btnServisKayitAra.FlatAppearance.BorderColor = Color.Gray;
            btnServisKayitAra.FlatAppearance.BorderSize = 3;
            btnServisKayitAra.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnServisKayitAra.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnServisKayitAra.FlatStyle = FlatStyle.Flat;
            btnServisKayitAra.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnServisKayitAra.Location = new Point(1031, 568);
            btnServisKayitAra.Name = "btnServisKayitAra";
            btnServisKayitAra.Size = new Size(179, 47);
            btnServisKayitAra.TabIndex = 22;
            btnServisKayitAra.Text = "Servis Kayıt Ara";
            btnServisKayitAra.UseVisualStyleBackColor = false;
            btnServisKayitAra.Click += btnServisKayitAra_Click;
            // 
            // ServisKayitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 187, 106);
            ClientSize = new Size(1296, 720);
            Controls.Add(txtServisKayitAra);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(btnServisKayitAra);
            Controls.Add(dataGridViewServisKayit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ServisKayitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ServisKayitForm";
            Load += ServisKayitForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewServisKayit).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewServisKayit;
        private TextBox txtServisKayitAra;
        private Panel panel1;
        private Button btnServisTemizle;
        private Label label7;
        private ComboBox cmbxMusterilerKayit;
        private TextBox txtServisID;
        private Label label6;
        private Button btnServisSil;
        private Button btnServisGuncelle;
        private Button btnServisEkle;
        private TextBox txtKesinÜcret;
        private Label label4;
        private TextBox txtTahminiÜcret;
        private Label label2;
        private TextBox txtArizaAçıklama;
        private Label label1;
        private Label label5;
        private Button btnServisKayitAra;
        private Label label3;
        private ComboBox cmbxCihazlarKayit;
        private Label label8;
        private ComboBox cmbxDurum;
        private Button btnTeslimEt;
        private CheckBox chckTeslimedildiMi;
    }
}