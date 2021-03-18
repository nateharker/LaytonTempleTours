﻿using LaytonTempleTours.Models;
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
        private TourDbContext _context { get; set; }

        private readonly ILogger<HomeController> _logger;
        //Constructor
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
            return View(new TourViewModel
            {
                GroupInfos = _context.GroupInfos,
                AvailableTimes = _context.AvailableTimes
            }); //Dsiplay all of the appointments made in the list
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(GroupInfo group)
        {
            if (ModelState.IsValid)
            {
                _context.GroupInfos.Add(group);
                _context.SaveChanges();
            }
            return View("Index");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View(new TourViewModel
            {
                GroupInfos = _context.GroupInfos,
                AvailableTimes = _context.AvailableTimes
                .Where(x => x.SlotBooked == false)
                //Filter times shown here by the boolean of if the slot has been booked or not
            });
        }

        [HttpPost]
        public IActionResult SignUp(DateTime time)
        {
            ViewBag.SelectedTime = time;
            foreach (var x in _context.AvailableTimes)
            {
                if (x.AppointementTime == time)
                {
                    x.SlotBooked = true;
                }
            }
            _context.SaveChanges();
            return View("Form");
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
