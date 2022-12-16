using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
using System.Web.Mvc;

namespace SiparisYonetimi.MVCUI.Areas.Admin.Controllers
{
    public class ContactsController : Controller
    {
        ContactManager manager = new ContactManager();
        // GET: Admin/Contacts
        public ActionResult Index()
        {
            var model = manager.GetAll();
            return View(model);
        }

        // GET: Admin/Contacts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Contacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Contacts/Create
        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            try
            {
                // TODO: Add insert logic here
                manager.Add(contact);
                manager.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Contacts/Edit/5
        public ActionResult Edit(int id)
        {
            var model = manager.Find(id);
            return View(model);
        }

        // POST: Admin/Contacts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Contact contact)
        {
            try
            {
                // TODO: Add update logic here
                manager.Update(contact);
                manager.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Contacts/Delete/5
        public ActionResult Delete(int id)
        {
            var model = manager.Find(id);
            return View(model);
        }

        // POST: Admin/Contacts/Delete/5
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
