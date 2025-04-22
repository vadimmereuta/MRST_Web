using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.BusinessLogic;

public class LoginController : Controller
{
    private readonly BusinessLogic _bl = new BusinessLogic();

    public ActionResult Login(string email, string password)
    {
        var user = _bl.Session.Login(email, password);
        if (user != null)
        {
            return RedirectToAction("Index", "Home");
        }

        ViewBag.Error = "Date incorecte.";
        return View();
    }
}
