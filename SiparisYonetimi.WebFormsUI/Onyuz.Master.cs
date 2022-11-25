using SiparisYonetimi.Business.Managers;
using System;

namespace SiparisYonetimi.WebFormsUI
{
    public partial class Onyuz : System.Web.UI.MasterPage
    {
        CategoryManager manager = new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptKategoriler.DataSource= manager.GetAll();
            rptKategoriler.DataBind();
        }
    }
}