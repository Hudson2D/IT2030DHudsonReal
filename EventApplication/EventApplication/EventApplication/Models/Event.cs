using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EventApplication.Models
{
    public class Event
    {
        public virtual int EventId { get; set; }

        [Display(Name = "Event Type")]
        public virtual int EventTypeId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Event Title")]
        public virtual string EventTitle { get; set; }

        [StringLength(150)]
        [Display(Name = "Event Description")]
        public virtual string EventDescription { get; set; }

        [Required]
        [DateGreaterThan("EventEndDate")]
        [Display(Name = "Event Start Date")]
        public virtual DateTime EventStartDate { get; set; }

        [Required]
        [Display(Name = "Event Start Time")]
        public virtual string EventStartTime { get; set; }

        [Required]
        [Display(Name = "Event End Date")]
        public virtual DateTime EventEndDate { get; set; }

        [Required]
        [Display(Name = "Event End Time")]
        public virtual string EventEndTime { get; set; }

        [Required]
        public virtual string City { get; set; }

        [Required]
        public virtual string State { get; set; }

        [Display(Name = "Event Type")]
        public virtual EventType EventType { get; set; }

        [Required]
        [Display(Name = "Organizer Name")]
        public virtual string OrganizerName { get; set; }

        [Display(Name = "Organizer Contact Info")]
        public virtual string OrganizerContactInfo { get; set; }

        [Required]
        [Display(Name = "Max Tickets")]
        [Range(1, int.MaxValue, ErrorMessage = "Enter A Number Higher than 0")]
        public virtual int MaxTickets { get; set; }

        [Required]
        [TicketsCheck("MaxTickets")]
        [Display(Name = "Available Tickets")]
        public virtual int AvailableTickets { get; set; }


    }
}