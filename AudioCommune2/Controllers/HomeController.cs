using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AudioCommune2.Models;
using AudioCommune2.ViewModels;
using AudioCommune2.Data;

namespace AudioCommune2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AudioCommuneDbContext context;


        public HomeController(ILogger<HomeController> logger, AudioCommuneDbContext dbcontext)
        {
            _logger = logger;
            context = dbcontext;
        }

        //main server page
        public IActionResult Index()
        {
            AddVideoViewModel vm = new AddVideoViewModel();
            IList<Message> allMessages = context.Messages.ToList();
            ViewBag.allMessages = allMessages;


            IList<video> allVideos = context.Videos.ToList();
            ViewBag.allVideos = allVideos;
            return View(vm);
        }

        //submit a video on server page
        [HttpPost]
        public IActionResult Index(AddVideoViewModel vm)
        {
            if (ModelState.IsValid)
            {
                    video newvideo = new video
                    {

                        Url = vm.EyeD,
                        Title = vm.Title

                    };
                    context.Videos.Add(newvideo);
                    context.SaveChanges();
                    return Redirect("/");

            }
            IList<Message> allMessages = context.Messages.ToList();
            ViewBag.allMessages = allMessages;
            return Redirect("/");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
