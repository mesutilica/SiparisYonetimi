using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiparisYonetimi.WebFormsUI.Admin
{
    public partial class UrunYonetimi : System.Web.UI.Page
    {
        ProductManager manager = new ProductManager();
        CategoryManager categoryManager = new CategoryManager();
        BrandManager brandManager = new BrandManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) // sayfa ilk açıldığında içerdeki kodları çalıştır
            {
                dgvUrunler.DataSource = manager.GetAll();
                dgvUrunler.DataBind();
                cbKategoriler.DataSource = categoryManager.GetAll();
                cbKategoriler.DataBind();
                cbMarkalar.DataSource = brandManager.GetAll();
                cbMarkalar.DataBind();
            }
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Product urun = new Product();
                urun.Name = txtUrunAdi.Text;
                urun.Description = txtAciklama.Text;
                urun.Price = Convert.ToDecimal(txtFiyat.Text);
                urun.BrandId = Convert.ToInt32(cbMarkalar.SelectedValue);
                urun.CategoryId = Convert.ToInt32(cbKategoriler.SelectedValue);
                if (fuResim.HasFile)
                {
                    fuResim.SaveAs(Server.MapPath("/Img/" + fuResim.FileName));
                    urun.Image = fuResim.FileName;
                }
                urun.Stock = int.Parse(txtStok.Text);
                urun.IsActive = chbDurum.Checked;
                manager.Add(urun);
                int sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Response.Redirect("UrunYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                Response.Write("<h1>Hata Oluştu!</h1>");
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvUrunler.SelectedRow.Cells[1].Text);
                var urun = manager.Find(id);

                urun.Name = txtUrunAdi.Text;
                urun.Description = txtAciklama.Text;
                urun.Price = Convert.ToDecimal(txtFiyat.Text);
                urun.BrandId = Convert.ToInt32(cbMarkalar.SelectedValue);
                urun.CategoryId = Convert.ToInt32(cbKategoriler.SelectedValue);
                if (fuResim.HasFile)
                {
                    fuResim.SaveAs(Server.MapPath("/Img/" + fuResim.FileName));
                    urun.Image = fuResim.FileName;
                }
                urun.Stock = int.Parse(txtStok.Text);
                urun.IsActive = chbDurum.Checked;
                manager.Update(urun);
                int sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Response.Redirect("UrunYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                Response.Write("<h1>Hata Oluştu!</h1>");
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvUrunler.SelectedRow.Cells[1].Text);

                var kayit = manager.Find(id);

                manager.Delete(kayit);

                var sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Response.Redirect("UrunYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                Response.Write("<h1>Hata Oluştu!</h1>");
            }
        }

        protected void dgvUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvUrunler.SelectedRow.Cells[1].Text);
                var urun = manager.Find(id);
                txtUrunAdi.Text = urun.Name;
                txtStok.Text = urun.Stock.ToString();
                
                txtFiyat.Text = urun.Price.ToString();
                txtAciklama.Text = urun.Description;
                chbDurum.Checked = urun.IsActive;
                cbKategoriler.SelectedValue = urun.CategoryId.ToString();
                cbMarkalar.SelectedValue = urun.BrandId.ToString();
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            catch (Exception)
            {
                Response.Write("<h1>Hata Oluştu!</h1>");
            }
        }
    }
}