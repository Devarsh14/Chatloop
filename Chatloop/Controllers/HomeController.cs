using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chatloop.Models;
using Chatloop.IDataServices;
using Chatloop.Services;

namespace Chatloop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IReminderManagment reminderManagment;
        private readonly ISendGrid sendGrid;
        public HomeController(IReminderManagment reminderManagment,ISendGrid sendGrid)
        {
            this.reminderManagment = reminderManagment;
            this.sendGrid = sendGrid;
        }
        public IActionResult Index()

        {
           sendGrid.Execute().Wait();
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
            this.reminderManagment.RemindersMangementList(reminder);
            

            
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
