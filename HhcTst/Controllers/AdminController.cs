using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HhcTst.Models;

namespace HhcTst.Controllers
{
    public class AdminController : Controller
    {
        HhcDbEntities1 db = new HhcDbEntities1();
        // GET: Admin
        //[Authorize(Roles="Admin")]
        public ActionResult GetAdmins()
        {
            if (Session["loggedAdminName"] != null)
            {
                var v = db.hhcAdminLogins.ToList();
                return View(v);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Index()
        {
            return View("Login");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginVm vm)
        {
            if (ModelState.IsValid)
            {
                var tbRes = new hhcAdminLogin()
                {
                    UserName = vm.UserName,
                    UserPwd = vm.UserPwd
                };
                using (HhcDbEntities1 db = new HhcDbEntities1())
                {
                    var v = db.hhcAdminLogins.Where(a => a.UserName.Equals(tbRes.UserName) && a.UserPwd.Equals(tbRes.UserPwd)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["loggedAdminName"] = v.UserName.ToString();
                        return RedirectToAction("AdminDashBoard", "Admin");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid login credentials.");
                    }
                }
            }
            return View();
        }
        public ActionResult AdminDashBoard()
        {
            if (Session["loggedAdminName"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Admin");
        }
    }
}