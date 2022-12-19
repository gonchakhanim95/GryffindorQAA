using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
﻿using GryffindorQAA.Support;
﻿using GryffindorQAA.Drivers;
using OpenQA.Selenium.Interactions;

namespace GryffindorQAA.Pages
{
    public class RegistrationPage : AbstractPage
    {
        public IWebElement TextBoxLastname => _driver.FindElement(By.XPath(@"//input[@name='lastName']"));
        public IWebElement TextBoxFirstname => _driver.FindElement(By.XPath(@"//input[@name='firstName']"));
        public IWebElement TextBoxPatronymic => _driver.FindElement(By.XPath(@"//input[@name='patronymic']"));
        public IWebElement TextBoxBirthDate => _driver.FindElement(By.XPath(@"//input[@class='form-control']"));
        public IWebElement TextBoxPassword => _driver.FindElement(By.XPath(@"//input[@name='password']"));
        public IWebElement TextBoxRepeatPassword => _driver.FindElement(By.XPath(@"//input[@name='confirmPassword']"));
        public IWebElement TextBoxEmail => _driver.FindElement(By.XPath(@"//input[@name='email']"));
        public IWebElement TextBoxPhoneNumb => _driver.FindElement(By.XPath(@"//input[@name='phoneNumber']"));
        public IWebElement TextCheckBox => _driver.FindElement(By.XPath(@"//label[@class='custom-checkbox']"));
        public IWebElement ButtonRegistration => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']"));
        public IWebElement ButtonChangeToAuth => _driver.FindElement(By.XPath(@"//a[@class='auth-link']"));
        
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.RegistrationPage);
        }

        public void EnterLastname(string text)
        {

            TextBoxLastname.SendKeys(text);
        }

        public void EnterFirstname(string text)
        {
            TextBoxFirstname.SendKeys(text);
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
        public void EnterPhoneNumb(string text)
        {
            TextBoxPhoneNumb.SendKeys(text);
        }
        public void EnterPhone(string text)
        {
            TetxBoxPhone.SendKeys(text);
        }
        public void ClickButtonRegistration()
        {
            ButtonRegistration.Click();
        }
        public void ClickCheckBoxButton()
        {
            TextCheckBox.Click();
        }
        public void ClickCheckButton()
        {
            TextCheckBox.Click();
        }

        public void ClickChangeButtonToAuth()
        {
            ButtonChangeToAuth.Click();
        }
    }
}