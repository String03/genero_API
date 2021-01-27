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
using genero_API.Models;

namespace genero_API.Controllers
{
    public class GeneroController : ApiController
    {
        private PringlesDBEntities db = new PringlesDBEntities();

        // GET: api/Genero
        public IQueryable<Genero> GetGenero()
        {
            return db.Genero;
        }

        // GET: api/Genero/5
        [ResponseType(typeof(Genero))]
        public IHttpActionResult GetGenero(int id)
        {
            Genero genero = db.Genero.Find(id);
            if (genero == null)
            {
                return NotFound();
            }

            return Ok(genero);
        }

        // PUT: api/Genero/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGenero(int id, Genero genero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != genero.id)
            {
                return BadRequest();
            }

            db.Entry(genero).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeneroExists(id))
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

        // POST: api/Genero
        [ResponseType(typeof(Genero))]
        public IHttpActionResult PostGenero(Genero genero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Genero.Add(genero);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = genero.id }, genero);
        }

        // DELETE: api/Genero/5
        [ResponseType(typeof(Genero))]
        public IHttpActionResult DeleteGenero(int id)
        {
            Genero genero = db.Genero.Find(id);
            if (genero == null)
            {
                return NotFound();
            }

            db.Genero.Remove(genero);
            db.SaveChanges();

            return Ok(genero);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GeneroExists(int id)
        {
            return db.Genero.Count(e => e.id == id) > 0;
        }
    }
}