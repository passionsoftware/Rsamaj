using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RS.DataModel;
using RS.BusinessLogicLayer;

namespace WebApplication2.Areas.admin.Controllers
{
    [RathoreSamajAuth]
    public class ContactsController : BaseController
    {
        // GET: admin/Contacts
        public ActionResult Index()
        {
            ContactDetailBL _contactDetailBL = new ContactDetailBL();
            List<ContactModel> lstContact =   _contactDetailBL.GetAllContactDetail();
            return View(lstContact);
        }


        public ActionResult EditContactusDetail(int id)
        {
            ContactDetailBL _contusBL = new ContactDetailBL();
            ContactModel contus = _contusBL.GetContactId(id);
            //string datetime = string.Format("{0:yyyy-MM-dd}", lstRathoreDetails.DateOfBirth);
            //lstRathoreDetails.CreatedOn = datetime;
            return View(contus);
        }

     
        public ActionResult DeleteContactus(int id)
        {
            ContactDetailBL _contactDetailBL = new ContactDetailBL();

            int result = _contactDetailBL.DeleteContact(id);
            if (result == 1)
            {
                TempData["Message"] = "चयन किया रिकॉर्ड मिटा दिया गया है !! ";
            }
            else
            {
                TempData["Message"] = "तकनिकी खराबी की वजह से आपका सन्देश नहीं मिला , कृपया दुबारा भेजे.  ";
            }

            return RedirectToAction("Index");
        }
    }
}