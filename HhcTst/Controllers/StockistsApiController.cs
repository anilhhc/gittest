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
        private HhcDbContainer db = new HhcDbContainer();

        // GET: api/Stockists
        public IQueryable<Stockist> GetStockists()
        {
            return db.Stockists;
        }

        // GET: api/Stockists/5
        [ResponseType(typeof(Stockist))]
        public IHttpActionResult GetStockist(int id)
        {
            Stockist stockist = db.Stockists.Find(id);
            if (stockist == null)
            {
                return NotFound();
            }

            return Ok(stockist);
        }

        // PUT: api/Stockists/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStockist(int id, Stockist stockist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != stockist.StockistId)
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
        [ResponseType(typeof(Stockist))]
        public IHttpActionResult PostStockist(Stockist stockist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Stockists.Add(stockist);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = stockist.StockistId }, stockist);
        }

        // DELETE: api/Stockists/5
        [ResponseType(typeof(Stockist))]
        public IHttpActionResult DeleteStockist(int id)
        {
            Stockist stockist = db.Stockists.Find(id);
            if (stockist == null)
            {
                return NotFound();
            }

            db.Stockists.Remove(stockist);
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
            return db.Stockists.Count(e => e.StockistId == id) > 0;
        }
    }
}