using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisYonetimi.MVCUI.Areas.Admin.Controllers
{
    public class MusteriYonetimiController : Controller
    {
        CustomerManager manager = new CustomerManager();
        // GET: Admin/MusteriYonetimi
        public ActionResult Index()
        {
            var model = manager.GetAll();
            return View(model);
        }

        // GET: Admin/MusteriYonetimi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/MusteriYonetimi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/MusteriYonetimi/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                // TODO: Add insert logic here
                manager.Add(customer);
                manager.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Hata Oluştu!");
            }
            return View(customer);
        }

        // GET: Admin/MusteriYonetimi/Edit/5
        public ActionResult Edit(int id)
        {
            var model = manager.Find(id);
            return View(model);
        }

        // POST: Admin/MusteriYonetimi/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                // TODO: Add update logic here
                manager.Update(customer);
                manager.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Hata Oluştu!");
            }
            return View(customer);
        }

        // GET: Admin/MusteriYonetimi/Delete/5
        public ActionResult Delete(int id)
        {
            var model = manager.Find(id);
            return View(model);
        }

        // POST: Admin/MusteriYonetimi/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var customer = manager.Find(id);
                manager.Delete(customer);
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
