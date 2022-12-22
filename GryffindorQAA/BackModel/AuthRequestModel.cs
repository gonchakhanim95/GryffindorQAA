namespace GryffindorQAA.BackModel
{
    public class AuthRequestModel
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
