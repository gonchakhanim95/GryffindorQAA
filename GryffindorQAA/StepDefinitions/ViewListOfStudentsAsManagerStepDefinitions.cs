using GryffindorQAA.BackModel;
using GryffindorQAA.Client;
using GryffindorQAA.Drivers;
using GryffindorQAA.Models;
using GryffindorQAA.Pages;
using TechTalk.SpecFlow.Assist;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class ViewListOfStudentsAsManagerStepDefinitions
    {
        ClientClient client = new ClientClient();
        RegistrationPage _registrationPage;
        AuthPage _authPage;
        //StudentPage _studentPage;

        public ViewListOfStudentsAsManagerStepDefinitions()
        {
            _registrationPage = new RegistrationPage();
            _authPage = new AuthPage();
            //_studentPage = new StudentPage();
        }
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
            DriverStorage storage = DriverStorage.GetDriverStorage();
            _authPage.Open();
            string xpath = @"/html/body/div/div[2]/button[3]";
            storage.Driver.FindElement(By.XPath(xpath)).Click();
            xpath = @"/html/body/div/div[3]/p[2]/a";
            storage.Driver.FindElement(By.XPath(xpath)).Click();
        }

        [Given(@"Fill out form Auth")]
        public void GivenFillOutFormAuth(Table tablle)
        {
            var tablica = tablle.CreateInstance<AuthModel>();
            _authPage.EnterLogin(tablica.email);
            _authPage.EnterPassword(tablica.password);
        }

        [Given(@"Click button Sing in")]
        public void GivenClickButtonSingIn()
        {
            _authPage.ClickButtonSingIn();
        }

        [When(@"Click botton list Students")]
        public void WhenClickBottonListStudents()
        {
            throw new PendingStepException();
        }
    }
}
