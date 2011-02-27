//-----------------------------------------------------------------------
// <copyright file="HomeController.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Web.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
