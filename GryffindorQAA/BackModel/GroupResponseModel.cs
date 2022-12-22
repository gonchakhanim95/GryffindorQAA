using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GryffindorQAA.BackModel
{
    public class GroupResponseModel
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

        public class Root
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
    }
}
