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
            return View();
        }

        [HttpPost]
        public ActionResult CheckCredetial(LoginModel obj)
        {
            return RedirectToAction("Index", "Home", new { area = "Admin" });

            if (ModelState.IsValid)
            {
                LoginBL _loginBL = new LoginBL();
                Session["LoginSuccesFull"] = null;

                LoginModel result = _loginBL.CheckLoginDetail(obj);
                ViewBag.Saved = true;

                if (result != null && result.Name != string.Empty)
                {
                    _loginBL.UpdateLoginInfoDetail(result);
                    Session["LoginSuccesFull"] = result;
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                else
                {
                    
                    @ViewBag.Message = "तकनिकी खराबी की वजह से आपका सन्देश नहीं मिला , कृपया दुबारा भेजे.  ";
                }

            }
            return View(obj);
        }
    }


}