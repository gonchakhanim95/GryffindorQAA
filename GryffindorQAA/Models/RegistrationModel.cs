using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GryffindorQAA.Drivers;
using GryffindorQAA.Support;
using GryffindorQAA.Pages;
using GryffindorQAA.Features;

namespace GryffindorQAA.Models
{
    public class RegistrationModel
    {
        public string Lastname { get; set; } 
        public string Firstname { get; set; }
        public string Paronymic { get; set; }
        public string BirthDate { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
