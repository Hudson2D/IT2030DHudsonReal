namespace EventApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EventApplication.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EventApplication.Models.EventApplicationDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EventApplication.Models.EventApplicationDB";
        }

        protected override void Seed(EventApplication.Models.EventApplicationDB context)
        {
            context.EventTypes.AddOrUpdate(x => x.EventTypeId,
             
           
                new EventType() { EventTypeId = 1, EventTypeName = "Concert" },
                new EventType() { EventTypeId = 2, EventTypeName = "Speech" },
                new EventType() { EventTypeId = 3, EventTypeName = "Clean-up" },
                new EventType() { EventTypeId = 4, EventTypeName = "Marathon" },
                new EventType() { EventTypeId = 5, EventTypeName = "Rally" },
                new EventType() { EventTypeId = 6, EventTypeName = "Meet-up" },
                new EventType() { EventTypeId = 7, EventTypeName = "Planning" },
                new EventType() { EventTypeId = 8, EventTypeName = "Seminar" },
                new EventType() { EventTypeId = 9, EventTypeName = "Convention" },
                new EventType() { EventTypeId = 10, EventTypeName = "Trade" }

            );


            context.Events.AddOrUpdate(x => x.EventId,
            
                new Event() { EventId = 1, EventTypeId = 1, EventTitle = "Concert 1", EventDescription = "Concert of 1", EventStartDate = new DateTime(2019, 05, 04), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 04), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 2, EventTypeId = 2, EventTitle = "Speech 1", EventDescription = "Speech of 1", EventStartDate = new DateTime(2019, 05, 04), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 04), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 3, EventTypeId = 3, EventTitle = "Clean-up 1", EventDescription = "Clean-up of 1", EventStartDate = new DateTime(2019, 05, 04), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 04), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 4, EventTypeId = 4, EventTitle = "Marathon 1", EventDescription = "Marathon of 1", EventStartDate = new DateTime(2019, 05, 04), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 04), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 5, EventTypeId = 5, EventTitle = "Rally 1", EventDescription = "Rally of 1", EventStartDate = new DateTime(2019, 05, 04), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 04), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 6, EventTypeId = 6, EventTitle = "Meet-up 1", EventDescription = "Meet-up of 1", EventStartDate = new DateTime(2019, 05, 06), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 07), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 7, EventTypeId = 7, EventTitle = "Planning 1", EventDescription = "Planning of 1", EventStartDate = new DateTime(2019, 05, 06), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 07), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 8, EventTypeId = 8, EventTitle = "Seminar 1", EventDescription = "Seminar of 1", EventStartDate = new DateTime(2019, 05, 06), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 07), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 9, EventTypeId = 9, EventTitle = "Convention 1", EventDescription = "Convention of 1", EventStartDate = new DateTime(2019, 05, 10), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 11), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 10, EventTypeId = 10, EventTitle = "Trade 1", EventDescription = "Trade of 1", EventStartDate = new DateTime(2019, 05, 11), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 12), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 11, EventTypeId = 1, EventTitle = "Concert 2", EventDescription = "Concert of 2", EventStartDate = new DateTime(2019, 05, 11), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 12), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 12, EventTypeId = 2, EventTitle = "Speech 2", EventDescription = "Speech of 2", EventStartDate = new DateTime(2019, 05, 10), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 11), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 13, EventTypeId = 3, EventTitle = "Clean-up 2", EventDescription = "Clean-up of 2", EventStartDate = new DateTime(2019, 05, 11), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 12), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 14, EventTypeId = 4, EventTitle = "Marathon 2", EventDescription = "Marathon of 2", EventStartDate = new DateTime(2019, 05, 12), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 13), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 15, EventTypeId = 5, EventTitle = "Rally 2", EventDescription = "Rally of 2", EventStartDate = new DateTime(2019, 05, 12), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 13), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 16, EventTypeId = 6, EventTitle = "Meet-up 2", EventDescription = "Meet-up of 2", EventStartDate = new DateTime(2019, 05, 05), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 06), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 17, EventTypeId = 7, EventTitle = "Planning 2", EventDescription = "Planning of 2", EventStartDate = new DateTime(2019, 05, 07), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 08), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 18, EventTypeId = 8, EventTitle = "Seminar 2", EventDescription = "Seminar of 2", EventStartDate = new DateTime(2019, 05, 08), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 09), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 19, EventTypeId = 9, EventTitle = "Convention 2", EventDescription = "Convention of 2", EventStartDate = new DateTime(2019, 05, 07), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 08), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 20, EventTypeId = 10, EventTitle = "Trade 2", EventDescription = "Trade of 2", EventStartDate = new DateTime(2019, 05, 08), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 09), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 21, EventTypeId = 1, EventTitle = "Concert 3", EventDescription = "Concert of 3", EventStartDate = new DateTime(2019, 05, 12), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 13), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 22, EventTypeId = 2, EventTitle = "Speech 3", EventDescription = "Speech of 3", EventStartDate = new DateTime(2019, 05, 13), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 14), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 23, EventTypeId = 3, EventTitle = "Clean-up 3", EventDescription = "Clean-up of 3", EventStartDate = new DateTime(2019, 05, 09), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 10), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 24, EventTypeId = 4, EventTitle = "Marathon 3", EventDescription = "Marathon of 3", EventStartDate = new DateTime(2019, 05, 14), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 15), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 25, EventTypeId = 5, EventTitle = "Rally 3", EventDescription = "Rally of 3", EventStartDate = new DateTime(2019, 05, 13), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 14), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 26, EventTypeId = 6, EventTitle = "Meet-up 3", EventDescription = "Meet-up of 3", EventStartDate = new DateTime(2019, 05, 19), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 20), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 27, EventTypeId = 7, EventTitle = "Planning 3", EventDescription = "Planning of 3", EventStartDate = new DateTime(2019, 05, 13), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 14), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 28, EventTypeId = 8, EventTitle = "Seminar 3", EventDescription = "Seminar of 3", EventStartDate = new DateTime(2019, 05, 14), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 15), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 29, EventTypeId = 9, EventTitle = "Convention 3", EventDescription = "Convention of 3", EventStartDate = new DateTime(2019, 05, 13), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 14), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 },
                new Event() { EventId = 30, EventTypeId = 10, EventTitle = "Trade 3", EventDescription = "Trade of 3", EventStartDate = new DateTime(2019, 05, 04), EventStartTime = "12:00am", EventEndDate = new DateTime(2019, 06, 04), EventEndTime = "12:00am", City = "Berea", State = "Ohio", OrganizerName = "Steve", OrganizerContactInfo = "4405553243", MaxTickets = 34, AvailableTickets = 34 }
            );
        }
    }
}
