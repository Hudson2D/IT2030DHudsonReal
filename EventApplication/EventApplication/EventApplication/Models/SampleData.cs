using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EventApplication.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<EventApplicationDB>
    {
        protected override void Seed(EventApplicationDB context)
        {
            var eventTypes = new List<EventType>
            {
                new EventType { EventTypeName = "Concert" },
                new EventType { EventTypeName = "Speech" },
                new EventType { EventTypeName = "Clean-up" },
                new EventType { EventTypeName = "Marathon" },
                new EventType { EventTypeName = "Rally" },
                new EventType { EventTypeName = "Meet-up" },
                new EventType { EventTypeName = "Planning" },
                new EventType { EventTypeName = "Seminar" },
                new EventType { EventTypeName = "Convention" },
                new EventType { EventTypeName = "Trade" },

            };


            new List<Event>
            {
                new Event {EventTypeId = 1, EventTitle = "Concert 1", EventDescription = "Concert of 1", EventStartDate = new DateTime(2019, 05, 04), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 04), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 2, EventTitle = "Speech 1", EventDescription = "Speech of 1", EventStartDate = new DateTime(2019, 05, 04), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 04), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 3, EventTitle = "Clean-up 1", EventDescription = "Clean-up of 1", EventStartDate = new DateTime(2019, 05, 04), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 04), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 4, EventTitle = "Marathon 1", EventDescription = "Marathon of 1", EventStartDate = new DateTime(2019, 05, 04), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 04), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 5, EventTitle = "Rally 1", EventDescription = "Rally of 1", EventStartDate = new DateTime(2019, 05, 04), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 04), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 6, EventTitle = "Meet-up 1", EventDescription = "Meet-up of 1", EventStartDate = new DateTime(2019, 05, 06), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 07), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 7, EventTitle = "Planning 1", EventDescription = "Planning of 1", EventStartDate = new DateTime(2019, 05, 06), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 07), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 8, EventTitle = "Seminar 1", EventDescription = "Seminar of 1", EventStartDate = new DateTime(2019, 05, 06), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 07), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 9, EventTitle = "Convention 1", EventDescription = "Convention of 1", EventStartDate = new DateTime(2019, 05, 10), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 11), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 10, EventTitle = "Trade 1", EventDescription = "Trade of 1", EventStartDate = new DateTime(2019, 05, 11), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 12), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 1, EventTitle = "Concert 2", EventDescription = "Concert of 2", EventStartDate = new DateTime(2019, 05, 11), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 12), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 2, EventTitle = "Speech 2", EventDescription = "Speech of 2", EventStartDate = new DateTime(2019, 05, 10), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 11), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 3, EventTitle = "Clean-up 2", EventDescription = "Clean-up of 2", EventStartDate = new DateTime(2019, 05, 11), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 12), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 4, EventTitle = "Marathon 2", EventDescription = "Marathon of 2", EventStartDate = new DateTime(2019, 05, 12), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 13), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 5, EventTitle = "Rally 2", EventDescription = "Rally of 2", EventStartDate = new DateTime(2019, 05, 12), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 13), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 6, EventTitle = "Meet-up 2", EventDescription = "Meet-up of 2", EventStartDate = new DateTime(2019, 05, 05), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 06), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 7, EventTitle = "Planning 2", EventDescription = "Planning of 2", EventStartDate = new DateTime(2019, 05, 07), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 08), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 8, EventTitle = "Seminar 2", EventDescription = "Seminar of 2", EventStartDate = new DateTime(2019, 05, 08), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 09), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 9, EventTitle = "Convention 2", EventDescription = "Convention of 2", EventStartDate = new DateTime(2019, 05, 07), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 08), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 10, EventTitle = "Trade 2", EventDescription = "Trade of 2", EventStartDate = new DateTime(2019, 05, 08), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 09), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 1, EventTitle = "Concert 3", EventDescription = "Concert of 3", EventStartDate = new DateTime(2019, 05, 12), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 13), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 2, EventTitle = "Speech 3", EventDescription = "Speech of 3", EventStartDate = new DateTime(2019, 05, 13), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 14), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 3, EventTitle = "Clean-up 3", EventDescription = "Clean-up of 3", EventStartDate = new DateTime(2019, 05, 09), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 10), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 4, EventTitle = "Marathon 3", EventDescription = "Marathon of 3", EventStartDate = new DateTime(2019, 05, 14), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 15), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 5, EventTitle = "Rally 3", EventDescription = "Rally of 3", EventStartDate = new DateTime(2019, 05, 13), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 14), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 6, EventTitle = "Meet-up 3", EventDescription = "Meet-up of 3", EventStartDate = new DateTime(2019, 05, 19), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 20), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 7, EventTitle = "Planning 3", EventDescription = "Planning of 3", EventStartDate = new DateTime(2019, 05, 13), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 14), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 8, EventTitle = "Seminar 3", EventDescription = "Seminar of 3", EventStartDate = new DateTime(2019, 05, 14), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 15), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 9, EventTitle = "Convention 3", EventDescription = "Convention of 3", EventStartDate = new DateTime(2019, 05, 13), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 14), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event {EventTypeId = 10, EventTitle = "Trade 3", EventDescription = "Trade of 3", EventStartDate = new DateTime(2019, 05, 04), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 04), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
            };
        }
    }
}
