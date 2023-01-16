using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication2.Model;

namespace WebApplication2.Controllers
{
    public class CountryMastersController : ApiController
    {
        public DbConnection db = new DbConnection();

        // GET: api/CountryMasters
        public List<CountryMaster> GetCountryMasters()
        {
            return db.CountryMasters.ToList();
        }

        // GET: api/CountryMasters/5
        [ResponseType(typeof(CountryMaster))]
       
        public async Task<IHttpActionResult> GetCountryMaster(int id)
        {
            CountryMaster countryMaster = await db.CountryMasters.FindAsync(id);
            if (countryMaster == null)
            {
                return NotFound();
            }

            return Ok(countryMaster);
        }

        // PUT: api/CountryMasters/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCountryMaster(int id, CountryMaster countryMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != countryMaster.ID)
            {
                return BadRequest();
            }

            db.Entry(countryMaster).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryMasterExists(id))
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

        // POST: api/CountryMasters
        [ResponseType(typeof(CountryMaster))]
        public async Task<IHttpActionResult> PostCountryMaster(CountryMaster countryMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CountryMasters.Add(countryMaster);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = countryMaster.ID }, countryMaster);
        }

        // DELETE: api/CountryMasters/5
        [ResponseType(typeof(CountryMaster))]
        public async Task<IHttpActionResult> DeleteCountryMaster(int id)
        {
            CountryMaster countryMaster = await db.CountryMasters.FindAsync(id);
            if (countryMaster == null)
            {
                return NotFound();
            }

            db.CountryMasters.Remove(countryMaster);
            await db.SaveChangesAsync();

            return Ok(countryMaster);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CountryMasterExists(int id)
        {
            return db.CountryMasters.Count(e => e.ID == id) > 0;
        }
    }
}