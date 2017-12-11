using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace RS.DataModel
{
    public class EventModel
    {
        public int EventId { get; set; }

        
        public int EventType { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "काम से काम 3 - 15 शब्दों में जानकारी भरे !!")]
        public string EventTypeName { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "काम से काम 4 - 100 शब्दों में जानकारी भरे !!")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "काम से काम 4 - 300 शब्दों में जानकारी भरे !!")]
        [AllowHtml]
        public string Body { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "काम से काम 10 शब्दों में जानकारी भरे !!")]
        public DateTime? EventDateFrom { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        public string EventTimeFrom { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "काम से काम 10 शब्दों में जानकारी भरे !!")]
        public DateTime? EventDateTo { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        public string EventTimeTo { get; set; }

        public int? Location { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "काम से काम 3 -20 शब्दों में जानकारी भरे !!")]
        public string LocationName { get; set; }


        public int? District { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "काम से काम 3 -20 शब्दों में जानकारी भरे !!")]
        public string DistrictName { get; set; }


        public DateTime? CreatedOn { get; set; }

        public int? CreatedBy { get; set; }

        public string CreatedByName { get; set; }

        public string CreaterName { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsActive { get; set; }
    }
}
