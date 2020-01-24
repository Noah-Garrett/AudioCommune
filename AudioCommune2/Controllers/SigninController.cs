using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AudioCommune2.ViewModels;
using AudioCommune2.Models;

namespace AudioCommune2.Controllers
{
    public class Signin : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Index()
        //{
            //confirm if username in system and password match, if not, return back to form.
            //if so, redirect to... server list? for now, just server page i guess.
            //return View();
        //}

        public IActionResult Signup()
        {
            AddUserViewModel vm = new AddUserViewModel();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Signup(AddUserViewModel vm)
        {
            if(ModelState.IsValid)
            {
                User newUser = new User
                {
                    Username = vm.Username,
                    Password = vm.Password

                };
                context.Users.Add(newUser);
                context.SaveChanges();

                return Redirect("/Index/");
            }
            return View(vm);
        }
        public Signin()
        {
        }
    }
}
