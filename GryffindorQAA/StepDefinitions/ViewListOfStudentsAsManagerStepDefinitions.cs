using GryffindorQAA.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using GryffindorQAA.BackModel;
using GryffindorQAA.Client;
using Gherkin;
using Newtonsoft.Json.Linq;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class ViewListOfStudentsAsManagerStepDefinitions
    {
        private WebDriver _driver;

        [Given(@"Registration as student")]
        public void GivenRegistrationAsStudent(Table table)
        {
            RegistrationRequestModel registrationRequestModel = new RegistrationRequestModel()
            {
                FirstName="Daniel",
                LastName="Martin",
                Patronymic="Pitt",
                Email="drep@gmail.com",
                Username="Drep",
                Password="daniello",
                City="Kurdemir",
                BirthDate= "23.03.2003",
                GitHubAccount= "23.03.2003",
                PhoneNumber= "+78884445454"
            };
            Clientt client = new Clientt();
            client.RegistrationStudent(registrationRequestModel);
        }

        [Given(@"Auth as Admin")]
        public void GivenAuthAsAdmin()
        {

            AuthRequestModel auth= new AuthRequestModel()
            {
                Email = "marina@example.com",
                Password = "marina123456"
            };
            Clientt client = new Clientt();
            string token = client.Auth(auth);
        }

        [Given(@"Get all list students")]
        public void GivenGetAllListStudents()
        {
            Clientt clientt = new Clientt();
            List<UserResponseModel> user = clientt.ShowAllUsers(token);
        }

        [Given(@"Give the student the role of a manager")]
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
