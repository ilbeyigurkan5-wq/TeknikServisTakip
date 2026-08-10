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
    public partial class OdemelerForm : Form
    {
        string baglanti = @"Data Source=.;Initial Catalog=TeknikServis;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        private readonly OdemelerRepository _odemelerRepository;
        private readonly OdemelerService _odemelerService;

        public OdemelerForm()
        {
            InitializeComponent();


            _odemelerRepository = new OdemelerRepository(baglanti);

            _odemelerService = new OdemelerService(_odemelerRepository);
        }

        private void ServisleriListele()
        {
            dataGridViewServis.DataSource = _odemelerService.ServisleriOdemeicinListele();
        }

        private void OdemeleriListele()
        {
            dataGridViewOdemeler.DataSource = _odemelerService.OdemeleriListele();
        }

        private void GridAyarları()
        {
            dataGridViewServis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewServis.MultiSelect = false;
            dataGridViewServis.ReadOnly = true;
            dataGridViewServis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            dataGridViewOdemeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOdemeler.MultiSelect = false;
            dataGridViewOdemeler.ReadOnly = true;
            dataGridViewOdemeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private bool TextBoxFormKontrol()
        {
            if (string.IsNullOrWhiteSpace(txtServisId.Text))
            {
                MessageBox.Show("Servis ID bilgisi boş olamaz!\nBilgileri kontrol edip tekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtMusteri.Text))
            {
                MessageBox.Show("Müşteri bilgisi boş olamaz!\nBilgileri kontrol edip tekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCihaz.Text))
            {
                MessageBox.Show("Cihaz bilgisi boş olamaz!\nBilgileri kontrol edip tekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtKesinUcret.Text))
            {
                MessageBox.Show("Kesin ücret bilgisi boş olamaz!\nBilgisi kontrol edip tekrar deneyiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtToplamOdenen.Text))
            {
                MessageBox.Show("Toplam ödenen tutar bilgisi boş olamaz!\nBilgileri kontrol edip tekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtKalanTutar.Text))
            {
                MessageBox.Show("Kalan tutar bilgisi boş bırakılamaz!\nBilgileri kontrol edip tekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtOdemeTutarı.Text))
            {
                MessageBox.Show("Ödeme ttarı bilgisi boş bırakılamaz!\nBilgileri kontrol edip tekrar deneyiniz.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txtOdemeTutarı.Text, out decimal odemeTutari))
            {
                MessageBox.Show("Ödeme tutarına alanına sadece sayı girilmelidir!\nBilgileri kontrol edip tekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbxOdemeTipi.SelectedIndex == -1)
            {
                MessageBox.Show("Ödeme tipi boş bırakılamaz!\nBilgileri kontrol edip tekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void OdemeTipiCmbox()
        {
            cmbxOdemeTipi.Items.Clear();

            cmbxOdemeTipi.Items.Add("Nakit");
            cmbxOdemeTipi.Items.Add("Kredi Kartı");
            cmbxOdemeTipi.Items.Add("Havale");

            cmbxOdemeTipi.SelectedIndex = -1;
        }

        private Odeme FormdanAl()
        {
            return new Odeme
            {
                OdemeID = string.IsNullOrWhiteSpace(txtOdemeId.Text) ? 0 : Convert.ToInt32(txtOdemeId.Text),
                ServisID = Convert.ToInt32(txtServisId.Text),
                OdemeTutari = Convert.ToDecimal(txtOdemeTutarı.Text),
                OdemeTipi = cmbxOdemeTipi.Text,
                Aciklama = txtAciklama.Text
            };
        }

        private void TextBoxClear()
        {
            txtServisId.Clear();
            txtOdemeId.Clear();
            txtOdemeAra.Clear();
            txtAciklama.Clear();
            txtCihaz.Clear();
            txtKalanTutar.Clear();
            txtKesinUcret.Clear();
            txtMusteri.Clear();
            txtOdemeTutarı.Clear();
            txtToplamOdenen.Clear();
        }

        private void dataGridViewOdemeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridViewOdemeler.Rows[e.RowIndex];

            txtOdemeId.Text = row.Cells["OdemeID"].Value?.ToString();

            txtAciklama.Text = row.Cells["Aciklama"].Value?.ToString() ?? "";

            txtOdemeTutarı.Text = row.Cells["OdemeTutari"].Value?.ToString();

            cmbxOdemeTipi.Text = row.Cells["OdemeTipi"].Value?.ToString();
        }


        private void dataGridViewServis_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridViewServis.Rows[e.RowIndex];

            txtServisId.Text = row.Cells["ServisID"].Value?.ToString();

            txtToplamOdenen.Text = row.Cells["ToplamOdenen"].Value?.ToString() ?? "";

            txtCihaz.Text = row.Cells["Cihaz"].Value?.ToString();

            txtKalanTutar.Text = row.Cells["KalanTutar"].Value?.ToString() ?? "";

            txtKesinUcret.Text = row.Cells["KesinUcret"].Value?.ToString() ?? "";

            txtMusteri.Text = row.Cells["Musteri"].Value?.ToString();


            int servisId = Convert.ToInt32(dataGridViewServis.Rows[e.RowIndex].Cells["ServisID"].Value);

            dataGridViewOdemeler.DataSource = _odemelerService.ServiseGoreOdemeleriListele(servisId);

            txtOdemeId.Clear();
            txtAciklama.Clear();
            txtOdemeTutarı.Clear();
            cmbxOdemeTipi.SelectedIndex = -1;
        }

        private void OdemelerForm_Load(object sender, EventArgs e)
        {

            ServisleriListele();
            OdemeleriListele();
            OdemeTipiCmbox();
            GridAyarları();
            TextBoxClear();

            dataGridViewServis.ClearSelection();
            dataGridViewOdemeler.ClearSelection();
        }

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            if (!TextBoxFormKontrol())
            {
                return;
            }

            Odeme odeme = FormdanAl();

            bool basariliMi = _odemelerService.OdemeEkle(odeme, out string mesaj);

            if (!basariliMi)
            {
                MessageBox.Show(mesaj, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int servisId = odeme.ServisID;

            ServisleriListele();

            dataGridViewOdemeler.DataSource = _odemelerService.ServiseGoreOdemeleriListele(servisId);

            txtAciklama.Clear();
            txtOdemeTutarı.Clear();
            cmbxOdemeTipi.SelectedIndex = -1;
        }

        private void btnOdemeAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOdemeAra.Text))
            {
                MessageBox.Show("Aramak yapmak için bilgi giriniz!\nBilgileri kontrol edip tekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string aranan = txtOdemeAra.Text;

            dataGridViewOdemeler.DataSource = _odemelerService.OdemeAra(aranan);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            ServisleriListele();
            OdemeleriListele();
        }

        private void btnOdemeSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewOdemeler.CurrentRow == null || dataGridViewOdemeler.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Lütfen silmek istediğiniz ödeme kaydını seçiniz!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            int odemeId = Convert.ToInt32(dataGridViewOdemeler.CurrentRow.Cells["OdemeID"].Value);


            DialogResult result = MessageBox.Show("Seçilen kaydı silmek istediğinize emin misiniz?","SORU",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Silme işlemi iptal edildi!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }

            bool basariliMi = _odemelerService.OdemeSil(odemeId, out string mesaj);

            if (!basariliMi)
            {
                MessageBox.Show(mesaj,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(mesaj,"BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);



            OdemeleriListele();
            ServisleriListele();
            TextBoxClear();
        }
    }
}
