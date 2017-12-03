using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RS.DataModel;

using RS.DataAccessLayer.entitydata;

namespace RS.DataAccessLayer
{
    public class RathoreDetailDL
    {
        public int InsertRathoreDetail(RathoreDetailModel obj)
        {
            int result = 0;

            using (RSEntities objEnt = new RSEntities())
            {
                 CheckForCurrentLocationDetail(ref obj, obj);
                 CheckForNativeLocationDetail(ref obj, obj);

                RS_RathoreDetails oData = new RS_RathoreDetails();
                oData.Name = obj.Name;
                oData.FatherName = obj.FatherName;
                oData.MotherName = obj.MotherName;
                oData.DateOfBirth = obj.DateOfBirth;
                oData.PhoneNumber = obj.PhoneNumber;
                oData.Occupation = obj.Occupation;
                oData.IsMarried = obj.IsMarried;
                oData.SpouseName = obj.SpouseName;
                oData.CurrentCountry = obj.CurrentCountry;
                oData.CurrentState = obj.CurrentState;
                oData.CurrentDistrict = obj.CurrentDistrict;
                oData.CurrentLocation = obj.CurrentLocation;
                oData.CurrentAddress = obj.CurrentAddress;
                oData.NativeCountry = obj.NativeCountry;
                oData.NativeState = obj.NativeState;
                oData.NativeDistrict = obj.NativeDistrict;
                oData.NativeLocation = obj.NativeLocation;
                oData.NativeAddress = obj.NativeAddress;
                oData.EmailId = obj.EmailId;
                oData.FinalEducation = obj.FinalEducation;
                oData.NoOfChildern = obj.NoOfChildern;
                oData.CreatedBy = obj.CreatedBy;
                oData.CreatedOn = DateTime.Now;
                oData.IsActive = true;

                //oData.CreatedOn = ;
                //oData.Location = obj.Location;
                //oData.IpAddress = obj.IpAddress;

                objEnt.RS_RathoreDetails.Add(oData);

                result = objEnt.SaveChanges();
            }

            return result;
        }

        public int UpdateRathoreDetail(RathoreDetailModel obj)
        {
            int result = 0;

            using (RSEntities objEnt = new RSEntities())
            {
                CheckForCurrentLocationDetail(ref obj, obj);
                CheckForNativeLocationDetail(ref obj, obj);

                var oData = objEnt.RS_RathoreDetails.Where(i => i.RathoreDetailId == obj.RathoreDetailId).First();
                oData.Name = obj.Name;
                oData.FatherName = obj.FatherName;
                oData.MotherName = obj.MotherName;
                oData.DateOfBirth = obj.DateOfBirth;
                oData.PhoneNumber = obj.PhoneNumber;
                oData.Occupation = obj.Occupation;
                oData.IsMarried = obj.IsMarried;
                oData.SpouseName = obj.SpouseName;
                oData.CurrentCountry = obj.CurrentCountry;
                oData.CurrentState = obj.CurrentState;
                oData.CurrentDistrict = obj.CurrentDistrict;
                oData.CurrentLocation = obj.CurrentLocation;
                oData.CurrentAddress = obj.CurrentAddress;
                oData.NativeCountry = obj.NativeCountry;
                oData.NativeState = obj.NativeState;
                oData.NativeDistrict = obj.NativeDistrict;
                oData.NativeLocation = obj.NativeLocation;
                oData.NativeAddress = obj.NativeAddress;
                oData.EmailId = obj.EmailId;
                oData.FinalEducation = obj.FinalEducation;
                oData.NoOfChildern = obj.NoOfChildern;
                oData.ModifiedBy = obj.ModifiedBy;
                oData.ModifiedOn = DateTime.Now;
                oData.IsActive = true;

                //oData.CreatedOn = ;
                //oData.Location = obj.Location;
                //oData.IpAddress = obj.IpAddress;

                //objEnt.RS_RathoreDetails.Add(oData);

                result = objEnt.SaveChanges();
            }

            return result;
        }

        public int DeleteRathoreDetail(int rathoreDetailId)
        {
            int result = 0;

            using (RSEntities obj = new RSEntities())
            {
                var oSelect = obj.RS_RathoreDetails.First(i => i.RathoreDetailId == rathoreDetailId);
                obj.RS_RathoreDetails.Remove(oSelect);

                result = obj.SaveChanges();
            }

            return result;
        }

        public List<RathoreDetailModel> GetAllRathoreDetail()
        {
            List<RathoreDetailModel> result = new List<RathoreDetailModel>();

            using (RSEntities ent = new RSEntities())
            {


                ////result = (from obj in ent.RS_RathoreDetails
                ////          from CCs in ent.RS_Country.Where(CC => CC.CountryId == obj.CurrentCountry).DefaultIfEmpty() // <== makes join left join
                ////          join CC in ent.RS_Country on obj.CurrentCountry equals CC.CountryId into ps
                ////          from CC in ps.DefaultIfEmpty()
                ////          join CS in ent.RS_State on obj.CurrentState equals CS.StateId
                ////          join CD in ent.RS_District on obj.CurrentDistrict equals CD.DistrictId
                ////          join CL in ent.RS_Location on obj.CurrentLocation equals CL.LocationId

                ////          //join NC in ent.RS_Country on obj.CurrentCountry equals CC.CountryId
                ////          //join CS in ent.RS_State on obj.CurrentState equals CS.StateId
                ////          //join CD in ent.RS_District on obj.CurrentDistrict equals CD.DistrictId
                ////          //join CL in ent.RS_Location on obj.CurrentLocation equals CL.LocationId

                result = (from obj in ent.RS_RathoreDetails
                          from CCs in ent.RS_Country.Where(CC => CC.CountryId == obj.CurrentCountry).DefaultIfEmpty() // <== makes join left join
                          from CSs in ent.RS_State.Where(CS => CS.StateId == obj.CurrentState).DefaultIfEmpty() // <== makes join left join
                          from CDs in ent.RS_District.Where(CD => CD.DistrictId == obj.CurrentDistrict).DefaultIfEmpty() // <== makes join left join
                          from CLs in ent.RS_Location.Where(CL => CL.LocationId == obj.CurrentLocation).DefaultIfEmpty() // <== makes join left join

                          from NCs in ent.RS_Country.Where(CC => CC.CountryId == obj.NativeCountry).DefaultIfEmpty() // <== makes join left join
                          from NSs in ent.RS_State.Where(CS => CS.StateId == obj.NativeState).DefaultIfEmpty() // <== makes join left join
                          from NDs in ent.RS_District.Where(CD => CD.DistrictId == obj.NativeDistrict).DefaultIfEmpty() // <== makes join left join
                          from NLs in ent.RS_Location.Where(CL => CL.LocationId == obj.NativeLocation).DefaultIfEmpty() // <== makes join left join

                          select new RathoreDetailModel
                          {
                              RathoreDetailId = obj.RathoreDetailId,
                              Name = obj.Name,
                              FatherName = obj.FatherName,
                              MotherName = obj.MotherName,
                              DateOfBirth = obj.DateOfBirth,
                              PhoneNumber = obj.PhoneNumber,
                              Occupation = obj.Occupation,
                              IsMarried = obj.IsMarried,
                              SpouseName = obj.SpouseName,

                              CurrentCountry = obj.CurrentCountry,
                              CurrentCountryName = CCs.CountryName,

                              CurrentState = obj.CurrentState,
                              CurrentStateName = CSs.StateName,

                              CurrentDistrict = obj.CurrentDistrict,
                              CurrentDistrictName = CDs.DistrictName,

                              CurrentLocation = obj.CurrentLocation,
                              CurrentLocationName = CLs.LocationName,
                             
                              NativeCountry = obj.NativeCountry,
                              NativeState = obj.NativeState,
                              NativeDistrict = obj.NativeDistrict,
                              NativeLocation = obj.NativeLocation,

                              NativeCountryName = NCs.CountryName,
                              NativeStateName = NSs.StateName,
                              NativeDistrictName = NDs.DistrictName,
                              NativeLocationName = NLs.LocationName,


                              CurrentAddress = obj.CurrentAddress,
                              NativeAddress = obj.NativeAddress,
                              EmailId = obj.EmailId,
                              FinalEducation = obj.FinalEducation,
                              NoOfChildern = obj.NoOfChildern,
                              ModifiedBy = obj.ModifiedBy,
                          }).ToList();
            }

            return result;
        }

        public RathoreDetailModel GetRathoreDetailId(int rathoreDetailId)
        {
            RathoreDetailModel result = new RathoreDetailModel();

            using (RSEntities ent = new RSEntities())
            {

                result = (from obj in ent.RS_RathoreDetails
                          from CCs in ent.RS_Country.Where(CC => CC.CountryId == obj.CurrentCountry).DefaultIfEmpty() // <== makes join left join
                          from CSs in ent.RS_State.Where(CS => CS.StateId == obj.CurrentState).DefaultIfEmpty() // <== makes join left join
                          from CDs in ent.RS_District.Where(CD => CD.DistrictId == obj.CurrentDistrict).DefaultIfEmpty() // <== makes join left join
                          from CLs in ent.RS_Location.Where(CL => CL.LocationId == obj.CurrentLocation).DefaultIfEmpty() // <== makes join left join

                          from NCs in ent.RS_Country.Where(CC => CC.CountryId == obj.NativeCountry).DefaultIfEmpty() // <== makes join left join
                          from NSs in ent.RS_State.Where(CS => CS.StateId == obj.NativeState).DefaultIfEmpty() // <== makes join left join
                          from NDs in ent.RS_District.Where(CD => CD.DistrictId == obj.NativeDistrict).DefaultIfEmpty() // <== makes join left join
                          from NLs in ent.RS_Location.Where(CL => CL.LocationId == obj.NativeLocation).DefaultIfEmpty() // <== makes join left join
                          where obj.RathoreDetailId  == rathoreDetailId
                          select new RathoreDetailModel
                          {
                              RathoreDetailId = obj.RathoreDetailId,
                              Name = obj.Name,
                              FatherName = obj.FatherName,
                              MotherName = obj.MotherName,
                              DateOfBirth = obj.DateOfBirth,
                              PhoneNumber = obj.PhoneNumber,
                              Occupation = obj.Occupation,
                              IsMarried = obj.IsMarried,
                              SpouseName = obj.SpouseName,

                              CurrentCountry = obj.CurrentCountry,
                              CurrentCountryName = CCs.CountryName,

                              CurrentState = obj.CurrentState,
                              CurrentStateName = CSs.StateName,

                              CurrentDistrict = obj.CurrentDistrict,
                              CurrentDistrictName = CDs.DistrictName,

                              CurrentLocation = obj.CurrentLocation,
                              CurrentLocationName = CLs.LocationName,

                              NativeCountry = obj.NativeCountry,
                              NativeState = obj.NativeState,
                              NativeDistrict = obj.NativeDistrict,
                              NativeLocation = obj.NativeLocation,

                              NativeCountryName = NCs.CountryName,
                              NativeStateName = NSs.StateName,
                              NativeDistrictName = NDs.DistrictName,
                              NativeLocationName = NLs.LocationName,


                              CurrentAddress = obj.CurrentAddress,
                              NativeAddress = obj.NativeAddress,
                              EmailId = obj.EmailId,
                              FinalEducation = obj.FinalEducation,
                              NoOfChildern = obj.NoOfChildern,
                              ModifiedBy = obj.ModifiedBy,
                          }).First();
            }

            return result;
        }




        #region use to display in Front screen

        public RathoreDetailDisplayModel GetDetailsToDisplay()
        {
            RathoreDetailDisplayModel objRathoreDetails = new RathoreDetailDisplayModel();
            using (RSEntities ent = new RSEntities())
            {
                var rathoreDetails = from obj in ent.RS_RathoreDetails
                              from CSs in ent.RS_State.Where(CS => CS.StateId == obj.CurrentState).DefaultIfEmpty()
                             from CDs in ent.RS_District.Where(CD => CD.DistrictId == obj.CurrentDistrict).DefaultIfEmpty()
                              select new RathoreDetailModel
                              {
                                  RathoreDetailId = obj.RathoreDetailId,
                                  CurrentState = obj.CurrentState,
                                  CurrentStateName = CSs.StateName,
                                  CurrentDistrict = obj.CurrentDistrict,
                                  CurrentDistrictName = CDs.DistrictName,
                              };

                     var results = rathoreDetails.GroupBy(p => new { p.CurrentState, p.CurrentStateName }, p => p,
                    (key, g) => new { CurrentState = key.CurrentState, CurrentStateName = key.CurrentStateName, Count = g.Count() });


                var resultsDist = rathoreDetails.GroupBy(p => new { p.CurrentState, p.CurrentDistrictName }, p => p,
                   (key, g) => new { CurrentState = key.CurrentState, CurrentDistrictName = key.CurrentDistrictName, Count = g.Count() });

                objRathoreDetails.StateBasedDetails = new List<TreeResultbase>();
                foreach (var val in results)
                {
                    TreeResultbase oValue = new TreeResultbase();
                    oValue.Id = val.CurrentState;
                    oValue.Name = val.CurrentStateName;
                    oValue.Value = val.Count;

                    objRathoreDetails.StateBasedDetails.Add(oValue);
                }

                objRathoreDetails.DistrictBasedDetails = new List<TreeResultbase>();
                foreach (var val in resultsDist)
                {
                    TreeResultbase oValue = new TreeResultbase();
                    oValue.Id = val.CurrentState;
                    oValue.Name = val.CurrentDistrictName;
                    oValue.Value = val.Count;
                    objRathoreDetails.DistrictBasedDetails.Add(oValue);
                }


                //objRathoreDetails.DistrictBasedDetails = from obj in objEnt.RS_RathoreDetails
                //                                         group 
            }

            return objRathoreDetails;
        }

            #endregion

            private RathoreDetailModel CheckForCurrentLocationDetail(ref RathoreDetailModel result, RathoreDetailModel obj)
        {

            RS_Country CurrentCountryResult = new RS_Country();
            RS_State CurrentStateResult = new RS_State();
            RS_District CurrentDistrictResult = new RS_District();
            RS_Location CurrentLocationResult = new RS_Location();



            using (RSEntities objEnt = new RSEntities())
            {

                if (obj.CurrentCountryName.Trim() != string.Empty)
                {
                    //// Checking that current inserted country is present or not
                    var CurrentCountry = objEnt.RS_Country.Where(o => o.CountryName.Trim().ToUpper() == obj.CurrentCountryName.Trim().ToUpper());


                    if (CurrentCountry.Count() > 0)
                    {
                        CurrentCountryResult = CurrentCountry.FirstOrDefault();
                    }
                    else
                    {
                        RS_Country oData = new RS_Country();
                        oData.CountryName = obj.CurrentCountryName;
                        oData.CreatedOn = DateTime.Now;
                        oData.CreatedBy = obj.CreatedBy;
                        objEnt.RS_Country.Add(oData);
                        objEnt.SaveChanges();
                        CurrentCountryResult = oData;
                        result.CurrentCountry = CurrentCountryResult.CountryId;
                    }

                }

                result.CurrentCountry = CurrentCountryResult != null && CurrentCountryResult.CountryId != 0 ? CurrentCountryResult.CountryId : (int?)null;
            }
            using (RSEntities objEnt = new RSEntities())
            {
                if (obj.CurrentStateName.Trim() != string.Empty)
                {
                    /// Checking for current state is present or nor
                    var CurrentState = objEnt.RS_State.Where(o => o.StateName.Trim().ToUpper() == obj.CurrentStateName.Trim().ToUpper());

                    if (CurrentState.Count() > 0)
                    {
                        CurrentStateResult = CurrentState.FirstOrDefault();
                    }
                    else
                    {
                        RS_State oData = new RS_State();
                        oData.CountryId = CurrentCountryResult.CountryId;
                        oData.StateName = obj.CurrentStateName;
                        oData.CreatedOn = DateTime.Now;
                        oData.CreatedBy = obj.CreatedBy;
                        objEnt.RS_State.Add(oData);
                        objEnt.SaveChanges();
                        CurrentStateResult = oData;
                    }
                }

                result.CurrentState = CurrentStateResult != null && CurrentStateResult.StateId != 0 ? CurrentStateResult.StateId : (int?)null;

            }

            using (RSEntities objEnt = new RSEntities())
            {
                if (obj.CurrentDistrictName.Trim() != string.Empty)
                {
                    /// Checking for current district present or not
                    var CurrentDistrict = objEnt.RS_District.Where(o => o.DistrictName.Trim().ToUpper() == obj.CurrentDistrictName.Trim().ToUpper());

                    if (CurrentDistrict.Count() > 0)
                    {
                        CurrentDistrictResult = CurrentDistrict.FirstOrDefault();
                    }
                    else
                    {
                        RS_District oData = new RS_District();
                        oData.DistrictName = obj.CurrentDistrictName;
                        oData.StateId = CurrentStateResult.StateId;
                        oData.CreatedOn = DateTime.Now;
                        oData.CreatedBy = obj.CreatedBy;
                        objEnt.RS_District.Add(oData);
                        objEnt.SaveChanges();
                        CurrentDistrictResult = oData;
                    }
                }

                result.CurrentDistrict = CurrentDistrictResult != null && CurrentDistrictResult.DistrictId != 0 ? CurrentDistrictResult.DistrictId : (int?)null;
            }

            using (RSEntities objEnt = new RSEntities())
            {
                if (obj.CurrentLocationName.Trim() != string.Empty)
                {
                    /// Checking for current location present or not
                    var CurrentLocation = objEnt.RS_Location.Where(o => o.LocationName.Trim().ToUpper() == obj.CurrentLocationName.Trim().ToUpper());

                    if (CurrentLocation.Count() > 0)
                    {
                        CurrentLocationResult = CurrentLocation.FirstOrDefault();
                    }
                    else
                    {
                        RS_Location oData = new RS_Location();
                        oData.LocationName = obj.CurrentLocationName;
                        oData.DistrictId = CurrentDistrictResult.DistrictId;
                        oData.CreatedOn = DateTime.Now;
                        oData.CreatedBy = obj.CreatedBy;
                        objEnt.RS_Location.Add(oData);
                        objEnt.SaveChanges();
                        CurrentLocationResult = oData;
                    }
                }

                result.CurrentLocation = CurrentLocationResult != null && CurrentLocationResult.LocationId != 0 ? CurrentLocationResult.LocationId : (int?)null;

            }

            return result;

        }


        private RathoreDetailModel CheckForNativeLocationDetail(ref RathoreDetailModel result, RathoreDetailModel obj)
        {

            RS_Country NativeCountryResult = new RS_Country();
            RS_State NativeStateResult = new RS_State();
            RS_District NativeDistrictResult = new RS_District();
            RS_Location NativeLocationResult = new RS_Location();



            using (RSEntities objEnt = new RSEntities())
            {

                if (obj.NativeCountryName.Trim() != string.Empty)
                {
                    //// Checking that current inserted country is present or not
                    var CurrentCountry = objEnt.RS_Country.Where(o => o.CountryName.Trim().ToUpper() == obj.NativeCountryName.Trim().ToUpper());


                    if (CurrentCountry.Count() > 0)
                    {
                        NativeCountryResult = CurrentCountry.FirstOrDefault();
                    }
                    else
                    {
                        RS_Country oData = new RS_Country();
                        oData.CountryName = obj.NativeCountryName;
                        oData.CreatedOn = DateTime.Now;
                        oData.CreatedBy = obj.CreatedBy;
                        objEnt.RS_Country.Add(oData);
                        objEnt.SaveChanges();
                        NativeCountryResult = oData;
                        result.CurrentCountry = NativeCountryResult.CountryId;
                    }
                }

                result.NativeCountry = NativeCountryResult != null && NativeCountryResult.CountryId != 0 ? NativeCountryResult.CountryId : (int?)null;
            }

            using (RSEntities objEnt = new RSEntities())
            {
                if (obj.NativeStateName.Trim() != string.Empty)
                {
                    /// Checking for current state is present or nor
                    var CurrentState = objEnt.RS_State.Where(o => o.StateName.Trim().ToUpper() == obj.NativeStateName.Trim().ToUpper());

                    if (CurrentState.Count() > 0)
                    {
                        NativeStateResult = CurrentState.FirstOrDefault();
                    }
                    else
                    {
                        RS_State oData = new RS_State();
                        oData.CountryId = NativeCountryResult.CountryId;
                        oData.StateName = obj.NativeStateName;
                        oData.CreatedOn = DateTime.Now;
                        oData.CreatedBy = obj.CreatedBy;
                        objEnt.RS_State.Add(oData);
                        objEnt.SaveChanges();
                        NativeStateResult = oData;
                    }
                }

                result.NativeState = NativeStateResult != null && NativeStateResult.StateId != 0 ? NativeStateResult.StateId : (int?)null;

            }

            using (RSEntities objEnt = new RSEntities())
            {
                if (obj.NativeDistrictName.Trim() != string.Empty)
                {
                    /// Checking for current district present or not
                    var CurrentDistrict = objEnt.RS_District.Where(o => o.DistrictName.Trim().ToUpper() == obj.NativeDistrictName.Trim().ToUpper());

                    if (CurrentDistrict.Count() > 0)
                    {
                        NativeDistrictResult = CurrentDistrict.FirstOrDefault();
                    }
                    else
                    {
                        RS_District oData = new RS_District();
                        oData.DistrictName = obj.NativeDistrictName;
                        oData.StateId = NativeStateResult.StateId;
                        oData.CreatedOn = DateTime.Now;
                        oData.CreatedBy = obj.CreatedBy;
                        objEnt.RS_District.Add(oData);
                        objEnt.SaveChanges();
                        NativeDistrictResult = oData;
                    }
                }

                result.NativeDistrict = NativeDistrictResult != null && NativeDistrictResult.DistrictId != 0 ? NativeDistrictResult.DistrictId : (int?)null;
            }

            using (RSEntities objEnt = new RSEntities())
            {
                if (obj.NativeLocationName.Trim() != string.Empty)
                {
                    /// Checking for current location present or not
                    var CurrentLocation = objEnt.RS_Location.Where(o => o.LocationName.Trim().ToUpper() == obj.NativeLocationName.Trim().ToUpper());

                    if (CurrentLocation.Count() > 0)
                    {
                        NativeLocationResult = CurrentLocation.FirstOrDefault();
                    }
                    else
                    {
                        RS_Location oData = new RS_Location();
                        oData.LocationName = obj.NativeLocationName;
                        oData.DistrictId = NativeDistrictResult.DistrictId;
                        oData.CreatedOn = DateTime.Now;
                        oData.CreatedBy = obj.CreatedBy;
                        objEnt.RS_Location.Add(oData);
                        objEnt.SaveChanges();
                        NativeLocationResult = oData;
                    }
                }

                result.NativeLocation = NativeLocationResult != null && NativeLocationResult.LocationId != 0 ? NativeLocationResult.LocationId : (int?)null;

            }

            return result;

        }

    }
}
