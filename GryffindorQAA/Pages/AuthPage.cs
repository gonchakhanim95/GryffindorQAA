using GryffindorQAA.Support;
using System;
namespace GryffindorQAA.Pages
{
    public class AuthPage:AbstractPage
    { 
        public IWebElement TextBoxEmail => _driver.FindElement(By.XPath(@"//input[@name='email']"));
        public IWebElement TextBoxPassword => _driver.FindElement(By.XPath(@"//input[@name='password']"));
        public IWebElement ButtonSignIn
        {
            get 
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']")));
            }
        }
        public IWebElement ButtonChangePage => _driver.FindElement(By.XPath(@"//a[text()='Регистрация']"));
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.AuthPage);
        }
        public void SkipSecure()
        {
            string xpath = @"//button[@class='secondary-button small-link']";
            _driver.FindElement(By.XPath(xpath)).Click();
            xpath = @"//a[@class='small-link']";
            _driver.FindElement(By.XPath(xpath)).Click();
        }
        public void EnterEmail(string text)
        {
            TextBoxEmail.SendKeys(text);
        }
        public void EnterPassword(string text)
        {
            TextBoxPassword.Clear();
            TextBoxPassword.SendKeys(text);
        }
        
        public void ClickButtonSignIn()
        {
            ButtonSignIn.Click();
        }
        public void ClickButtonChangePage()
        {
            ButtonChangePage.Click();
        }
    }
}