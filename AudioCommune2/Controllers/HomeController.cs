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


        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
         //}
        //testtest commitoverride



        public IActionResult Index()
        {
            AddVideoViewModel vm = new AddVideoViewModel();
            IList<Message> allMessages = context.Messages.ToList();
            ViewBag.allMessages = allMessages;
            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(AddVideoViewModel vm)
        {
            if (ModelState.IsValid)
            {
                if (vm.Url.Contains("="))
                {

                    string videoIDextract = vm.Url.Split('=').Last();
                    video newvideo = new video
                    {

                        Url = videoIDextract

                    };
                    context.Videos.Add(newvideo);
                    context.SaveChanges();

                    return Redirect("/");
                }
                else
                {

                    string source = vm.Url;
                    string split = "https://youtu.be/";


                    string videoIDextract = source.Substring(source.IndexOf(split) + split.Length);

                    video newvideo = new video
                    {

                        Url = videoIDextract

                    };
                    context.Videos.Add(newvideo);
                    context.SaveChanges();

                    return Redirect("/");

                }
            }
            return View(vm);
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
