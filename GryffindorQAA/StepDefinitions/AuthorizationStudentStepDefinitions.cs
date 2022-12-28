namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class AuthorizationStudentStepDefinitions
    {
        public static string Email;
        RegistrationPage _registrationPage;
        AuthPage _authPage;
        public AuthorizationStudentStepDefinitions()
        {
           _registrationPage = new RegistrationPage();
           _authPage = new AuthPage();
        }

        [Given(@"Open web registration page")]
        public void GivenOpenWebRegistrationPage()
        {
            _registrationPage.Open();
            _authPage.SkipSecure();
            _authPage.ClickButtonChangePage();
        }

        [When(@"Fill out form")]
        public void WhenFillOutForm(Table table)
        {
            var tablica = table.CreateSet<RegistrationModel>().ToList();
            _registrationPage.EnterLastName(tablica[0].LastName);
            _registrationPage.EnterFirstName(tablica[0].FirstName);
            _registrationPage.EnterParonymic(tablica[0].Patronymic);
            _registrationPage.EnterBrithDate(tablica[0].BirthDate);
            _registrationPage.EnterPassword(tablica[0].Password);
            _registrationPage.EnterRepeatPassword(tablica[0].RepeatPassword);
            _registrationPage.EnterEmail(tablica[0].Email);
            _registrationPage.EnterPhoneNumber(tablica[0].Phone);

            Email = tablica[0].Email;
        }

        [When(@"Click button registration")]
        public void WhenClickButtonRegistration()
        {
            _registrationPage.ClickButtonCheckBox();
            _registrationPage.ClickButtonRegistration();
        }

        [When(@"Open auth page")]
        public void WhenOpenAuthPage()
        {
            _authPage.Open();
        }

        [When(@"Fill auth form")]
        public void WhenFillAuthForm(Table table)
        {
            var tablica = table.CreateInstance<AuthModel>();
            _authPage.EnterEmail(tablica.Email);
            _authPage.EnterPassword(tablica.Password);
        }

        [When(@"Click button sign in")]
        public void WhenClickButtonSignIn()
        {
            _authPage.ClickButtonSignIn();
        }

        [Then(@"Authorization completed")]
        public void ThenAuthorizationCompleted()
        {
            string expected = Urls.HomePage;
            string actual = Urls.HomePage;
            Assert.Equal(expected, actual);
        }
    }
}
