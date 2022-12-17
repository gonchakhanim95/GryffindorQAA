using GryffindorQAA.BackModel;
using GryffindorQAA.Client;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class ViewListOfStudentsAsManagerStepDefinitions
    {
        ClientClient client = new ClientClient();
        [Given(@"Registration as student and Auth as Admin and give the student the role of a manager")]
        public void GivenRegistrationAsStudentAndAuthAsAdminAndGiveTheStudentTheRoleOfAManager(Table table)
        {
            RegistrationRequestModel registrationRequestModel = new RegistrationRequestModel()
            {
                FirstName = "Daniel",
                LastName = "Martin",
                Patronymic = "Pitt",
                Email = "pofoihhee@gmail.com",
                Username = "Drep",
                Password = "daniello",
                City = "SaintPetersburg",
                BirthDate = "23.03.2003",
                GitHubAccount = "@drep33",
                PhoneNumber = "+78884445454"
            };
            string userId = client.RegistrationStudent(registrationRequestModel);
            AuthRequestModel auth = new AuthRequestModel()
            {
                Email = "marina@example.com",
                Password = "marina123456"
            };
            string token = client.Auth(auth);
            client.GiveRoleTeacher(token, userId);
        }

        [Given(@"Open auth page for Manager")]
        public void GivenOpenAuthPageForManager()
        {
            throw new PendingStepException();
        }

        [Given(@"Fill out form Auth")]
        public void GivenFillOutFormAuth(Table table)
        {
            throw new PendingStepException();
        }

        [Given(@"Click button Sing in")]
        public void GivenClickButtonSingIn()
        {
            throw new PendingStepException();
        }

        [When(@"Click botton list Students")]
        public void WhenClickBottonListStudents()
        {
            throw new PendingStepException();
        }
    }
}
