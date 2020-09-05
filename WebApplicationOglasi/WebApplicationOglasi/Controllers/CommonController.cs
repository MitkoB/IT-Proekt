using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationOglasi.Models;

namespace WebApplicationOglasi.Controllers
{
    public class CommonController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Common
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Menu()
        {
            CategoryViewModel viewModel = new CategoryViewModel { MenuItems = db.Categories.ToList() };

            return View(viewModel);

        }
    }
}