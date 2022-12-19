using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GryffindorQAA.Support;

namespace GryffindorQAA.Pages
{
    public class AdminPage : AbstractPage
    {
        public IWebElement ButtonOnRole => _driver.FindElement(By.XPath(@"//div[@class='drop-down-filter  left']"));
        public IWebElement ButtonChanheRoleAdmin => _driver.FindElement(By.XPath(@"//div[text()='Администратор']"));
        public IWebElement ButtonGroup => _driver.FindElement(By.XPath(@"//span[text()='Группы']"));
        
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.HomePage);
        }
        public void ClickButtonOnRole()
        {
            ButtonOnRole.Click();
        }
        public void ClickButtonChangeRoleAdmin()
        {
            ButtonChanheRoleAdmin.Click();
        }
        public void ClickButtonGroup()
        {
            ButtonGroup.Click();
        }
    }
}
