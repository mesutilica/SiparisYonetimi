using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
using System.Web;
using System.Web.Mvc;

namespace SiparisYonetimi.MVCUI.Areas.Admin.Controllers
{
    public class UrunYonetimiController : Controller
    {
        ProductManager manager = new ProductManager();
        BrandManager brandManager = new BrandManager();
        CategoryManager categoryManager = new CategoryManager();
        // GET: Admin/UrunYonetimi
        public ActionResult Index()
        {
            var model = manager.GetAll();
            return View(model);
        }

        // GET: Admin/UrunYonetimi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/UrunYonetimi/Create
        public ActionResult Create()
        {
            ViewBag.BrandId = new SelectList(brandManager.GetAll(), "Id", "Name");
            ViewBag.CategoryId = new SelectList(categoryManager.GetAll(), "Id", "Name");
            return View();
        }

        // POST: Admin/UrunYonetimi/Create
        [HttpPost]
        public ActionResult Create(Product product, HttpPostedFileBase Image)
        {
            try
            {
                // TODO: Add insert logic here
                if (Image != null)
                {
                    Image.SaveAs(Server.MapPath("/Img/" + Image.FileName));
                    product.Image = Image.FileName;
                }
                manager.Add(product);
                manager.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Hata Oluştu!");
            }
            ViewBag.BrandId = new SelectList(brandManager.GetAll(), "Id", "Name");
            ViewBag.CategoryId = new SelectList(categoryManager.GetAll(), "Id", "Name");
            return View(product);
        }

        // GET: Admin/UrunYonetimi/Edit/5
        public ActionResult Edit(int id)
        {
            var model = manager.Find(id);
            ViewBag.BrandId = new SelectList(brandManager.GetAll(), "Id", "Name", model.BrandId);
            ViewBag.CategoryId = new SelectList(categoryManager.GetAll(), "Id", "Name", model.CategoryId);
            return View(model);
        }

        // POST: Admin/UrunYonetimi/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product product, HttpPostedFileBase Image)
        {
            try
            {
                // TODO: Add insert logic here
                if (Image != null)
                {
                    Image.SaveAs(Server.MapPath("/Img/" + Image.FileName));
                    product.Image = Image.FileName;
                }
                manager.Update(product);
                manager.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Hata Oluştu!");
            }
            ViewBag.BrandId = new SelectList(brandManager.GetAll(), "Id", "Name", product.BrandId);
            ViewBag.CategoryId = new SelectList(categoryManager.GetAll(), "Id", "Name", product.CategoryId);
            return View(product);
        }

        // GET: Admin/UrunYonetimi/Delete/5
        public ActionResult Delete(int id)
        {
            var model = manager.Find(id);
            return View(model);
        }

        // POST: Admin/UrunYonetimi/Delete/5
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
