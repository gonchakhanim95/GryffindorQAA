namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class EditCoursesAsMethodologistStepDefinitions
    {
        public static string Email;
        private string _adminToken;
        private int _idMethodist;
        Clientt _client;
        AuthPage _authPage;
        MethodistPage _methodistPage;
        public EditCoursesAsMethodologistStepDefinitions()
        {
            _authPage = new AuthPage();
            _methodistPage = new MethodistPage();
            _client = new Clientt();
        }
        [Given(@"Created new User")]
        public void GivenCreatedNewUser(Table table)
        {
            var tablica = table.CreateSet<RequestRegistrationModel>().ToList();
            Email = tablica[0].Email;
            _idMethodist = _client.Registration(tablica[0]);
        }

        [Given(@"Auth as  Admin")]
        public void GivenAuthAsAdmin(Table table)
        {
            var tablica = table.CreateSet<AuthRequestModel>().ToList();
            _adminToken = _client.Auth(tablica[0]);
        }

        [Given(@"Give role a methodist")]
        public void GivenGiveRoleAMethodist()
        {
            _client.GiveRole(_adminToken, _idMethodist, "Methodist");
        }

        [Given(@"Open web auth page")]
        public void GivenOpenWebAuthPage()
        {
            _authPage.Open();
            _authPage.SkipSecure();
        }

        [When(@"Fill form")]
        public void WhenFillForm(Table table)
        {
            var tablica= table.CreateSet<AuthModel>().ToList();
            _authPage.EnterEmail(tablica[0].Email);
            _authPage.EnterPassword(tablica[0].Password);
        }

        [When(@"Sing in")]
        public void WhenSingIn()
        {
            _authPage.ClickButtonSignIn();
        }

        [When(@"Change role on methodist")]
        public void WhenChangeRoleOnMethodist()
        {
            _methodistPage.ClickOnRole();
            _methodistPage.ClickButtongChangeRoleMethodist();
        }

        [When(@"Click Edit courses")]
        public void WhenClickEditCourses()
        {
            _methodistPage.ClickButtonEditCourses();
        }

        [When(@"Make changes")]
        public void WhenMakeChanges()
        {
            _methodistPage.ClickDragAndDrop();
        }

        [When(@"Add new Topic")]
        public void WhenAddNewTopic()
        {
            _methodistPage.EnterNumberTopic("7");
            _methodistPage.EnterNameTopic("Многомерный массив");
            _methodistPage.EnterTopicHours("2");
        }

        [When(@"Click save")]
        public void WhenClickSave()
        {
            _methodistPage.ClickButtonSave();
        }

        [When(@"Sing out")]
        public void WhenSingOut()
        {
            _methodistPage.ClickSingOut();
        }

        [Then(@"Must log out")]
        public void ThenMustLogOut()
        {
            DriverStorage storage = DriverStorage.GetInstance();
            string expected = Urls.AuthPage;
            string actual = storage.Driver.Url;
            Assert.Equal(expected, actual);
        }
    }
}
