﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HhcTst.Models;

namespace HhcTst.Controllers
{
    public class AdminController : Controller
    {
        HhcDbContainer db = new HhcDbContainer();
        // GET: Admin
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
                var tbRes = new Admin()
                {
                    AdminName = vm.AdminName,
                    Password = vm.Password
                };
                using (HhcDbContainer db = new HhcDbContainer())
                {
                    var v = db.Admins.Where(a => a.AdminName.Equals(tbRes.AdminName) && a.Password.Equals(tbRes.Password)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["loggedAdminName"] = v.AdminName.ToString();
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