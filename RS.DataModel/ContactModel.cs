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


        [Required(ErrorMessage = "नाम अनिवार्य है !!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "काम से काम ५ शब्दों में जानकारी दे!!")]
        public string Name { get; set; }

        [StringLength(10, MinimumLength = 10,ErrorMessage = "काम से काम १० शब्दों में फ़ोन नंबर भरे !!")]
        [Required(ErrorMessage = "फ़ोन नंबर अनिवार्य है !!")]
        public string PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "सही ईमेल दे !!")]
        public string EmailId { get; set; }

        [StringLength(100, MinimumLength = 5, ErrorMessage = "काम से काम ५  शब्दों में जानकारी दे !!")]
        [Required(ErrorMessage = "विषय अनिवार्य है !!")]
        public string Subject { get; set; }


        [StringLength(300, MinimumLength = 20, ErrorMessage = "काम से काम २० शब्दों में जानकारी दे !!")]
        [Required(ErrorMessage = "जानकारी अनिवार्य है!!")]
        public string Body { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string Location { get; set; }

        public string IpAddress { get; set; }
    }
}
