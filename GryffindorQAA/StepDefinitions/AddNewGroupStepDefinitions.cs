using GryffindorQAA.BackModel;
using GryffindorQAA.Client;
using GryffindorQAA.Drivers;
using GryffindorQAA.Models;
using GryffindorQAA.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class AddNewGroupStepDefinitions
    {
        ClientClient _client;
        AuthPage _authPage;
        ManagersPage _managersPage;
        AdminPage _adminPage;
        public static string Email;
        private string _adminToken;
        private int _idAdmin;

        public AddNewGroupStepDefinitions()
        {
            _authPage = new AuthPage();
            _managersPage = new ManagersPage();
            _client = new ClientClient();
            _adminPage= new AdminPage();
        }

        [Given(@"Created new user")]
        public void GivenCreatedNewUser(Table table)
        {
            var tablica = table.CreateSet<RegistrationRequestModel>().ToList();
            Email = tablica[0].Email;
            _idAdmin = _client.Registration(tablica[0]);
        }

        [Given(@"Auth as admin")]
        public void GivenAuthAsAdmin(Table table)
        {
            var tablica = table.CreateSet<AuthRequestModel>().ToList();
            _adminToken = _client.Auth(tablica[0]);
        }

        [Given(@"Give role Admin to the new user")]
        public void GivenGiveRoleAdminToTheNewUser()
        {
            _client.GiveRoleManager(_adminToken, _idAdmin);
        }

        [Given(@"Auth as new Admin")]
        public void GivenAuthAsNewAdmin(Table table)
        {
            var tablica = table.CreateSet<AuthRequestModel>().ToList();
            _adminToken = _client.Auth(tablica[0]);
        }

        [Given(@"Create new group Slyzerin")]
        public void GivenCreateNewGroupSlyzerin()
        {
            throw new PendingStepException();
        }

        [When(@"Open auth Web page")]
        public void WhenOpenAuthWebPage()
        {
            DriverStorage storage = DriverStorage.GetInstance();
            _authPage.Open();
            string xpath = @"/html/body/div/div[2]/button[3]";
            storage.Driver.FindElement(By.XPath(xpath)).Click();
            xpath = @"/html/body/div/div[3]/p[2]/a";
            storage.Driver.FindElement(By.XPath(xpath)).Click();
        }

        [When(@"Auth as our admin")]
        public void WhenAuthAsOurAdmin(Table table)
        {
            var tablica = table.CreateInstance<AuthModel>();
            _authPage.EnterLogin(tablica.Email);
            _authPage.EnterPassword(tablica.Password);
        }

        [When(@"Change mine role on Admin")]
        public void WhenChangeMineRoleOnAdmin()
        {
            _adminPage.ClickButtonOnRole();
            _adminPage.ClickButtonChangeRoleAdmin();
        }

        [When(@"Click button group")]
        public void WhenClickButtonGroup()
        {
            _adminPage.ClickButtonGroup();
        }

        [When(@"Select new Slyzerin")]
        public void WhenSelectNewSlyzerin()
        {
            throw new PendingStepException();
        }

        [Then(@"View group Slyzerin")]
        public void ThenViewGroupSlyzerin()
        {
            throw new PendingStepException();
        }
    }
}
