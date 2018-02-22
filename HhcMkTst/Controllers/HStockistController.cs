using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HhcMkTst.Models;
using System.Data.Entity;

namespace HhcMkTst.Controllers
{
    public class HStockistController : Controller
    {
        public ActionResult test() { return View(); }
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAllStockists()
        {
            using (HhcmkdbEntities db = new HhcmkdbEntities())
            {
                List<Hstockistdetail> stk = db.Hstockistdetails.ToList();
                return Json(stk, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult GetStockistById(string Id)
        {
            using (HhcmkdbEntities db = new HhcmkdbEntities())
            {
                int HstockistdetailsID = int.Parse(Id);
                return Json(db.Hstockistdetails.Find(HstockistdetailsID), JsonRequestBehavior.AllowGet);
            }
        }
        public string InsertStockist(Hstockistdetail stkist)
        {
            if (stkist != null)
            {
                using (HhcmkdbEntities db = new HhcmkdbEntities())
                {
                    db.Hstockistdetails.Add(stkist);
                    db.SaveChanges();
                    return "Employee Added Successfully";
                }
            }
            else
            {
                return "Employee Not Inserted! Try Again";
            }
        }
        public string DeleteStockist(Hstockistdetail stkist)
        {
            if (stkist != null)
            {
                using (HhcmkdbEntities db = new HhcmkdbEntities())
                {
                    var stk = db.Entry(stkist);
                    if (stk.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.Hstockistdetails.Attach(stkist);
                        db.Hstockistdetails.Remove(stkist);
                    }
                    db.SaveChanges();
                    return "Employee Deleted Successfully";
                }
            }
            else
            {
                return "Employee Not Deleted! Try Again";
            }
        }
        public string UpdateStockist(Hstockistdetail stkst)
        {
            if (stkst != null)
            {
                using (HhcmkdbEntities db = new HhcmkdbEntities())
                {
                    var Emp_ = db.Entry(stkst);
                    Hstockistdetail stk = db.Hstockistdetails.Where(x => x.HstockistdetailsID == stkst.HstockistdetailsID).FirstOrDefault();
                    stk.hsfullname = stkst.hsfullname;
                    stk.hslastname = stkst.hslastname;
                    stk.hsemailid = stkst.hsemailid;
                    stk.hsmobile = stkst.hsmobile;
                    stk.hspwd = stkst.hspwd;
                    stk.hssapcustomerid = stkst.hssapcustomerid;
                    stk.hsplotno = stkst.hsplotno;
                    stk.hsadressone = stkst.hsadressone;
                    stk.hsadresstwo = stkst.hsadresstwo;
                    stk.hscountry = stkst.hscountry;
                    stk.hsstate = stkst.hsstate;
                    stk.hsheadquater = stkst.hsheadquater;
                    stk.hssubarea = stkst.hssubarea;
                    stk.hsdivision = stkst.hsdivision;
                    stk.hscnf = stkst.hscnf;
                    stk.hstherapatic = stkst.hstherapatic;
                    stk.hspincode = stkst.hspincode;
                    stk.hstelephone = stkst.hstelephone;
                    stk.hsfax = stkst.hsfax;
                    stk.hsgstprovisionalid = stkst.hsgstprovisionalid;
                    stk.hspan = stkst.hspan;
                    stk.hsspocname = stkst.hsspocname;
                    stk.hsspocmobile = stkst.hsspocmobile;
                    stk.hsssistatus = stkst.hsssistatus;
                    stk.hsdruglicenceno = stkst.hsdruglicenceno;
                    stk.hszone = stkst.hszone;
                    stk.ACTIVE = stkst.ACTIVE;
                    stk.CreatedOn = DateTime.Now; //stkst.CreatedOn;
                    db.Entry(stkst).State = EntityState.Modified;
                    db.SaveChanges();
                    return "Employee Updated Successfully";
                }
            }
            else
            {
                return "Employee Not Updated! Try Again";
            }
        }  
    }
}