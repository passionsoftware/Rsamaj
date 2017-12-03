using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RS.DataModel;
using RS.BusinessLogicLayer;

namespace WebApplication2.Controllers
{
    public class RathoreDetailController : Controller
    {
        // GET: RathoreDetail
        public ActionResult Index()
        {
            RathoreDetailBL _rathoreDetailBL = new RathoreDetailBL();
            RathoreDetailDisplayModel objDisplay =  _rathoreDetailBL.GetDetailsToDisplay();
            return View(objDisplay);
        }
    }
}