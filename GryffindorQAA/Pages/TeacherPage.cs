using GryffindorQAA.Support;
using System;
using System.Collections.Generic;
namespace GryffindorQAA.Pages
{
    public class TeacherPage:AbstractPage
    {
        public IWebElement DropDownRole
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(6));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//div[@class='drop-down-filter  left']")));
            }
        }
        public IWebElement SwitchRole
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(6));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//li[text()='Преподаватель']")));
            }
        }
        public IWebElement ButtonAddLesson => _driver.FindElement(By.XPath(@"//span[text()='Добавить занятие']"));
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.AuthPage);
        }
        public string GetTextDropDownRole()
        {
            DropDownRole.Click();
            SwitchRole.Click();

            return DropDownRole.Text;
        }
        public void ClickButtonAddLesson()
        {
            ButtonAddLesson.Click();
        }
    }
}
