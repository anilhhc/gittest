using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HhcTst.Models;

namespace HhcTst.Controllers
{
    public class hhcAdminLoginsController : Controller
    {
        private HhcDbEntities db = new HhcDbEntities();

        // GET: hhcAdminLogins
        public ActionResult Index()
        {
            return View(db.hhcAdminLogins.ToList());
        }

        // GET: hhcAdminLogins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hhcAdminLogin hhcAdminLogin = db.hhcAdminLogins.Find(id);
            if (hhcAdminLogin == null)
            {
                return HttpNotFound();
            }
            return View(hhcAdminLogin);
        }

        // GET: hhcAdminLogins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: hhcAdminLogins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "hhcAdminLoginsId,UserName,UserPwd,Name,Permissions,EmailID,ActiveStatus")] hhcAdminLogin hhcAdminLogin)
        {
            if (ModelState.IsValid)
            {
                var v = from p in db.hhcAdminLogins
                        where p.UserName == hhcAdminLogin.UserName && p.hhcAdminLoginsId != hhcAdminLogin.hhcAdminLoginsId
                        select p;
                if (v.Any()) 
                {
                    ModelState.AddModelError("UserName", "Name already taken");
                    return View(hhcAdminLogin);
                }
                else
                {
                    var Dt = DateTime.Now;
                    var d = Dt.Date;
                    hhcAdminLogin.CreatedOn = d;
                    db.hhcAdminLogins.Add(hhcAdminLogin);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(hhcAdminLogin);
        }

        // GET: hhcAdminLogins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hhcAdminLogin hhcAdminLogin = db.hhcAdminLogins.Find(id);
            if (hhcAdminLogin == null)
            {
                return HttpNotFound();
            }
            return View(hhcAdminLogin);
        }

        // POST: hhcAdminLogins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "hhcAdminLoginsId,UserName,UserPwd,Name,Permissions,EmailID,ActiveStatus")] hhcAdminLogin hhcAdminLogin)
        {
            if (ModelState.IsValid)
            {
                var v = from p in db.hhcAdminLogins
                        where p.UserName == hhcAdminLogin.UserName && p.hhcAdminLoginsId != hhcAdminLogin.hhcAdminLoginsId
                        select p;
                if (v.Any())
                {
                    ModelState.AddModelError("UserName",hhcAdminLogin.UserName +" Name already taken");
                    return View(hhcAdminLogin);
                }
                else
                {
                    db.Entry(hhcAdminLogin).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(hhcAdminLogin);
        }

        // GET: hhcAdminLogins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hhcAdminLogin hhcAdminLogin = db.hhcAdminLogins.Find(id);
            if (hhcAdminLogin == null)
            {
                return HttpNotFound();
            }
            return View(hhcAdminLogin);
        }

        // POST: hhcAdminLogins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hhcAdminLogin hhcAdminLogin = db.hhcAdminLogins.Find(id);
            db.hhcAdminLogins.Remove(hhcAdminLogin);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Active(int id)
        {
            hhcAdminLogin hhcadminlogin = db.hhcAdminLogins.Find(id);
            if (hhcadminlogin.ActiveStatus == "n")
            {
                hhcadminlogin.ActiveStatus = "y";
                db.SaveChanges();
            }
            else
            {
                hhcadminlogin.ActiveStatus = "n";
                db.SaveChanges();
            }
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
