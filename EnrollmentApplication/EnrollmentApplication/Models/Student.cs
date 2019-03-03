using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student : IValidatableObject
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

        // [MinimumAge(20)]
        [MinimumAge(20)]
        public virtual int Age { get; set; }

        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string City { get; set; }
        public virtual string Zipcode { get; set; }
        public virtual string State { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var pAddress2 = new[] { Address2 };
            if(Address2 == Address1)
            {
                yield return new ValidationResult("Address 1 and Address 2 can't match");
            }
            var pState = new[] { State };
            if(State.Length > 2)
            {
                yield return new ValidationResult("Enter a 2 digit state code");
            }
            var pZipcode = new[] { Zipcode };
            if(Zipcode.Length > 5 || Zipcode.Length < 5)
            {
                yield return new ValidationResult("Enter a 5 digit zip code");
            }
            //throw new NotImplementedException();
        }
    }
}


