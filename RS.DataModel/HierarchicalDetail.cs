using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.DataModel
{
    public class HRathoreDetails
    {
        public int RathoreDetailId { get; set; }
        public string Name { get; set; }
        public string SpouseName { get; set; }
        public string Age { get; set; }
        public string District { get; set; }
        public string Location { get; set; }
        public int ParentId { get; set; }
        public bool IsActive { get; set; }
       
    }
}
