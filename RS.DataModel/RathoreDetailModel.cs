using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.DataModel
{
    public class RathoreDetailModel
    {

        public int RathoreDetailId { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public int FatherNameId { get; set; }

        public int MotherNameId { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }

        public string Occupation { get; set; }

        public bool? IsMarried { get; set; }
        public string SpouseName { get; set; }

        public int SpouseNameId { get; set; }

        public int? CurrentCountry { get; set; }
        public int? CurrentState { get; set; }
        public int? CurrentDistrict { get; set; }
        public int? CurrentLocation { get; set; }

        public string CurrentAddress { get; set; }

        public int? NativeCountry { get; set; }
        public int? NativeState { get; set; }
        public int? NativeDistrict { get; set; }
        public int? NativeLocation { get; set; }

        public string NativeAddress { get; set; }
        public string EmailId { get; set; }
        public string FinalEducation { get; set; }
        public int? NoOfChildern { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool? IsActive { get; set; }


    }

    public class AdminLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public int LoginCount { get; set; }
        public int Role { get; set; }


    }
}
