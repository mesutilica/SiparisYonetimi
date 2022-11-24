using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
using System;

namespace SiparisYonetimi.WebFormsUI.Admin
{
    public partial class KullaniciYonetimi : System.Web.UI.Page
    {
        UserManager manager = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvKullanicilar.DataSource = manager.GetAll();
            dgvKullanicilar.DataBind();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
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
                Response.Redirect("KullaniciYonetimi.aspx");
            }
            else Response.Write("Kayıt Başarısız");
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvKullanicilar.SelectedRow.Cells[1].Text);

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

            if (sonuc > 0)
            {
                Response.Redirect("KullaniciYonetimi.aspx");
            }
            else Response.Write("Kayıt Başarısız");
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvKullanicilar.SelectedRow.Cells[1].Text);

                User kayit = manager.Find(id);

                int sonuc = manager.Remove(kayit);

                if (sonuc > 0)
                {
                    Response.Redirect("KullaniciYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                Response.Write("Hata Oluştu!");
            }
        }

        protected void dgvKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvKullanicilar.SelectedRow.Cells[1].Text);

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
                Response.Write("İşlem Başarısız");
            }
        }
    }
}