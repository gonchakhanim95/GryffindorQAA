using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryffindorQAA.Pages
{
    public class MethodistPage : AbstractPage
    {
        public IWebElement DragAndDrop => _driver.FindElement(By.XPath(@"//input[@value='6']"));
        public IWebElement ButtonSingOut => _driver.FindElement(By.XPath(@"//span[text()='Выйти']"));
        public IWebElement TextBoxNumberTopic => _driver.FindElement(By.XPath(@"//input[@name='position']"));
        public IWebElement TextBoxNameTopic => _driver.FindElement(By.XPath(@"//input[@name='topicName']"));
        public IWebElement TextBoxTopicHours => _driver.FindElement(By.XPath(@"//input[@name='hoursCount']"));

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
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(7));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//li[text()='Методист']")));
            }
        }

        public IWebElement ButtonEditCourses
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(8));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//span[text()='Редактировать курсы']")));
            }
        }
        
        public IWebElement ButtonSave
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(7));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//button[text()='Сохранить']")));
            }
        }

        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.AuthPage);
        }
        public void ClickOnRole()
        {
            DropDownRole.Click();
        }
        public void ClickButtongChangeRoleMethodist()
        {
            SwitchRole.Click();
        }
        public void ClickDragAndDrop()
        {
            Actions actions = new Actions(_driver);
            actions.DragAndDropToOffset(DragAndDrop, -1, -114);
        }
        public void ClickButtonSave()
        {
            ButtonSave.Click();
        }
        public void ClickButtonEditCourses()
        {
            ButtonEditCourses.Click();
        }
        public void ClickSingOut()
        {
            ButtonSingOut.Click();
        }
        public void EnterNumberTopic(string numb)
        {
            TextBoxNumberTopic.SendKeys(numb);
        }
        public void EnterNameTopic(string text)
        {
            TextBoxNameTopic.SendKeys(text);
        }
        public void EnterTopicHours(string text)
        {
            TextBoxTopicHours.SendKeys(text);
        }
    }
}
