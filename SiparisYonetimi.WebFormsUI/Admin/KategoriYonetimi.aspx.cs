using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
using System;

namespace SiparisYonetimi.WebFormsUI.Admin
{
    public partial class KategoriYonetimi : System.Web.UI.Page
    {
        CategoryManager manager = new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = manager.GetAll();
            dgvKategoriler.DataBind(); // web form da bu satırı eklemezsek veritabanından çektiğimiz veriler ekranda yüklenmez!
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = txtKategoriAdi.Text;
            category.Description = txtAciklama.Text;
            category.IsActive = chbDurum.Checked;

            try
            {
                manager.Add(category);
                var sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Response.Redirect("KategoriYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                ltMesaj.Text = "<div class='alert alert-danger'>Hata Oluştu!</div>";
            }
        }

        protected void dgvKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgvKategoriler.SelectedRow.Cells[1].Text);
                var kategori = manager.Find(id);
                txtKategoriAdi.Text = kategori.Name;
                txtAciklama.Text = kategori.Description;
                chbDurum.Checked = kategori.IsActive;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            catch (Exception)
            {
                ltMesaj.Text = "<div class='alert alert-danger'>Hata Oluştu!</div>";
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgvKategoriler.SelectedRow.Cells[1].Text);
                Category category = manager.Find(id);
                category.Name = txtKategoriAdi.Text;
                category.Description = txtAciklama.Text;
                category.IsActive = chbDurum.Checked;

                manager.Update(category);
                var sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Response.Redirect("KategoriYonetimi.aspx");
                }

            }
            catch (Exception)
            {
                ltMesaj.Text = "<div class='alert alert-danger'>Hata Oluştu!</div>";
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgvKategoriler.SelectedRow.Cells[1].Text);
                Category category = manager.Find(id);
                manager.Delete(category);
                var sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Response.Redirect("KategoriYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                ltMesaj.Text = "<div class='alert alert-danger'>Hata Oluştu!</div>";
            }
        }
    }
}