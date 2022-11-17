using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
using System;
using System.Windows.Forms;

namespace SiparisYonetimi.WinFormsUI
{
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }
        UserManager manager = new UserManager();

        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            dgvKullanicilar.DataSource = manager.GetAll();
        }

        void Temizle()
        {
            txtAdi.Text = string.Empty;
            txtAra.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtKullaniciAdi.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtSoyadi.Text = string.Empty;
            txtTelefon.Text = string.Empty;
            chbAdmin.Checked = false;
            chbDurum.Checked = false;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = txtAdi.Text;
            user.Email = txtEmail.Text;
            user.Surname = txtSoyadi.Text;
            user.Phone = txtTelefon.Text;
            user.IsActive = chbDurum.Checked;
            user.IsAdmin = chbAdmin.Checked;
            user.Username = txtKullaniciAdi.Text;
            user.Password = txtSifre.Text;

            var sonuc = manager.Add(user);

            if (sonuc > 0) // sonuc 0 dan büyükse ekleme başarılıdır
            {
                Temizle();
                dgvKullanicilar.DataSource = manager.GetAll();
                MessageBox.Show("Kayıt Başarılı");
            }
            else MessageBox.Show("Kayıt Başarısız");

        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells[0].Value);

                User kayit = manager.Find(id);

                txtAdi.Text = kayit.Name;
                txtSoyadi.Text = kayit.Surname;
                txtEmail.Text = kayit.Email;
                txtSifre.Text = kayit.Password;
                txtTelefon.Text = kayit.Phone;
                txtKullaniciAdi.Text = kayit.Username;
                chbAdmin.Checked = kayit.IsAdmin;
                chbDurum.Checked = kayit.IsActive;

                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem Başarısız");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells[0].Value);

            User user = manager.Find(id);

            user.Name = txtAdi.Text;
            user.Email = txtEmail.Text;
            user.Surname = txtSoyadi.Text;
            user.Phone = txtTelefon.Text;
            user.IsActive = chbDurum.Checked;
            user.IsAdmin = chbAdmin.Checked;
            user.Username = txtKullaniciAdi.Text;
            user.Password = txtSifre.Text;

            var sonuc = manager.Update(user);

            if (sonuc > 0) // sonuc 0 dan büyükse ekleme başarılıdır
            {
                Temizle();
                dgvKullanicilar.DataSource = manager.GetAll();
                MessageBox.Show("Kayıt Başarılı");
            }
            else MessageBox.Show("Kayıt Başarısız");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells[0].Value);

                User kayit = manager.Find(id);

                int sonuc = manager.Remove(kayit);

                if (sonuc > 0)
                {
                    Temizle();
                    dgvKullanicilar.DataSource = manager.GetAll();
                    MessageBox.Show("Kayıt Silindi");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem Başarısız");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvKullanicilar.DataSource = manager.GetAll(txtAra.Text);
        }
    }
}
