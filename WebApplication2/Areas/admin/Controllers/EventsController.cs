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
    public class EventsController : BaseController
    {
        EventBL _eventDetailBL;
        public EventsController()
        {
            _eventDetailBL = new EventBL();
        }
        // GET: admin/Events
        [RathoreSamajAuth(Order = 1, Roles = "1,2,99", Users = null)]
        public ActionResult Index()
        {
            List<EventModel> lstEventDetails = _eventDetailBL.GetAllEvent();
            return View(lstEventDetails);
        }

        [RathoreSamajAuth(Order = 1, Roles = "1,2,99", Users = null)]
        public ActionResult AddEvent()
        {
            @ViewBag.Style = "alert alert-success";
            //RathoreDetailModel rathoreDetails = new RathoreDetailModel();
            // BindDropdown(ref rathoreDetails);
            return View();
        }


        [HttpPost]
        [RathoreSamajAuth(Order = 1, Roles = "1,2,99", Users = null)]
        public ActionResult AddEvent(EventModel obj)
        {
            @ViewBag.Style = "alert alert-success";
            if (ModelState.IsValid)
            {

                obj.CreatedBy = LoginUserID;
                obj.EventDateFrom = Convert.ToDateTime(obj.EventDateFromFormated);
                obj.EventDateTo = Convert.ToDateTime(obj.EventDateToFormated);

                int result = _eventDetailBL.InsertEvent(obj);
                // BindDropdown(ref obj);
                ViewBag.Saved = true;

                if (result == 1)
                {
                    ViewBag.Style = "alert alert-success";
                    ViewBag.Message = "जानकारी डेटाबेस मे दर्ज हो गया है | धन्यवाद् ";
                    ModelState.Clear();
                }
                else
                {
                    ViewBag.Style = "alert alert-danger";
                    ViewBag.Message = "तकनिकी खराबी की वजह से आपका सन्देश नहीं मिला , कृपया दुबारा भेजे.  ";
                }
            }
            return View(obj);
        }


        [RathoreSamajAuth(Order = 1, Roles = "1,2,99", Users = null)]
        public ActionResult EditEvent(int id)
        {
            ViewBag.Style = "alert alert-success";
            EventModel eventModel = new EventModel();
            eventModel = _eventDetailBL.GetEventId(id);


            string datetimeFrom = string.Format("{0:yyyy-MM-dd}", eventModel.EventDateFrom);
            string datetimeTo = string.Format("{0:yyyy-MM-dd}", eventModel.EventDateTo);

            eventModel.EventDateFromFormated = datetimeFrom;
            eventModel.EventDateToFormated = datetimeTo;

            return View(eventModel);
        }


        [HttpPost]
        [RathoreSamajAuth(Order = 1, Roles = "1,2,99", Users = null)]
        public ActionResult EditEvent(EventModel obj)
        {
            @ViewBag.Style = "alert alert-success";
            if (ModelState.IsValid)
            {
                obj.ModifiedBy = LoginUserID;
                obj.EventDateFrom = Convert.ToDateTime(obj.EventDateFromFormated);
                obj.EventDateTo = Convert.ToDateTime(obj.EventDateToFormated);

                //string Name = Convert.ToString(TempData["Name"]).Trim();
                //DateTime DateofBirth = Convert.ToDateTime(TempData["DateofBirth"]);

                //TempData.Keep("Name");
                //TempData.Keep("DateofBirth");


                int result = _eventDetailBL.UpdateEvent(obj);

                ViewBag.Saved = true;

                if (result == 1)
                {
                    ViewBag.Style = "alert alert-success";
                    ViewBag.Message = "जानकारी डेटाबेस मे दर्ज हो गया है | धन्यवाद् ";
                }
                else
                {
                    ViewBag.Style = "alert alert-danger";
                    ViewBag.Message = "तकनिकी खराबी की वजह से आपका सन्देश नहीं मिला , कृपया दुबारा भेजे.  ";
                }

            }
            return View(obj);
        }


        [RathoreSamajAuth(Order = 1, Roles = "1,99", Users = null)]
        public ActionResult DeleteEvent(int id)
        {
            int result = _eventDetailBL.DeleteEvent(id);
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


        [HttpPost]
        public JsonResult DistrictAutosuggest(string Prefix)
        {
            AutoSuggestTextBL obj = new AutoSuggestTextBL();

            var distList = (from N in obj.GetAllDistrict()
                            where N.Value.ToUpper().StartsWith(Prefix.ToUpper())
                            select new { N.Value });
            return Json(distList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult LocationAutosuggest(string Prefix)
        {
            AutoSuggestTextBL obj = new AutoSuggestTextBL();

            var distlocation = (from N in obj.GetAllLocation()
                                where N.Value.ToUpper().StartsWith(Prefix.ToUpper())
                                select new { N.Value });
            return Json(distlocation, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult EventAutosuggest(string Prefix)
        {
            AutoSuggestTextBL obj = new AutoSuggestTextBL();

            var eventsType = (from N in obj.GetEventType()
                                where N.Value.ToUpper().StartsWith(Prefix.ToUpper())
                                select new { N.Value });
            return Json(eventsType, JsonRequestBehavior.AllowGet);
        }
    }
}