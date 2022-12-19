using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GryffindorQAA.BackModel
{
    public class UserResponseModelId
    {
        public class Course
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("isDeleted")]
            public bool IsDeleted { get; set; }
        }

        public class Group
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("course")]
            public Course Course { get; set; }

            [JsonPropertyName("groupStatus")]
            public string GroupStatus { get; set; }

            [JsonPropertyName("startDate")]
            public string StartDate { get; set; }

            [JsonPropertyName("endDate")]
            public string EndDate { get; set; }

            [JsonPropertyName("timetable")]
            public string Timetable { get; set; }

            [JsonPropertyName("paymentPerMonth")]
            public int PaymentPerMonth { get; set; }

            [JsonPropertyName("paymentsCount")]
            public int PaymentsCount { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("firstName")]
            public string FirstName { get; set; }

            [JsonPropertyName("lastName")]
            public string LastName { get; set; }

            [JsonPropertyName("email")]
            public string Email { get; set; }

            [JsonPropertyName("photo")]
            public string Photo { get; set; }

            [JsonPropertyName("roles")]
            public List<string> Roles { get; set; }

            [JsonPropertyName("patronymic")]
            public string Patronymic { get; set; }

            [JsonPropertyName("username")]
            public string Username { get; set; }

            [JsonPropertyName("registrationDate")]
            public string RegistrationDate { get; set; }

            [JsonPropertyName("birthDate")]
            public string BirthDate { get; set; }

            [JsonPropertyName("gitHubAccount")]
            public string GitHubAccount { get; set; }

            [JsonPropertyName("phoneNumber")]
            public string PhoneNumber { get; set; }

            [JsonPropertyName("exileDate")]
            public string ExileDate { get; set; }

            [JsonPropertyName("city")]
            public string City { get; set; }

            [JsonPropertyName("groups")]
            public List<Group> Groups { get; set; }
        }
    }
}
