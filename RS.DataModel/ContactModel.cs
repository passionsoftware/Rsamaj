using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.DataModel
{
    public class ContactModel
    {

        public int ContactusId { get; set; }


        [Required(ErrorMessage ="Name is required!!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Invalid Name!!")]
        public string Name { get; set; }

        [StringLength(10, MinimumLength = 10,ErrorMessage = "Invalid Phone number!!")]
        [Required(ErrorMessage = "Phone Number is required!!")]
        public string PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address!!")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Subject is required!!")]
        public string Subject { get; set; }

        public string Body { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Location { get; set; }

        public string IpAddress { get; set; }
    }
}
