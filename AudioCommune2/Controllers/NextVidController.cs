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
            //var videos = context.Videos.ToList();
            return View();
        }

        //this is to retrieve the list of videos on the server
        public List<video> Vids()
        {
            var videos = context.Videos.ToList();
            return videos;
        }

        //idk why i put it in here, but this is where we retrieve the list of messages from server
        public List<Message> GetAllMessages()
        {
            var allMessages = context.Messages.ToList();
            return allMessages;
        }
    }

}
