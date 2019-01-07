using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using proj.Models;



namespace proj.Controllers
{

    public class StudsController : Controller
    {
      
        private Model1 db = new Model1();

        // GET: Studs
        public ActionResult Index(string searchBy, string search, int? id)
        {
            if (searchBy == "Name")
                return View(db.Studs.Where(x => x.Name.Contains(search) || search == null).ToList());
            else
            return View(db.Studs.Where(x => x.Age.ToString().StartsWith(search) || search ==null).ToList());
        }

        // GET: Studs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stud stud = db.Studs.Find(id);
            if (stud == null)
            {
                return HttpNotFound();
            }
            return View(stud);
        }

        // GET: Studs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Studs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Age,Mykid,Health,TotalFees,Overmin,Statuspay,Datepay,Monthpay,DateAttend,StatusAttend")] Stud stud)
        {
            if (ModelState.IsValid)
            {
                db.Studs.Add(stud);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stud);
        }

        // GET: Studs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stud stud = db.Studs.Find(id);
            if (stud == null)
            {
                return HttpNotFound();
            }
            return View(stud);
        }

        // POST: Studs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Age,Mykid,Health,TotalFees,Overmin,Statuspay,Datepay,Monthpay,DateAttend,StatusAttend")] Stud stud)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stud).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stud);
        }

        // GET: Studs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stud stud = db.Studs.Find(id);
            if (stud == null)
            {
                return HttpNotFound();
            }
            return View(stud);
        }

        // POST: Studs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stud stud = db.Studs.Find(id);
            db.Studs.Remove(stud);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
