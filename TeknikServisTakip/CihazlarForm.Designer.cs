namespace TeknikServisTakip
{
    partial class CihazlarForm
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
            dataGridViewCihazlar = new DataGridView();
            panel1 = new Panel();
            btnTextbxTemizle = new Button();
            label7 = new Label();
            cmbxMusterilerCihaz = new ComboBox();
            txtCihazID = new TextBox();
            label6 = new Label();
            btnCihazSil = new Button();
            btnCihazGuncelle = new Button();
            btnCihazEkle = new Button();
            txtSeriNo = new TextBox();
            label4 = new Label();
            txtImeı = new TextBox();
            label3 = new Label();
            txtModel = new TextBox();
            label2 = new Label();
            txtMarka = new TextBox();
            label1 = new Label();
            btnCihazAra = new Button();
            txtCihazAra = new TextBox();
            label5 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCihazlar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCihazlar
            // 
            dataGridViewCihazlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCihazlar.Location = new Point(25, 22);
            dataGridViewCihazlar.Name = "dataGridViewCihazlar";
            dataGridViewCihazlar.RowHeadersWidth = 51;
            dataGridViewCihazlar.Size = new Size(972, 420);
            dataGridViewCihazlar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnTextbxTemizle);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmbxMusterilerCihaz);
            panel1.Controls.Add(txtCihazID);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnCihazSil);
            panel1.Controls.Add(btnCihazGuncelle);
            panel1.Controls.Add(btnCihazEkle);
            panel1.Controls.Add(txtSeriNo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtImeı);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtModel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMarka);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 471);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 232);
            panel1.TabIndex = 2;
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
            btnTextbxTemizle.Location = new Point(682, 122);
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
            // cmbxMusterilerCihaz
            // 
            cmbxMusterilerCihaz.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxMusterilerCihaz.FormattingEnabled = true;
            cmbxMusterilerCihaz.Location = new Point(475, 51);
            cmbxMusterilerCihaz.Name = "cmbxMusterilerCihaz";
            cmbxMusterilerCihaz.Size = new Size(151, 28);
            cmbxMusterilerCihaz.TabIndex = 16;
            cmbxMusterilerCihaz.SelectedIndexChanged += cmbxMusterilerCihaz_SelectedIndexChanged;
            // 
            // txtCihazID
            // 
            txtCihazID.Location = new Point(15, 42);
            txtCihazID.Name = "txtCihazID";
            txtCihazID.ReadOnly = true;
            txtCihazID.Size = new Size(179, 27);
            txtCihazID.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label6.Location = new Point(15, 13);
            label6.Name = "label6";
            label6.Size = new Size(77, 26);
            label6.TabIndex = 14;
            label6.Text = "Cihaz ID:";
            // 
            // btnCihazSil
            // 
            btnCihazSil.BackColor = Color.FromArgb(165, 214, 167);
            btnCihazSil.FlatAppearance.BorderColor = Color.Gray;
            btnCihazSil.FlatAppearance.BorderSize = 3;
            btnCihazSil.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnCihazSil.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnCihazSil.FlatStyle = FlatStyle.Flat;
            btnCihazSil.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnCihazSil.Location = new Point(682, 179);
            btnCihazSil.Name = "btnCihazSil";
            btnCihazSil.Size = new Size(163, 47);
            btnCihazSil.TabIndex = 13;
            btnCihazSil.Text = "Cihaz Sil";
            btnCihazSil.UseVisualStyleBackColor = false;
            btnCihazSil.Click += btnCihazSil_Click;
            // 
            // btnCihazGuncelle
            // 
            btnCihazGuncelle.BackColor = Color.FromArgb(165, 214, 167);
            btnCihazGuncelle.FlatAppearance.BorderColor = Color.Gray;
            btnCihazGuncelle.FlatAppearance.BorderSize = 3;
            btnCihazGuncelle.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnCihazGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnCihazGuncelle.FlatStyle = FlatStyle.Flat;
            btnCihazGuncelle.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnCihazGuncelle.Location = new Point(682, 69);
            btnCihazGuncelle.Name = "btnCihazGuncelle";
            btnCihazGuncelle.Size = new Size(163, 47);
            btnCihazGuncelle.TabIndex = 11;
            btnCihazGuncelle.Text = "Cihaz Güncelle";
            btnCihazGuncelle.UseVisualStyleBackColor = false;
            btnCihazGuncelle.Click += btnCihazGuncelle_Click;
            // 
            // btnCihazEkle
            // 
            btnCihazEkle.BackColor = Color.FromArgb(165, 214, 167);
            btnCihazEkle.FlatAppearance.BorderColor = Color.Gray;
            btnCihazEkle.FlatAppearance.BorderSize = 3;
            btnCihazEkle.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnCihazEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnCihazEkle.FlatStyle = FlatStyle.Flat;
            btnCihazEkle.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnCihazEkle.Location = new Point(682, 7);
            btnCihazEkle.Name = "btnCihazEkle";
            btnCihazEkle.Size = new Size(163, 54);
            btnCihazEkle.TabIndex = 10;
            btnCihazEkle.Text = "Cihaz Ekle";
            btnCihazEkle.UseVisualStyleBackColor = false;
            btnCihazEkle.Click += btnCihazEkle_Click;
            // 
            // txtSeriNo
            // 
            txtSeriNo.Location = new Point(228, 146);
            txtSeriNo.Name = "txtSeriNo";
            txtSeriNo.Size = new Size(179, 27);
            txtSeriNo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(228, 117);
            label4.Name = "label4";
            label4.Size = new Size(69, 26);
            label4.TabIndex = 6;
            label4.Text = "Seri No:";
            // 
            // txtImeı
            // 
            txtImeı.Location = new Point(228, 82);
            txtImeı.Name = "txtImeı";
            txtImeı.Size = new Size(179, 27);
            txtImeı.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(228, 53);
            label3.Name = "label3";
            label3.Size = new Size(51, 26);
            label3.TabIndex = 4;
            label3.Text = "IMEI:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(15, 170);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(179, 27);
            txtModel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(15, 141);
            label2.Name = "label2";
            label2.Size = new Size(104, 26);
            label2.TabIndex = 2;
            label2.Text = "Cihaz Model:";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(15, 106);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(179, 27);
            txtMarka.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(15, 77);
            label1.Name = "label1";
            label1.Size = new Size(106, 26);
            label1.TabIndex = 0;
            label1.Text = "Cihaz Marka:";
            // 
            // btnCihazAra
            // 
            btnCihazAra.BackColor = Color.FromArgb(165, 214, 167);
            btnCihazAra.FlatAppearance.BorderColor = Color.Gray;
            btnCihazAra.FlatAppearance.BorderSize = 3;
            btnCihazAra.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnCihazAra.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnCihazAra.FlatStyle = FlatStyle.Flat;
            btnCihazAra.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnCihazAra.Location = new Point(919, 554);
            btnCihazAra.Name = "btnCihazAra";
            btnCihazAra.Size = new Size(121, 47);
            btnCihazAra.TabIndex = 12;
            btnCihazAra.Text = "Cihaz Ara";
            btnCihazAra.UseVisualStyleBackColor = false;
            btnCihazAra.Click += btnCihazAra_Click;
            // 
            // txtCihazAra
            // 
            txtCihazAra.Location = new Point(888, 500);
            txtCihazAra.Name = "txtCihazAra";
            txtCihazAra.Size = new Size(179, 27);
            txtCihazAra.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(888, 471);
            label5.Name = "label5";
            label5.Size = new Size(86, 26);
            label5.TabIndex = 19;
            label5.Text = "Cihaz Ara:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Display", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label9.Location = new Point(373, 103);
            label9.Name = "label9";
            label9.Size = new Size(102, 26);
            label9.TabIndex = 29;
            label9.Text = "Kalan Tutar:";
            // 
            // CihazlarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 187, 106);
            ClientSize = new Size(1504, 726);
            Controls.Add(txtCihazAra);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(dataGridViewCihazlar);
            Controls.Add(btnCihazAra);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CihazlarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CihazlarForm";
            Load += CihazlarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCihazlar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCihazlar;
        private Panel panel1;
        private Button btnTextbxTemizle;
        private Label label7;
        private ComboBox cmbxMusterilerCihaz;
        private TextBox txtCihazID;
        private Label label6;
        private Button btnCihazSil;
        private Button btnCihazAra;
        private Button btnCihazGuncelle;
        private Button btnCihazEkle;
        private TextBox txtSeriNo;
        private Label label4;
        private TextBox txtImeı;
        private Label label3;
        private TextBox txtModel;
        private Label label2;
        private TextBox txtMarka;
        private Label label1;
        private TextBox txtCihazAra;
        private Label label5;
        private Label label9;
    }
}