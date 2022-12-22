using SiparisYonetimi.Business.Managers;
using System.Web.Mvc;

namespace SiparisYonetimi.MVCUI.Controllers
{
    public class ProductsController : Controller
    {
        ProductManager manager = new ProductManager();
        // GET: Products
        public ActionResult Index()
        {
            var model = manager.GetAll();
            return View(model);
        }
        public ActionResult Search(string kelime)
        {
            var model = manager.GetAll(p => p.Name.Contains(kelime));
            return View(model);
        }
        public ActionResult Detail(int id)
        {
            var model = manager.Find(id);
            return View(model);
        }
    }
}