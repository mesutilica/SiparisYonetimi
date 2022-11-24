using System;
using System.Web.Security;

namespace SiparisYonetimi.WebFormsUI.Moduller
{
    public partial class Header : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbCikis_Click(object sender, EventArgs e)
        {
            Session.Remove("Admin"); // admin isimli session ı sil
            FormsAuthentication.SignOut(); // oturumu kapat
            Response.Redirect("/Admin/Login.aspx"); // logine yönlendir
        }
    }
}