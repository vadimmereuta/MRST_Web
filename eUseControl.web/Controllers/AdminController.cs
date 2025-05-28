using eUseControl.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.web.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            if (Session["Role"]?.ToString() != "Admin")
                return RedirectToAction("Index", "Home");

            var users = db.Users.ToList();
            return View(users);
        }

        public ActionResult Delete(int id)
        {
            var user = db.Users.Find(id);
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }

}