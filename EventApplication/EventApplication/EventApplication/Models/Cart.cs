﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EventApplication.Models
{
    public class Cart
    {
        [Key]
        public int RecordId { get; set; }

        public string CartId { get; set; }

        public int EventId { get; set; }

        public virtual Event EventSelected { get; set; }

        public int Count { get; set; }

        public DateTime DateCreated { get; set; }

        public string OrderStatus { get; set; }
    }
}