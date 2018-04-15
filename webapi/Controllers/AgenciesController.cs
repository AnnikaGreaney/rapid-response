using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using RapidResponse.database;
using RapidResponse.domain;

namespace RapidResponse.webapi.Controllers
{
    public class AgenciesController : ApiController
    {
        private RapidResponseDbContext db = new RapidResponseDbContext();

        // GET: api/Agencies
        public IQueryable<Agency> GetAgencies()
        {
            return db.Agencies;
        }

        // GET: api/Agencies/5
        [ResponseType(typeof(Agency))]
        public async Task<IHttpActionResult> GetAgency(Guid id)
        {
            Agency agency = await db.Agencies.FindAsync(id);
            if (agency == null)
            {
                return NotFound();
            }

            return Ok(agency);
        }

        // PUT: api/Agencies/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAgency(Guid id, Agency agency)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != agency.Id)
            {
                return BadRequest();
            }

            db.Entry(agency).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgencyExists(id))
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

        // POST: api/Agencies
        [ResponseType(typeof(Agency))]
        public async Task<IHttpActionResult> PostAgency(Agency agency)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Agencies.Add(agency);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AgencyExists(agency.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = agency.Id }, agency);
        }

        // DELETE: api/Agencies/5
        [ResponseType(typeof(Agency))]
        public async Task<IHttpActionResult> DeleteAgency(Guid id)
        {
            Agency agency = await db.Agencies.FindAsync(id);
            if (agency == null)
            {
                return NotFound();
            }

            db.Agencies.Remove(agency);
            await db.SaveChangesAsync();

            return Ok(agency);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AgencyExists(Guid id)
        {
            return db.Agencies.Count(e => e.Id == id) > 0;
        }
    }
}