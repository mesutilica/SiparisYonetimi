using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisYonetimi.MVCUI.Areas.Admin.Controllers
{
    public class KullaniciYonetimiController : Controller
    {
        UserManager manager = new UserManager();
        // GET: Admin/KullaniciYonetimi
        public ActionResult Index()
        {
            var model = manager.GetAll();
            return View(model);
        }

        // GET: Admin/KullaniciYonetimi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/KullaniciYonetimi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/KullaniciYonetimi/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            try
            {
                // TODO: Add insert logic here
                manager.Add(user);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/KullaniciYonetimi/Edit/5
        public ActionResult Edit(int id)
        {
            var model = manager.Find(id);
            return View(model);
        }

        // POST: Admin/KullaniciYonetimi/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User user)
        {
            try
            {
                // TODO: Add update logic here
                manager.Update(user);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/KullaniciYonetimi/Delete/5
        public ActionResult Delete(int id)
        {
            var model = manager.Find(id);
            return View(model);
        }

        // POST: Admin/KullaniciYonetimi/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var model = manager.Find(id);
                manager.Remove(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
