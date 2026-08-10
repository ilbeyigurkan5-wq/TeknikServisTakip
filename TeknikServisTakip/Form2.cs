using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TeknikServisTakip
{
    public partial class Form2 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form2()
        {
            InitializeComponent();

            MdiArkaPlanRengiAyarla();

            this.FormBorderStyle = FormBorderStyle.None;

            panel1.MouseDown += Form2_MouseDown;
        }

        private void FormAc(Form acilacakForm)
        {
            // Daha önce açılmış alt form varsa kapatır.
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            // Formu bu ana formun MDI alt formu yapar.
            acilacakForm.MdiParent = this;

            // Formun kendi başlığını ve çerçevesini kaldırır.
            acilacakForm.FormBorderStyle = FormBorderStyle.None;
            acilacakForm.ControlBox = false;
            acilacakForm.ShowIcon = false;
            acilacakForm.ShowInTaskbar = false;

            // ÖNEMLİ: Maximized yapmıyoruz.
            acilacakForm.WindowState = FormWindowState.Normal;

            // MDI alanını tamamen doldurur.
            acilacakForm.Dock = DockStyle.Fill;

            acilacakForm.Show();

            // Soldaki menü panelini önde tutar.
            panel1.BringToFront();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MdiArkaPlanRengiAyarla()
        {
            foreach (Control kontrol in this.Controls)
            {
                if (kontrol is MdiClient mdiAlan)
                {
                    mdiAlan.BackColor = this.BackColor;
                }
            }
        }

        private void btnMüsteriForm_Click(object sender, EventArgs e)
        {
            FormAc(new MüsteriForm());
        }

        private void pcrbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcrbxMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pcrbxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCihazForm_Click(object sender, EventArgs e)
        {
            FormAc(new CihazlarForm());
        }

        private void btnServisKayitForm_Click(object sender, EventArgs e)
        {
            FormAc(new ServisKayitForm());
        }

        private void btnÖdemelerForm_Click(object sender, EventArgs e)
        {
            FormAc(new OdemelerForm());
        }
    }
}
