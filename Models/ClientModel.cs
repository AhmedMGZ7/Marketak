using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Marketak.Models
{
    public class ClientModel
    {
        [Display(Name = " UserName ")]
        [Required(ErrorMessage = " Enter Your UserName ")]
        public string UserName { get; set; }
        [Display(Name = " Password ")]
        [ DataType(DataType.Password)]
        [Required(ErrorMessage = " Enter Your Password ")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Enter A strong password ")]
        public string Password { get; set; }
        [Display(Name = " E-mail ")]
        [Required(ErrorMessage = " Enter Your E-mail ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = " Address ")]
        [Required(ErrorMessage = " Enter Your Address ")]
        public string Address { get; set; }
        [Display(Name = " BithDate ")]
        [Required(ErrorMessage = " Enter Your Birthdate ")]
        [DataType(DataType.Date)]
        public string Birthdate { get; set; }


    }
}