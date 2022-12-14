using GryffindorQAA.Support;
using OpenQA.Selenium.Interactions;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class WatchHomeWorksAsStudentStepDefinitions
    {
        WebDriver _driver;
        [Given(@"open  registration page")]
        public void GivenOpenRegistrationPage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(Urls.RegistrationPage);

            string xpath = @"/html/body/div/div[2]/button[3]"; // xpath kak pravilno pisat? class, name, id, ? ili mojno i to i druqoe. 
            _driver.FindElement(By.XPath(xpath)).Click();
            xpath = @"/html/body/div/div[3]/p[2]/a";
            _driver.FindElement(By.XPath(xpath)).Click();

            xpath = @"//a[@class='auth-link']";
            _driver.FindElement(By.XPath(xpath)).Click();
        }

        [Given(@"Fill  out form")]
        public void GivenFillOutForm(Table table)
        {  
            string xpath = @"//input[@id='lastName']";
            _driver.FindElement(By.XPath(xpath)).SendKeys("Saidli");
            xpath = @"//input[@id='firstName']";
            _driver.FindElement(By.XPath(xpath)).SendKeys("Farid");
            xpath = @"//input[@name='patronymic']";
            _driver.FindElement(By.XPath(xpath)).SendKeys("Ahmed");

            xpath = @"//input[@class='form-control']";
            IWebElement birthDateBar = _driver.FindElement(By.XPath(xpath));
            Actions action = new Actions(_driver);
            action.DoubleClick(birthDateBar).Perform();
            _driver.FindElement(By.XPath(xpath)).SendKeys("03.08.1999");

            xpath = @"//input[@name='password']";
            _driver.FindElement(By.XPath(xpath)).SendKeys("salamsalam");
            xpath = @"//input[@name='confirmPassword']";
            _driver.FindElement(By.XPath(xpath)).SendKeys("salamsalam");
            xpath = @"//input[@name='email']";
            _driver.FindElement(By.XPath(xpath)).SendKeys("saidlifarid@mail.ru");
            xpath = @"//input[@name='phoneNumber']";
            _driver.FindElement(By.XPath(xpath)).SendKeys("+78885551122");
        }

        [Given(@"Click  button registered")]
        public void GivenClickButtonRegistered()
        {
            string xpath = @"//label[@class='custom-checkbox']";
            _driver.FindElement(By.XPath(xpath)).Click();

            xpath = @"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']";
            _driver.FindElement(By.XPath(xpath)).Click();
            Thread.Sleep(500);
        }

        [Given(@"Must  come out inscription ""([^""]*)""")]
        public void GivenMustComeOutInscription(string expected)
        {
            string xpath = @"//p[@class='notification-text']";
            IWebElement button = _driver.FindElement(By.XPath(xpath));
            string actual = button.Text;
            Assert.Equal(expected, actual);
        }

        [Given(@"Open  Auth as student")]
        public void GivenOpenAuthAsStudent()
        {
            string xpath = @"//a[@class='auth-link']";
            _driver.FindElement(By.XPath(xpath)).Click();
        }

        [Given(@"fill  form")]
        public void GivenFillForm(Table table)
        {
            string xpath = @"//input[@name='email']";
            _driver.FindElement(By.XPath(xpath)).SendKeys("saidlifarid@mail.ru");
            xpath = @"//input[@name='password']";
            _driver.FindElement(By.XPath(xpath)).Clear();
            _driver.FindElement(By.XPath(xpath)).SendKeys("salamsalam");

        }

        [Given(@"press  button sing in")]
        public void GivenPressButtonSingIn()
        {
            string xpath = @"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']";
            _driver.FindElement(By.XPath(xpath)).Click();
        }

        [Given(@"Should  entered into system")]
        public void GivenShouldEnteredIntoSystem()
        {
            string expected = Urls.HomePage;
            string actual = Urls.AuthPage;
            Assert.NotEqual(expected, actual);
            Thread.Sleep(1000);
        }

        [When(@"Select homeworks")]
        public void WhenSelectHomeworks()
        {
            string xpath = @"//span[text()='Домашние задания']";
            _driver.FindElement(By.XPath(xpath)).Click();
        }

        [Then(@"View  homeworks")]
        public void ThenViewHomeworks()
        {
            string expected = Urls.HomeWorkPage;
            string actual = Urls.HomePage;
            Assert.NotEqual(expected, actual);
        }
    }
}