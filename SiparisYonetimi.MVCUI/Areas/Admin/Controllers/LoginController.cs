using SiparisYonetimi.Business.Managers;
using System.Web.Security; // login için gerekli güvenlik kütüphanesi
using System.Web.Mvc;

namespace SiparisYonetimi.MVCUI.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        UserManager manager = new UserManager();
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string kullaniciAdi, string sifre, string ReturnUrl)
        {
            var kullanici = manager.GetUser(kullaniciAdi, sifre);
            if (kullanici != null)
            {
                Session["Admin"] = kullanici;
                FormsAuthentication.SetAuthCookie(kullaniciAdi, true);
                return ReturnUrl == null ? Redirect("/Admin/Main/Index") : (ActionResult)Redirect(ReturnUrl);
            }
            TempData["mesaj"] = $"<div class='alert alert-danger'>Giriş Başarısız!</div>";
            return Redirect("/Admin/Login");
        }
        [Route("Logout")]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut(); // oturumu kapat
            return Redirect("/Admin/Login");
        }
    }
}