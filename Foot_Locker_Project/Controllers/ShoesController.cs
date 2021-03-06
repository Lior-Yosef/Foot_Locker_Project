using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Foot_Locker_Project.Models;

namespace Foot_Locker_Project.Controllers.api
{

    public class ShoesController : Controller

    {
        static string StringConnection = "Data Source=LAPTOP-OT5IVM7S;Initial Catalog=SportStoreDB;Integrated Security=True;Pooling=False";
        SportStoreDBDataContext db = new SportStoreDBDataContext(StringConnection);
        // GET: Shoes
        public ActionResult GetAllShoes()
        {
            return View(db.Shoes.ToList());
        }
        public ActionResult ShoesOnSael()
        {
            
            return View(db.Shoes.Where(item=>item.OnSale==true).ToList());
        }
        public ActionResult ShortShoes()
        {
            return View(db.Shoes.OrderBy(item => item.Price).ToList());
        }
        public ActionResult TableDetails()
        {
            return View(db.Shoes.ToList());
        }
    }
}