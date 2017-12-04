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


            List<RathoreDetailModel> rathoreDetail = new List<RathoreDetailModel>();
            foreach(var val in _rathoreDetailBL.GetAllRathoreDetail())
            {
                val.Age = CalculateAge(Convert.ToDateTime(val.DateOfBirth));
                rathoreDetail.Add(val);
            }

            objDisplay.RathoreDetails = _rathoreDetailBL.GetAllRathoreDetail();

            return View(objDisplay);
        }


        /// <summary>  
        /// For calculating only age  
        /// </summary>  
        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
    }
}