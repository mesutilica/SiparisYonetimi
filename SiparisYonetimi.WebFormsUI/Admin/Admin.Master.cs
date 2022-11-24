using System;

namespace SiparisYonetimi.WebFormsUI.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null) // Session nesnesi web uygulamalarında kullanılır ve sayfalar arası veri taşıyabilir
            {
                //Response.Redirect("/Admin/Login.aspx");
            }
        }
    }
}