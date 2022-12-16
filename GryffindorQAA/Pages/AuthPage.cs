using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GryffindorQAA.Support;

namespace GryffindorQAA.Pages
{
    public class AuthPage : AbstractPage
    {
        public IWebElement Login => _driver.FindElement(By.XPath(@"//input[@name='email']"));
        public IWebElement Password => _driver.FindElement(By.XPath(@"//input[@name='password']"));
        public IWebElement ButtonSingIn => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']"));

        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.AuthPage);
        }

        public void EnterLogin(string text)
        {
            Login.Clear();
            Login.SendKeys(text);
        }

        public void EnterPassword(string text)
        {
            Login.SendKeys(text);
        }

        public void ClickButtonSingIn()
        {
            ButtonSingIn.Click();
        }
    }
}
