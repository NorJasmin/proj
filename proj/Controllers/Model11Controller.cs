using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using proj.Models;

namespace proj.Controllers
{
    public class Model11Controller : Controller
    {
        private Entities4 db = new Entities4();

        // GET: Model11
        public ActionResult Index()
        {
            Model11 objProductModel = new Model11();
            objProductModel.ClassTitle = "Class";
            objProductModel.AttendTitle = "Attend";
            objProductModel.AbsentTitle = "Absent";
            return View(objProductModel);
           
        }

        
    }
}
