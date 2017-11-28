using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.DataModel
{
    public class NewsModel
    {

        public int NewsId { get; set; }

        public int Newstype { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public string Photo { get; set; }

        public int Location { get; set; }

        public int District { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CreatedBy { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public bool IsActive { get; set; }
    }
}
