using System.Web.Mvc;
using eUseControl.web.Models;
using eUseControl.BusinessLogic;
using eUseControl.BusinessLogic.Interfaces;

namespace eUseControl.web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ISession _session;

        public RegisterController()
        {
            _session = new SessionBL();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        public ActionResult Index(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var success = _session.RegisterUser(model.Username, model.Email, model.Password);

            if (!success)
            {
                ViewBag.Error = "Acest email este deja folosit.";
                return View(model);
            }

            return RedirectToAction("Index", "Login");
        }
    }
}
