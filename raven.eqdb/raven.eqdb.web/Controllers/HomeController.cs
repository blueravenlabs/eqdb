using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using raven.eqdb.web.ViewModels.Home;

namespace raven.eqdb.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeIndexViewModel vm = new HomeIndexViewModel();

            return View(vm);
        }
    }
}