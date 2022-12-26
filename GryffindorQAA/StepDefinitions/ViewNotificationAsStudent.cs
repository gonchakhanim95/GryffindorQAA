using System;
using TechTalk.SpecFlow;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class ViewNotificationAsStudent
    {
        StudentPage _studentPage;
        AuthPage _authPage;
        RegistrationPage _registrationPage;
        public ViewNotificationAsStudent()
        {
            _studentPage = new StudentPage();
            _authPage = new AuthPage();
            _registrationPage = new RegistrationPage();
        }

        [Given(@"Open registration page")]
        public void GivenOpenRegistrationPage()
        {
            _authPage.Open();
            _authPage.SkipSecure();
            _authPage.ClickButtonChangePage();
        }

        [Given(@"Click button registered")]
        public void GivenClickButtonRegistered()
        {
            _registrationPage.ClickButtonRegistration();
        }

        [Given(@"Must come out inscription ""([^""]*)""")]
        public void GivenMustComeOutInscription(string expected)
        {
            DriverStorage storage = DriverStorage.GetInstance();
            string xpath = @"//p[@class='notification-text']";
            IWebElement button = storage.Driver.FindElement(By.XPath(xpath));
            string actual = button.Text;
            Assert.Equal(expected, actual);
        }

        [Given(@"Open Auth as student")]
        public void GivenOpenAuthAsStudent()
        {
            _authPage.Open();
        }

        [Given(@"Press button sign in")]
        public void GivenPressButtonSignIn()
        {
            _authPage.ClickButtonSignIn();
        }

        [When(@"Select chapter notification")]
        public void WhenSelectChapterNotification()
        {
            _studentPage.ClickNotification();
        }

        [Then(@"Get all notifications")]
        public void ThenGetAllNotifications()
        {
            
        }
    }
}
