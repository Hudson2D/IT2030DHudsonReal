﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Course : IValidatableObject
    {
        [Display(Name = "Course ID")]
        public virtual int CourseId { get; set; }

        [Required(ErrorMessage = "Proper Course Title Required, Max 150 Characters")]
        [Display(Name = "Course Title")]
        [StringLength(150)]
        public virtual string Title { get; set; }

        [Display(Name = "Description")]
        public virtual string Description { get; set; }

        [Required(ErrorMessage = "Number of Credits must be from 1 to 4")]
        [Display(Name = "Number of Credits")]
        [Range(1, 4)]
        public virtual int Credits { get; set; }

        public virtual string InstructorName { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Validation 1: Credits have to between 1-4
            if (Credits < 1 || Credits > 4)
            {
                yield return (new ValidationResult("Credits must be between 1 and 4"));
            }

            if(Description.Split(' ').Length > 100)
            {
                yield return (new ValidationResult("Your description is too verbose"));
            }

           
        }
    }
}
