using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryffindorQAA.BackModel
{
    public class PaymentResponseModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("sum")]
        public int Sum { get; set; }

        [JsonPropertyName("user")]
        public UserModel User { get; set; }

        [JsonPropertyName("isPaid")]
        public bool IsPaid { get; set; }
    }
}
