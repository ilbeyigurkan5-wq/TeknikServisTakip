namespace TeknikServisTakip
{
    partial class OdemelerForm
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
            dataGridViewServis = new DataGridView();
            dataGridViewOdemeler = new DataGridView();
            panel1 = new Panel();
            btnTemizle = new Button();
            btnOdemeAra = new Button();
            btnOdemeSil = new Button();
            btnOdemeEkle = new Button();
            label11 = new Label();
            cmbxOdemeTipi = new ComboBox();
            txtOdemeAra = new TextBox();
            label10 = new Label();
            txtAciklama = new TextBox();
            label7 = new Label();
            txtOdemeTutarı = new TextBox();
            label8 = new Label();
            txtKalanTutar = new TextBox();
            label9 = new Label();
            txtToplamOdenen = new TextBox();
            label3 = new Label();
            txtKesinUcret = new TextBox();
            label4 = new Label();
            txtCihaz = new TextBox();
            label5 = new Label();
            txtMusteri = new TextBox();
            label2 = new Label();
            txtServisId = new TextBox();
            label1 = new Label();
            txtOdemeId = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOdemeler).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewServis
            // 
            dataGridViewServis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServis.Location = new Point(18, 52);
            dataGridViewServis.Name = "dataGridViewServis";
            dataGridViewServis.ReadOnly = true;
            dataGridViewServis.RowHeadersWidth = 51;
            dataGridViewServis.Size = new Size(772, 380);
            dataGridViewServis.TabIndex = 0;
            dataGridViewServis.CellClick += dataGridViewServis_CellClick;
            // 
            // dataGridViewOdemeler
            // 
            dataGridViewOdemeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOdemeler.Location = new Point(825, 63);
            dataGridViewOdemeler.Name = "dataGridViewOdemeler";
            dataGridViewOdemeler.ReadOnly = true;
            dataGridViewOdemeler.RowHeadersWidth = 51;
            dataGridViewOdemeler.Size = new Size(737, 380);
            dataGridViewOdemeler.TabIndex = 1;
            dataGridViewOdemeler.CellClick += dataGridViewOdemeler_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTemizle);
            panel1.Controls.Add(btnOdemeAra);
            panel1.Controls.Add(btnOdemeSil);
            panel1.Controls.Add(btnOdemeEkle);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(cmbxOdemeTipi);
            panel1.Controls.Add(txtOdemeAra);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtAciklama);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtOdemeTutarı);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtKalanTutar);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtToplamOdenen);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtKesinUcret);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCihaz);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtMusteri);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtServisId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtOdemeId);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(18, 475);
            panel1.Name = "panel1";
            panel1.Size = new Size(1544, 263);
            panel1.TabIndex = 3;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(165, 214, 167);
            btnTemizle.FlatAppearance.BorderColor = Color.Gray;
            btnTemizle.FlatAppearance.BorderSize = 3;
            btnTemizle.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnTemizle.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnTemizle.Location = new Point(1365, 187);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(163, 47);
            btnTemizle.TabIndex = 43;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnOdemeAra
            // 
            btnOdemeAra.BackColor = Color.FromArgb(165, 214, 167);
            btnOdemeAra.FlatAppearance.BorderColor = Color.Gray;
            btnOdemeAra.FlatAppearance.BorderSize = 3;
            btnOdemeAra.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnOdemeAra.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnOdemeAra.FlatStyle = FlatStyle.Flat;
            btnOdemeAra.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnOdemeAra.Location = new Point(779, 183);
            btnOdemeAra.Name = "btnOdemeAra";
            btnOdemeAra.Size = new Size(116, 54);
            btnOdemeAra.TabIndex = 42;
            btnOdemeAra.Text = "Ödeme Ara";
            btnOdemeAra.UseVisualStyleBackColor = false;
            btnOdemeAra.Click += btnOdemeAra_Click;
            // 
            // btnOdemeSil
            // 
            btnOdemeSil.BackColor = Color.FromArgb(165, 214, 167);
            btnOdemeSil.FlatAppearance.BorderColor = Color.Gray;
            btnOdemeSil.FlatAppearance.BorderSize = 3;
            btnOdemeSil.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnOdemeSil.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnOdemeSil.FlatStyle = FlatStyle.Flat;
            btnOdemeSil.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnOdemeSil.Location = new Point(1365, 99);
            btnOdemeSil.Name = "btnOdemeSil";
            btnOdemeSil.Size = new Size(163, 47);
            btnOdemeSil.TabIndex = 39;
            btnOdemeSil.Text = "Ödeme Sil";
            btnOdemeSil.UseVisualStyleBackColor = false;
            btnOdemeSil.Click += btnOdemeSil_Click;
            // 
            // btnOdemeEkle
            // 
            btnOdemeEkle.BackColor = Color.FromArgb(165, 214, 167);
            btnOdemeEkle.FlatAppearance.BorderColor = Color.Gray;
            btnOdemeEkle.FlatAppearance.BorderSize = 3;
            btnOdemeEkle.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnOdemeEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnOdemeEkle.FlatStyle = FlatStyle.Flat;
            btnOdemeEkle.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnOdemeEkle.Location = new Point(1365, 7);
            btnOdemeEkle.Name = "btnOdemeEkle";
            btnOdemeEkle.Size = new Size(163, 54);
            btnOdemeEkle.TabIndex = 38;
            btnOdemeEkle.Text = "Ödeme Al";
            btnOdemeEkle.UseVisualStyleBackColor = false;
            btnOdemeEkle.Click += btnOdemeEkle_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label11.Location = new Point(965, 22);
            label11.Name = "label11";
            label11.Size = new Size(93, 26);
            label11.TabIndex = 37;
            label11.Text = "Ödeme Tipi";
            // 
            // cmbxOdemeTipi
            // 
            cmbxOdemeTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxOdemeTipi.FormattingEnabled = true;
            cmbxOdemeTipi.Location = new Point(965, 51);
            cmbxOdemeTipi.Name = "cmbxOdemeTipi";
            cmbxOdemeTipi.Size = new Size(195, 28);
            cmbxOdemeTipi.TabIndex = 36;
            // 
            // txtOdemeAra
            // 
            txtOdemeAra.Location = new Point(751, 129);
            txtOdemeAra.Name = "txtOdemeAra";
            txtOdemeAra.Size = new Size(179, 27);
            txtOdemeAra.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label10.Location = new Point(751, 100);
            label10.Name = "label10";
            label10.Size = new Size(92, 26);
            label10.TabIndex = 34;
            label10.Text = "Ödeme ara:";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(532, 210);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(179, 27);
            txtAciklama.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label7.Location = new Point(532, 181);
            label7.Name = "label7";
            label7.Size = new Size(82, 26);
            label7.TabIndex = 32;
            label7.Text = "Açıklama:";
            // 
            // txtOdemeTutarı
            // 
            txtOdemeTutarı.Location = new Point(532, 128);
            txtOdemeTutarı.Name = "txtOdemeTutarı";
            txtOdemeTutarı.Size = new Size(179, 27);
            txtOdemeTutarı.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.Location = new Point(532, 99);
            label8.Name = "label8";
            label8.Size = new Size(110, 26);
            label8.TabIndex = 30;
            label8.Text = "Ödeme tutarı:";
            // 
            // txtKalanTutar
            // 
            txtKalanTutar.Location = new Point(532, 48);
            txtKalanTutar.Name = "txtKalanTutar";
            txtKalanTutar.ReadOnly = true;
            txtKalanTutar.Size = new Size(179, 27);
            txtKalanTutar.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label9.Location = new Point(532, 19);
            label9.Name = "label9";
            label9.Size = new Size(102, 26);
            label9.TabIndex = 28;
            label9.Text = "Kalan Tutar:";
            // 
            // txtToplamOdenen
            // 
            txtToplamOdenen.Location = new Point(292, 210);
            txtToplamOdenen.Name = "txtToplamOdenen";
            txtToplamOdenen.ReadOnly = true;
            txtToplamOdenen.Size = new Size(179, 27);
            txtToplamOdenen.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(292, 181);
            label3.Name = "label3";
            label3.Size = new Size(126, 26);
            label3.TabIndex = 26;
            label3.Text = "Toplam Ödenen:";
            // 
            // txtKesinUcret
            // 
            txtKesinUcret.Location = new Point(292, 128);
            txtKesinUcret.Name = "txtKesinUcret";
            txtKesinUcret.ReadOnly = true;
            txtKesinUcret.Size = new Size(179, 27);
            txtKesinUcret.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(292, 99);
            label4.Name = "label4";
            label4.Size = new Size(98, 26);
            label4.TabIndex = 24;
            label4.Text = "Kesin Ücret:";
            // 
            // txtCihaz
            // 
            txtCihaz.Location = new Point(292, 48);
            txtCihaz.Name = "txtCihaz";
            txtCihaz.ReadOnly = true;
            txtCihaz.Size = new Size(211, 27);
            txtCihaz.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(292, 19);
            label5.Name = "label5";
            label5.Size = new Size(57, 26);
            label5.TabIndex = 22;
            label5.Text = "Cihaz:";
            // 
            // txtMusteri
            // 
            txtMusteri.Location = new Point(21, 210);
            txtMusteri.Name = "txtMusteri";
            txtMusteri.ReadOnly = true;
            txtMusteri.Size = new Size(225, 27);
            txtMusteri.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(21, 181);
            label2.Name = "label2";
            label2.Size = new Size(72, 26);
            label2.TabIndex = 20;
            label2.Text = "Müşteri:";
            // 
            // txtServisId
            // 
            txtServisId.Location = new Point(21, 128);
            txtServisId.Name = "txtServisId";
            txtServisId.ReadOnly = true;
            txtServisId.Size = new Size(179, 27);
            txtServisId.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(21, 99);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 18;
            label1.Text = "Servis ID";
            // 
            // txtOdemeId
            // 
            txtOdemeId.Location = new Point(21, 48);
            txtOdemeId.Name = "txtOdemeId";
            txtOdemeId.ReadOnly = true;
            txtOdemeId.Size = new Size(179, 27);
            txtOdemeId.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label6.Location = new Point(21, 19);
            label6.Name = "label6";
            label6.Size = new Size(81, 26);
            label6.TabIndex = 16;
            label6.Text = "OdemeID:";
            // 
            // OdemelerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 187, 106);
            ClientSize = new Size(1591, 750);
            Controls.Add(panel1);
            Controls.Add(dataGridViewOdemeler);
            Controls.Add(dataGridViewServis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OdemelerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OdemelerForm";
            Load += OdemelerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewServis).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOdemeler).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewServis;
        private DataGridView dataGridViewOdemeler;
        private Panel panel1;
        private Button btnTemizle;
        private Button btnOdemeAra;
        private Button btnOdemeSil;
        private Button btnOdemeEkle;
        private Label label11;
        private ComboBox cmbxOdemeTipi;
        private TextBox txtOdemeAra;
        private Label label10;
        private TextBox txtAciklama;
        private Label label7;
        private TextBox txtOdemeTutarı;
        private Label label8;
        private TextBox txtKalanTutar;
        private Label label9;
        private TextBox txtToplamOdenen;
        private Label label3;
        private TextBox txtKesinUcret;
        private Label label4;
        private TextBox txtCihaz;
        private Label label5;
        private TextBox txtMusteri;
        private Label label2;
        private TextBox txtServisId;
        private Label label1;
        private TextBox txtOdemeId;
        private Label label6;
    }
}