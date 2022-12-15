using GryffindorQAA.Support;

namespace GryffindorQAA.Pages
{
    public class RegistrationPage : AbstractPage
    {
        public IWebElement LastnameBox => _driver.FindElement(By.XPath(@"//input[@name='lastName']"));
        public IWebElement FirstnameBox => _driver.FindElement(By.XPath(@"//input[@name='firstName']"));
        public IWebElement PatronymicBox => _driver.FindElement(By.XPath(@"//input[@name='patronymic']"));
        public IWebElement BirthDateBox => _driver.FindElement(By.XPath(@"//input[@class='form-control']"));
        public IWebElement PasswordBox => _driver.FindElement(By.XPath(@"//input[@name='password']"));
        public IWebElement RepeatPasswordBox => _driver.FindElement(By.XPath(@"//input[@name='confirmPassword']"));
        public IWebElement EmailBox => _driver.FindElement(By.XPath(@"//input[@name='email']"));
        public IWebElement PhoneNumbBox => _driver.FindElement(By.XPath(@"//input[@name='phoneNumber']"));
        public IWebElement CheckBox => _driver.FindElement(By.XPath(@"//label[@class='custom-checkbox']"));
        public IWebElement ButtonRegistration => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']"));

        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.RegistrationPage);
        }

        public void EnterLastname(string text)
        {

            LastnameBox.SendKeys(text);
        }

        public void EnterFirstname(string text)
        {
            FirstnameBox.SendKeys(text);
        }

        public void EnterParonymic(string text)
        {
            PatronymicBox.SendKeys(text);
        }
        public void EnterBrithDate(string text)
        {
            BirthDateBox.SendKeys(text);
        }
        public void EnterPassword(string text)
        {
            PasswordBox.SendKeys(text);
        }
        public void EnterRepeatPassword(string text)
        {
            RepeatPasswordBox.SendKeys(text);
        }
        public void EnterEmail(string text)
        {
            EmailBox.SendKeys(text);
        }
        public void EnterPhoneNumb(string text)
        {
            PhoneNumbBox.SendKeys(text);
        }
        public void ClickButtonRegistration()
        {
            ButtonRegistration.Click();
        }
        public void ClickCheckButton()
        {
            CheckBox.Click();
        }
    }
}
