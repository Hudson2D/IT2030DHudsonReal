using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class InvalidCharsAttribute : ValidationAttribute
    {
        string patterns;

        public InvalidCharsAttribute(string patterns) : base("{0} contains unacceptable characters!")
        {
            this.patterns = patterns;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            string character = value as string;
            if (value != null)
            {
                if (character.Contains(patterns))
                {
                    var errormessages = FormatErrorMessage(validationContext.DisplayName);


                    return new ValidationResult("Notes contains unacceptable characters!");
                }
            }

            return ValidationResult.Success;
            // return base.IsValid(value, validationContext);
        }
    }
}