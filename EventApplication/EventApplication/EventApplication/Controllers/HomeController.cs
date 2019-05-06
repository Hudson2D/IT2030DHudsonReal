using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventApplication.Models;


namespace EventApplication.Controllers
{
    public class HomeController : Controller
    {

        private EventApplicationDB db = new EventApplicationDB();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LastMinuteDeals()
        {
            var events = GetDealEvents();
            return PartialView("_LastMinuteDeals", events);
        }

        public List<Event> GetDealEvents()
        {
            DateTime newDate = DateTime.Today;
            DateTime endDate = newDate.AddDays(2);
            return db.Events
                .Where(a => a.EventStartDate >= DateTime.Today && a.EventStartDate <= endDate)
                .ToList();
        }

        public ActionResult FindEvent()
        {
            return View();
        }

        public ActionResult EventSearch(string q, string z)
        {

            var events = GetEvents(q, z);
            return PartialView("_EventSearch", events);


            }

        private List<Event> GetEvents(string searchString, string searchString2)
        {
            int EType = GetEventType(searchString2);
            return db.Events
                .Where(a => (a.City.Contains(searchString) || a.State.Contains(searchString)) && a.EventTypeId == EType )
                .ToList();
        }

        private int GetEventType(string searchString2)
        {
            EventType searchResults = db.EventTypes
                                         .Where(a => a.EventTypeName.Contains(searchString2))
                                         .FirstOrDefault();
            return searchResults.EventTypeId;
                
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}