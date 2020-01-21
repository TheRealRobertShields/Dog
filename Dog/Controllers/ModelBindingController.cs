using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dog.Models;
using Microsoft.AspNetCore.Mvc;

namespace DogObject.Controllers
{
    public class ModelBindingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Dog1 d)
        {
            if (ModelState.IsValid) //Ensures model is in valid state
            {
                //DogDB.Add(d);
                return RedirectToAction("Index", "Home");
            }
            else // Validation problems occurred
            {
                return View();
            }
            
        }
    }
}