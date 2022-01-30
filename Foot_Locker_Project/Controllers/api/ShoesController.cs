using Foot_Locker_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Foot_Locker_Project.Controllers.api
{
    public class shoesController : ApiController
    {
         public static string StringConnection = "Data Source=LAPTOP-OT5IVM7S;Initial Catalog=SportStoreDB;Integrated Security=True;Pooling=False";
        SportStoreDBDataContext db = new SportStoreDBDataContext(StringConnection);

        // GET: api/shoes
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(db.Shoes.ToList());

            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        //GET: api/shoes/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                
                return Ok(db.Shoes.First(item=>item.Id==id));
            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // POST: api/shoes

        public IHttpActionResult Post([FromBody] Shoe value)
        {
            try
            {
                db.Shoes.InsertOnSubmit(value);
                db.SubmitChanges();           
                return Ok("row add Successfully");

            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // PUT: api/shoes/5
        public IHttpActionResult Put(int id, [FromBody] Shoe value)
        {
            try
            {
                Shoe newShoe = db.Shoes.First ((item) => item.Id == id);
                newShoe.ShoesType = value.ShoesType;
                newShoe.CompanyName = value.CompanyName;
                newShoe.Type = value.Type;
                newShoe.Price = value.Price;
                newShoe.Quantity = value.Quantity;
                newShoe.OnSale = value.OnSale;
                db.SubmitChanges();
                return Ok(new { newShoe });

            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // DELETE: api/shoes/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                db.Shoes.DeleteOnSubmit(db.Shoes.First((item)=>item.Id==id));
                db.SubmitChanges();
                return Ok("Delete");
            }
            catch (sqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}
