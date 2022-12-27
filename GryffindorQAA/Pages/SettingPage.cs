using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GryffindorQAA.Pages
{
    public class SettingPage : AbstractPage
    {
        public IWebElement ButtonSetting => _driver.FindElement(By.XPath(@"//div[@class='svg-fond']"));
        public IWebElement ButtonPhotoProfile => _driver.FindElement(By.XPath(@"//div[@class='svg-text']"));
        public IWebElement ButtonSelectPhoto => _driver.FindElement(By.XPath(@"//input[@type='submit']"));
        public override void Open()
        {
        }
        public void ClickButtonSetting()
        {
            WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//div[@class='svg-fond']")));
            ButtonSetting.Click();
        }
        public void ClickButtonPhotoProfile()
        {
            WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//div[@class='svg-text']")));
            ButtonPhotoProfile.Click();
        }
        public void ClickButtonSelectPhoto()
        {
            string scrypt = "document.querySelector('#root > div.modal-background > div > div.buttons-container > label > input').setAttribute('class','display')";
            _driver.ExecuteScript(scrypt);
            string filePath = "C:\\Users\\goncha\\Downloads\\1102284.jpg";
            _driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(filePath);
            ButtonSelectPhoto.Click();
        }

        public bool CheckProfilePhotoExists()
        {
            return _driver.FindElements(By.XPath(@"//img[@class='avatar-photo']")).Any();
        }
    }
}
