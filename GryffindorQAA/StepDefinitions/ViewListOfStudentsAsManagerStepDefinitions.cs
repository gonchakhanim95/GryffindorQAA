using GryffindorQAA.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using GryffindorQAA.BackModel;
using GryffindorQAA.Client;
namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class ViewListOfStudentsAsManagerStepDefinitions
    {
        private WebDriver _driver;
        ClientClient client = new ClientClient();

        [Given(@"Registration as student")]
        public void GivenRegistrationAsStudent(Table table)
        {
            RegistrationRequestModel registrationRequestModel = new RegistrationRequestModel()
            {
                FirstName = "Daniel",
                LastName = "Martin",
                Patronymic = "Pitt",
                Email = "pofoi@gmail.com",
                Username = "Drep",
                Password = "daniello",
                City = "SaintPetersburg",
                BirthDate = "23.03.2003",
                GitHubAccount = "@drep33",
                PhoneNumber = "+78884445454"
            };
            var userId = client.RegistrationStudent(registrationRequestModel);
            AuthRequestModel auth = new AuthRequestModel()
            {
                Email = "marina@example.com",
                Password = "marina123456"
            };
            string token = client.Auth(auth);
            //List<UserResponseModel> user = client.GetUsers(token);
            client.GiveRole(token, userId);
        }
    }
}

        /*[Given(@"Auth as Admin")]
        public void GivenAuthAsAdmin()
        {

            
        }*/
/*
        [Given(@"Auth as Admin,Get all list students,Give the student the role of a manager")]
        public void GivenAuthAsAdminGetAllListStudentsGiveTheStudentTheRoleOfAManager()
        {
            AuthRequestModel auth = new AuthRequestModel()
            {
                Email = "marina@example.com",
                Password = "marina123456"
            };
            string token = client.Auth(auth);
            List<UserResponseModel> user = client.GetUsers(token);
            client.GiveRole(userId, token);
        }
*/

        /*[Given(@"Get all list students")]
        public void GivenGetAllListStudents()
        {
            ClientClient clientt = new ClientClient();
            List<UserResponseModel> user = clientt.
        }*/

        /*[Given(@"Give the student the role of a manager")]
        public void GivenGiveTheStudentTheRoleOfAManager()
        {
            throw new PendingStepException();
        }

        [Given(@"Open auth page")]
        public void GivenOpenAuthPage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(Urls.LogInPage);
            string xpacth = @"/html/body/div/div[2]/button[3]";
            IWebElement button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
            xpacth = @"/html/body/div/div[3]/p[2]/a";
            button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
        }

        [Given(@"Fill out form")]
        public void GivenFillOutForm(Table table)
        {
            throw new PendingStepException();
        }

        [Given(@"Click sing in")]
        public void GivenClickSingIn()
        {
            throw new PendingStepException();
        }

        [When(@"Click")]
        public void WhenClick()
        {
            throw new PendingStepException();
        }
    }
}
*/