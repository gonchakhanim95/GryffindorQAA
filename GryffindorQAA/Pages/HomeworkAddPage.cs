namespace GryffindorQAA.Pages
{
    public class HomeworkAddPage : AbstractPage
    {
        public IWebElement SwitchRole => _driver.FindElement(By.XPath(@"//li[text()='Преподаватель']"));
        public IWebElement CheckGroup => _driver.FindElement(By.XPath(@"//span[text()='Group1']"));
        public IWebElement TextBoxEndDate => _driver.FindElement(By.XPath(@"//div[text()='Срок сдачи задания']/div[@class='rdt']/div/div[@class='date-picker form-input ']/input"));
        public IWebElement TextBoxTaskName => _driver.FindElement(By.XPath(@"//div[text()='Название задания']/input"));
        public IWebElement TextBoxTaskDescription => _driver.FindElement(By.XPath(@"//div[text()='Описание задания']/textarea"));
        public IWebElement TextBoxTaskLinks => _driver.FindElement(By.XPath(@"//textarea[@placeholder='Вставьте ссылку']"));
        public IWebElement LinkButton => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ kEeNDb btn btn-fill ellipse flex-container']"));
        public IWebElement TextBoxCreate => _driver.FindElement(By.XPath(@"//button[text()='Опубликовать']"));
        public IWebElement DropDownRole
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//div[@class='drop-down-filter  left']")));
            }
        }
        public IWebElement TextBoxStartDate
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//div[text()='Дата выдачи задания']/div[@class='rdt']/div/div[@class='date-picker form-input ']/input")));

            }
        }

        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.NewHomeworkPage);
        }
        public void ClickDropDownRole()
        {
            DropDownRole.Click();
        }
        public void ClickSwitchRole()
        {
            SwitchRole.Click();
        }
        public void ClickCheckGroup()
        {
            CheckGroup.Click();
        }
        public void EnterStartDate(string text)
        {
            DriverStorage storage = DriverStorage.GetInstance();

            IWebElement StardateBar = storage.Driver.FindElement(By.XPath(@"//div[text()='Дата выдачи задания']/div[@class='rdt']/div/div[@class='date-picker form-input ']/input"));
            Actions action = new Actions(storage.Driver);
            action.DoubleClick(StardateBar).SendKeys(text).Build().Perform();
        }
        public void EnterEndDate(string text)
        {
            DriverStorage storage = DriverStorage.GetInstance();

            IWebElement EnddateBar = storage.Driver.FindElement(By.XPath(@"//div[text()='Срок сдачи задания']/div[@class='rdt']/div/div[@class='date-picker form-input ']/input"));
            Actions action = new Actions(storage.Driver);
            action.DoubleClick(EnddateBar).SendKeys(text).Build().Perform();
        }
        public void EnterTaskName(string text)
        {
            TextBoxTaskName.SendKeys(text);
        }
        public void EnterTaskDescription(string text)
        {
            TextBoxTaskDescription.SendKeys(text);
        }
        public void AddTaskLinks(List<string> text)
        {
            foreach (string link in text)
            {
                TextBoxTaskLinks.SendKeys(link);
            }
        }
        public void ClickLinkButton()
        {
            LinkButton.Click();
        }
        public void ClickCreateButton()
        {
            TextBoxCreate.Click();
        }
    }
}
