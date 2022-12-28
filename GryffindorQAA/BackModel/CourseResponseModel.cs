namespace GryffindorQAA.BackModel
{
    public class CourseResponseModel
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("topics")]
        public List<object> Topics { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("isDeleted")]
        public bool IsDeleted { get; set; }
    }
}
