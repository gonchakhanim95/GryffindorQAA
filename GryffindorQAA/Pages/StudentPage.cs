using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GryffindorQAA.Support;

namespace GryffindorQAA.Pages
{
    public class StudentPage :AbstractPage
    {
        public IWebElement ButtonHomeWork => _driver.FindElement(By.XPath(@"//span[text()='Домашние задания']"));

        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.HomeWorkPage);
        }
        public void ClickHomeWork()
        {
            ButtonHomeWork.Click();
        }
    }
}