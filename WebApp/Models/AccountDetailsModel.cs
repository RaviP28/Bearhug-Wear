using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class AccountDetailsModel
    {
        [EmailAddress]
        public string Email { get; set; }
        [MinLength(8)]
        public string Password { get; set; }

        public string FistName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}