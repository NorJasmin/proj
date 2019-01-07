using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proj.Controllers
{
    public class GoogleController : Controller
    {
        // GET: Google
        public ActionResult ColumnFees()
        {
            return View();
        }
        public JsonResult GetSalesData()
        {

            List<Fee1> sd = new List<Fee1>();
            using (Model1 dc = new Model1())
            {
                sd = dc.Fee1.OrderBy(a => a.Month).ToList();
            }

            var chartData = new object[sd.Count + 1];
            chartData[0] = new object[]{
                    "Month",
                    "Total Fees",



                };
            int j = 0;
            foreach (var i in sd)
            {
                j++;
                chartData[j] = new object[] { i.Month, i.TotalFees };
            }

            return new JsonResult { Data = chartData, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


    }
}
    