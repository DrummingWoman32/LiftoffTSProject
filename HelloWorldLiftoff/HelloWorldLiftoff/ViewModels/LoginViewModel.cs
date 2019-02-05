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
        //[Required(ErrorMessage = "You must type in a username")]
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }


        //[Required(ErrorMessage = "Wrong password.")]
        [Required(ErrorMessage = "Sorry, that's not the right password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /*public LoginViewModel()
        {
            //default constructor, right?
        }*/
        
    }
}
