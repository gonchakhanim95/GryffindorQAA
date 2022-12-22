namespace GryffindorQAA.Pages
{
    public class StudentPage :AbstractPage
    {
        public IWebElement ButtonHomeWork => _driver.FindElement(By.XPath(@"//span[text()='Домашние задания']"));
        public IWebElement ButtonSetting => _driver.FindElement(By.XPath(@"//span[text()='Настройки']"));
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.HomeWorkPage);
        }
        public void ClickHomeWork()
        {
            ButtonHomeWork.Click();
        }
        public void ClickSetting()
        {
            ButtonSetting.Click();
        }
    }
}