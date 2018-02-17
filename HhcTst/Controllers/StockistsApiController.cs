using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using HhcTst.Models;

namespace HhcTst.Controllers
{
    public class StockistsApiController : ApiController
    {
        private HhcDbEntities db = new HhcDbEntities();

        // GET: api/Stockists
        public IQueryable<Hstockistdetail> GetStockists()
        {
            return db.Hstockistdetails;
        }

        // GET: api/Stockists/5
        [ResponseType(typeof(Hstockistdetail))]
        public IHttpActionResult GetStockist(int id)
        {
            Hstockistdetail stockist = db.Hstockistdetails.Find(id);
            if (stockist == null)
            {
                return NotFound();
            }

            return Ok(stockist);
        }

        // PUT: api/Stockists/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStockist(int id, Hstockistdetail stockist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != stockist.HstockistdetailsID)
            {
                return BadRequest();
            }

            db.Entry(stockist).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StockistExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Stockists
        [ResponseType(typeof(Hstockistdetail))]
        public IHttpActionResult PostStockist(Hstockistdetail stockist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Hstockistdetails.Add(stockist);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = stockist.HstockistdetailsID }, stockist);
        }

        // DELETE: api/Stockists/5
        [ResponseType(typeof(Hstockistdetail))]
        public IHttpActionResult DeleteStockist(int id)
        {
             Hstockistdetail stockist = db.Hstockistdetails.Find(id);
            if (stockist == null)
            {
                return NotFound();
            }

            db.Hstockistdetails.Remove(stockist);
            db.SaveChanges();

            return Ok(stockist);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StockistExists(int id)
        {
            return db.Hstockistdetails.Count(e => e.HstockistdetailsID == id) > 0;
        }
    }
}