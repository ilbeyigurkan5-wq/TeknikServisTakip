using System.Diagnostics;
using Microsoft.Data.SqlClient;
using TeknikServisTakip.Model.cs;
using TeknikServisTakip.Repositories.cs;
using TeknikServisTakip.Services;

namespace TeknikServisTakip
{
    public partial class Form1 : Form
    {

        string baglanti = @"Data Source=.;Initial Catalog=TeknikServis;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private KullanıcıRepository _kullaniciRepository;

        private KullanıcıService _kullaniciService;

        public Form1()
        {
            InitializeComponent();

            _kullaniciRepository = new KullanıcıRepository(baglanti);

            _kullaniciService = new KullanıcıService(_kullaniciRepository);
        }

        private bool TxtKontrolAl()
        {
            if (string.IsNullOrWhiteSpace(txtKullanıcıAdı.Text))
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz!\nTekrar deneyiniz.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Şifre boş bırakılamaz!\nTekrar deneyiniz.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void pcrbxClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pcrbxMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pcrbxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pcrboxInstagram_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.Instagram.com",
                UseShellExecute = true
            });
        }

        private void pcrboxYoutube_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "http://www.Youtube.com",
                UseShellExecute = true
            });
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (!TxtKontrolAl())
            {
                return;
            }

            Kullanıcılar kullanıcı = new Kullanıcılar
            {
                kullaniciAdi = txtKullanıcıAdı.Text,
                kullaniciSifre = txtSifre.Text
            };

            bool eslestiMi = _kullaniciService.GirisKontrol(kullanıcı, out string mesaj);

            if (!eslestiMi)
            {
                MessageBox.Show(mesaj,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(mesaj,"BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);

            Form2 frm2 = new Form2();
            this.Hide();
            frm2.ShowDialog();


        }
    }
}
