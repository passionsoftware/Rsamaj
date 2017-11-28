using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.DataModel
{
    public class ContactModel
    {

        public int ContactusId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailId { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Location { get; set; }

        public string IpAddress { get; set; }
    }
}
