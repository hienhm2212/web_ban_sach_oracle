using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using Oracle_sell_book;
using Oracle_sell_book.Models;
using Oracle.ManagedDataAccess.Client;
using System.Net;

namespace Oracle_sell_book.Controllers
{
    public class HomeController : Controller
    {
        private Entities db = new Entities();
        OracleParameter oraP = new OracleParameter();

        //Get sach
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Bookstore()
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
        public ActionResult BookDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SACH sach = db.SACHes.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            return View(sach);
        }
    }
}