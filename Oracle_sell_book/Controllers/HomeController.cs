using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using Oracle_sell_book;
using Oracle_sell_book.Models;

namespace Oracle_sell_book.Controllers
{
    public class HomeController : Controller
    {
        private Entities db = new Entities();

        //Get sach
        public ActionResult Index()
        {
            return View(db.SACHes.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}