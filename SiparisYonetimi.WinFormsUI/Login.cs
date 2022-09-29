using SiparisYonetimi.Business.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisYonetimi.WinFormsUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        UserManager manager = new UserManager();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                var kullanici = manager.GetUser(txtKullaniciAdi.Text, txtSifre.Text);
                if (kullanici != null)
                {

                }
                else MessageBox.Show("Giriş Başarısız");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu");
            }
        }
    }
}
