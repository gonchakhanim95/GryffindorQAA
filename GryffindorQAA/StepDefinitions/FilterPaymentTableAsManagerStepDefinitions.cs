using System;
using TechTalk.SpecFlow;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class FilterPaymentTableAsManagerStepDefinitions
    {
        Clientt clientt;
        public static List<string> Emails = new List<string>();
        AuthPage _authPage;
        ManagerPage _managerPage;
        PaymentTablePage _paymentTablePage;
        ManagerPage managerPage;
        public FilterPaymentTableAsManagerStepDefinitions()
        {
            clientt = new Clientt();
            _authPage = new AuthPage();
            _managerPage = new ManagerPage();
            _paymentTablePage = new PaymentTablePage();
            _managerPage = new ManagerPage();
        }

        [Given(@"Registration new User for Manager")]
        public void GivenRegistrationNewUserForManager(Table table)
        { 
            var tab = table.CreateSet<RequestRegistrationModel>().ToList();
            Emails.Add(tab[0].Email);
            Variables.GetInstance().ManagerId = clientt.Registration(tab[0]);
        }

        [Given(@"Add New Students in Group")]
        public void GivenAddNewStudentsInGroup()
        {
            clientt.AddUserInGroup(Variables.GetInstance().GroupId, Variables.GetInstance().StudentId, "Student", Variables.GetInstance().AdminToken);
        }
        [Given(@"Give role manager")]
        public void GivenGiveRoleManager()
        {
            clientt.GiveRole(Variables.GetInstance().AdminToken, Variables.GetInstance().ManagerId, "Manager");
        }

        [Given(@"Add Manager in Group")]
        public void GivenAddManagerInGroup()
        {
            clientt.AddUserInGroup(Variables.GetInstance().GroupId, Variables.GetInstance().ManagerId, "Manager", Variables.GetInstance().AdminToken);
        }

        [When(@"Authorized  as Manager")]
        public void WhenAuthorizedAsManager(Table table)
        {
            var tab = table.CreateSet<AuthRequestModel>().ToList();
            _authPage.EnterEmail(tab[0].Email);
            _authPage.EnterPassword(tab[0].Password);
            _authPage.ClickButtonSignIn();
            _managerPage.ClickOnRole();
            _managerPage.ClickButtongChangeRoleManager();
        }

        [When(@"Open Payment table page")]
        public void WhenOpenPaymentTablePage()
        {
            _managerPage.ClickPaymentTable();
        }

        [Then(@"Must be added Group in Payment page")]
        public void ThenMustBeAddedGroupInPaymentPage()
        {
            string expected = CreateHomeworkStepDefinitions.GroupName;
            _paymentTablePage.ClickShorAllGroups();
            string actual = _paymentTablePage.GetChecksGroupName();
            Assert.Equal(expected, actual);
        }
    }
}
