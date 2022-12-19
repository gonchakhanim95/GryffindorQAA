using GryffindorQAA.Drivers;
using GryffindorQAA.Pages;
using GryffindorQAA.Support;
using TechTalk.SpecFlow.Assist;
using GryffindorQAA.Models;

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
            DriverStorage storage = DriverStorage.GetInstance();

            _registrationPage.Open();

            string xpath = @"/html/body/div/div[2]/button[3]";
            storage.Driver.FindElement(By.XPath(xpath)).Click();
            xpath = @"/html/body/div/div[3]/p[2]/a";
            storage.Driver.FindElement(By.XPath(xpath)).Click();

            xpath = @"//a[@class='auth-link']";
            storage.Driver.FindElement(By.XPath(xpath)).Click();
        }

        [Given(@"Fill out form")]
        public void GivenFillOutForm(Table table)
        {
            var tablica = table.CreateInstance<RegistrationModel>();
            _registrationPage.EnterLastname(tablica.Lastname);
            _registrationPage.EnterFirstname(tablica.Firstname);
            _registrationPage.EnterParonymic(tablica.Patronymic);
            _registrationPage.EnterBrithDate(tablica.BirthDate);
            _registrationPage.EnterPassword(tablica.Password);
            _registrationPage.EnterRepeatPassword(tablica.RepeatPassword);
            _registrationPage.EnterEmail(tablica.Email);
            _registrationPage.EnterPhone(tablica.Phone);

            Email = tablica.Email;
        }


        [Given(@"Click  button registered")]
        public void GivenClickButtonRegistered()
        {
            _registrationPage.ClickCheckButton();
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
           _registrationPage.ClickChangeButtonToAuth();
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
            _authPage.ClickButtonSingIn();
        }

        [Given(@"Should  entered into system")]
        public void GivenShouldEnteredIntoSystem()
        {
            string expected = Urls.HomePage;
            string actual = Urls.AuthPage;
            Assert.NotEqual(expected, actual);
            Thread.Sleep(1000);
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