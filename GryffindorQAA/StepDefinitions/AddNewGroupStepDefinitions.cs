using GryffindorQAA.BackModel;
using GryffindorQAA.Client;
using GryffindorQAA.Models;
using GryffindorQAA.Pages;
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
        private int _idTutor;
        private int _idTeacher;

        public AddNewGroupStepDefinitions()
        {
            _authPage = new AuthPage();
            _managersPage = new ManagersPage();
            _client = new ClientClient();
            _adminPage = new AdminPage();
        }
        [Given(@"Created new user")]
        public void GivenCreatedNewUser(Table table)
        {
            var tablica = table.CreateSet<RegistrationRequestModel>().ToList();
            Email = tablica[0].Email;
            _idTutor = _client.Registration(tablica[0]);
            Email = tablica[1].Email;
            _idTeacher = _client.Registration(tablica[1]);
        }

        [Given(@"Auth as admin")]
        public void GivenAuthAsAdmin(Table table)
        {
            var tablica = table.CreateSet<AuthRequestModel>().ToList();
            _adminToken = _client.Auth(tablica[0]);
        }

        [Given(@"Give role Teacher to the new user")]
        public void GivenGiveRoleTeacherToTheNewUser()
        {
            _client.GiveRoleTeacher(_adminToken, _idTeacher);
        }

        [Given(@"Give role Tutor to the new user")]
        public void GivenGiveRoleTutorToTheNewUser()
        {
            _client.GiveRoleTutor(_adminToken, _idTutor);
        }

        [Given(@"Open auth Web page")]
        public void GivenOpenAuthWebPage()
        {
            _authPage.Open();
        }

        [Given(@"Fill out form for manager")]
        public void GivenFillOutFormForManager(Table table)
        {
            var tablica = table.CreateSet<AuthModel>().ToList();
            
        }

        [Given(@"Click sig in button")]
        public void GivenClickSigInButton()
        {
            throw new PendingStepException();
        }

        [When(@"Click button create group")]
        public void WhenClickButtonCreateGroup()
        {
            throw new PendingStepException();
        }

        [When(@"Enter group name")]
        public void WhenEnterGroupName()
        {
            throw new PendingStepException();
        }

        [When(@"Select Tutor and select Teacher")]
        public void WhenSelectTutorAndSelectTeacher()
        {
            throw new PendingStepException();
        }

        [When(@"Click button save")]
        public void WhenClickButtonSave()
        {
            throw new PendingStepException();
        }

        [When(@"Open groups")]
        public void WhenOpenGroups()
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
