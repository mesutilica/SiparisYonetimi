using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
using System.Web;
using System.Web.Mvc;

namespace SiparisYonetimi.MVCUI.Areas.Admin.Controllers
{
    public class BrandsController : Controller
    {
        BrandManager manager = new BrandManager();
        // GET: Admin/Brands
        public ActionResult Index()
        {
            var model = manager.GetAll();
            return View(model);
        }

        // GET: Admin/Brands/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Brands/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Brands/Create
        [HttpPost]
        public ActionResult Create(Brand brand, HttpPostedFileBase Logo)
        {
            try
            {
                // TODO: Add insert logic here
                if (Logo != null)
                {
                    Logo.SaveAs(Server.MapPath("/Img/" + Logo.FileName));
                    brand.Logo = Logo.FileName;
                }
                manager.Add(brand);
                manager.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Hata Oluştu!");
            }
            return View(brand);
        }

        // GET: Admin/Brands/Edit/5
        public ActionResult Edit(int id)
        {
            var model = manager.Find(id);
            return View(model);
        }

        // POST: Admin/Brands/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Brand brand, HttpPostedFileBase Logo)
        {
            try
            {
                // TODO: Add update logic here
                if (Logo != null)
                {
                    Logo.SaveAs(Server.MapPath("/Img/" + Logo.FileName));
                    brand.Logo = Logo.FileName;
                }
                manager.Update(brand);
                manager.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Hata Oluştu!");
            }
            return View(brand);
        }

        // GET: Admin/Brands/Delete/5
        public ActionResult Delete(int id)
        {
            var model = manager.Find(id);
            return View(model);
        }

        // POST: Admin/Brands/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var model = manager.Find(id);
                manager.Delete(model);
                manager.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
