namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class CreateTeacherStepDefinitions
    {
        public static string Email;
        private string _adminToken;
        private int _idTeacher;
        TeacherPage _teacherPage;
        AuthPage _authPage;
        Clientt _client;

        public CreateTeacherStepDefinitions()
        {
            _authPage = new AuthPage();
            _teacherPage = new TeacherPage();
            _client = new Clientt();
        }

        [Given(@"Registration new User")]
        public void GivenRegistrationNewUser(Table table)
        {
            var tab = table.CreateSet<RequestRegistrationModel>().ToList();
            Email = tab[0].Email;
            _idTeacher = _client.RegistrationStudent(tab[0]);
        }

        [Given(@"Authoraized as admin")]
        public void GivenAuthoraizedAsAdmin(Table table)
        {
            var tab = table.CreateSet<AuthRequestModel>().ToList();
            _adminToken = _client.Auth(tab[0]);
        }

        [Given(@"Give role teacher to the new User")]
        public void GivenGiveRoleTeacherToTheNewUser()
        {
            _client.GiveRole(_adminToken,_idTeacher, "Teacher");
        }

        [When(@"Open auuthorization page")]
        public void WhenOpenAuuthorizationPage()
        {
            _authPage.Open();
        }

        [When(@"Skip bezopasnost")]
        public void WhenSkipBezopasnost()
        {
            _authPage.SkipSecure();
        }

        [When(@"Fill sign in form as teacher")]
        public void WhenFillSignInFormAsTeacher(Table table)
        {
            var tab = table.CreateSet<AuthModel>().ToList();
            _authPage.EnterEmail(tab[0].Email);
            _authPage.EnterPassword(tab[0].Password);
        }

        [When(@"Click sign button")]
        public void WhenClickSignButton()
        {
            _authPage.ClickButtonSignIn();
            Thread.Sleep(1000);
        }

        [Then(@"Login as a teacher")]
        public void ThenLoginAsATeacher()
        {
            string expected = "Преподаватель";
            string actual =  _teacherPage.GetTextDropDownRole();
            Assert.Equal(expected, actual);
        }
    }
}


