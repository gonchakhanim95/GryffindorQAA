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
        public FilterPaymentTableAsManagerStepDefinitions()
        {
            clientt = new Clientt();
            _authPage = new AuthPage();
            _managerPage = new ManagerPage();
            _paymentTablePage = new PaymentTablePage();
        }

        [Given(@"Registartion Users for Student")]
        public void GivenRegistartionUsersForStudent(Table table)
        {
            var tab = table.CreateSet<RequestRegistrationModel>().ToList();
            for (int i = 0; i < tab.Count; i++)
            {
                Emails.Add(tab[i].Email);
            }
            Variables.GetInstance().StudentsId.Add(clientt.Registration(tab[0]));
            Variables.GetInstance().StudentsId.Add(clientt.Registration(tab[1]));
            Variables.GetInstance().StudentsId.Add(clientt.Registration(tab[2]));
            Variables.GetInstance().StudentsId.Add(clientt.Registration(tab[3]));


        }

        [Given(@"Registration User for Manager")]
        public void GivenRegistrationUserForManager(Table table)
        {
            var tab = table.CreateSet<RequestRegistrationModel>().ToList();
            Emails.Add(tab[0].Email);
            Variables.GetInstance().ManagerId = clientt.Registration(tab[0]);
        }
        [Given(@"Add New Students in Group")]
        public void GivenAddNewStudentsInGroup()
        {
            foreach (var item in Variables.GetInstance().StudentsId)
            {
                clientt.AddUserInGroup(Variables.GetInstance().GroupId, item, "Student", Variables.GetInstance().AdminToken);
            }
        }

        [Given(@"Give the role of a manager")]
        public void GivenGiveTheRoleOfAManager()
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
            _authPage.Open();
            _authPage.EnterEmail(tab[0].Email);
            _authPage.EnterPassword(tab[0].Password);
            _authPage.ClickButtonSignIn();
            _managerPage.ClickOnRole();
            _managerPage.ClickButtongChangeRoleManager();
        }

        [When(@"Open Payment table page")]
        public void WhenOpenPaymentTablePage()
        {
            _paymentTablePage.Open();
        }

        [Then(@"Filter name column")]
        public void ThenFilterNameColumn()
        {
            throw new PendingStepException();
        }

        [Then(@"Filter one payment column")]
        public void ThenFilterOnePaymentColumn()
        {
            throw new PendingStepException();
        }

        [Then(@"Filter two payment column")]
        public void ThenFilterTwoPaymentColumn()
        {
            throw new PendingStepException();
        }

        [Then(@"Filter three payment column")]
        public void ThenFilterThreePaymentColumn()
        {
            throw new PendingStepException();
        }

        [Then(@"Filter four payment column")]
        public void ThenFilterFourPaymentColumn()
        {
            throw new PendingStepException();
        }

    }
}
