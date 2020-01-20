using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dog.Models;

namespace DogObject.Controllers
{
    public class FormsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection data)
        {
            Dog1 d = new Dog1();
            d.Name = data["name"];
            d.DateOfBirth = Convert.ToDateTime(data["dob"]);
            d.Breed = data["breed"];

            ViewData["Message"] = "Dog added successfully";

            return View();
        }
    }
}