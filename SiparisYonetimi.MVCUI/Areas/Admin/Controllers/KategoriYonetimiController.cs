using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
using System.Web.Mvc;

namespace SiparisYonetimi.MVCUI.Areas.Admin.Controllers
{
    [Authorize]
    public class KategoriYonetimiController : Controller
    {
        CategoryManager manager = new CategoryManager();
        // GET: Admin/KategoriYonetimi
        public ActionResult Index()
        {
            var model = manager.GetAll();
            return View(model);
        }

        // GET: Admin/KategoriYonetimi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/KategoriYonetimi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/KategoriYonetimi/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                // TODO: Add insert logic here
                manager.Add(category);
                manager.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Hata Oluştu!");
            }
            return View(category);
        }

        // GET: Admin/KategoriYonetimi/Edit/5
        public ActionResult Edit(int id)
        {
            var model = manager.Find(id);
            return View(model);
        }

        // POST: Admin/KategoriYonetimi/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Category category)
        {
            try
            {
                // TODO: Add update logic here
                manager.Update(category);
                manager.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Hata Oluştu!");
            }
            return View(category);
        }

        // GET: Admin/KategoriYonetimi/Delete/5
        public ActionResult Delete(int id)
        {
            var model = manager.Find(id);
            return View(model);
        }

        // POST: Admin/KategoriYonetimi/Delete/5
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
