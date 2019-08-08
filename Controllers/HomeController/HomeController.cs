using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using simpleLoginViewModel.Models;

namespace simpleLoginViewModel
{
    public class HomeController: Controller
    {
        [HttpGet("")] //This renders the Main Page        
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost("register")]
        public IActionResult Create(IndexViewModel modelData)
        {
            Console.Write("Is This Getting Here?");
            User submittedInfo = modelData.newUser;
            if(ModelState.IsValid)
            {
                Console.Write("###########It's Valid?#########");
                // do somethng!  maybe insert into db?  then we will redirect
                return RedirectToAction("Success");
            }
            else
            {
                Console.Write("##########It's Not Valid?#########");
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult LoginUser(IndexViewModel modelData)
        {
            Console.Write("Is This Getting Here?");
            Login submittedInfo = modelData.newLogin;
            if(ModelState.IsValid)
            {
                Console.Write("###########It's Valid?#########");
                // do somethng!  maybe insert into db?  then we will redirect
                return RedirectToAction("Success");
            }
            else
            {
                Console.Write("##########It's Not Valid?#########");
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index");
            }
        }

        [HttpGet("success")] //This renders the Results Page        
        public ViewResult Success()
        {
            return View("Results");
        }
    }
}