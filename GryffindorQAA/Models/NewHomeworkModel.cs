namespace GryffindorQAA.Models
{
    public class NewHomeworkModel
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string HomeworkName { get; set; }
        public string HomeworkDescription{ get; set; }
        public List<string> HomeworkLinks { get; set; }
    }
}
