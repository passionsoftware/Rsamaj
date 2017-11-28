using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.DataModel
{
   public class AlbumModel
    {
        public int AlbumId { get; set; }

        [Required(ErrorMessage ="Album Name is Required")]
        public string AlbumName { get; set; }

        public string BriefDesc { get; set; }

        public string Location { get; set; }

        public string District { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CreatedBy { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public bool IsActive { get; set; }

    }
}
