using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RS.DataModel;
using RS.BusinessLogicLayer;

namespace WebApplication2.Areas.admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: admin/Login
        public ActionResult Index()
        {
            @ViewBag.Message = string.Empty;
            return View();
        }

        
        [HttpPost]
        public ActionResult Index(LoginModel obj)
        {

            if (ModelState.IsValid)
            {
                if (obj.UserName == "admin" && obj.Password == "admin123")
                {
                    LoginModel _login = new LoginModel();
                    _login.Name = "Admin";
                    _login.RathoreDetailId = 0;
                    _login.Role = 99;
                    Session["LoginSuccesFull"] = _login;

                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                else
                {
                    @ViewBag.Message = "Please provide valid username and password.";
                    return View(obj);
                }

                //LoginBL _loginBL = new LoginBL();
                //Session["LoginSuccesFull"] = null;

                //LoginModel result = _loginBL.CheckLoginDetail(obj);
                //ViewBag.Saved = true;

                //if (result != null && result.Name != string.Empty)
                //{
                //    _loginBL.UpdateLoginInfoDetail(result);
                //    Session["LoginSuccesFull"] = result;
                //    return RedirectToAction("Index", "Home", new { area = "Admin" });
                //}
                //else
                //{
                    
                //    @ViewBag.Message = "तकनिकी खराबी की वजह से आपका सन्देश नहीं मिला , कृपया दुबारा भेजे.  ";
                //}

            }
            return View(obj);
        }
    }


}