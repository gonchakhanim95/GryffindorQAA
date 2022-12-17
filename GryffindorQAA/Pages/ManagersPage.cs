using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GryffindorQAA.Support;

namespace GryffindorQAA.Pages
{
    public class ManagersPage : AbstractPage
    {
        public IWebElement ButtonListStudents => _driver.FindElement(By.XPath(@"//span[text()='Список студентов']"));
        public IWebElement ButtonFilterStudents => _driver.FindElement(By.XPath(@"//div[text()='Сортировать по фамилии']"));
        public IWebElement ButtonChangeFilter => _driver.FindElement(By.XPath(@"//li[text()='Сортировать обратно']"));
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.HomePage);
        }

        public void ClickButtonListStudents()
        {
            ButtonListStudents.Click();
        }
        public void ClickFilterStudents()
        {
            ButtonFilterStudents.Click();
        }
        public void ClickButtonChangeFilter()
        {
            ButtonChangeFilter.Click();
        }
    }
}
