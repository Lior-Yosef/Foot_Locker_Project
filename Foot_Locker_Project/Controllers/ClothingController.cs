using Foot_Locker_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Foot_Locker_Project.Controllers.api
{
    public class ClothingController : Controller
    {
        static string StringConnection = "Data Source=LAPTOP-OT5IVM7S;Initial Catalog=SportStoreDB;Integrated Security=True;Pooling=False";
        SportStoreDBDataContext db = new SportStoreDBDataContext(StringConnection);
        // GET: Clothing
        public ActionResult AllClothing()
        {
            return View(db.Clothings.ToList());
        }
        public ActionResult Tshirt()
        {
            return View(db.Clothings.Where(item=>item.Type =="T-Shirt").ToList());
        }
        public ActionResult GenderMan()
        {
            return View(db.Clothings.Where(item => item.Gender == "Male").ToList());
        }
        public ActionResult ShortMan()
        {
            return View(db.Clothings.Where(item => item.Gender == "Male").OrderBy(item=>item.Price).ToList());
        }
        public ActionResult ManTshirt()
        {
            return View(db.Clothings.Where(item => item.Gender == "Male" && item.Type == "T-Shirt").ToList());
        }
        public ActionResult ShorTshirt()
        {
            return View(db.Clothings.Where(item => item.Gender == "Male" && item.Type == "T-Shirt").OrderBy(item => item.Price).ToList());
        }
        public ActionResult ManShorts()
        {
            return View(db.Clothings.Where(item => item.Gender == "Male" && item.Type == "Shorts").ToList());
        }
        public ActionResult OrderManShorts()
        {
            return View(db.Clothings.Where(item => item.Gender == "Male" && item.Type == "Shorts").OrderBy(item => item.Price).ToList());
        }
        public ActionResult GenderWomen()
        {
            return View(db.Clothings.Where(item => item.Gender == "Female").ToList());
        }
        public ActionResult WomenTshirt()
        {
            return View(db.Clothings.Where(item => item.Gender == "Female" && item.Type == "T-Shirt").ToList());
        }
        public ActionResult ShortTshirt()
        {
            return View(db.Clothings.Where(item => item.Gender == "Female" && item.Type == "T-Shirt").OrderBy(item => item.Price).ToList());
        }
        public ActionResult WomenShorts()
        {
            return View(db.Clothings.Where(item => item.Gender == "Female" && item.Type == "Shorts").ToList());
        }
        public ActionResult OrderWomenShorts()
        {
            return View(db.Clothings.Where(item => item.Gender == "Female" && item.Type == "Shorts").OrderBy(item => item.Price).ToList());
        }
        public ActionResult TableDetails()
        {
            return View(db.Clothings.ToList());
        }

    }
}