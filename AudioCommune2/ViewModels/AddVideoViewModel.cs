using System;
using System.ComponentModel.DataAnnotations;
using AudioCommune2.Models;

namespace AudioCommune2.ViewModels
{
    public class AddVideoViewModel
    {
        [Required(ErrorMessage = "You must provide a URL")]
        public string Url { get; set; }
        //public int Id { get; set; }

        //public video NewUser()
        //{
        //    return new video
        //    {
        //        Id = 1,
        //        Url=this.Url
                
        //    };
        //}


        public AddVideoViewModel()
        {
        }
    }
}
