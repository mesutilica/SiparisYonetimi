using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SiparisYonetimi.WinFormsUI
{
    public partial class MusteriYonetimi : Form
    {
        public MusteriYonetimi()
        {
            InitializeComponent();
        }
        CustomerManager manager = new CustomerManager();
        private void MusteriYonetimi_Load(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = manager.GetAll();
        }
        void Temizle()
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();
            foreach (var item in nesneler)
            {
                item.Clear();
            }
            chbDurum.Checked = false;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Phone = txtTelefon.Text;
            customer.Email = txtEmail.Text;
            customer.Name = txtAdi.Text;
            customer.Surname = txtSoyadi.Text;
            customer.Address = txtAdres.Text;
            customer.IsActive = chbDurum.Checked;
            if (string.IsNullOrWhiteSpace(txtAdi.Text) || string.IsNullOrWhiteSpace(txtSoyadi.Text))
            {
                MessageBox.Show("Ad ve Soyad Boş Geçilemez");
                return;
            }
            try
            {
                manager.Add(customer);
                var sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Temizle();
                    dgvMusteriler.DataSource = manager.GetAll();
                    MessageBox.Show("Kayıt Başarılı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells[0].Value);

                var kayit = manager.Find(id);

                txtAdi.Text = kayit.Name;
                txtAdres.Text = kayit.Address;
                txtSoyadi.Text = kayit.Surname;
                txtEmail.Text = kayit.Email;
                txtTelefon.Text = kayit.Phone;
                chbDurum.Checked = kayit.IsActive;

                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdi.Text) || string.IsNullOrWhiteSpace(txtSoyadi.Text))
            {
                MessageBox.Show("Ad ve Soyad Boş Geçilemez");
                return;
            }

            int id = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells[0].Value);

            Customer customer = manager.Find(id);
            customer.Phone = txtTelefon.Text;
            customer.Email = txtEmail.Text;
            customer.Name = txtAdi.Text;
            customer.Surname = txtSoyadi.Text;
            customer.Address = txtAdres.Text;
            customer.IsActive = chbDurum.Checked;

            try
            {
                manager.Update(customer);
                var sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Temizle();
                    dgvMusteriler.DataSource = manager.GetAll();
                    MessageBox.Show("Kayıt Başarılı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells[0].Value);

                var kayit = manager.Find(id);

                manager.Delete(kayit);

                var sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Temizle();
                    dgvMusteriler.DataSource = manager.GetAll();
                    MessageBox.Show("Silme Başarılı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = manager.GetAll(m => m.Name.Contains(txtAra.Text));
        }
    }
}
