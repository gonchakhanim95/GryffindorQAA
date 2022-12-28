namespace GryffindorQAA.Support
{
    public class Variables
    {
        public string AdminToken { get; set; }
        public int CourseId { get; set; }
        public int GroupId { get; set; }
        public int TaskId { get; set; }
        public int TutorId { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public List<int> StudentsId { get; set; }

        public int ManagerId { get; set; }

        public string HomeworkName { get; set; }

        private static Variables _instance;

        private Variables()
        {

        }

        public static Variables GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Variables();
            }
            return _instance;
        }
    }
}
