using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace simpleLoginViewModel.Models{

    public class IndexViewModel
    {
        public User newUser {get;set;}
        public Login newLogin {get;set;}
    }
}