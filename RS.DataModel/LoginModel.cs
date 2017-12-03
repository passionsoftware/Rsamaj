using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RS.DataModel
{
    public class LoginModel
    {
        public int RathoreDetailId { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "जानकारी अनिवार्य है !!")]
        public string Password { get; set; }

        public DateTime? LastLogin { get; set; }
        public int? LoginCount { get; set; }
        public int? Role { get; set; }
    }
}
