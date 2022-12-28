namespace GryffindorQAA.Pages
{
    public class AdminPage : AbstractPage
    {
        public IWebElement ButtonOnRole => _driver.FindElement(By.XPath(@"//div[@class='drop-down-filter  left']"));
        public IWebElement ButtonChanheRoleAdmin => _driver.FindElement(By.XPath(@"//div[text()='Администратор']"));
        public IWebElement ButtonSaveGroup => _driver.FindElement(By.XPath(@"//button[text()='Сохранить']"));
        public IWebElement NameGroup => _driver.FindElement(By.XPath(@"//div[text()='Bryaka']"));
        public IWebElement ButtonGroup
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//span[text()='Группы']")));
            }
        }
        public IWebElement ButtonCreatGroup
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//span[text()='Создать группу']")));
            }
        }
        public IWebElement TextBoxNameGroup
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//input[@name='name']")));
            }
        }
        public IWebElement CheckSelectTutor
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//span[text()='Albus Dumbledore']")));
            }
        }
        public IWebElement CheckSelectTeacher
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//span[text()='Severus Snape']")));
            }
        }
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.HomePage);
        }
        public void ClickButtonOnRole()
        {
            ButtonOnRole.Click();
        }
        public void ClickButtonChangeRoleAdmin()
        {
            ButtonChanheRoleAdmin.Click();
        }
        public void ClickButtonGroup()
        {
            ButtonGroup.Click();
        }
        public void ClickButtonCreatGroup()
        {
            ButtonCreatGroup.Click();
        }
        public void EnterNameGroup(string name)
        {
            Actions actions = new Actions(_driver);
            actions.Click(TextBoxNameGroup).SendKeys(name).Build().Perform();
        }
        public void ClickCheckSelectTutor()
        {
            CheckSelectTutor.Click();
        }
        public void ClickCheckSelectTeacher()
        {
            CheckSelectTeacher.Click();
        }
        public void ClickButtonSaveGroup()
        {
            ButtonSaveGroup.Click();
        }
        public string GetNameGroup()
        {
            NameGroup.Click();
            return NameGroup.Text;
        }
    }
}
