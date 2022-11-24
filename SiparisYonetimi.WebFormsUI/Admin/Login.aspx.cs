using SiparisYonetimi.Business.Managers;
using System;
using System.Web.Security;

namespace SiparisYonetimi.WebFormsUI.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        UserManager manager = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            var kullanici = manager.GetUser(floatingInput.Value, floatingPassword.Value);
            if (kullanici != null)
            {
                Session["admin"] = kullanici;
                FormsAuthentication.SetAuthCookie(kullanici.Username, true);
                if (Request.QueryString["ReturnUrl"] == null)
                    Response.Redirect("/Admin/");
                else Response.Redirect(Request.QueryString["ReturnUrl"]);
            }
            else Response.Write("<script>alert('Giriş Başarısız!')</script>");
        }
    }
}