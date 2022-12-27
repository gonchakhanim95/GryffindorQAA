namespace GryffindorQAA.Pages
{
    public class StudentPage :AbstractPage
    {
        public IWebElement ButtonHomeWork => _driver.FindElement(By.XPath(@"//span[text()='Домашние задания']"));

        public IWebElement ButtonNotification
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(6));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//span[text()='Уведомления']")));
            }
        }
        public void ClickNotification()
        {
            ButtonNotification.Click();
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