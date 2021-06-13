using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "First Name is required")] public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")] public string LastName { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage = "Email is required")] public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")] public string Password { get; set; }
    }
}
