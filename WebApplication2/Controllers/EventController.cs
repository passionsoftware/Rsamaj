using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RS.DataModel;
using RS.BusinessLogicLayer;

namespace WebApplication2.Controllers
{
    public class EventController : Controller
    {

        EventBL _eventDetailBL;
        public EventController()
        {
            _eventDetailBL = new EventBL();
        }
        // GET: Event
        public ActionResult Index()
        {
            EventModelDetails lstEventDetails = new EventModelDetails();

            var allEvents = _eventDetailBL.GetAllEvent();

            lstEventDetails.CurrentMonthEvent = allEvents.Where(o => o.EventDateFrom.Value.Month == DateTime.Now.Month).ToList();
            lstEventDetails.TotalEvent = allEvents;
            return View(lstEventDetails);
        }

        public ActionResult EventDetails(int id)
        {
            ViewBag.Style = "alert alert-success";
            EventModelView eventModelView = new EventModelView();
            eventModelView.SelectedEvent = _eventDetailBL.GetEventId(id);
            eventModelView.CurrentMonthEvent = _eventDetailBL.GetAllEvent().Where(o => o.EventDateFrom.Value.Month == DateTime.Now.Month).ToList();

            return View(eventModelView);
        }
    }
}