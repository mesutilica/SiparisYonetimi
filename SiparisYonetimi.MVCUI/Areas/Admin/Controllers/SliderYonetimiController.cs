using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
using System.Web;
using System.Web.Mvc;

namespace SiparisYonetimi.MVCUI.Areas.Admin.Controllers
{
    [Authorize]
    public class SliderYonetimiController : Controller
    {
        SliderManager manager = new SliderManager();
        // GET: Admin/SliderYonetimi
        public ActionResult Index()
        {
            var model = manager.GetAll();
            return View(model);
        }

        // GET: Admin/SliderYonetimi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/SliderYonetimi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/SliderYonetimi/Create
        [HttpPost]
        public ActionResult Create(Slide slide, HttpPostedFileBase Image)
        {
            try
            {
                // TODO: Add insert logic here
                if (Image != null)
                {
                    Image.SaveAs(Server.MapPath("/Img/" + Image.FileName));
                    slide.Image = Image.FileName;
                }
                manager.Add(slide);
                manager.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/SliderYonetimi/Edit/5
        public ActionResult Edit(int id)
        {
            var model = manager.Find(id);
            return View(model);
        }

        // POST: Admin/SliderYonetimi/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Slide slide, HttpPostedFileBase Image)
        {
            try
            {
                // TODO: Add update logic here
                if (Image != null)
                {
                    Image.SaveAs(Server.MapPath("/Img/" + Image.FileName));
                    slide.Image = Image.FileName;
                }
                manager.Update(slide);
                manager.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Hata Oluştu!");
            }
            return View(slide);
        }

        // GET: Admin/SliderYonetimi/Delete/5
        public ActionResult Delete(int id)
        {
            var model = manager.Find(id);
            return View(model);
        }

        // POST: Admin/SliderYonetimi/Delete/5
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
