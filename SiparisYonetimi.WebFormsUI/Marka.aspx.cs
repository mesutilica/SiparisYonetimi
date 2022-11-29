using SiparisYonetimi.Business.Managers;
using System;

namespace SiparisYonetimi.WebFormsUI
{
    public partial class Marka : System.Web.UI.Page
    {
        BrandManager brandManager = new BrandManager();
        ProductManager productManager = new ProductManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                try
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);

                    var marka = brandManager.Find(id);

                    ltMarkaAdi.Text = marka.Name;

                    ltAciklama.Text = marka.Description;

                    var urunler = productManager.GetAll(p => p.BrandId == id && p.IsActive == true);

                    rptUrunler.DataSource = urunler;
                    rptUrunler.DataBind();
                }
                catch (Exception)
                {
                    Response.Write("<script>alert('Hata Oluştu!')</script>");
                }
            }
        }
    }
}