using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationOglasi.Models;

namespace WebApplicationOglasi.Controllers
{
    public class FavoriteCartController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddToFav(int id)
        {
            Oglas oglas = db.Oglas.Find(id);
            FavoriteItems model = new FavoriteItems();
            if(Session["Cart"]==null)
            {
                List<Oglas> cart = model.omileniOglasi;
                cart.Add(oglas);
                Session["Cart"] = cart;
            }
            else
            {
                List<Oglas> cart = (List<Oglas>)Session["Cart"];
                int flag = 1;
                for(int i=0;i<cart.Count;i++)
                {
                    if (cart[i].Id == id)
                    {
                        flag = 0;
                    }
                }
                if (flag == 1)
                {
                    cart.Add(oglas);
                    Session["Cart"] = cart;
                }
            }
            return RedirectToAction("Index");
        }
        public ActionResult removeFromFav(int id)
        {
            List<Oglas> cart = (List<Oglas>)Session["Cart"];
            Oglas oglas = db.Oglas.Find(id);
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Id == id)
                {
                    cart.RemoveAt(i);
                }
            }
            Session["Cart"] = cart;
            return RedirectToAction("Index");

        }

    }
}