using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AudioCommune2.ViewModels;
using AudioCommune2.Models;
using Microsoft.EntityFrameworkCore;
using AudioCommune2.Data;
using System.Data.SqlClient;
using System.Data;

namespace AudioCommune2.Controllers
{
    public class Signin : Controller
    {
        private AudioCommuneDbContext context;

        public Signin(AudioCommuneDbContext dbcontext)
        {
            context = dbcontext;
        }

        //login page
        public IActionResult Index()
        {
            LoginIserViewModel vm = new LoginIserViewModel();
            return View(vm);
        }

        //login confirm page
        [HttpPost]
        public IActionResult Index(LoginIserViewModel vm)
        {
            //confirm if username in system and password match, if not, return back to form.
            //if so, redirect to... server list? for now, just server page i guess.
            //return View();

            if (ModelState.IsValid)
            {
                try
                {
                    var user = context.Users
                        .Single(user => user.Username == vm.Username & user.Password == vm.Password);
                    return Redirect("/");
                }
                catch (InvalidOperationException)
                {
                    return View(vm);
                }
            }
            return View(vm);
        }

        //sign up page
        public IActionResult Signup()
        {
            AddUserViewModel vm = new AddUserViewModel();
            return View(vm);
        }


        //create a new account check n create
        [HttpPost]
        public IActionResult Signup(AddUserViewModel vm)
        {
            if(ModelState.IsValid)
            {
                if (vm.Password == vm.ConfirmPassword)
                {
                    User newUser = new User
                    {
                        Username = vm.Username,
                        Password = vm.Password

                    };
                    context.Users.Add(newUser);
                    context.SaveChanges();

                    return Redirect("/");
                }
                return View(vm);

            }
            return View(vm);
        }

    }
}
