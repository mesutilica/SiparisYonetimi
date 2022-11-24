using SiparisYonetimi.Business.Managers;
using System;

namespace SiparisYonetimi.WebFormsUI
{
    public partial class Default : System.Web.UI.Page
    {
        BrandManager manager = new BrandManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptMarkalar.DataSource = manager.GetAll();
            rptMarkalar.DataBind();
        }
    }
}