using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UserRegistration.Interfaces;
using System.Net.Mail;
using UserRegistration.Helper;
using System.Text.RegularExpressions;

namespace UserRegistration.Model
{
    public class User : AbstractEntity<int>, IAuditable, IValidatableObject
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Gender { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!Email.IsValidEmail())
            {
                yield return new ValidationResult("Invalid Email Address", new[] { "Email" });
            }
            if(!Regex.IsMatch(PhoneNumber, "^[89]\\d{7}$"))
            {
                yield return new ValidationResult("Not valid Singapore Number", new[] { "PhoneNumber" });
            }
        }
    }
}
