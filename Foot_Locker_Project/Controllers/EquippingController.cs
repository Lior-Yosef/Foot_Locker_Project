using Foot_Locker_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Foot_Locker_Project.Controllers.api
{
    public class EquippingController : Controller
    {
        static string StringConnection = "Data Source=LAPTOP-OT5IVM7S;Initial Catalog=SportStoreDB;Integrated Security=True;Pooling=False";
        SportStoreDBDataContext db = new SportStoreDBDataContext(StringConnection);

        // GET: Equipping
        public ActionResult TableDetails()
        {
            return View(db.Sport_Equippings.ToList());
        }
        public ActionResult AllEquippings()
        {
            return View(db.Sport_Equippings.ToList());
        }
        public ActionResult FootBallEquippings()
        {
            return View(db.Sport_Equippings.Where(item => item.Sport_Type == "Football").ToList());
        }
        public ActionResult BasketBallEquippings()
        {
            return View(db.Sport_Equippings.Where(item => item.Sport_Type == "BasketBall").ToList());
        }
    }
}