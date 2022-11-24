using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
using System;
using System.Web.UI;

namespace SiparisYonetimi.WebFormsUI.Admin
{
    public partial class MarkaYonetimi : System.Web.UI.Page
    {
        BrandManager manager = new BrandManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvMarkalar.DataSource = manager.GetAll();
            dgvMarkalar.DataBind();
        }

        protected void dgvMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(dgvMarkalar.SelectedRow.Cells[1].Text);
                var marka = manager.Find(id);
                txtAciklama.Text = marka.Description.ToString();
                txtMarkaAdi.Text = marka.Name.ToString();
                chbDurum.Checked = marka.IsActive;
                hfResimAdi.Value = marka.Logo;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu");
            }
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand()
            {
                Description = txtAciklama.Text,
                IsActive = chbDurum.Checked,
                Name = txtMarkaAdi.Text
            };
            if (fuLogo.HasFile) // eğer file upload dan dosya seçilmişse
            {
                fuLogo.SaveAs(Server.MapPath("/Img/" + fuLogo.FileName)); // seçilen dosyayı sunucuya farklı kaydet metoduyla yükle
                brand.Logo = fuLogo.FileName;
            }
            try
            {
                manager.Add(brand);
                int sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Response.Redirect("MarkaYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu");
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(dgvMarkalar.SelectedRow.Cells[1].Text);
                var marka = manager.Find(id);
                marka.Name = txtMarkaAdi.Text;
                marka.Description = txtAciklama.Text;
                marka.IsActive = chbDurum.Checked;
                if (fuLogo.HasFile) // eğer file upload dan dosya seçilmişse
                {
                    fuLogo.SaveAs(Server.MapPath("/Img/" + fuLogo.FileName)); // seçilen dosyayı sunucuya farklı kaydet metoduyla yükle
                    marka.Logo = fuLogo.FileName;
                }

                manager.Update(marka);
                int sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Response.Redirect("MarkaYonetimi.aspx");
                }

            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu");
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(dgvMarkalar.SelectedRow.Cells[1].Text);
                var marka = manager.Find(id);
                manager.Delete(marka);
                int sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Response.Redirect("MarkaYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu");
            }
        }

        void MessageBox(string mesaj)
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "Uyarı", $"alert('{mesaj}')"); // bu kod ekrana javascript kodu göndermemizi ve çalıştırmamızı sağlıyor
        }

    }
}