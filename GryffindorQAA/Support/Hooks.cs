using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace GryffindorQAA.Support
{
    [Binding]
    public sealed class Hooks
    {

        [AfterScenario]
        public void AfterScenario()
        {
            List<string> emails = new List<string>();
            emails.Add(CreateTeacherStepDefinitions.Email);
            emails.Add(WatchHomeWorksAsStudentStepDefinitions.Email);
            emails.Add(ViewListOfStudentsAsManagerStepDefinitions.Email);
            emails.Add(AddNewGroupStepDefinitions.Email1);
            emails.Add(AddNewGroupStepDefinitions.Email2);
            emails.Add(EditCoursesAsMethodologistStepDefinitions.Email);

           // DriverStorage.GetInstance().Driver.Close();

            foreach (var item in emails)
            {
                string connectionString = @"Data Source = 80.78.240.16; Initial Catalog = DevEdu; Persist Security Info = True; User ID = student; Password = qwe!23;";
                IDbConnection dbConnection = new SqlConnection(connectionString);
                dbConnection.Open();
                dbConnection.Query($"delete from Payment where UserId = (select Id from [User] where Email = '{item}');");
                dbConnection.Query($"delete from Student_Lesson where UserId = (select Id from [User] where Email = '{item}');");
                dbConnection.Query($"delete from Group_Lesson where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = '{item}'));");
                dbConnection.Query($"delete from Lesson_Topic where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = '{item}'));");
                dbConnection.Query($"delete from Lesson where TeacherId = (select Id from [User] where Email = '{item}');");
                dbConnection.Query($"delete from User_Group where UserId = (select Id from [User] where Email = '{item}');");
                dbConnection.Query($"delete from StudentRating where UserId = (select Id from [User] where Email = '{item}');");
                dbConnection.Query($"delete from User_Role where UserId = (select Id from [User] where Email = '{item}');");
                dbConnection.Query($"delete from [Notification] where UserId = (select Id from [User] where Email = '{item}');");
                dbConnection.Query($"delete from Comment where UserId = (select Id from [User] where Email = '{item}');");
                dbConnection.Query($"delete from Comment where StudentHomeworkId = (select Id from [Student_Homework] where StudentId = (select Id from [User] where Email = '{item}'));");
                dbConnection.Query($"delete from Student_Homework where StudentId = (select Id from [User] where Email = '{item}');");
                dbConnection.Query($"delete from [User] where Email = '{item}';");
                dbConnection.Close();
            }
            
        }
    }
}