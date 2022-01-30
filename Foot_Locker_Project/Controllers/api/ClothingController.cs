using Foot_Locker_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Foot_Locker_Project.Controllers.api
{
    public class clothingController : ApiController
    {
        // GET: api/clothing

        public static string StringConnection = "Data Source=LAPTOP-OT5IVM7S;Initial Catalog=SportStoreDB;Integrated Security=True;Pooling=False";
        SportStoreDBDataContext db = new SportStoreDBDataContext(StringConnection);
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(db.Clothings.ToList());

            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // GET: api/clothing/5
        public IHttpActionResult Get(int id)
        {
            try
            {

                return Ok(db.Clothings.First(item => item.Id == id));
            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // POST: api/clothing
        public IHttpActionResult Post([FromBody] Clothing value)
        {
            try
            {
                db.Clothings.InsertOnSubmit(value);
                db.SubmitChanges();
                return Ok("row add Successfully");

            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // PUT: api/clothing/5
        public IHttpActionResult Put(int id, [FromBody] Clothing value)
        {
            try
            {
                Clothing updateClothing = db.Clothings.First((item) => item.Id == id);
                updateClothing.Company = value.Company;
                updateClothing.Type = value.Type;
                updateClothing.Gender = value.Gender;
                updateClothing.Price = value.Price;
                updateClothing.Quantity = value.Quantity;
                updateClothing.Short = value.Short;
                updateClothing.Dryfit = value.Dryfit;

                db.SubmitChanges();
                return Ok(new { updateClothing });

            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // DELETE: api/clothing/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                db.Clothings.DeleteOnSubmit(db.Clothings.First((item) => item.Id == id));
                db.SubmitChanges();
                return Ok("Delete");
            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}
