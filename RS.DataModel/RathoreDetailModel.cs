using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RS.DataModel
{
    public class RathoreDetailModel
    {

        public int RathoreDetailId { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "काम से काम 4 - 100 शब्दों में जानकारी भरे !!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "काम से काम 4 -100 शब्दों में जानकारी भरे !!")]
        public string FatherName { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "काम से काम 4 -100 शब्दों में जानकारी भरे !!")]
        public string MotherName { get; set; }

        public int FatherNameId { get; set; }

        public int MotherNameId { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        public string Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        public string DateOfBirthFormated { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "काम से काम 10 शब्दों में जानकारी भरे !!")]
        public string PhoneNumber { get; set; }

        [StringLength(30, MinimumLength = 0, ErrorMessage = "काम से काम 0 - 30 शब्दों में जानकारी भरे !!")]
        public string Occupation { get; set; }

        public bool IsMarried { get; set; }

        [StringLength(100, MinimumLength = 0, ErrorMessage = "काम से काम 0 - 100 शब्दों में जानकारी भरे !!")]
        public string SpouseName { get; set; }

        public int SpouseNameId { get; set; }

        public int? CurrentCountry { get; set; }
        public int? CurrentState { get; set; }
        public int? CurrentDistrict { get; set; }
        public int? CurrentLocation { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "काम से काम 2 -50 शब्दों में जानकारी भरे !!")]
        public string CurrentCountryName { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "काम से काम 2 -50 शब्दों में जानकारी भरे !!")]
        public string CurrentStateName { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "काम से काम 2 -50 शब्दों में जानकारी भरे !!")]
        public string CurrentDistrictName { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "काम से काम 2 -50 शब्दों में जानकारी भरे !!")]
        public string CurrentLocationName { get; set; }

        [StringLength(500, MinimumLength = 0, ErrorMessage = "काम से काम 0 -200 शब्दों में जानकारी भरे !!")]
        public string CurrentAddress { get; set; }


        public int? NativeCountry { get; set; }

        public int? NativeState { get; set; }
        public int? NativeDistrict { get; set; }
        public int? NativeLocation { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "काम से काम 2 -50 शब्दों में जानकारी भरे !!")]
        public string NativeCountryName { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "काम से काम 2 -50 शब्दों में जानकारी भरे !!")]
        public string NativeStateName { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "काम से काम 2 -50 शब्दों में जानकारी भरे !!")]
        public string NativeDistrictName { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "काम से काम 2 -50 शब्दों में जानकारी भरे !!")]
        public string NativeLocationName { get; set; }

        [StringLength(500, MinimumLength = 0, ErrorMessage = "काम से काम 0 -200 शब्दों में जानकारी भरे !!")]
        public string NativeAddress { get; set; }

        [EmailAddress(ErrorMessage = "सही ईमेल दे !!")]
        public string EmailId { get; set; }
        public string FinalEducation { get; set; }
        public int? NoOfChildern { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public int Age { get; set; }

        public IEnumerable<DropdownList> GenderDropDown { get; set; }

}


public class RathoreDetailDisplayModel
{
    public List<TreeResultbase> StateBasedDetails { get; set; }

    public List<TreeResultbase> DistrictBasedDetails { get; set; }

    public List<RathoreDetailModel> RathoreDetails { get; set; }

}

public class AdminLogin
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public DateTime LastLogin { get; set; }
    public int LoginCount { get; set; }
    public int Role { get; set; }


}


public class TreeResultbase
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public int Value { get; set; }


}


public class DropdownList
{
    public string Key { get; set; }
    public string Value { get; set; }

}
}
