using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lost_in_the_woods.Models;
using Microsoft.EntityFrameworkCore;

namespace lost_in_the_woods.Controllers
{
    public class HomeController : Controller
    {
        private lost_in_the_woodsContext _context;
        public HomeController(lost_in_the_woodsContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            List<Place> AllUsers = _context.Trail.ToList();
            ViewBag.trails = AllUsers;
            return View();
        }
        [HttpGet]
        [Route("/newtrail/")]
        public IActionResult NewTrail()
        {
            ViewBag.iserrors = false;

            return View();
        }
        [HttpPost]
        [Route("/addnewtrail/")]
        public IActionResult AddNewTrail(TrailViewModel trail)
        {
            TryValidateModel(trail);
            if(ModelState.IsValid)
            {
                Place newtrail = new Place();
                newtrail.name = trail.name;
                newtrail.description = trail.description;
                newtrail.length = trail.length;
                newtrail.longi = trail.longi;
                newtrail.lati = trail.lati;
                newtrail.elevationchange = trail.elevationchange;
                _context.Add(newtrail);
                _context.SaveChanges();
                
                return RedirectToAction("Index");
            }
            ViewBag.iserrors = true;
            ViewBag.errors = ModelState.Values;


            return View("NewTrail");
        }

        [HttpGet]
        [Route("/trail/{id}")]
        public IActionResult Details(int id)
        {
            Place trailer = _context.Trail.Where(trail => trail.idTrail == id).SingleOrDefault();
            ViewBag.trail = trailer;
            return View();
        }
    }
}
