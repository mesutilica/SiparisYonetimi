using SiparisYonetimi.Business.Managers;
using System.Web.Mvc;

namespace SiparisYonetimi.MVCUI.Controllers
{
    public class BrandsController : Controller
    {
        BrandManager manager = new BrandManager();
        // GET: Brands
        public ActionResult Index(int id)
        {
            var model = manager.Find(id);
            return View(model);
        }
    }
}