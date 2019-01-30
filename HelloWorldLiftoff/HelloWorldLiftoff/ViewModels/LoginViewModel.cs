using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldLiftoff.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace HelloWorldLiftoff.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Password needs to be minimum 3 characters long.")]
        public string Password { get; set; }

        public LoginViewModel()
        {
            //default constructor, right?
        }
        
    }
}
