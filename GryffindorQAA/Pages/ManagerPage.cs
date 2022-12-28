namespace GryffindorQAA.Pages
{
    public class ManagerPage:AbstractPage
    {
        public IWebElement ButtonListStudents => _driver.FindElement(By.XPath(@"//span[text()='Список студентов']"));
        public IWebElement ButtonFilterStudents => _driver.FindElement(By.XPath(@"//div[text()='Сортировать по фамилии']"));
        public IWebElement ButtonChangeFilter => _driver.FindElement(By.XPath(@"//li[text()='Сортировать обратно']"));
        public IWebElement ButtonUsers => _driver.FindElement(By.XPath(@"//span[text()='Все пользователи']"));
        public IWebElement ButtonPaymentTable => _driver.FindElement(By.XPath(@"//span[text()='Таблица оплат']"));
        public IWebElement DropDownRole
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//div[@class = 'user-roles-wrapper']/div[@class = 'drop-down-filter__wrapper']/div[@class='drop-down-filter  left']")));
            }
        }
        public IWebElement SwitchRoleOnManager
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(6));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//li[text()='Менеджер']")));
            }
        }
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.HomePage);
        }

        public void ClickButtonListStudents()
        {
            ButtonListStudents.Click();
        }
        public void ClickFilterStudents()
        {
            ButtonFilterStudents.Click();
        }
        public void ClickButtonChangeFilter()
        {
            ButtonChangeFilter.Click();
        }
        public void ClickOnRole()
        {
            DropDownRole.Click();
        }
        public void ClickButtongChangeRoleManager()
        {
            SwitchRoleOnManager.Click();
        }
        public void ClickButtonUsers()
        {
            ButtonUsers.Click();
        }
        public void ClickPaymentTable()
        {
            ButtonPaymentTable.Click();
        }
    }
}