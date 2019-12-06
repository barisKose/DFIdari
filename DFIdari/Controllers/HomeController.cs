using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DFIdari.Models;

namespace DFIdari.Controllers
{
    public class HomeController : Controller
    {
        DFIdariEntities DFI = new DFIdariEntities();

        public ActionResult Index()
        {
            return View();
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

        public ActionResult Listele()
        {
            return View(DFI.Personels.ToList());
        }

    }
}