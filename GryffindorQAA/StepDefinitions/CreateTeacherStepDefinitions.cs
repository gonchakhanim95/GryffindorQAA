using GryffindorQAA.BackModel;
using GryffindorQAA.Client;
using GryffindorQAA.Drivers;
using GryffindorQAA.Models;
using GryffindorQAA.Pages;
using TechTalk.SpecFlow.Assist;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class CreateTeacherStepDefinitions
    {
        AuthPage _authPage;

        public static string Email;
        private string _adminToken;
        private int _idTeacher;

        MetodsForSwagger client = new MetodsForSwagger();

        public CreateTeacherStepDefinitions()
        {
            _authPage = new AuthPage();
        }


        [Given(@"Registration new User")]
        public void GivenRegistrationNewUser(Table table)
        {
            var tab = table.CreateSet<RequestRegistrationModel>().ToList();
            Email = tab[0].Email;
            _idTeacher = client.RegistrationNewUser(tab[0]);
        }

        [Given(@"Authoraized as admin")]
        public void GivenAuthoraizedAsAdmin(Table table)
        {
            var tab = table.CreateSet<AuthModel>().ToList();

            _adminToken = client.AuthAsAdmin(tab[0]);
        }

        [Given(@"Give role teacher to the new User")]
        public void GivenGiveRoleTeacherToTheNewUser()
        {
            client.GiveRoleToTheTeacher(_idTeacher,_adminToken);
        }

        [When(@"Open auuthorization page")]
        public void WhenOpenAuuthorizationPage()
        {
            _authPage.Open();
        }

        [When(@"Skip bezopasnost")]
        public void WhenSkipBezopasnost()
        {
            string xpath = @"/html/body/div/div[2]/button[3]";
            DriverStorage.GetInstance().Driver.FindElement(By.XPath(xpath)).Click();
            xpath = @"/html/body/div/div[3]/p[2]/a";
            DriverStorage.GetInstance().Driver.FindElement(By.XPath(xpath)).Click();
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
            _authPage.ClickSignButton();
            Thread.Sleep(1500);
            
        }

        [Then(@"Login as a teacher")]
        public void ThenLoginAsATeacher()
        {
            string expected = "Преподаватель";
            string actual = _authPage.GetTextDropDownRole();
            Assert.Equal(expected, actual);
        }
    }
}


