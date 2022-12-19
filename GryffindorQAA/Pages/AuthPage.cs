using GryffindorQAA.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GryffindorQAA.Pages
{
    public class AuthPage:AbstractPage
    { 
        public IWebElement TextBoxEmail => _driver.FindElement(By.XPath(@"//input[@name='email']"));
        public IWebElement TextBoxPassword => _driver.FindElement(By.XPath(@"//input[@name='password']"));
        public IWebElement ButtonSingIn => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']"));
        public IWebElement TextBoxRoleDropDown => _driver.FindElement(By.XPath(@"//div[@class='drop-down-filter  left']"));
        public IWebElement SwitchRole => _driver.FindElement(By.XPath(@"/ html / body / div / div / aside / div / div[1] / div[2] / div / div / div / div[2] / ul / li[2]"));
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.AuthPage);

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
        public void ClickSignButton()
        {
            ButtonSingIn.Click();
        }
        public string GetTextDropDownRole()
        {
            TextBoxRoleDropDown.Click();
            SwitchRole.Click();

            return TextBoxRoleDropDown.Text;
        }
        public void EnterLogin(string text)
        {
            Login.Clear();
            Login.SendKeys(text);
        }

        public void ClickButtonSingIn()
        {
            ButtonSingIn.Click();
        }
    }
}