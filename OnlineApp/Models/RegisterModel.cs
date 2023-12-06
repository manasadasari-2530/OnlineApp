using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{
    public class RegisterModel
    {
        [Display(Name = "Firstname")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "FirstName should not be empty")]

        public string FirstName { get; set; }
        [Display(Name = "Lastname")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "LastName should not be empty")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email should not be empty")]
        public string Email { get; set; }
        [Display(Name = "phone")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone should not be empty")]
        public string Phone { get; set; }
        [Display(Name = "City")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "City should not be empty")]
        public string City { get; set; }
        [Display(Name = "Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Address should not be empty")]
        public string Address { get; set; }
        [Display(Name = "State")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "State should not be empty")]
        public string State { get; set; }
        [Display(Name = "PinCode")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "PinCode should not be empty")]
        public string PinCode { get; set; }
    }
}
