using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using MbmStore.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Books = Repository.Products.OfType<Book>().ToList();
            ViewBag.Cds = Repository.Products.OfType<MusicCD>().ToList();
            ViewBag.Movies = Repository.Products.OfType<Movie>().ToList();

            return View();
        }
    }
}
