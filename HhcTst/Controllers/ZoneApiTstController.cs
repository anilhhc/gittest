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
        public IQueryable<Zone> GetZones()
        {
            return db.Zones;
        }
    }
}
