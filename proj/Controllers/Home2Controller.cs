using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proj.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}