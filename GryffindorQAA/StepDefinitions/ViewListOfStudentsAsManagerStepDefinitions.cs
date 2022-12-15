using GryffindorQAA.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class ViewListOfStudentsAsManagerStepDefinitions
    {
        private WebDriver _driver;
        [Given(@"Registration as student")]
        public void GivenRegistrationAsStudent(Table table)
        {
            throw new PendingStepException();
        }

        [Given(@"Auth as Admin")]
        public void GivenAuthAsAdmin()
        {
            throw new PendingStepException();
        }

        [Given(@"Get all list students")]
        public void GivenGetAllListStudents()
        {
            throw new PendingStepException();
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
