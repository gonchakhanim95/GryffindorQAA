using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryffindorQAA.Pages
{
    public class HomeworkViewPage:AbstractPage
    {
        public IWebElement ButtonInHomework=> _driver.FindElement(By.XPath(@"//a[text()='к заданию']"));
        public IWebElement HomeworkName
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//span[@class = 'homework-title']")));

            }
        }


        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.NewHomeworkPage);
        }
        public void ClickButtonInHomework()
        {
            ButtonInHomework.Click();
        }
        public string GetHomeworkName()
        {
            return HomeworkName.Text;
        }
    }
}
