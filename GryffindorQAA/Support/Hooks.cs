using GryffindorQAA.Drivers;
using System.Data;
using System.Data.SqlClient;
using TechTalk.SpecFlow;
using Dapper;
using GryffindorQAA.StepDefinitions;

namespace GryffindorQAA.Support
{
    [Binding]
    public sealed class Hooks
    {

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {

        }


        [AfterScenario]
        public void AfterScenario()
        {
            CreateTeacherStepDefinitions definitions = new CreateTeacherStepDefinitions();
            DriverStorage.GetInstance().Driver.Close();
            string connectionString = @"Data Source = 80.78.240.16; Initial Catalog = DevEdu; Persist Security Info = True; User ID = student; Password = qwe!23;";
            IDbConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            dbConnection.Query($"delete from Payment where UserId = (select Id from [User] where Email = '{definitions.Email}');");
            dbConnection.Query($"delete from Student_Lesson where UserId = (select Id from [User] where Email = '{definitions.Email}');");
            dbConnection.Query($"delete from Group_Lesson where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = '{definitions.Email}'));");
            dbConnection.Query($"delete from Lesson_Topic where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = '{definitions.Email}'));");
            dbConnection.Query($"delete from Lesson where TeacherId = (select Id from [User] where Email = '{definitions.Email}');");
            dbConnection.Query($"delete from User_Group where UserId = (select Id from [User] where Email = '{definitions.Email}');");
            dbConnection.Query($"delete from StudentRating where UserId = (select Id from [User] where Email = '{definitions.Email}');");
            dbConnection.Query($"delete from User_Role where UserId = (select Id from [User] where Email = '{definitions.Email}');");
            dbConnection.Query($"delete from [Notification] where UserId = (select Id from [User] where Email = '{definitions.Email}');");
            dbConnection.Query($"delete from Comment where UserId = (select Id from [User] where Email = '{definitions.Email}');");
            dbConnection.Query($"delete from Comment where StudentHomeworkId = (select Id from [Student_Homework] where StudentId = (select Id from [User] where Email = '{definitions.Email}'));");
            dbConnection.Query($"delete from Student_Homework where StudentId = (select Id from [User] where Email = '{definitions.Email}');");
            dbConnection.Query($"delete from [User] where Email = '{definitions.Email}';");
            dbConnection.Close();
        }
    }
}