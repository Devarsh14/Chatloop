using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chatloop.Models;

namespace Chatloop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReminderManagment()
        {
            //IList<Reminder> reminders = new List<Reminder>();
            Reminder reminder = new Reminder();
            
            return View(reminder);
        }

        [HttpPost]
        public IActionResult ReminderManagment(Reminder reminder)
        {
            IList<Reminder> reminders = new List<Reminder>();
            reminders.Add(reminder);
            
            return View(reminder);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ErrorViewModel errorViewModel = new ErrorViewModel();
            return View(errorViewModel);
        }
    }
}
