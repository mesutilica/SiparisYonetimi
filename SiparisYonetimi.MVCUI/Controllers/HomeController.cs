using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.MVCUI.Models;
using System.Web.Mvc;

namespace SiparisYonetimi.MVCUI.Controllers
{
    public class HomeController : Controller
    {
        CategoryManager categoryManager = new CategoryManager();
        SliderManager sliderManager = new SliderManager();
        BrandManager brandManager = new BrandManager();
        ProductManager productManager = new ProductManager();
        public ActionResult Index()
        {
            var model = sliderManager.GetAll();
            HomePageViewModel homePageViewModel = new HomePageViewModel()
            {
                Slides = model,
                Brands = brandManager.GetAll(),
                Products = productManager.GetAll()
            };

            return View(homePageViewModel);
        }

        public ActionResult PartialMenu()
        {
            return PartialView("_PartialMenu", categoryManager.GetAll());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}