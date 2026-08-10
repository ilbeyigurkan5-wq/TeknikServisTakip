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
    public partial class ServisKayitForm : Form
    {
        string baglanti = @"Data Source=.;Initial Catalog=TeknikServis;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        private readonly MusteriRepository _musteriRepository;
        private readonly MusteriService _musteriService;

        private readonly CihazlarRepository _cihazlarRepository;
        private readonly CihazlarService _cihazlarService;

        private readonly ServisKayitRepository _servisKayitRepository;
        private readonly ServisKayitService _servisKayitService;


        public ServisKayitForm()
        {
            InitializeComponent();

            _musteriRepository = new MusteriRepository(baglanti);
            _musteriService = new MusteriService(_musteriRepository);

            _cihazlarRepository = new CihazlarRepository(baglanti);
            _cihazlarService = new CihazlarService(_cihazlarRepository);

            _servisKayitRepository = new ServisKayitRepository(baglanti);
            _servisKayitService = new ServisKayitService(_servisKayitRepository);

        }

        public void CihazCmbxDoldur(int musteriId)
        {
            DataTable cihaz = _cihazlarRepository.MusteriyeGoreCihazListele(musteriId);

            cmbxCihazlarKayit.DataSource = cihaz;
            cmbxCihazlarKayit.DisplayMember = "Cihaz bilgisi";
            cmbxCihazlarKayit.ValueMember = "CihazID";
            cmbxCihazlarKayit.SelectedIndex = -1;
        }

        private void cmbxMusterilerKayit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxMusterilerKayit.SelectedValue == null || cmbxMusterilerKayit.SelectedValue is DataRowView)
            {
                cmbxCihazlarKayit.DataSource = null;
                return;
            }

            int musteriId = Convert.ToInt32(cmbxMusterilerKayit.SelectedValue);

            CihazCmbxDoldur(musteriId);
        }

        public void ServisKayitListele()
        {
            dataGridViewServisKayit.DataSource = _servisKayitService.ServisKayitliListele();
        }

        public void MusteriCmbxDoldur()
        {
            DataTable musteri = _musteriRepository.MusterileriListele();

            cmbxMusterilerKayit.DataSource = musteri;
            cmbxMusterilerKayit.DisplayMember = "Ad";
            cmbxMusterilerKayit.ValueMember = "MusteriID";
            cmbxMusterilerKayit.SelectedIndex = -1;
        }

        public void DurumCmbxDoldur()
        {
            cmbxDurum.Items.Clear();

            cmbxDurum.Items.Add("Beklemede");
            cmbxDurum.Items.Add("İşlemde");
            cmbxDurum.Items.Add("Tamamlandı");
            cmbxDurum.Items.Add("İptal");
            cmbxDurum.Items.Add("Teslim edildi");

            cmbxDurum.SelectedIndex = -1;
        }

        private void seciliServisKayitYazdır()
        {
            DataGridViewRow row = dataGridViewServisKayit.CurrentRow;

            if (row == null || row.IsNewRow)
            {
                MessageBox.Show("Geçersiz kayıt bilgisi işlem yapmak için lütfen tablodan bir kayıt seçiniz.");
                return;
            }

            txtServisID.Text = Convert.ToInt32(dataGridViewServisKayit.CurrentRow.Cells["ServisID"].Value).ToString();

            txtArizaAçıklama.Text = dataGridViewServisKayit.CurrentRow.Cells["Arıza"].Value.ToString();

            txtTahminiÜcret.Text = dataGridViewServisKayit.CurrentRow.Cells["TahminiUcret"].Value?.ToString() ?? "";

            txtKesinÜcret.Text = dataGridViewServisKayit.CurrentRow.Cells["KesinUcret"].Value?.ToString() ?? "";

            cmbxMusterilerKayit.SelectedValue = Convert.ToInt32(row.Cells["MusteriID"].Value);

            cmbxCihazlarKayit.SelectedValue = Convert.ToInt32(row.Cells["CihazID"].Value);

            cmbxDurum.Text = row.Cells["Durum"].Value?.ToString() ?? "";
        }

        private ServisKayit FormdanAl(int servisId)
        {
            decimal? tahminiUcret = null;
            decimal? kesinUcret = null;

            if (!string.IsNullOrWhiteSpace(txtTahminiÜcret.Text))
            {
                tahminiUcret = Convert.ToDecimal(txtTahminiÜcret.Text);
            }

            if (!string.IsNullOrWhiteSpace(txtKesinÜcret.Text))
            {
                kesinUcret = Convert.ToDecimal(txtKesinÜcret.Text);
            }

            return new ServisKayit
            {
                servisID = servisId,
                musteriID = Convert.ToInt32(cmbxMusterilerKayit.SelectedValue),
                cihazID = Convert.ToInt32(cmbxCihazlarKayit.SelectedValue),
                arizaAciklama = txtArizaAçıklama.Text,
                durum = cmbxDurum.Text,
                tahminiUcret = tahminiUcret,
                kesinUcret = kesinUcret,

                teslimEdildiMi = false,
                teslimTarihi = null
            };
        }

        private void TextBoxClear()
        {
            cmbxMusterilerKayit.SelectedIndex = -1;
            cmbxCihazlarKayit.DataSource = null;
            cmbxDurum.SelectedIndex = -1;
            txtServisID.Clear();
            txtArizaAçıklama.Clear();
            txtTahminiÜcret.Clear();
            txtKesinÜcret.Clear();
            chckTeslimedildiMi.Checked = false;
        }

        public bool TextBoxFormKontrol()
        {
            if (cmbxMusterilerKayit.SelectedValue == null)
            {
                MessageBox.Show("İşlem yapmak için lütfen müşteri seçiniz\nBilgileri kontrol edip tekrar deneyiniz",
                    "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbxCihazlarKayit.SelectedValue == null)
            {
                MessageBox.Show("İşlem yapmak için lütfen cihaz seçiniz\nBilgileri kontrol edip tekrar deneyiniz",
                    "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtArizaAçıklama.Text))
            {
                MessageBox.Show("İşlem yapmak için arıza açıklamasını doldurunuz\nBilgileri kontrol edip tekrar deneyiniz",
                    "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtTahminiÜcret.Text))
            {
                if (!decimal.TryParse(txtTahminiÜcret.Text, out decimal tahminiUcret) || tahminiUcret < 0)
                {
                    MessageBox.Show("Tahmini ücret alanına sadece sayı ve 0'dan büyük değer girilmelidir!\nBilgileri kontrol edip tekrar deneyiniz.",
                        "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }


            if (!string.IsNullOrWhiteSpace(txtKesinÜcret.Text))
            {
                if (!decimal.TryParse(txtKesinÜcret.Text, out decimal kesinUcret) || kesinUcret < 0)
                {
                    MessageBox.Show("Kesin ücret sadece alanına sayı ve 0'dan büyük değer girilmelidir!\nBilgileri kontrol edip tekrar deneyiniz",
                        "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (cmbxDurum.SelectedIndex == -1)
            {
                MessageBox.Show("İşlem yapmak için durum bilgisini doldurunuz!\nBilgileri kontrol edip tekrar deneyiniz",
                    "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ServisKayitForm_Load(object sender, EventArgs e)
        {
            MusteriCmbxDoldur();
            DurumCmbxDoldur();
            ServisKayitListele();

            cmbxCihazlarKayit.DataSource = null;

            chckTeslimedildiMi.Checked = false;
            chckTeslimedildiMi.Enabled = false;

            seciliServisKayitYazdır();
            dataGridViewServisKayit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewServisKayit.ClearSelection();
            TextBoxClear();

            dataGridViewServisKayit.MultiSelect = false;
        }

        private void btnServisEkle_Click(object sender, EventArgs e)
        {
            if (!TextBoxFormKontrol())
            {
                return;
            }

            ServisKayit servisKayit = FormdanAl(0);

            bool basariliMi = _servisKayitService.ServisKayitEkle(servisKayit, out string mesaj);

            if (!basariliMi)
            {
                MessageBox.Show(mesaj, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ServisKayitListele();
            MusteriCmbxDoldur();
            TextBoxClear();
        }

        private void btnServisGuncelle_Click(object sender, EventArgs e)
        {
            if (!TextBoxFormKontrol())
            {
                return;
            }

            int servisId = Convert.ToInt32(txtServisID.Text);

            ServisKayit servisKayit = FormdanAl(servisId);

            bool basariliMi = _servisKayitService.SevisKayitGuncelle(servisKayit, out string mesaj);

            if (!basariliMi)
            {
                MessageBox.Show(mesaj, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ServisKayitListele();
            MusteriCmbxDoldur();
            TextBoxClear();
        }

        private void dataGridViewServisKayit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            dataGridViewServisKayit.CurrentCell = dataGridViewServisKayit.Rows[e.RowIndex].Cells[0];

            seciliServisKayitYazdır();
        }

        private void btnServisKayitAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtServisKayitAra.Text))
            {
                MessageBox.Show("Kayıt aramak için arama terimi giriniz!\nBilgileri kontrol edip tekrar deneyiniz.");
                return;
            }

            string aranan = txtServisKayitAra.Text.Trim();

            DataTable dt = _servisKayitService.KayitAra(aranan);

            dataGridViewServisKayit.DataSource = dt;
        }

        private void btnServisTemizle_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            ServisKayitListele();
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (dataGridViewServisKayit.CurrentRow == null || dataGridViewServisKayit.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Teslim edilecek bir kayıt seçilmedi!\nBilgileri kontrol edip tekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int servisId = Convert.ToInt32(dataGridViewServisKayit.CurrentRow.Cells["ServisID"].Value);

            bool basariliMi = _servisKayitService.TeslimEt(servisId, out string mesaj);

            if (!basariliMi)
            {
                MessageBox.Show(mesaj, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            chckTeslimedildiMi.Checked = true;

            ServisKayitListele();
            MusteriCmbxDoldur();
            TextBoxClear();
        }

        private void btnServisSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewServisKayit.CurrentRow == null || dataGridViewServisKayit.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Teslim edilecek bir kayıt seçilmedi!\nBilgileri kontrol edip tekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int servisId = Convert.ToInt32(dataGridViewServisKayit.CurrentRow.Cells["ServisID"].Value); 

            DialogResult result = MessageBox.Show("Seçili servis kaydını silmek istediğinize emin misiniz?","ONAY",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Silme işlemi iptal edildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool basariliMi = _servisKayitService.ServiskayitSil(servisId, out string mesaj);

            if (!basariliMi)
            {
                MessageBox.Show(mesaj,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ServisKayitListele();
            MusteriCmbxDoldur();
            TextBoxClear();
        }
    }
}
