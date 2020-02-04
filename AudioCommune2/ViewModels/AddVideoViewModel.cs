using System;
using System.ComponentModel.DataAnnotations;
using AudioCommune2.Models;

namespace AudioCommune2.ViewModels
{
    public class AddVideoViewModel
    {
        [Required(ErrorMessage = "You must provide a URL")]
        public string Url { get; set; }

        public string Title { get; set; }

        public string EyeD { get; set; }

        public AddVideoViewModel()
        {
        }
    }
}
