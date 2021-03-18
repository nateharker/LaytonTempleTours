using LaytonTempleTours.Models;
using LaytonTempleTours.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTempleTours.Controllers
{
    public class HomeController : Controller
    {
        private TourDbContext _context { get; set; }        //Sets up variable to be used in the home controller class

        private readonly ILogger<HomeController> _logger;
        //Constructor for the controller
        public HomeController(ILogger<HomeController> logger, TourDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewAppointments()
        {
            return View(new TourViewModel           //Display all of the appointments made in a list
            {
                GroupInfos = _context.GroupInfos,
                AvailableTimes = _context.AvailableTimes
            }); 
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(GroupInfo group)          
        {
            if (ModelState.IsValid)//On the post from the form, it checks if the model is valid
            {
                foreach (var x in _context.AvailableTimes)
                {
                    if (x.AppointementTime == group.TimeSlot)//Changes the boolean property in the AvailableTimes to the appointment being booked if it is part of a group object
                    {
                        x.SlotBooked = true;
                    }
                }
                _context.GroupInfos.Add(group);//Adds new group to the list
                _context.SaveChanges();//Saves changes to the DB
                return View("Index");//Redirect to the home page if successful
            }
            else {
                ViewBag.SelectedTime = group.TimeSlot;
                return View(); //If model state is invalid, return form view again, with data validation summary
            }
            
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View(new TourViewModel
            {
                GroupInfos = _context.GroupInfos,
                AvailableTimes = _context.AvailableTimes
                .Where(x => x.SlotBooked == false)//Filter times shown here by the boolean of if the slot has been booked or not
            });
        }

        [HttpPost]
        public IActionResult SignUp(DateTime time)
        {
            ViewBag.SelectedTime = time;//Pass the time selected into a ViewBag that will be displayed on the Form.cshtml
            return View("Form");//Take the user to the form, where time is already filled out, and they just enter extra info about their group
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
