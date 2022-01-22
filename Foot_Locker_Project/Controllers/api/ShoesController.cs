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
        SportStoreDB db = new SportStoreDB(StringConnection);  
        // GET: Shoes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllShoes()
        {
            return View();
        }

    }
}