using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Policy;
using TechTalk.SpecFlow;
using GryffindorQAA.Support;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class ViewHomeworkAsStudentStepDefinitions
    {
        private WebDriver _driver;
        [Given(@"Open Auth as student")]
        public void GivenOpenAuthAsStudent()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(Urls.HomePage);
            string xpacth = @"/html/body/div/div[2]/button[3]";
            IWebElement button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
            xpacth = @"/html/body/div/div[3]/p[2]/a";
            button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
        }

        [Given(@"fill form")]
        public void GivenFillForm(Table table)
        {
            string xpacth = @"/html/body/div/div/main/div[1]/form/div[1]/input";
            IWebElement email = _driver.FindElement(By.XPath(xpacth));
            email.SendKeys("said@mail.ru");
            xpacth = @"/html/body/div/div/main/div[1]/form/div[2]/input";
            IWebElement passsword = _driver.FindElement(By.XPath(xpacth));
            passsword.Clear();
            passsword.SendKeys("salamsalam");
        }

        [Given(@"press button sing in")]
        public void GivenPressButtonSingIn()
        {
            string xpacth = @"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']";
            IWebElement button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
        }

        [When(@"Select homeworks")]
        public void WhenSelectHomeworks()
        {
            string xpacth = @"/html/body/div/div/aside/div/nav/a[3]";
            IWebElement button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
            
        }

        [Then(@"View homeworks")]
        public void ThenViewHomeworks()
        {
            _driver.Navigate().GoToUrl(Urls.HomeWorkPage);
        }
    }
}
