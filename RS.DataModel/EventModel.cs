using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.DataModel
{
    public class EventModel
    {
        public int EventId { get; set; }

        public int EventType { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public DateTime? EventDateFrom { get; set; }

        public string EventTimeFrom { get; set; }

        public DateTime? EventDateTo { get; set; }

        public string EventTimeTo { get; set; }

        public int? Location { get; set; }

        public string LocationName { get; set; }


        public int? District { get; set; }

        public string DistrictName { get; set; }


        public DateTime? CreatedOn { get; set; }

        public int? CreatedBy { get; set; }

        public string CreaterName { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsActive { get; set; }
    }
}
