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
    }
}