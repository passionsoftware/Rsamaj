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
    public class RathoreDetailsController : BaseController
    {
        // GET: admin/RathoreDetail
        public ActionResult Index()
        {
            RathoreDetailBL _rathoreDetailBL = new RathoreDetailBL();
            List<RathoreDetailModel> lstRathoreDetails = _rathoreDetailBL.GetAllRathoreDetail();
            return View(lstRathoreDetails);
        }


        public ActionResult AddRathoreDetail()
        {
            RathoreDetailModel rathoreDetails = new RathoreDetailModel();
            BindDropdown(ref rathoreDetails);
            return View(rathoreDetails);
        }

        [HttpPost]
        public ActionResult AddRathoreDetail(RathoreDetailModel obj)
        {
            if (ModelState.IsValid)
            {
                RathoreDetailBL _contactDetailBL = new RathoreDetailBL();

                obj.DateOfBirth = Convert.ToDateTime(obj.DateOfBirthFormated);
              
                int result = _contactDetailBL.InsertRathoreDetail(obj);
                ViewBag.Saved = true;
               

                if (result == 1)
                {
                    @ViewBag.Message = "जानकारी डेटाबेस मे दर्ज हो गया है | धन्यवाद् ";
                    ModelState.Clear();
                }
                else
                {
                    @ViewBag.Message = "तकनिकी खराबी की वजह से आपका सन्देश नहीं मिला , कृपया दुबारा भेजे.  ";
                }
                BindDropdown(ref obj);
            }
            return View(obj);
        }

        public ActionResult EditRathoreDetail(int id)
        {
            RathoreDetailBL _rathoreDetailBL = new RathoreDetailBL();
            RathoreDetailModel lstRathoreDetails = new RathoreDetailModel();
            lstRathoreDetails = _rathoreDetailBL.GetRathoreDetailId(id);
            BindDropdown(ref lstRathoreDetails);
            string datetime = string.Format("{0:yyyy-MM-dd}", lstRathoreDetails.DateOfBirth);
            lstRathoreDetails.DateOfBirthFormated = datetime;
            return View(lstRathoreDetails);
        }

        [HttpPost]
        public ActionResult EditRathoreDetail(RathoreDetailModel obj)
        {
            if (ModelState.IsValid)
            {
                RathoreDetailBL _contactDetailBL = new RathoreDetailBL();
                obj.DateOfBirth = Convert.ToDateTime(obj.DateOfBirthFormated);
                int result = _contactDetailBL.UpdateRathoreDetail(obj);
                BindDropdown(ref obj);
                ViewBag.Saved = true;

                if (result == 1)
                {
                    @ViewBag.Message = "जानकारी डेटाबेस मे दर्ज हो गया है | धन्यवाद् ";
                }
                else
                {
                    @ViewBag.Message = "तकनिकी खराबी की वजह से आपका सन्देश नहीं मिला , कृपया दुबारा भेजे.  ";
                }

            }
            return View(obj);
        }

        public ActionResult DeleteRathoreDetail(int id)
        {
            RathoreDetailBL _contactDetailBL = new RathoreDetailBL();

            int result = _contactDetailBL.DeleteRathoreDetail(id);
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
        public JsonResult CountryAutosuggest(string Prefix)
        {
            AutoSuggestTextBL obj = new AutoSuggestTextBL();

            var countryList = (from N in obj.GetAllCountry()
                               where N.Value.ToUpper().StartsWith(Prefix.ToUpper())
                               select new { N.Value });
            return Json(countryList, JsonRequestBehavior.AllowGet);

        }


        [HttpPost]
        public JsonResult StateAutosuggest(string Prefix)
        {
            AutoSuggestTextBL obj = new AutoSuggestTextBL();

            var stateList = (from N in obj.GetAllStates()
                             where N.Value.ToUpper().StartsWith(Prefix.ToUpper())
                             select new { N.Value });
            return Json(stateList, JsonRequestBehavior.AllowGet);

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



        private void BindDropdown(ref RathoreDetailModel rathoreDetails)
        {
            rathoreDetails.GenderDropDown = GetGenderDetail();
        }

        private IEnumerable<DropdownList> GetGenderDetail()
        {
            return new List<DropdownList>
            {
                new DropdownList(){Value = "Female", Key="F" },
                new DropdownList(){Value = "Male", Key="M" }
            };
        }

    }
}