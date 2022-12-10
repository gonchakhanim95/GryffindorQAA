using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using GryffindorQAA.Support;
using System.IO;
using Gherkin.Ast;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class ViewListOfStudentsAsManagerStepDefinitions
    {
        public IWebDriver _driver;
        
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

        [When(@"Add email ""([^""]*)""")]
        public void WhenAddEmail(string emailText)
        {
            string xpacth = @"/html/body/div/div/main/div[1]/form/div[1]/input";
            IWebElement email= _driver.FindElement(By.XPath(xpacth));
            email.SendKeys(emailText);
        }

        [When(@"Add password ""([^""]*)""")]
        public void WhenAddPassword(string passwordText)
        {
            string xpacth = @"/html/body/div/div/main/div[1]/form/div[2]/input";
            IWebElement passsword = _driver.FindElement(By.XPath(xpacth));
            passsword.Clear();
            passsword.SendKeys(passwordText);
        }

        [When(@"Click button sing in")]
        public void WhenClickButtonSingIn() // ne menaet page
        {
            string xpacth = @"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']";
            IWebElement button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
        }

        [Then(@"is included in the system")]
        public void ThenIsIncludedInTheSystem() // ne raotaet
        {
            string expected = Urls.Page;
            string actual = _driver.Url;
            Assert.NotEqual(expected, actual);
        }

        [Given(@"Auth as Manage")]
        public void GivenAuthAsManage() // neznayu kak pisat'
        {
        }

        [When(@"Click to spisok studentov")]
        public void WhenClickToSpisokStudentov()
        {
            string xpacth = @"//span[@class='links-name transition-styles']";
            IWebElement list = _driver.FindElement(By.XPath(xpacth));
            list.Click();
        }

        [When(@"Filter by vice versa")]
        public void WhenFilterByLastname()
        {
            string xpacth = @"/html/body/div/div/main/div[1]/div[2]/div/div[1]/div/svg/path";
            IWebElement filter = _driver.FindElement(By.XPath(xpacth));
            filter.Click();
        }

        [Then(@"View a list of students")]
        public void ThenViewAListOfStudents()
        {
            string expected = @"https://piter-education.ru:7074/students-list";
            string actual = _driver.Url;
            Assert.NotEqual(expected, actual);
        }
    }
}
