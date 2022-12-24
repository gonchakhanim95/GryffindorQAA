using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryffindorQAA.Pages
{
    public class HomeworkAddPage : AbstractPage
    {
        public IWebElement DropDownRole
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//div[@class='drop-down-filter  left']")));
            }
        }
        public IWebElement SwitchRole => _driver.FindElement(By.XPath(@"//li[text()='Преподаватель']"));
        public IWebElement CheckGroup => _driver.FindElement(By.XPath(@"//span[text()='Group1']"));
        public IWebElement TextBoxStartDate
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//div[text()='Дата выдачи задания']/input")));

            }
        }
        public IWebElement TextBoxEndDate => _driver.FindElement(By.XPath(@"//div[text()='Срок сдачи задания']/input"));
        public IWebElement TextBoxTaskName => _driver.FindElement(By.XPath(@"//div[text()='Название задания']/input"));
        public IWebElement TextBoxTaskDescription => _driver.FindElement(By.XPath(@"//div[text()='Описание задания']/textarea"));
        public IWebElement TextBoxTaskLinks => _driver.FindElement(By.XPath(@"//div[text()='Полезные ссылки']/textarea"));
        public IWebElement TextBoxCreate => _driver.FindElement(By.XPath(@"//button[text()='Опубликовать']"));
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.NewHomeworkPage);
        }
        public void ClickDropDownRole()
        {
            DropDownRole.Click();
        }
        public void ClickSwitchRole()
        {
            SwitchRole.Click();
        }
        public void ClickCheckGroup()
        {
            CheckGroup.Click();
        }
        public void EnterStartDate(string text)
        {
            DriverStorage storage = DriverStorage.GetInstance();

            IWebElement StardateBar = storage.Driver.FindElement(By.XPath(@"//div[text()='Дата выдачи занятия']/input"));
            Actions action = new Actions(storage.Driver);
            action.DoubleClick(StardateBar).Perform();
            TextBoxStartDate.SendKeys(text);
        }
        public void EnterEndDate(string text)
        {
            DriverStorage storage = DriverStorage.GetInstance();

            IWebElement EnddateBar = storage.Driver.FindElement(By.XPath(@"//div[text()='Срок сдачи занятия']/input"));
            Actions action = new Actions(storage.Driver);
            action.DoubleClick(EnddateBar).Perform();
            TextBoxEndDate.SendKeys(text);
        }
        public void EnterTaskName(string text)
        {
            TextBoxTaskName.SendKeys(text);
        }
        public void EnterTaskDescription(string text)
        {
            TextBoxTaskDescription.SendKeys(text);
        }
        public void AddTaskLinks(string text)
        {
            TextBoxTaskLinks.SendKeys(text);
        }
        public void ClickCreateButton()
        {
            TextBoxCreate.Click();
        }
    }
}
