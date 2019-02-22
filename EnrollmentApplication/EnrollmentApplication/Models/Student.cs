using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student
    {
        [Display(Name = "Student ID")]
        public virtual int StudentId { get; set; }

        [Required(ErrorMessage = "Must not exceed 50 characters")]
        [Display(Name = "Last Name" )]
        [StringLength(50)]
        public virtual string LastName { get; set; }

        [Required(ErrorMessage = "Must not exceed 50 characters")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public virtual string FirstName { get; set; }
    }
}


