using GryffindorQAA.BackModel;
using GryffindorQAA.Client;
using GryffindorQAA.Drivers;
using GryffindorQAA.Models;
using GryffindorQAA.Pages;
using TechTalk.SpecFlow.Assist;
using GryffindorQAA.Support;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class ViewListOfStudentsAsManagerStepDefinitions
    {
        ClientClient _client;
        AuthPage _authPage;
        ManagersPage _managersPage;
        public static string Email;
        private string _adminToken;
        private int _idManager;

        public ViewListOfStudentsAsManagerStepDefinitions()
        {
            _authPage = new AuthPage();
            _managersPage = new ManagersPage();
            _client = new ClientClient();
        }

        [Given(@"Registration as student")]
        public void GivenRegistrationAsStudent(Table table)
        {
            var tablica = table.CreateInstance<RegistrationRequestModel>();
            Email= tablica.Email;
            _idManager = _client.RegistrationStudent(tablica);
        }

        [Given(@"Auth as Admin")]
        public void GivenAuthAsAdmin(Table table)
        {
            var tablica = table.CreateInstance<AuthRequestModel>();
            _adminToken = _client.Auth(tablica);
        }

        [Given(@"Give the student the role of a manager")]
        public void GivenGiveTheStudentTheRoleOfAManager()
        {
            _client.GiveRoleManager(_adminToken, _idManager);
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
        public void GivenFillOutFormAuth(Table table)
        {
            var tablica = table.CreateInstance<AuthModel>();
            _authPage.EnterLogin(tablica.email);
            _authPage.EnterPassword(tablica.password);
        }

        [Given(@"Click button Sing in")]
        public void GivenClickButtonSingIn()
        {
            _authPage.ClickButtonSingIn();
            Thread.Sleep(1000);
            _managersPage.ClickOnRole();
            Thread.Sleep(1000);
            _managersPage.ClickButtongChangeRoleManager();
        }

        [When(@"Click botton list Students")]
        public void WhenClickBottonListStudents()
        {
            _managersPage.ClickButtonListStudents();
        }

        [When(@"Filter the list")]
        public void WhenFilterTheList()
        {
            _managersPage.ClickFilterStudents();
            Thread.Sleep(1000);
            _managersPage.ClickButtonChangeFilter();
        }

        [Then(@"View Studets List")]
        public void ThenViewStudetsList()
        {
            DriverStorage storage = DriverStorage.GetDriverStorage();
            string expected = Urls.StudentListPage;
            string actual = storage.Driver.Url;
            Assert.Equal(expected, actual);
        }

    }
}
