namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class ViewListOfStudentsAsManagerStepDefinitions
    {
        public static string Email;
        private string _adminToken;
        private int _idManager;
        Client _client;
        AuthPage _authPage;
        ManagerPage _managerPage;

        public ViewListOfStudentsAsManagerStepDefinitions()
        {
            _authPage = new AuthPage();
            _managerPage = new ManagerPage();
            _client = new Client();
        }

        [Given(@"Registration as student")]
        public void GivenRegistrationAsStudent(Table table)
        {
            var tablica = table.CreateSet<RequestRegistrationModel>().ToList();
            Email= tablica[0].Email;
            _idManager = _client.Registration(tablica[0]);
        }

        [Given(@"Auth as Admin")]
        public void GivenAuthAsAdmin(Table table)
        {
            var tablica = table.CreateSet<AuthRequestModel>().ToList();
            _adminToken = _client.Auth(tablica[0]);
        }

        [Given(@"Give the student the role of a manager")]
        public void GivenGiveTheStudentTheRoleOfAManager()
        {
            _client.GiveRole(_adminToken, _idManager,"Manager");
        }

        [Given(@"Open auth page for Manager")]
        public void GivenOpenAuthPageForManager()
        {
            _authPage.Open();
            _authPage.SkipSecure();
        }

        [Given(@"Fill out form Auth")]
        public void GivenFillOutFormAuth(Table table)
        {
            var tablica = table.CreateInstance<AuthModel>();
            _authPage.EnterEmail(tablica.Email);
            _authPage.EnterPassword(tablica.Password);
        }

        [Given(@"Click button Sing in")]
        public void GivenClickButtonSingIn()
        {
            _authPage.ClickButtonSignIn();
            Thread.Sleep(1000); // sil
            _managerPage.ClickOnRole();
            Thread.Sleep(1000); // sil
            _managerPage.ClickButtongChangeRoleManager();
        }

        [When(@"Click botton list Students")]
        public void WhenClickBottonListStudents()
        {
            _managerPage.ClickButtonListStudents();
        }

        [When(@"Filter the list")]
        public void WhenFilterTheList()
        {
            _managerPage.ClickFilterStudents();
            Thread.Sleep(1000);
            _managerPage.ClickButtonChangeFilter();
        }

        [Then(@"View Studets List")]
        public void ThenViewStudetsList()
        {
            DriverStorage storage = DriverStorage.GetInstance();
            string expected = Urls.StudentListPage;
            string actual = storage.Driver.Url;
            Assert.Equal(expected, actual);
        }
    }
}
