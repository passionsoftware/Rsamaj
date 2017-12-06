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
            @ViewBag.Style = "alert alert-success";
            RathoreDetailModel rathoreDetails = new RathoreDetailModel();
            BindDropdown(ref rathoreDetails);
            return View(rathoreDetails);
        }

        [HttpPost]
        public ActionResult AddRathoreDetail(RathoreDetailModel obj)
        {
            @ViewBag.Style = "alert alert-success";
            if (ModelState.IsValid)
            {
                RathoreDetailBL _contactDetailBL = new RathoreDetailBL();

                obj.DateOfBirth = Convert.ToDateTime(obj.DateOfBirthFormated);

                if (!_contactDetailBL.CheckRathoreDetailExist(obj.Name, obj.DateOfBirth))
                {
                    int result = _contactDetailBL.InsertRathoreDetail(obj);
                    BindDropdown(ref obj);
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
                else
                {
                    ViewBag.Saved = true;
                    ViewBag.Style = "alert alert-danger";
                    ViewBag.Message = " इस नाम की जानकारी पहले से अंकित है. ";
                }

                BindDropdown(ref obj);

            }
            return View(obj);
        }

        public ActionResult EditRathoreDetail(int id)
        {
            TempData.Remove("Name");
            TempData.Remove("DateofBirth");

            ViewBag.Style = "alert alert-success";
            RathoreDetailBL _rathoreDetailBL = new RathoreDetailBL();
            RathoreDetailModel lstRathoreDetails = new RathoreDetailModel();
            lstRathoreDetails = _rathoreDetailBL.GetRathoreDetailId(id);

            TempData["Name"] = lstRathoreDetails.Name;
            TempData["DateofBirth"] = lstRathoreDetails.DateOfBirth;

            BindDropdown(ref lstRathoreDetails);
            string datetime = string.Format("{0:yyyy-MM-dd}", lstRathoreDetails.DateOfBirth);
            lstRathoreDetails.DateOfBirthFormated = datetime;
            return View(lstRathoreDetails);
        }

        [HttpPost]
        public ActionResult EditRathoreDetail(RathoreDetailModel obj)
        {
            @ViewBag.Style = "alert alert-success";
            if (ModelState.IsValid)
            {
                RathoreDetailBL _contactDetailBL = new RathoreDetailBL();
                obj.DateOfBirth = Convert.ToDateTime(obj.DateOfBirthFormated);
                string Name = Convert.ToString(TempData["Name"]).Trim();
                DateTime DateofBirth = Convert.ToDateTime(TempData["DateofBirth"]);

                TempData.Keep("Name");
                TempData.Keep("DateofBirth");


                if (Name != obj.Name.Trim()  || (!obj.DateOfBirth.Equals(DateofBirth)))
                {

                    if (_contactDetailBL.CheckRathoreDetailExist(obj.Name, obj.DateOfBirth))
                    {
                        ViewBag.Saved = true;
                        ViewBag.Style = "alert alert-danger";
                        ViewBag.Message = " इस नाम की जानकारी पहले से अंकित है. ";
                        BindDropdown(ref obj);
                        return View(obj);
                    }
                }
              

                int result = _contactDetailBL.UpdateRathoreDetail(obj);
                   
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
               

                BindDropdown(ref obj);

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