namespace GryffindorQAA.Pages
{
    public class SettingPage : AbstractPage
    {
        public IWebElement TextBoxLastName => _driver.FindElement(By.XPath(@"//input[@name='lastName']"));
        public IWebElement TextBoxFirstName => _driver.FindElement(By.XPath(@"//input[@name='firstName']"));
        public IWebElement TextBoxPatronymic => _driver.FindElement(By.XPath(@"//input[@name='patronymic']"));
        public IWebElement TextBoxBirthDate => _driver.FindElement(By.XPath(@"//input[@class='form-control']"));
        public IWebElement TextBoxOldPassword => _driver.FindElement(By.XPath(@"//input[@name='oldPassword']"));
        public IWebElement TextBoxNewPassword => _driver.FindElement(By.XPath(@"//input[@name='newPassword']"));
        public IWebElement TextBoxRepeatNewPassword => _driver.FindElement(By.XPath(@"//input[@name='newPasswordRepeat']"));
        public IWebElement TextBoxEmail => _driver.FindElement(By.XPath(@"//input[@name='email']"));
        public IWebElement TextBoxGitHub => _driver.FindElement(By.XPath(@"//input[@name='gitHubAccount']"));
        public IWebElement TextBoxPhone => _driver.FindElement(By.XPath(@"//input[@name='phoneNumber']"));
        public IWebElement ButtonSave => _driver.FindElement(By.XPath(@"//button[text()='Сохранить']"));
        public IWebElement ButtonToChangePassword => _driver.FindElement(By.XPath(@"//a[@href='/change-password']"));
        public IWebElement ButtonBack => _driver.FindElement(By.XPath(@"//div[text()='Назад']")); 
        public IWebElement ButtonSetting => _driver.FindElement(By.XPath(@"//div[@class='svg-fond']"));
        public IWebElement ButtonPhotoProfile => _driver.FindElement(By.XPath(@"//span[@class='avatar-text']"));
        public IWebElement ButtonSelectPhoto => _driver.FindElement(By.XPath(@"//input[@type='submit']"));
        public override void Open()
        {
        }
        public void ClickButtonSetting()
        {
            WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//div[@class='svg-fond']")));
            ButtonSetting.Click();
        }
        public void ClickButtonPhotoProfile()
        {
            WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//div[@class='svg-text']")));
            ButtonPhotoProfile.Click();
        }
        public void ClickButtonSelectPhoto()
        {
            string scrypt = "document.querySelector('#root > div.modal-background > div > div.buttons-container > label > input').setAttribute('class','display')";
            _driver.ExecuteScript(scrypt);
            string filePath = "C:\\Users\\goncha\\Downloads\\1102284.jpg";
            _driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(filePath);
            ButtonSelectPhoto.Click();
        }

        public bool CheckProfilePhotoExists()
        {
            return _driver.FindElements(By.XPath(@"//img[@class='avatar-photo']")).Any();
        }
       /* public IWebElement ButtonSelectPhoto
        {
            get
            {

                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//img[@class='avatar-photo']")));
            }
        }*/
        public void EnterLastName(string text)
        {
            DriverStorage storage = DriverStorage.GetInstance();

            Actions action = new Actions(storage.Driver);
            action.DoubleClick(TextBoxLastName).Perform();
            TextBoxLastName.SendKeys(text);
        }
        public void EnterFirstName(string text)
        {
            TextBoxFirstName.Click();
            TextBoxFirstName.Clear();
            TextBoxFirstName.SendKeys(text);
        }
        public void EnterParonymic(string text)
        {
            DriverStorage storage = DriverStorage.GetInstance();

            Actions action = new Actions(storage.Driver);
            action.DoubleClick(TextBoxPatronymic).Perform();
            TextBoxPatronymic.SendKeys(text);
        }

        public void EnterBirthDate(string text)
        {
            TextBoxBirthDate.SendKeys(text);
           DriverStorage storage = DriverStorage.GetInstance();

            string xpath = @"//input[@class='form-control']";
            IWebElement birthDateBar = storage.Driver.FindElement(By.XPath(xpath));
            Actions action = new Actions(storage.Driver);
            action.DoubleClick(TextBoxBirthDate).Perform();
            TextBoxBirthDate.SendKeys(text);
        }
        public void ClickkChangeToPassword()
        {
            ButtonToChangePassword.Click();
        }
        public void EnterOldPassword(string text)
        {
            TextBoxOldPassword.Clear();
            TextBoxOldPassword.SendKeys(text);
        }
        public void EnterNewPassword(string text)
        {
            TextBoxNewPassword.Clear();
            TextBoxNewPassword.SendKeys(text);
        }
        public void EnterRepeateNewPassword(string text)
        {
            TextBoxRepeatNewPassword.Clear();
            TextBoxRepeatNewPassword.SendKeys(text);
        }
        public void EnterEmail(string text)
        {
            TextBoxEmail.Clear();
            TextBoxEmail.SendKeys(text);
        }
        public void EnterGitHub(string text)
        {
            TextBoxGitHub.SendKeys(text);
        }
        public void EnterPhone(string text)
        {
            TextBoxPhone.Clear();
            TextBoxPhone.SendKeys(text);
        }
        public void ClickButtonSave()
        {
            ButtonSave.Click();
        }
        public void ClickButtonBack()
        {
            ButtonBack.Click();
        }
    } 
}
