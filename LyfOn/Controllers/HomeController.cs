using LyfOnLibrary.Service;
using LyfOnLibrary.Model;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LyfOn.Models;
using System.Threading.Tasks;

namespace LyfOn.Controllers
{
    public class HomeController : Controller
    {
        
        private ReadService ReadService { get; }
        private WriteService WriteService { get; }

     
        public HomeController()
        {
            ReadService = new ReadService(System.Configuration.ConfigurationManager.ConnectionStrings["LyfOn"].ConnectionString);
            WriteService = new WriteService(System.Configuration.ConfigurationManager.ConnectionStrings["LyfOn"].ConnectionString);
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Home/Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        // POST: /Home/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = ReadService.LoginProvider(model.UserName, model.Password);

            switch (result.Status)
            {
                case "success":
                    Session["UserName"] = model.UserName;
                    Session["User"] = result;
                    return RedirectToAction("Index", "Provider");
                case "LOCKEDOUT":
                    return View("Lockout");
                case "REQUIRESVERIFICATION":
                    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
                case "FAILURE":
                    ModelState.AddModelError("", "Invalid UserName or Password.");
                    return View(model);
                default:
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(model);
            }
        }

        // GET: /Home/Logout
        [AllowAnonymous]
        public ActionResult Logout()
        {
            Session["User"] = null;
            //var result = WriteService.LogOut(model.UserName);
            return RedirectToAction("Login", "Home");
        }
    }
}