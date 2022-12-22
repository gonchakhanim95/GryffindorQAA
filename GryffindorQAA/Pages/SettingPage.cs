using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryffindorQAA.Pages
{
    public class SettingPage : AbstractPage
    {
        public IWebElement TextBoxLastName => _driver.FindElement(By.XPath(@"//input[@name='lastName']"));
        public IWebElement TextBoxFirstName => _driver.FindElement(By.XPath(@"//input[@name='firstName']"));
        public IWebElement TextBoxPatronymic => _driver.FindElement(By.XPath(@"//input[@name='patronymic']"));
        public IWebElement TextBoxBirthDate => _driver.FindElement(By.XPath(@"//input[@class='form-control']"));
        public IWebElement TextBoxOldPassword => _driver.FindElement(By.XPath(@"//input[@name='confirmPassword']"));
        public IWebElement TextBoxNewPassword => _driver.FindElement(By.XPath(@"//input[@name='newPassword']"));
        public IWebElement TextBoxRepeatNewPassword => _driver.FindElement(By.XPath(@"//input[@name='newPasswordRepeat']"));
        public IWebElement TextBoxEmail => _driver.FindElement(By.XPath(@"//input[@name='email']"));
        public IWebElement TextBoxGitHub => _driver.FindElement(By.XPath(@"//input[@name='gitHubAccount']"));
        public IWebElement TextBoxPhone => _driver.FindElement(By.XPath(@"//input[@name='phoneNumber']"));
        public IWebElement ButtonSave => _driver.FindElement(By.XPath(@"//button[text()='Сохранить']"));
        public IWebElement ButtonChangeToPassword => _driver.FindElement(By.XPath(@"//a[@href='/change-password']"));
        public IWebElement ButtonBack => _driver.FindElement(By.XPath(@"//div[text()='Назад']"));
    
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.SettingPage);
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

        public void EnterBirthDate(string text)
        {
            TextBoxBirthDate.SendKeys(text);
           DriverStorage storage = DriverStorage.GetInstance();

            string xpath = @"//input[@class='form-control']";
            IWebElement birthDateBar = storage.Driver.FindElement(By.XPath(xpath));
            Actions action = new Actions(storage.Driver);
            action.DoubleClick(birthDateBar).Perform();
            TextBoxBirthDate.SendKeys(text);
        }
        
        public void EnterChangeToPassword()
        {
            ButtonChangeToPassword.Click();
        }
        public void EnterOldPassword(string text)
        {
            TextBoxOldPassword.SendKeys(text);
        }
        public void EnterNewPassword(string text)
        {
            TextBoxNewPassword.SendKeys(text);
        }
        public void EnterRepeateNewPassword(string text)
        {
            TextBoxRepeatNewPassword.SendKeys(text);
        }
        public void EnterEmail(string text)
        {
            TextBoxEmail.SendKeys(text);
        }
        public void EnterGitHub(string text)
        {
            TextBoxGitHub.SendKeys(text);
        }
        public void EnterPhone(string text)
        {
            TextBoxPhone.SendKeys(text);
        }
        public void EnterSave()
        {
            ButtonSave.Click();
        }
        public void ClickButtonBack()
        {
            ButtonBack.Click();
        }
    } 
}
