using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
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
        ContactManager contactManager = new ContactManager();
        public ActionResult Index()
        {
            var model = sliderManager.GetAll();
            HomePageViewModel homePageViewModel = new HomePageViewModel()
            {
                Slides = model,
                Brands = brandManager.GetAll(),
                Products = productManager.GetAll(p => p.IsHome)
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
            
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Contact contact)
        {
            try
            {
                contactManager.Add(contact);
                var sonuc = contactManager.SaveChanges();
                if (sonuc > 0)
                {
                    TempData["Message"] = "<div class='alert alert-success'>Mesajınız Gönderildi. Teşekkürler..</div>";
                    return RedirectToAction("Contact");
                }
            }
            catch (System.Exception)
            {
                ModelState.AddModelError("", "Hata Oluştu!");
            }

            return View(contact);
        }
    }
}