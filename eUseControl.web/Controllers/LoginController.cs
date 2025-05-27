using System.Web.Mvc;
using eUseControl.web.Models;
using eUseControl.BusinessLogic;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities;

namespace eUseControl.web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession _session;

        public LoginController()
        {
            _session = new SessionBL();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = _session.Login(model.Email, model.Password);

            if (user == null)
            {
                ViewBag.Error = "Date de autentificare incorecte.";
                return View(model);
            }

            // salvăm în sesiune
            Session["Username"] = user.Username;
            Session["Role"] = user.Role;

            return RedirectToAction("Index", "Dashboard");
        }
    }
}
