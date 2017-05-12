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
using ShoppingApp.Models;
using Microsoft.AspNet.Identity;

namespace ShoppingApp.Controllers
{
    public class ShoppingVendorsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/ShoppingVendors
        //public IQueryable<Transaction> GetTransactions()
        public IEnumerable<ShoppingVendor> GetShoppingVendors()
        {
            List<ShoppingVendor> shoppingVendorList = db.ShoppingVendors.ToList();
            List<ApplicationUser> userList = db.Users.ToList();
            var user = db.Users.SingleOrDefault(c => c.SecretToken == 963788571);
            var userId = user.Id;
            var transacationList = db.ShoppingVendors.Where(c => c.ApplicationUser.Id == userId).ToList();
            return shoppingVendorList;

        }

        // GET: api/ShoppingVendors/5
        [ResponseType(typeof(ShoppingVendor))]
        public IHttpActionResult GetShoppingVendors(int id)
        {
            ShoppingVendor shoppingVendor = db.ShoppingVendors.Find(id);
            if (shoppingVendor == null)
            {
                return NotFound();
            }

            return Ok(shoppingVendor);
        }

        // PUT: api/ShoppingVendors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutShoppingVendor(int id, ShoppingVendor shoppingVendor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != shoppingVendor.Id)
            {
                return BadRequest();
            }

            db.Entry(shoppingVendor).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShoppingVendorExists(id))
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

        // POST: api/ShoppingVendors
        [ResponseType(typeof(ShoppingVendor))]
        public IHttpActionResult PostShoppingVendor(ShoppingVendor shoppingVendor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ShoppingVendors.Add(shoppingVendor);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = shoppingVendor.Id }, shoppingVendor);
        }

        // DELETE: api/ShoppingVendors/5
        [ResponseType(typeof(ShoppingVendor))]
        public IHttpActionResult DeleteShoppingVendor(int id)
        {
            ShoppingVendor shoppingVendor = db.ShoppingVendors.Find(id);
            if (shoppingVendor == null)
            {
                return NotFound();
            }

            db.ShoppingVendors.Remove(shoppingVendor);
            db.SaveChanges();

            return Ok(shoppingVendor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ShoppingVendorExists(int id)
        {
            return db.ShoppingVendors.Count(e => e.Id == id) > 0;
        }
    }
}