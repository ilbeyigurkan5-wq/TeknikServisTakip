namespace TeknikServisTakip
{
    partial class MüsteriForm
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
            dataGridViewMusteriler = new DataGridView();
            panel1 = new Panel();
            btnTextbxTemizle = new Button();
            label7 = new Label();
            cmbxMusteriler = new ComboBox();
            txtMusteriID = new TextBox();
            label6 = new Label();
            btnMusteriSil = new Button();
            btnMusteriAra = new Button();
            btnMusteriGuncelle = new Button();
            btnMusteriEkle = new Button();
            txtMusteriİlce = new TextBox();
            label5 = new Label();
            txtMusteriİl = new TextBox();
            label4 = new Label();
            txtMusteriTelNo = new TextBox();
            label3 = new Label();
            txtMusteriSoyad = new TextBox();
            label2 = new Label();
            txtMusteriAdi = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMusteriler).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMusteriler
            // 
            dataGridViewMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMusteriler.Location = new Point(21, 21);
            dataGridViewMusteriler.Name = "dataGridViewMusteriler";
            dataGridViewMusteriler.ReadOnly = true;
            dataGridViewMusteriler.RowHeadersWidth = 51;
            dataGridViewMusteriler.Size = new Size(754, 406);
            dataGridViewMusteriler.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTextbxTemizle);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmbxMusteriler);
            panel1.Controls.Add(txtMusteriID);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnMusteriSil);
            panel1.Controls.Add(btnMusteriAra);
            panel1.Controls.Add(btnMusteriGuncelle);
            panel1.Controls.Add(btnMusteriEkle);
            panel1.Controls.Add(txtMusteriİlce);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtMusteriİl);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtMusteriTelNo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMusteriSoyad);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMusteriAdi);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 433);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 232);
            panel1.TabIndex = 1;
            // 
            // btnTextbxTemizle
            // 
            btnTextbxTemizle.BackColor = Color.FromArgb(165, 214, 167);
            btnTextbxTemizle.FlatAppearance.BorderColor = Color.Gray;
            btnTextbxTemizle.FlatAppearance.BorderSize = 3;
            btnTextbxTemizle.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnTextbxTemizle.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnTextbxTemizle.FlatStyle = FlatStyle.Flat;
            btnTextbxTemizle.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnTextbxTemizle.Location = new Point(475, 179);
            btnTextbxTemizle.Name = "btnTextbxTemizle";
            btnTextbxTemizle.Size = new Size(163, 47);
            btnTextbxTemizle.TabIndex = 18;
            btnTextbxTemizle.Text = "Temizle";
            btnTextbxTemizle.UseVisualStyleBackColor = false;
            btnTextbxTemizle.Click += btnTextbxTemizle_Click;
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
            // cmbxMusteriler
            // 
            cmbxMusteriler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxMusteriler.FormattingEnabled = true;
            cmbxMusteriler.Location = new Point(475, 51);
            cmbxMusteriler.Name = "cmbxMusteriler";
            cmbxMusteriler.Size = new Size(151, 28);
            cmbxMusteriler.TabIndex = 16;
            cmbxMusteriler.SelectedIndexChanged += cmbxMusteriler_SelectedIndexChanged;
            // 
            // txtMusteriID
            // 
            txtMusteriID.Location = new Point(15, 42);
            txtMusteriID.Name = "txtMusteriID";
            txtMusteriID.ReadOnly = true;
            txtMusteriID.Size = new Size(179, 27);
            txtMusteriID.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label6.Location = new Point(15, 13);
            label6.Name = "label6";
            label6.Size = new Size(92, 26);
            label6.TabIndex = 14;
            label6.Text = "Müşteri ID:";
            // 
            // btnMusteriSil
            // 
            btnMusteriSil.BackColor = Color.FromArgb(165, 214, 167);
            btnMusteriSil.FlatAppearance.BorderColor = Color.Gray;
            btnMusteriSil.FlatAppearance.BorderSize = 3;
            btnMusteriSil.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnMusteriSil.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnMusteriSil.FlatStyle = FlatStyle.Flat;
            btnMusteriSil.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnMusteriSil.Location = new Point(682, 179);
            btnMusteriSil.Name = "btnMusteriSil";
            btnMusteriSil.Size = new Size(163, 47);
            btnMusteriSil.TabIndex = 13;
            btnMusteriSil.Text = "Müşteri Sil";
            btnMusteriSil.UseVisualStyleBackColor = false;
            btnMusteriSil.Click += btnMusteriSil_Click;
            // 
            // btnMusteriAra
            // 
            btnMusteriAra.BackColor = Color.FromArgb(165, 214, 167);
            btnMusteriAra.FlatAppearance.BorderColor = Color.Gray;
            btnMusteriAra.FlatAppearance.BorderSize = 3;
            btnMusteriAra.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnMusteriAra.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnMusteriAra.FlatStyle = FlatStyle.Flat;
            btnMusteriAra.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnMusteriAra.Location = new Point(682, 69);
            btnMusteriAra.Name = "btnMusteriAra";
            btnMusteriAra.Size = new Size(163, 47);
            btnMusteriAra.TabIndex = 12;
            btnMusteriAra.Text = "Müşteri Ara";
            btnMusteriAra.UseVisualStyleBackColor = false;
            btnMusteriAra.Click += btnMusteriAra_Click;
            // 
            // btnMusteriGuncelle
            // 
            btnMusteriGuncelle.BackColor = Color.FromArgb(165, 214, 167);
            btnMusteriGuncelle.FlatAppearance.BorderColor = Color.Gray;
            btnMusteriGuncelle.FlatAppearance.BorderSize = 3;
            btnMusteriGuncelle.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnMusteriGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnMusteriGuncelle.FlatStyle = FlatStyle.Flat;
            btnMusteriGuncelle.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnMusteriGuncelle.Location = new Point(682, 124);
            btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            btnMusteriGuncelle.Size = new Size(163, 47);
            btnMusteriGuncelle.TabIndex = 11;
            btnMusteriGuncelle.Text = "Müşteri Güncelle";
            btnMusteriGuncelle.UseVisualStyleBackColor = false;
            btnMusteriGuncelle.Click += btnMusteriGuncelle_Click;
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.BackColor = Color.FromArgb(165, 214, 167);
            btnMusteriEkle.FlatAppearance.BorderColor = Color.Gray;
            btnMusteriEkle.FlatAppearance.BorderSize = 3;
            btnMusteriEkle.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnMusteriEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnMusteriEkle.FlatStyle = FlatStyle.Flat;
            btnMusteriEkle.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnMusteriEkle.Location = new Point(682, 7);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(163, 54);
            btnMusteriEkle.TabIndex = 10;
            btnMusteriEkle.Text = "Müşteri Ekle";
            btnMusteriEkle.UseVisualStyleBackColor = false;
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // txtMusteriİlce
            // 
            txtMusteriİlce.Location = new Point(240, 170);
            txtMusteriİlce.Name = "txtMusteriİlce";
            txtMusteriİlce.Size = new Size(179, 27);
            txtMusteriİlce.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(240, 141);
            label5.Name = "label5";
            label5.Size = new Size(41, 26);
            label5.TabIndex = 8;
            label5.Text = "İlçe:";
            // 
            // txtMusteriİl
            // 
            txtMusteriİl.Location = new Point(240, 106);
            txtMusteriİl.Name = "txtMusteriİl";
            txtMusteriİl.Size = new Size(179, 27);
            txtMusteriİl.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(240, 77);
            label4.Name = "label4";
            label4.Size = new Size(27, 26);
            label4.TabIndex = 6;
            label4.Text = "İl:";
            // 
            // txtMusteriTelNo
            // 
            txtMusteriTelNo.Location = new Point(240, 42);
            txtMusteriTelNo.Name = "txtMusteriTelNo";
            txtMusteriTelNo.Size = new Size(179, 27);
            txtMusteriTelNo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(240, 13);
            label3.Name = "label3";
            label3.Size = new Size(91, 26);
            label3.TabIndex = 4;
            label3.Text = "Telefon No:";
            // 
            // txtMusteriSoyad
            // 
            txtMusteriSoyad.Location = new Point(15, 170);
            txtMusteriSoyad.Name = "txtMusteriSoyad";
            txtMusteriSoyad.Size = new Size(179, 27);
            txtMusteriSoyad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(15, 141);
            label2.Name = "label2";
            label2.Size = new Size(60, 26);
            label2.TabIndex = 2;
            label2.Text = "Soyad:";
            // 
            // txtMusteriAdi
            // 
            txtMusteriAdi.Location = new Point(15, 106);
            txtMusteriAdi.Name = "txtMusteriAdi";
            txtMusteriAdi.Size = new Size(179, 27);
            txtMusteriAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(15, 77);
            label1.Name = "label1";
            label1.Size = new Size(100, 26);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Adı:";
            // 
            // MüsteriForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 187, 106);
            ClientSize = new Size(1133, 677);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(dataGridViewMusteriler);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MüsteriForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MüsteriForm";
            Load += MüsteriForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMusteriler).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewMusteriler;
        private Panel panel1;
        private TextBox txtMusteriAdi;
        private Label label1;
        private TextBox txtMusteriİlce;
        private Label label5;
        private TextBox txtMusteriİl;
        private Label label4;
        private TextBox txtMusteriTelNo;
        private Label label3;
        private TextBox txtMusteriSoyad;
        private Label label2;
        private Button btnMusteriEkle;
        private Button btnMusteriGuncelle;
        private Button btnMusteriSil;
        private Button btnMusteriAra;
        private TextBox txtMusteriID;
        private Label label6;
        private Label label7;
        private ComboBox cmbxMusteriler;
        private Button btnTextbxTemizle;
    }
}