using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.DataModel
{
    public class GallaryModel
    {

        public int PhotoId { get; set; }

        public int AlbumId { get; set; }

        public string PhotoLink { get; set; }

        public DateTime PostedOn { get; set; }

        public string Location { get; set; }

        public string PhotoDescription { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CreatedBy { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public bool IsActive { get; set; }

        public bool IsCoverPhoto { get; set; }

        public int Likes { get; set; }


    }
}
