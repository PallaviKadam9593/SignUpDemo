using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpDemo.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please enter your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Please set your Password")]
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match")]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage ="Please enter Confirm Password") ]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Please enter contact no")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please select country name")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please select your city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please select Gender")]
        public string Gender { get; set; }

        [RegularExpression(@"^true", ErrorMessage = "Please accept terms and conditions")]
        public string Terms { get; set; }
    }
}
