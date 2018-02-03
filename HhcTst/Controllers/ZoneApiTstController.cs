using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HhcTst.Models;

namespace HhcTst.Controllers
{
    public class ZoneApiTstController : ApiController
    {
        HhcDbEntities db = new HhcDbEntities();
        public IQueryable<Zone> Get()
        {
            return db.Zones;
        }
        public IHttpActionResult GetById(int id)
        {
            var v = db.Zones.FirstOrDefault(x => x.ZoneID == id);
            if (v == null)
            {
                return NotFound();
            }
            return Ok(v);
        }
    }
}
