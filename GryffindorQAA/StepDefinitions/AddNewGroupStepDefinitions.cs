namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class AddNewGroupStepDefinitions
    {
        Clientt _client;
        AuthPage _authPage;
        ManagerPage _managersPage;
        AdminPage _adminPage;
        public static string Email1;
        public static string Email2;
        private string _adminToken;
        private int _idTutor;
        private int _idTeacher;
        public AddNewGroupStepDefinitions()
        {
            _authPage = new AuthPage();
            _managersPage = new ManagerPage();
            _client = new Clientt();
            _adminPage = new AdminPage();
        }

        [Given(@"Created new user")]
        public void GivenCreatedNewUser(Table table)
        {
            var tablica = table.CreateSet<RequestRegistrationModel>().ToList();
            Email1 = tablica[0].Email;
            Variables.GetInstance().TutorId = _client.Registration(tablica[0]);
            Email2 = tablica[1].Email;
            _idTeacher = _client.Registration(tablica[1]);
        }

        [Given(@"Auth as admin")]
        public void GivenAuthAsAdmin(Table table)
        {
            var tablica = table.CreateInstance<AuthRequestModel>();
            _adminToken = _client.Auth(tablica);
        }

        [Given(@"Give role Teacher to the new user")]
        public void GivenGiveRoleTeacherToTheNewUser()
        {
            _client.GiveRole(Variables.GetInstance().AdminToken, Variables.GetInstance().TeacherId, "Teacher");
        }

        [Given(@"Give role Tutor to the new user")]
        public void GivenGiveRoleTutorToTheNewUser()
        {
            _client.GiveRole(Variables.GetInstance().AdminToken, Variables.GetInstance().TutorId, "Tutor");
        }

        [Given(@"Open auth Web page")]
        public void GivenOpenAuthWebPage()
        {
            _authPage.Open();
            _authPage.SkipSecure();
        }

        [When(@"Fill out form for Admin")]
        public void WhenFillOutFormForAdmin(Table table)
        {
            var tablica = table.CreateSet<AuthModel>().ToList();
            _authPage.EnterEmail(tablica[0].Email);
            _authPage.EnterPassword(tablica[0].Password);
        }

        [When(@"Click sing in")]
        public void WhenClickSingIn()
        {
            _authPage.ClickButtonSignIn();
        }

        [When(@"Click button create group")]
        public void WhenClickButtonCreateGroup()
        {
            _adminPage.ClickButtonCreatGroup();
        }

        [When(@"Enter group name ""([^""]*)""")]
        public void WhenEnterGroupName(string nameGroup)
        {
            _adminPage.EnterNameGroup(nameGroup);
        }

        [When(@"Select Tutor and Teacher")]
        public void WhenSelectTutorAndTeacher()
        {
            _adminPage.ClickCheckSelectTutor();
            _adminPage.ClickCheckSelectTeacher();
        }

        [When(@"Click Save")]
        public void WhenClickSave()
        {
            _adminPage.ClickButtonSaveGroup();
        }

        [When(@"Click Groups")]
        public void WhenClickGroups()
        {
            _adminPage.ClickButtonGroup();
        }

        [Then(@"View group Slyzerin")]
        public void ThenViewGroupSlyzerin()
        {
            string expected = "Slyzerin";
            string actual = _adminPage.GetNameGroup();
            Assert.Equal(expected, actual);
        }
    }
}
