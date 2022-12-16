using GryffindorQAA.Drivers;
using GryffindorQAA.Pages;
using GryffindorQAA.Support;
using OpenQA.Selenium.Interactions;
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

        public WatchHomeWorksAsStudentStepDefinitions()
        {
            _registrationPage = new RegistrationPage();
            _authPage = new AuthPage();
            _studentPage= new StudentPage();
        }

        [Given(@"open  registration page")]
        public void GivenOpenRegistrationPage()
        {
            DriverStorage storage = DriverStorage.GetDriverStorage();

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
            
            _registrationPage.EnterBirthDate(tablica.BirthDate);
            _registrationPage.EnterPassword(tablica.Password);
            _registrationPage.EnterRepeatPassword(tablica.RepeatPassword);
            _registrationPage.EnterEmail(tablica.Email);
            _registrationPage.EnterPhone(tablica.Phone);
        }


        [Given(@"Click  button registered")]
        public void GivenClickButtonRegistered()
        {
            _registrationPage.ClickCheckButton();
            _registrationPage.ClickButtonRegistration();
            Thread.Sleep(500);
        }

        [Given(@"Must  come out inscription ""([^""]*)""")]
        public void GivenMustComeOutInscription(string expected)
        {
            DriverStorage storage = DriverStorage.GetDriverStorage();

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

        [Given(@"fill  form")]
        public void GivenFillForm(Table table)
        {
            var tablica = table.CreateInstance<AuthModel>();
            _authPage.EnterLogin(tablica.email);
            _authPage.EnterPassword(tablica.password);

        }

        [Given(@"press  button sing in")]
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