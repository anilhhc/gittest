using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using HhcTst.Models;

namespace HhcTst.Controllers
{
    public class StockistController : Controller
    {
       private HhcDbEntities db = new HhcDbEntities();
        // GET: Stockist
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(StockistLoginVM vm)
        {
            if (ModelState.IsValid)
            {
                var tbRes = new Stockist()
                {
                    StockistName = vm.StockistName,
                    Password = vm.Password
                };
                using (HhcDbEntities db = new HhcDbEntities())
                {
                    var v = db.Stockists.Where(a => a.StockistName.Equals(tbRes.StockistName) && a.Password.Equals(tbRes.Password)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["loggedStockistName"] = v.StockistName.ToString();
                        return RedirectToAction("StockistDashBoard", "Stockist");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid login credentials.");
                    }
                }
            }
            return View();
        }
        public ActionResult StockistDashBoard()
        {
            if (Session["loggedStockistName"] != null)
            {

                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        public ActionResult ProfilePage()
        {
            string str = Session["loggedStockistName"].ToString();
            var v = db.Stockists.Where(a=>a.StockistName == str).FirstOrDefault();

            return View(v);
        }
        public ActionResult Register()
        {
            return View();
        }

        // POST: Stockists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "StockistId,StockistName,Description,Password")] Stockist stockist)
        {
            if (ModelState.IsValid)
            {
                if (db.Stockists.Where(u => u.StockistName == stockist.StockistName).Any())
                {
                    ModelState.AddModelError("StockistName", "Stockist Name already taken");
                    return View(stockist);
                    //   .Write("Name already exists");
                    //Do what do u need to do...
                }
                else
                {
                    db.Stockists.Add(stockist);
                    db.SaveChanges();
                    ViewBag.name = stockist.StockistName.ToString();
                    return RedirectToAction("Login"); // RedirectToAction("Index");
                }
            }

            return View(stockist);
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Stockist");
        }
    }
}