using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryffindorQAA.BackModel
{
    public class PaymentRequestModel
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("sum")]
        public int Sum { get; set; }

        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        [JsonPropertyName("isPaid")]
        public bool IsPaid { get; set; }
    }
}
