using GryffindorQAA.Support;
using System;
using System.Collections.Generic;
namespace GryffindorQAA.Pages
{
    public class TeacherPage:AbstractPage
    {
        public IWebElement DropDownRole => _driver.FindElement(By.XPath(@"//div[@class='drop-down-filter  left']"));
        public IWebElement SwitchRole => _driver.FindElement(By.XPath(@"//li[text()='Преподаватель']"));
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
    }
}
