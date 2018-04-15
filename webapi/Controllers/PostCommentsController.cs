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
    public class PostCommentsController : ApiController
    {
        private RapidResponseDbContext db = new RapidResponseDbContext();

        // GET: api/PostComments
        public IQueryable<PostComment> GetPostComments()
        {
            return db.PostComments;
        }

        // GET: api/PostComments/5
        [ResponseType(typeof(PostComment))]
        public async Task<IHttpActionResult> GetPostComment(Guid id)
        {
            PostComment postComment = await db.PostComments.FindAsync(id);
            if (postComment == null)
            {
                return NotFound();
            }

            return Ok(postComment);
        }

        // PUT: api/PostComments/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPostComment(Guid id, PostComment postComment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != postComment.Id)
            {
                return BadRequest();
            }

            db.Entry(postComment).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostCommentExists(id))
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

        // POST: api/PostComments
        [ResponseType(typeof(PostComment))]
        public async Task<IHttpActionResult> PostPostComment(PostComment postComment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PostComments.Add(postComment);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PostCommentExists(postComment.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = postComment.Id }, postComment);
        }

        // DELETE: api/PostComments/5
        [ResponseType(typeof(PostComment))]
        public async Task<IHttpActionResult> DeletePostComment(Guid id)
        {
            PostComment postComment = await db.PostComments.FindAsync(id);
            if (postComment == null)
            {
                return NotFound();
            }

            db.PostComments.Remove(postComment);
            await db.SaveChangesAsync();

            return Ok(postComment);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PostCommentExists(Guid id)
        {
            return db.PostComments.Count(e => e.Id == id) > 0;
        }
    }
}