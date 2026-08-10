using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TeknikServisTakip.Model.cs;
using TeknikServisTakip.Repositories.cs;
using TeknikServisTakip.Services;

namespace TeknikServisTakip
{
    public partial class CihazlarForm : Form
    {
        string baglanti = @"Data Source=.;Initial Catalog=TeknikServis;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        private readonly CihazlarRepository _cihazlarRepository;
        private readonly CihazlarService _cihazlarService;

        private readonly MusteriRepository _musteriRepository;
        private readonly MusteriService _MusteriService;

        public CihazlarForm()
        {
            InitializeComponent();

            _cihazlarRepository = new CihazlarRepository(baglanti);
            _cihazlarService = new CihazlarService(_cihazlarRepository);

            _musteriRepository = new MusteriRepository(baglanti);
            _MusteriService = new MusteriService(_musteriRepository);
        }

        private bool TextBoxFormKontrol()
        {
            if (string.IsNullOrWhiteSpace(txtMarka.Text))
            {
                MessageBox.Show("Cihazın marka bigisi boş bırakılamaz!\nLütfen bilgileri kontrol edip tekrar deneyiniz.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Cihazın model bigisi boş bırakılamaz!\nLütfen bilgileri kontrol edip tekrar deneyiniz.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtImeı.Text))
            {
                MessageBox.Show("Cihazın IMEI bigisi boş bırakılamaz!\nLütfen bilgileri kontrol edip tekrar deneyiniz.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSeriNo.Text))
            {
                MessageBox.Show("Cihazın IMEI bigisi boş bırakılamaz!\nLütfen bilgileri kontrol edip tekrar deneyiniz.");
                return false;
            }

            string ımeı = txtImeı.Text;
            string seriNo = txtSeriNo.Text;

            if (!ımeı.All(char.IsDigit))
            {
                MessageBox.Show("Cihazın IMEI bilgisine sadece sayı girilmelidir!\nLütfen bilgileri kontrol edip tekrar deneyiniz.");
                return false;
            }

            if (!seriNo.All(char.IsDigit))
            {
                MessageBox.Show("Cihazın Seri No bilgisine sadece sayı girilmelidir!\nLütfen bilgileri kontrol edip tekrar deneyiniz.");
                return false;
            }

            if (ımeı.Length != 5)
            {
                MessageBox.Show("IMEI numarası 5 haneli olmalıdır\nLütfen bilgileri kontrol edip tekrar deneyiniz.");
                return false;
            }

            if (seriNo.Length != 5)
            {
                MessageBox.Show("Seri No 5 haneli olmalıdır\nLütfen bilgileri kontrol edip tekrar deneyiniz.");
                return false;
            }

            return true;
        }

        private void cmbxMusterilerCihaz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxMusterilerCihaz.SelectedIndex == -1)
            {
                return;
            }

            if (cmbxMusterilerCihaz.SelectedItem is not DataRowView row)
            {
                return;
            }

            int musteriID = Convert.ToInt32(row.Row["MusteriID"]);

            DataTable cihazlar = _cihazlarService.MusteriCihaziGetir(musteriID);

            if (cihazlar.Rows.Count == 0)
            {
                txtCihazID.Clear();
                txtMarka.Clear();
                txtModel.Clear();
                txtImeı.Clear();
                txtSeriNo.Clear();

                return;
            }

            DataRow cihazRow = cihazlar.Rows[0];

            txtCihazID.Text = cihazRow["CihazID"].ToString();
            txtMarka.Text = cihazRow["Marka"].ToString();
            txtModel.Text = cihazRow["Model"].ToString();
            txtImeı.Text = cihazRow["IMEI"].ToString();
            txtSeriNo.Text = cihazRow["SeriNo"].ToString();
        }

        public Cihaz SeciliCihazAl()
        {
            if (dataGridViewCihazlar.CurrentRow == null || dataGridViewCihazlar.CurrentRow.IsNewRow)
            {
                MessageBox.Show("İşlem yapmak için tablodan bir cihaz seçiniz!\nKontrol edip tekrar deneyiniz.");
                return null;
            }

            Cihaz cihaz = new Cihaz
            {
                CihazID = Convert.ToInt32(dataGridViewCihazlar.CurrentRow.Cells["CihazID"].Value),
                MusteriID = Convert.ToInt32(dataGridViewCihazlar.CurrentRow.Cells["MusteriID"].Value),
                Marka = dataGridViewCihazlar.CurrentRow.Cells["Marka"].ToString(),
                Model = dataGridViewCihazlar.CurrentRow.Cells["Model"].ToString(),
                IMEI = dataGridViewCihazlar.CurrentRow.Cells["IMEI"].ToString(),
                SeriNo = dataGridViewCihazlar.CurrentRow.Cells["SeriNo"].ToString(),
            };

            return cihaz;
        }

        public Cihaz FormdanAl(int cihazId, int musteriId)
        {
            return new Cihaz
            {
                CihazID = cihazId,
                MusteriID = musteriId,
                Marka = txtMarka.Text.Trim(),
                Model = txtModel.Text.Trim(),
                IMEI = txtImeı.Text.Trim(),
                SeriNo = txtSeriNo.Text.Trim(),
                kayitTarihi = DateTime.Now
            };
        }

        private void MusteriCmbxDoldur()
        {
            DataTable musteri = _musteriRepository.MusterileriListele();

            cmbxMusterilerCihaz.DataSource = musteri;
            cmbxMusterilerCihaz.DisplayMember = "Ad";
            cmbxMusterilerCihaz.ValueMember = "MusteriID";
            cmbxMusterilerCihaz.SelectedIndex = -1;
        }

        private void TextBoxClear()
        {
            cmbxMusterilerCihaz.SelectedIndex = -1;

            txtCihazID.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtImeı.Clear();
            txtSeriNo.Clear();
            txtCihazAra.Clear();
        }

        private void CihazlarıListele()
        {
            dataGridViewCihazlar.DataSource = _cihazlarRepository.CihazlarListele();

            dataGridViewCihazlar.ClearSelection();
        }

        private void CihazlarForm_Load(object sender, EventArgs e)
        {
            MusteriCmbxDoldur();
            CihazlarıListele();

            dataGridViewCihazlar.ClearSelection();
            TextBoxClear();
        }

        private void btnCihazEkle_Click(object sender, EventArgs e)
        {
            if (!TextBoxFormKontrol())
            {
                return;
            }

            if (cmbxMusterilerCihaz.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz!\nTekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int musteriID = Convert.ToInt32(cmbxMusterilerCihaz.SelectedValue);

            Cihaz cihaz = FormdanAl(0, musteriID);

            bool basariliMi = _cihazlarService.CihazEkle(cihaz, out string mesaj);

            if (!basariliMi)
            {
                MessageBox.Show(mesaj, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CihazlarıListele();
            MusteriCmbxDoldur();
            TextBoxClear();
        }

        private void btnCihazGuncelle_Click(object sender, EventArgs e)
        {
            if (!TextBoxFormKontrol())
            {
                return;
            }


            if (cmbxMusterilerCihaz.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz!\nTekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int musteriId = Convert.ToInt32(cmbxMusterilerCihaz.SelectedValue);

            int cihazId = Convert.ToInt32(txtCihazID.Text);

            Cihaz cihaz = FormdanAl(cihazId, musteriId);

            bool basariliMi = _cihazlarService.CihazGuncelle(cihaz, out string mesaj);

            if (!basariliMi)
            {
                MessageBox.Show(mesaj, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CihazlarıListele();
            MusteriCmbxDoldur();
            TextBoxClear();
        }

        private void btnCihazAra_Click(object sender, EventArgs e)
        {
            if (!TextBoxFormKontrol())
            {
                return;
            }

            string aranan = txtCihazAra.Text;

            dataGridViewCihazlar.DataSource = _cihazlarService.CihazAra(aranan);
        }

        private void btnTextbxTemizle_Click(object sender, EventArgs e)
        {
            CihazlarıListele();
            dataGridViewCihazlar.ClearSelection();
            TextBoxClear();
        }

        private void btnCihazSil_Click(object sender, EventArgs e)
        {
            Cihaz seciliCihaz = SeciliCihazAl();

            DialogResult cevap = MessageBox.Show("Seçtiğiniz müşteri silmek istediğinize eminmisiniz?",
                "SORU",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (cevap == DialogResult.No)
            {
                MessageBox.Show("Müşteri silinmedi","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }

            bool basariliMi = _cihazlarService.CihazSil(seciliCihaz,out string mesaj);

            if (!basariliMi)
            {
                MessageBox.Show(mesaj,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            MessageBox.Show("Seçtiğiniz müşteri başarıyla silindi.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);

            CihazlarıListele();
            MusteriCmbxDoldur();
            TextBoxClear();
        }
    }
}
