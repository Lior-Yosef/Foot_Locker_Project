using Foot_Locker_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Foot_Locker_Project.Controllers.api
{
    public class equippingController : ApiController
    {
        // GET: api/equipping

        public static string StringConnection = "Data Source=LAPTOP-OT5IVM7S;Initial Catalog=SportStoreDB;Integrated Security=True;Pooling=False";
        SportStoreDBDataContext db = new SportStoreDBDataContext(StringConnection);
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(db.Sport_Equippings.ToList());

            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // GET: api/equipping/5
        public IHttpActionResult Get(int id)
        {
            try
            {

                return Ok(db.Sport_Equippings.First(item => item.Id == id));
            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // POST: api/equipping
        public IHttpActionResult Post([FromBody]Sport_Equipping value)
        {
            try
            {
                db.Sport_Equippings.InsertOnSubmit(value);
                db.SubmitChanges();
                return Ok("row add Successfully");

            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // PUT: api/equipping/5
        public IHttpActionResult Put(int id, [FromBody] Sport_Equipping value)
        {
            try
            {
                Sport_Equipping updateEquipping = db.Sport_Equippings.First((item) => item.Id == id);
                updateEquipping.Sport_Type = value.Sport_Type;
                updateEquipping.Product_Name = value.Product_Name;
                updateEquipping.Company = value.Company;
                updateEquipping.Price = value.Price;
                updateEquipping.Quantity = value.Quantity;


                db.SubmitChanges();
                return Ok(new { updateEquipping });

            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // DELETE: api/equipping/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                db.Sport_Equippings.DeleteOnSubmit(db.Sport_Equippings.First((item) => item.Id == id));
                db.SubmitChanges();
                return Ok("Delete");
            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
            }
    }
}
