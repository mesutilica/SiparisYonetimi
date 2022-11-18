using SiparisYonetimi.Business.Managers;
using System;
using System.Collections.Generic;
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
            dgvUrunler.DataSource = manager.GetAll();
            dgvUrunler.DataBind();
        }
    }
}