using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HhcTst.Models;

namespace HhcTst.Models
{
    public class tempclass
    {
        HhcDbEntities db = new HhcDbEntities();
        public void a(){
        // Create the DbContext object.
    
        // Find the record to be deleted from TableA by using a query like the following
     var employee = db.tbl_registration.FirstOrDefault();//.ToList();
    // Because the above record is of type TableA you will need to copy the fields from it
    // to a record of type TableB. Note in this new record I did not copy the Primary key
    // this will be added by TableB when inserted.
    tbl_regNew moveEmployee = new tbl_regNew { 
        Name = employee.Name, ContactNo = employee.ContactNo,Email=employee.Email,Password=employee.Password,
        City=employee.City,Address=employee.Address
            };
    // Add the new record to TableB 
    db.tbl_regNew.Add(moveEmployee);
    // Delete the record from TableA
    db.tbl_registration.Remove(employee);
    // Save the changes.
    db.SaveChanges();
    }
    }
}