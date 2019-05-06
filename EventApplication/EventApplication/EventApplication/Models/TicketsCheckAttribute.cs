using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EventApplication.Models
{
    [AttributeUsage(AttributeTargets.Property)]
    public class TicketsCheckAttribute : ValidationAttribute
    {
        public TicketsCheckAttribute(string valueToCompare)
        {
            ValueToCompare = valueToCompare;
        }

        private string ValueToCompare { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int TicketCheck1 = (int)value;

            var TicketCheck2 = (int)validationContext.ObjectType.GetProperty(ValueToCompare).GetValue(validationContext.ObjectInstance, null);

            if (TicketCheck2 >= TicketCheck1)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Available Tickets Can't Exceed Max Tickets");
            }
        }
    }

}