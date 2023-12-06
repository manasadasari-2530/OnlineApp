using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{
    public class DataModel
    {
        [Display(Name = "username")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "username should not be empty")]
        public string username { get; set; }
        [Display(Name = "password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "password should not be empty")]

        [DataType(DataType.Password)]
        public string password { get; set; }


    }
}
