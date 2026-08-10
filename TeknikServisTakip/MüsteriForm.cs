using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using TeknikServisTakip.Model.cs;
using TeknikServisTakip.Repositories.cs;
using TeknikServisTakip.Services;

namespace TeknikServisTakip
{
    public partial class MüsteriForm : Form
    {
        string baglanti = @"Data Source=.;Initial Catalog=TeknikServis;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        private readonly MusteriRepository _musteriRepository;

        private readonly MusteriService _musteriservice;

        public MüsteriForm()
        {
            InitializeComponent();

            _musteriRepository = new MusteriRepository(baglanti);

            _musteriservice = new MusteriService(_musteriRepository);
        }

        private void ComboBoxDoldur()
        {
            DataTable musteri = _musteriservice.MusteriListele();

            cmbxMusteriler.DataSource = musteri;
            cmbxMusteriler.DisplayMember = "Ad";
            cmbxMusteriler.ValueMember = "MusteriID";
            cmbxMusteriler.SelectedIndex = -1;
        }

        private void cmbxMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxMusteriler.SelectedItem == null)
            {
                return;
            }

            if (cmbxMusteriler.SelectedItem is not DataRowView row)
            {
                return;
            }

            int musteriID = Convert.ToInt32(row.Row["MusteriID"]);
            txtMusteriID.Text = musteriID.ToString();

            string musteriAdi = row.Row["Ad"].ToString();
            txtMusteriAdi.Text = musteriAdi;

            string soyad = row.Row["Soyad"].ToString();
            txtMusteriSoyad.Text = soyad;

            string telefonNo = row.Row["TelefonNo"].ToString();
            txtMusteriTelNo.Text = telefonNo;

            string il = row.Row["İl"].ToString();
            txtMusteriİl.Text = il;

            string ilce = row.Row["İlce"].ToString();
            txtMusteriİlce.Text = ilce;
        }

        private void ListData()
        {
            dataGridViewMusteriler.DataSource = _musteriservice.MusteriListele();
        }

        private bool TextBoxFormdanAl()
        {
            if (string.IsNullOrWhiteSpace(txtMusteriAdi.Text))
            {
                MessageBox.Show("Müşteri adı boş bırakılamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMusteriSoyad.Text))
            {
                MessageBox.Show("Müşteri soyadı boş bırakılamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMusteriTelNo.Text))
            {
                MessageBox.Show("Müşteri telefon numarası boş bırakılamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMusteriİl.Text))
            {
                MessageBox.Show("Müşteri il bilgisi boş bırakılamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMusteriİlce.Text))
            {
                MessageBox.Show("Müşteri ilçe bilgisi boş bırakılamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string telNo = txtMusteriTelNo.Text;

            if (!telNo.All(char.IsDigit))
            {
                MessageBox.Show("Telefon numarası alanına girilen değer sadece sayı olmalıdır!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (telNo.Length != 4)
            {
                MessageBox.Show("Telefon numarası 4 haneli olmalıdır", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public Musteriler FormdanAl(int musteriId)
        {
            return new Musteriler
            {
                MusteriID = musteriId,
                MusteriAd = txtMusteriAdi.Text.Trim(),
                MusteriSoyad = txtMusteriSoyad.Text.Trim(),
                MusteriTelNo = txtMusteriTelNo.Text.Trim(),
                MusteriIl = txtMusteriİl.Text.Trim(),
                MusteriIlce = txtMusteriİlce.Text.Trim()
            };
        }


        public Musteriler SeciliMusteriAl()
        {
            if (dataGridViewMusteriler.CurrentRow == null || dataGridViewMusteriler.CurrentRow.IsNewRow)
            {
                return null;
            }

            Musteriler musteri = new Musteriler
            {
                MusteriID = Convert.ToInt32(dataGridViewMusteriler.CurrentRow.Cells["MusteriID"].Value),
                MusteriAd = dataGridViewMusteriler.CurrentRow.Cells["Ad"].Value.ToString(),
                MusteriSoyad = dataGridViewMusteriler.CurrentRow.Cells["Soyad"].Value.ToString(),
                MusteriTelNo = dataGridViewMusteriler.CurrentRow.Cells["TelefonNo"].Value.ToString(),
                MusteriIl = dataGridViewMusteriler.CurrentRow.Cells["İl"].Value.ToString(),
                MusteriIlce = dataGridViewMusteriler.CurrentRow.Cells["İlce"].Value.ToString()
            };
            return musteri;
        }

        private void TextBoxClear()
        {
            cmbxMusteriler.SelectedIndex = -1;

            txtMusteriID.Clear();
            txtMusteriAdi.Clear();
            txtMusteriSoyad.Clear();
            txtMusteriTelNo.Clear();
            txtMusteriİl.Clear();
            txtMusteriİlce.Clear();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (!TextBoxFormdanAl())
            {
                return;
            }

            Musteriler musteri = FormdanAl(0);

            bool basariliMi = _musteriservice.MusteriEkle(musteri, out string mesaj);

            if (!basariliMi)
            {
                MessageBox.Show(mesaj, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListData();
            ComboBoxDoldur();
            TextBoxClear();
        }

        private void MüsteriForm_Load(object sender, EventArgs e)
        {
            ListData();
            ComboBoxDoldur();

            dataGridViewMusteriler.ClearSelection();
            TextBoxClear();
        }

        private void btnMusteriAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMusteriAdi.Text))
            {
                MessageBox.Show("aradığınız müşteri adını giriniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Musteriler musteri = FormdanAl(0);

            dataGridViewMusteriler.DataSource = _musteriservice.MusteriAra(musteri);
        }

        private void btnTextbxTemizle_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            ListData();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbxMusteriler.SelectedValue == null)
            {
                MessageBox.Show("Geçerli bir müşteri seçiniz!");
                return;
            }

            if (!TextBoxFormdanAl())
            {
                return;
            }

            int musteriId = Convert.ToInt32(cmbxMusteriler.SelectedValue);

            Musteriler musteri = FormdanAl(musteriId);


            bool basariliMi = _musteriservice.MusteriGuncelle(musteri, out string mesaj);

            if (!basariliMi)
            {
                MessageBox.Show(mesaj, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListData();
            ComboBoxDoldur();
            TextBoxClear();
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {

            if (dataGridViewMusteriler.CurrentRow == null || dataGridViewMusteriler.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Müşteri seçilmedi! Lütfen müşteri seçiniz.");
                return;
            }

            Musteriler seciliMusteri = SeciliMusteriAl();

            DialogResult cevap = MessageBox.Show("Tablodan seçtiğniz müşteri silmek istedğinize eminmisiniz?","SORU",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (cevap == DialogResult.No)
            {
                MessageBox.Show("Müşteri silinmedi","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            bool basariliMi = _musteriservice.MusteriSil(seciliMusteri.MusteriID,out string mesaj);

            if (!basariliMi)
            {
                MessageBox.Show(mesaj,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(mesaj,"BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);

            ListData();
            ComboBoxDoldur();
            TextBoxClear();
        }
    }
}
