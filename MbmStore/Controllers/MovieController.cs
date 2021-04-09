using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {

            // create a new Movie object with instance name jungleBook
            var jungleBook = new Movie(10004, "Jungle Book", 160.50m, "junglebook.jpg", "John Favreau");
            var gladiator = new Movie(10003, "Gladiator", 130.50m, "gladiator.jpg", "Ridley Scott");
            var forrestGump = new Movie(1, "Forrest Gump", 170.25m, "forrest-gump.jpg", "Robert Zemeckis");

            // assign a ViewBag property to the new Movie object
            ViewBag.JungleBook = jungleBook;
            ViewBag.Gladiator = gladiator;
            ViewBag.ForrestGump = forrestGump;

            // return the default view
            return View();
        }
    }
}