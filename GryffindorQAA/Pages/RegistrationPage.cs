namespace GryffindorQAA.Pages
{
    public class RegistrationPage : AbstractPage
    {
        public IWebElement TextBoxLastName => _driver.FindElement(By.XPath(@"//input[@name='lastName']"));
        public IWebElement TextBoxFirstName => _driver.FindElement(By.XPath(@"//input[@name='firstName']"));
        public IWebElement TextBoxPatronymic => _driver.FindElement(By.XPath(@"//input[@name='patronymic']"));
        public IWebElement TextBoxBirthDate => _driver.FindElement(By.XPath(@"//input[@class='form-control']"));
        public IWebElement TextBoxPassword => _driver.FindElement(By.XPath(@"//input[@name='password']"));
        public IWebElement TextBoxRepeatPassword => _driver.FindElement(By.XPath(@"//input[@name='confirmPassword']"));
        public IWebElement TextBoxEmail => _driver.FindElement(By.XPath(@"//input[@name='email']"));
        public IWebElement TextBoxPhone => _driver.FindElement(By.XPath(@"//input[@name='phoneNumber']"));
        public IWebElement CheckBox => _driver.FindElement(By.XPath(@"//label[@class='custom-checkbox']"));
        public IWebElement ButtonChangeToAuth => _driver.FindElement(By.XPath(@"//a[@class='auth-link']"));
        public IWebElement ButtonRegistration
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(6));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']")));
            }
        }
        
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.RegistrationPage);
        }

        public void EnterLastName(string text)
        {

            TextBoxLastName.SendKeys(text);
        }

        public void EnterFirstName(string text)
        {
            TextBoxFirstName.SendKeys(text);
        }
        public void EnterParonymic(string text)
        {
            TextBoxPatronymic.SendKeys(text);
        }
        public void EnterBrithDate(string text)
        {
            DriverStorage storage = DriverStorage.GetInstance();

            string xpath = @"//input[@class='form-control']";
            IWebElement birthDateBar = storage.Driver.FindElement(By.XPath(xpath));
            Actions action = new Actions(storage.Driver);
            action.DoubleClick(birthDateBar).Perform();
            TextBoxBirthDate.SendKeys(text);
        }
        public void EnterPassword(string text)
        {
            TextBoxPassword.SendKeys(text);
        }
        public void EnterRepeatPassword(string text)
        {
            TextBoxRepeatPassword.SendKeys(text);
        }
        public void EnterEmail(string text)
        {
            TextBoxEmail.SendKeys(text);
        }
        public void EnterPhoneNumber(string text)
        {
            TextBoxPhone.SendKeys(text);
        }
        public void ClickButtonRegistration()
        {
            ButtonRegistration.Click();
        }
        public void ClickButtonCheckBox()
        {
            CheckBox.Click();
        }

        public void ClickChangeButtonToAuth()
        {
            ButtonChangeToAuth.Click();
        }
        public string GetTextNotification()
        {
            return TextNotiification.Text;
        }
    }
}