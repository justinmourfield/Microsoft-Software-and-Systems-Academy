using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            string timeofday;
            if (hour < 12)
                timeofday = "Good morning";
            else if (hour < 18)
                timeofday = "Good Afternoon";
            else
                timeofday = "Good Evening";
            ViewBag.Greeting = timeofday;
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                //TODO: Email response to the party organizer 
                return View("Thanks", guestResponse);
            }
            else
            {
                //there is a validation error
                return View();
            }
        }
    }           
}
    
