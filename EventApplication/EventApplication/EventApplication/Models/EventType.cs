using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EventApplication.Models
{
    public class EventType
    {
        public virtual int EventTypeId { get; set; }

        [Display(Name = "Event Type Name")]
        public virtual string EventTypeName { get; set; }


    }
}