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
                result = (from obj in ent.RS_RathoreDetails
                          select new RathoreDetailModel
                          {
                              Name = obj.Name,
                              FatherName = obj.FatherName,
                              MotherName = obj.MotherName,
                              DateOfBirth = obj.DateOfBirth,
                              PhoneNumber = obj.PhoneNumber,
                              Occupation = obj.Occupation,
                              IsMarried = obj.IsMarried,
                              SpouseName = obj.SpouseName,
                              CurrentCountry = obj.CurrentCountry,
                              CurrentState = obj.CurrentState,
                              CurrentDistrict = obj.CurrentDistrict,
                              CurrentLocation = obj.CurrentLocation,
                              CurrentAddress = obj.CurrentAddress,
                                NativeCountry = obj.NativeCountry,
                              NativeState = obj.NativeState,
                              NativeDistrict = obj.NativeDistrict,
                              NativeLocation = obj.NativeLocation,
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


            return result;
        }
    }
}
