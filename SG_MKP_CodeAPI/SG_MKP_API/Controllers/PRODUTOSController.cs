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
using SG_MKP_API.Models;

namespace SG_MKP_API.Controllers
{
    public class PRODUTOSController : ApiController
    {
        private Model_PRODUTO db = new Model_PRODUTO();

        // GET: api/PRODUTOS
        public IQueryable<PRODUTO> GetPRODUTO()
        {
            return db.PRODUTO;
        }

        // GET: api/PRODUTOS/5
        [ResponseType(typeof(PRODUTO))]
        public IHttpActionResult GetPRODUTO(int id)
        {
            PRODUTO pRODUTO = db.PRODUTO.Find(id);
            if (pRODUTO == null)
            {
                return NotFound();
            }

            return Ok(pRODUTO);
        }

        // PUT: api/PRODUTOS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPRODUTO(int id, PRODUTO pRODUTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pRODUTO.PRO_CODIGO)
            {
                return BadRequest();
            }

            db.Entry(pRODUTO).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PRODUTOExists(id))
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

        // POST: api/PRODUTOS
        [ResponseType(typeof(PRODUTO))]
        public IHttpActionResult PostPRODUTO(PRODUTO pRODUTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PRODUTO.Add(pRODUTO);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pRODUTO.PRO_CODIGO }, pRODUTO);
        }

        // DELETE: api/PRODUTOS/5
        [ResponseType(typeof(PRODUTO))]
        public IHttpActionResult DeletePRODUTO(int id)
        {
            PRODUTO pRODUTO = db.PRODUTO.Find(id);
            if (pRODUTO == null)
            {
                return NotFound();
            }

            db.PRODUTO.Remove(pRODUTO);
            db.SaveChanges();

            return Ok(pRODUTO);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PRODUTOExists(int id)
        {
            return db.PRODUTO.Count(e => e.PRO_CODIGO == id) > 0;
        }
    }
}