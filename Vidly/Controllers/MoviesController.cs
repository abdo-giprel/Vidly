using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebSockets;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    [System.Runtime.InteropServices.Guid("C92DF1DB-CEE8-4D2B-BCDB-C99D6DD91E31")]
    public class MoviesController : Controller
    {
        List<Movies> movie = new List<Movies>()
        {
            new Movies { Id=0,Name = "hello world"},
            new Movies { Id=1,Name = "next day"}
        };
        // GET: Movies/Random
        [Route("Movies")]
        public ActionResult Random()
        { 
            return View(movie);
        }

        [Route("Movies/datails/{id?}")]
        public ActionResult Details(int id)
        {
            if (id >=movie.ToList().Count )
            {
                return HttpNotFound();
            }

            var movieID = movie[id];
            return View(movieID);
        }
        
    }
}