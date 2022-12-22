using SiparisYonetimi.Business.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisYonetimi.MVCUI.Controllers
{
    public class CategoriesController : Controller
    {
        CategoryManager categoryManager = new CategoryManager();
        // GET: Categories
        public ActionResult Index(int id)
        {
            var model = categoryManager.Find(id);
            return View(model);
        }
    }
}