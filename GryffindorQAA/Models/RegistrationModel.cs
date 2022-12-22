using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GryffindorQAA.Drivers;
namespace GryffindorQAA.Models
{
    public class RegistrationModel
    {
        public string LastName { get; set; } 
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string BirthDate { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
