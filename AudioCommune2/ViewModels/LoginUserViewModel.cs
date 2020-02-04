using System;
using System.ComponentModel.DataAnnotations;
using AudioCommune2.Models;
namespace AudioCommune2.ViewModels
{
    public class LoginIserViewModel
    {
        [Required(ErrorMessage = "You must provide a Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "you need a password")]
        public string Password { get; set; }
    
        public User NewUser()
        {
            return new User
            {
                Username = this.Username,
                Password = this.Password,
            };
        }
        public LoginIserViewModel()
        {
        }
    }
}
 