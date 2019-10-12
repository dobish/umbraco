using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AarhusWebDevCoop.ViewModels
{
    public class ContactForm
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        [Display(Name = "Email")]
        [RegularExpression(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$",
            ErrorMessage ="Please enter correct email address")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter a subject")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Please enter a message")]
        public string Message { get; set; }
    }
}