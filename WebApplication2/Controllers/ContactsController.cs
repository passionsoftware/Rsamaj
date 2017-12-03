using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RS.DataModel;
using RS.BusinessLogicLayer;

namespace WebApplication2.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        public ActionResult Index()
        {
            ViewBag.Saved = false;
            @ViewBag.Message = "";
            return View();
        }


        [HttpPost]
        public ActionResult Index(ContactModel obj)
        {

            if(ModelState.IsValid)
            {
                ContactDetailBL _contactDetailBL = new ContactDetailBL();
                obj.IpAddress = "Host Name - " +  Request.UserHostName + ": IP Address -" + Request.UserHostAddress;
                obj.IpAddress = Request.UserHostName;
                //string url = String.Format("http://iplocationtools.com/ip_query2.php?ip={0}", Request.UserHostAddress);
                //XDocument xDoc = XDocument.Load(url);
                int result = _contactDetailBL.InsertContact(obj);
                ViewBag.Saved = true;

                if (result == 1)
                {
                    @ViewBag.Message = "आपका सन्देश हमें मिल गया है, धन्यवाद् ";
                    ModelState.Clear();
                    return View();
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