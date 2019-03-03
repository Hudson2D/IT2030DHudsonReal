using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentId { get; set; }

        [Display(Name = "Student ID")]
        public virtual int StudentId { get; set; }

        [Display(Name = "Course ID")]
        public virtual int CourseId { get; set; }

        [Required(ErrorMessage = "Please Enter a Valid grade from A, B, C, D, F")]
        [RegularExpression(@"[A-D, F]{1}", ErrorMessage = "Please Enter a Valid grade from A, B, C, D, F")]
        public virtual string Grade { get; set; }

        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }

        [Display(Name = "Is Active")]
        public virtual bool IsActive { get; set; }

        [Required(ErrorMessage = "Please Enter an Assigned Campus.")]
        [Display(Name = "Assigned Campus")]
        public virtual string AssignedCampus { get; set; }

        [Required(ErrorMessage = "Please choose an Enrollment Semester")]
        [Display(Name = "Enrolled in Semester")]
        public virtual string EnrollmentSemester { get; set; }

        [Required(ErrorMessage = "Please Enter a year greater than 2018")]
        [Range(2018, int.MaxValue, ErrorMessage = "Please Enter a year greater than 2018")]
        [Display(Name = "Enrollement Year")]
        public virtual int EnrollmentYear { get; set; }
        
 
        [InvalidChars("*", ErrorMessage = "Notes contains unacceptable characters!")]
        public virtual string Notes { get; set; }

    }
}