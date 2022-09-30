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
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez!");
                return;
            }
            else
            {
                try
                {
                    var kullanici = manager.GetUser(txtKullaniciAdi.Text, txtSifre.Text);
                    if (kullanici != null)
                    {
                        AnaMenu anaMenu = new AnaMenu();
                        this.Hide(); // Bu formu gizle
                        anaMenu.Show(); // Menü formunu göster
                    }
                    else MessageBox.Show("Giriş Başarısız! Kullanıcı Bulunamadı!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata Oluştu");
                }
            }

        }
    }
}
