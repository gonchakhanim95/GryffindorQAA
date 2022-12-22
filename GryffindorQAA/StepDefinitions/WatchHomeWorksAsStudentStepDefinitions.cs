namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class WatchHomeWorksAsStudentStepDefinitions
    {
        RegistrationPage _registrationPage;
        AuthPage _authPage;
        StudentPage _studentPage;
        public static string Email;
        public WatchHomeWorksAsStudentStepDefinitions()
        {
            _registrationPage = new RegistrationPage();
            _authPage = new AuthPage();
            _studentPage= new StudentPage();
        }

        [Given(@"Open  registration page")]
        public void GivenOpenRegistrationPage()
        {
            _registrationPage.Open();
            _authPage.SkipSecure();
            _authPage.ClickButtonChangePage();
        }

        [Given(@"Fill out form")]
        public void GivenFillOutForm(Table table)
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

        [Given(@"Click  button registered")]
        public void GivenClickButtonRegistered()
        {
            _registrationPage.ClickButtonCheckBox();
            _registrationPage.ClickButtonRegistration();
            Thread.Sleep(500);                                    //nujno menyat
        }

        [Given(@"Must  come out inscription ""([^""]*)""")]
        public void GivenMustComeOutInscription(string expected)
        {
            DriverStorage storage = DriverStorage.GetInstance();
            string xpath = @"//p[@class='notification-text']";
            IWebElement button =storage.Driver.FindElement(By.XPath(xpath));
            string actual = button.Text;
            Assert.Equal(expected, actual);
        }

        [Given(@"Open  Auth as student")]
        public void GivenOpenAuthAsStudent()
        {
            _authPage.Open();
        }

        [Given(@"Fill out form for Auth")]
        public void GivenFillOutFormForAuth(Table table)
        {
            var tablica = table.CreateInstance<AuthModel>();
            _authPage.EnterEmail(tablica.Email);
            _authPage.EnterPassword(tablica.Password);
        }

        [Given(@"Press button sing in")]
        public void GivenPressButtonSingIn()
        {
            _authPage.ClickButtonSignIn();
        }

        [Given(@"Should  entered into system")]
        public void GivenShouldEnteredIntoSystem()
        {
            string expected = Urls.HomePage;
            string actual = Urls.AuthPage;
            Assert.NotEqual(expected, actual);
            Thread.Sleep(1000); // sil
        }

        [When(@"Select homeworks")]
        public void WhenSelectHomeworks()
        {
            _studentPage.ClickHomeWork();
            Thread.Sleep(500);
        }

        [Then(@"View  homeworks")]
        public void ThenViewHomeworks()
        {
            string expected = Urls.HomeWorkPage;
            string actual = Urls.HomePage;
            Assert.NotEqual(expected, actual);
        }
    }
}