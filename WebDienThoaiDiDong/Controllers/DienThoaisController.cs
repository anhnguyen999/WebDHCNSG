using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebDienThoaiDiDong.Models;

namespace WebDienThoaiDiDong.Controllers
{
    [Authorize]
    public class DienThoaisController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DienThoais
        public ActionResult Index()
        {
            var dienThoais = db.DienThoais.Include(d => d.DanhMuc).Include(d => d.Employee);
            return View(dienThoais.ToList());
        }

        // GET: DienThoais/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DienThoai dienThoai = db.DienThoais.Find(id);
            if (dienThoai == null)
            {
                return HttpNotFound();
            }
            return View(dienThoai);
        }

        // GET: DienThoais/Create
        public ActionResult Create()
        {
            ViewBag.DanhMucId = new SelectList(db.DanhMucs, "Id", "Name");
            ViewBag.EmployeeId = new SelectList(db.Users, "Id", "Email");
            return View();
        }

        // POST: DienThoais/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PhoneName,Price,PhoneImage,EmployeeId,DanhMucId")] DienThoai dienThoai)
        {
            if (ModelState.IsValid)
            {
                db.DienThoais.Add(dienThoai);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DanhMucId = new SelectList(db.DanhMucs, "Id", "Name", dienThoai.DanhMucId);
            ViewBag.EmployeeId = new SelectList(db.Users, "Id", "Email", dienThoai.EmployeeId);
            return View(dienThoai);
        }

        // GET: DienThoais/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DienThoai dienThoai = db.DienThoais.Find(id);
            if (dienThoai == null)
            {
                return HttpNotFound();
            }
            ViewBag.DanhMucId = new SelectList(db.DanhMucs, "Id", "Name", dienThoai.DanhMucId);
            ViewBag.EmployeeId = new SelectList(db.Users, "Id", "Email", dienThoai.EmployeeId);
            return View(dienThoai);
        }

        // POST: DienThoais/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PhoneName,Price,PhoneImage,EmployeeId,DanhMucId")] DienThoai dienThoai)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dienThoai).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DanhMucId = new SelectList(db.DanhMucs, "Id", "Name", dienThoai.DanhMucId);
            ViewBag.EmployeeId = new SelectList(db.Users, "Id", "Email", dienThoai.EmployeeId);
            return View(dienThoai);
        }

        // GET: DienThoais/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DienThoai dienThoai = db.DienThoais.Find(id);
            if (dienThoai == null)
            {
                return HttpNotFound();
            }
            return View(dienThoai);
        }

        // POST: DienThoais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DienThoai dienThoai = db.DienThoais.Find(id);
            db.DienThoais.Remove(dienThoai);
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
