using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proj.Controllers
{
    public class GoogleChartController : Controller
    {
        // GET: GoogleChart
        public ActionResult Column()
        {
            return View();
        }
        public JsonResult GetSalesData()
        {
            List<Att> sd = new List<Att>();
            using (Entities4 dc = new Entities4())
            {
                sd = dc.Atts.OrderBy(a => a.Class).ToList();
            }

            var chartData = new object[sd.Count + 1];
            chartData[0] = new object[]{
                    "Class",
                    "Attend",
                    "Absent",


                };
            int j = 0;
            foreach (var i in sd)
            {
                j++;
                chartData[j] = new object[] { i.Class, i.Attend,i.Absent };
            }

            return new JsonResult { Data = chartData, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

    }
}
    