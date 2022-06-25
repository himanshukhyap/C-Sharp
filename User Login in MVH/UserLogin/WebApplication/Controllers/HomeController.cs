using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Services;
namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            if (Session["username"] == null)
            {
                return RedirectToAction("Login");

            }
            //ViewBag.Title = "Home Page";
            //var data = new UserProfileController();
            var UserProfileService = new UserProfileService();
            var data = UserProfileService.userbyusername(Session["username"].ToString());
            return View(data);
        }
        [HttpPost]
        public ActionResult Login(LoginModel userdata)
        {
            
                var UserProfileService = new UserProfileService();
                var isSuccess = UserProfileService.Authentication(userdata);

                if (isSuccess == true)
                {
                    Session["username"] = userdata.UserName;
                    return RedirectToAction("Index");

                }
                else
                    return View();

           
       

        }

        [HttpGet]
        public ActionResult Login()
        {
            if (Session["username"]!=null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public class LoginModel
        {

            public string UserName { get; set; }
            public string Password { get; set; }

        }
    }
}

