using GeocodingGoogleMap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeocodingGoogleMap.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
         
        [HttpGet]
        public ActionResult LocationInfo()
        {

            return View();
        }

        [HttpPost]
        public ActionResult LocationInfo(PropertyDetail propertyDetail)
        {

            return RedirectToAction("Index");
        }


	}
}