using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace simpleLoginViewModel.Models{
    public class Login {
        [Required(ErrorMessage = "Please your Email")]
        [EmailAddress(ErrorMessage = "Enter a valid email address ex: name@address.com")]
        public string loginEmail{ get; set; }

        [Required(ErrorMessage = "Enter a password")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public string loginPassword { get; set; }
    }

}