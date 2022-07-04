using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_KatDemo.Models;

namespace MVC_KatDemo.Controllers
{
    public class MoviesController : Controller
    {
        //url: Movies/Random
        public IActionResult Random()
        {
            //normally we'd retrieve this information from a database
            var movie = new Movie() { nName = "Shrek!" };

            return View(movie);
        }
    }
}
