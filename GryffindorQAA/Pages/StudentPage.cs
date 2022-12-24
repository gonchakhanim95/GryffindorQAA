﻿namespace GryffindorQAA.Pages
{
    public class StudentPage :AbstractPage
    {
        public IWebElement ButtonHomeWork
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//span[text()='Домашние задания']")));

            }
        }
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