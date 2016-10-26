using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            RegistrationModel model = new RegistrationModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Register(RegistrationModel model)
        {
            if(ModelState.IsValid)
            {
                if(WebMatrix.WebData.WebSecurity.UserExists(model.Email))
                {
                    ModelState.AddModelError("Email", "Email address already exiestes");
                }
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Login()
        {
            RegistrationModel model = new RegistrationModel();

            string apikey = ConfigurationManager.AppSettings["SendGrid.Key"];

            return View(model);
        }
        
    }
}