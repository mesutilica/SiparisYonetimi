using SiparisYonetimi.Business.Managers;
using System;

namespace SiparisYonetimi.WebFormsUI
{
    public partial class UrunDetay : System.Web.UI.Page
    {
        ProductManager productManager = new ProductManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                try
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);

                    var urun = productManager.Find(id);

                    if (urun != null)
                    {
                        urunResmi.ImageUrl = "/Img/" + urun.Image;
                        ltUrunAdi.Text = urun.Name;
                        ltUrunFiyati.Text = urun.Price.ToString();
                        lblUrunStok.Text = urun.Stock.ToString();
                        ltUrunAciklama.Text = urun.Description;
                    }
                }
                catch (Exception)
                {
                    Response.Write("<script>alert('Hata Oluştu!')</script>");
                }
            }
        }
    }
}