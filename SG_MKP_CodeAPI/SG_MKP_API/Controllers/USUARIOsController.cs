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
    public class USUARIOSController : ApiController
    {
        private Model_USUARIO db = new Model_USUARIO();

        // GET: api/USUARIOS
        public IQueryable<USUARIO> GetUSUARIO()
        {
            return db.USUARIO;
        }

        // GET: api/USUARIOS/5
        [ResponseType(typeof(USUARIO))]
        public IHttpActionResult GetUSUARIO(int id) 
        {
            USUARIO Usuario = db.USUARIO.Find(id);
            if (Usuario == null)
            {
                return NotFound();
            }

            return Ok(Usuario);
        }

        // PUT: api/USUARIOS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUSUARIO(int id, USUARIO Usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != Usuario.USU_ID)
            {
                return BadRequest();
            }

            db.Entry(Usuario).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!USUARIOExists(id))
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

        // POST: api/USUARIOS
        [ResponseType(typeof(USUARIO))]
        public IHttpActionResult PostUSUARIO(USUARIO Usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.USUARIO.Add(Usuario);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = Usuario.USU_ID }, Usuario);
        }

        // DELETE: api/USUARIOS/5
        [ResponseType(typeof(USUARIO))]
        public IHttpActionResult DeleteUSUARIO(int id)
        {
            USUARIO Usuario = db.USUARIO.Find(id);
            if (Usuario == null)
            {
                return NotFound();
            }

            db.USUARIO.Remove(Usuario);
            db.SaveChanges();

            return Ok(Usuario);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool USUARIOExists(int id)
        {
            return db.USUARIO.Count(e => e.USU_ID == id) > 0;
        }
    }
}