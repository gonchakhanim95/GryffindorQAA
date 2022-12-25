using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryffindorQAA.Pages
{
    public class HomeworkViewPage:AbstractPage
    {
        public IWebElement EditHomework
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(6));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//a[text()='Редактировать']")));
            }
        }
        public IWebElement SendLinkButton
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(6));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//div[@class = 'input-link']/button")));
            }
        }
        public IWebElement HomeworkCompleted
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(6));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//a[text()='Выполненное задание']")));
            }
        }
        public IWebElement ButtonInHomework
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//a[text()='к заданию']")));

            }
        }
        public IWebElement TextBoxLinkInput
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(6));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//div[@class = 'input-link']/input[@placeholder='Ссылка на GitHub или архив']")));

            }
        }
        public IWebElement HomeworkName
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(6));
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
        public void EnterLinkInput(string text)
        {
            TextBoxLinkInput.Clear();
            TextBoxLinkInput.SendKeys(text);
        }
        public void ClickButtonSendLink()
        {
            SendLinkButton.Click();
        }
        public string GetHomeworkCompleted()
        {
            return HomeworkCompleted.Text;
        }
        public void ClickEditHomework()
        {
            EditHomework.Click();
        }
    }
}
