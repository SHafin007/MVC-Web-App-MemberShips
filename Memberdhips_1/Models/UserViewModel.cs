using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Memberdhips_1.Models
{
    public class UserViewModel
    {
        [Display(Name ="User Id")]
        public string Id { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        [Display(Name = "First Name")]        
        [StringLength(30,ErrorMessage ="The {0} must be at least {1} Characters long",MinimumLength =2)]
        public string FirstName { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required]
        [StringLength(100)]
        public string Password { get; set; }


    }
}