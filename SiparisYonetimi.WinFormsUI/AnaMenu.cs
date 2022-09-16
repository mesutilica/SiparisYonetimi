using System;
using System.Windows.Forms;

namespace SiparisYonetimi.WinFormsUI
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullanici = new KullaniciYonetimi();
            kullanici.ShowDialog();
        }
    }
}
