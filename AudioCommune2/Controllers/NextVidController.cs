using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AudioCommune2.Data;
using AudioCommune2.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AudioCommune2.Controllers
{
    public class NextVidController : Controller
    {

        private AudioCommuneDbContext context;

        public NextVidController(AudioCommuneDbContext dbcontext)
        {
            context = dbcontext;
        }
        // GET: /<controller>/
        public  IActionResult Index()
        {
            var videos = context.Videos.ToList();

            //where server = current server
           
            //OK. so we need to do a few things here.
            //1 - we need to get the length of videos (but will need to be playlists at some point).
            //2 - we need to iterate that saved number.
            //3 - we need to make sure number is not greater then len list, if so back to 1.
            //4 - we need to get the video whos id matches a saved number.
            //5 - return URL.

            return View();
        }

        public List<video> Vids()
        {
            var videos = context.Videos.ToList();
            return videos;
        }
    }
}
