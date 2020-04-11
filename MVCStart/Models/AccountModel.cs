using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCStart.Models
{
    public class AccountModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You need to provide a First Name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to provide a Last Name.")]
        public string LastName { get; set; }

        [Display(Name = "Birth Day")]
        [Required(ErrorMessage = "You need to provide a Birth Day.")]
        public DateTime BirthDay { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "You need to provide a Phone Number.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "You need to provide a UserName.")]
        public string UserName { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "You need to provide an Email Address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Confirm Email Address")]
        [Compare("Email", ErrorMessage ="The Emails must match.")]
        [DataType(DataType.EmailAddress)]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "You need to provide a Password.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage ="Your password is not long enough")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Your Passwords do not match.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Street Address")]
        [Required(ErrorMessage = "You need to provide an Address.")]
        public string StreetAddress { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "You need to provide a City.")]
        public string City { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "You need to provide a State.")]
        public string State { get; set; }

        [Display(Name = "Zip")]
        [Required(ErrorMessage = "You need to provide a Zip Code.")]
        public int Zip { get; set; }

        [Display(Name = "Are you an Employee?")]
        public bool IsEmployee { get; set; }

        [Display(Name = "Are you a Manager?")]
        public bool IsManager { get; set; }

        [Display(Name = "Are you a Member?")]
        public bool IsMember { get; set; }
    }
}