﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GryffindorQAA.BackModel
{
    public class RequestRegistrationModel
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("patronymic")]
        public string Patronymic { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("birthDate")]
        public string BirthDate { get; set; }

        [JsonPropertyName("gitHubAccount")]
        public string GitHubAccount { get; set; }

        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }

    }
}
