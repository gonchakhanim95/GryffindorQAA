namespace GryffindorQAA.Pages
{
    public class PaymentTablePage:AbstractPage
    {
        public IWebElement DropDownShowAllGroups => _driver.FindElement(By.XPath(@"//div[text() = 'Показать все']"));
        public IWebElement ButtonChecksGroup => _driver.FindElement(By.XPath(@"//div[@class = 'drop-down-filter__list-wrapper right']/ul[@class='drop-down-filter__list ']/li[4]"));
        
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.PaymentTablePage);
        }
        public void ClickShorAllGroups()
        {
            DropDownShowAllGroups.Click();
        }
        public string GetChecksGroupName()
        {
            return ButtonChecksGroup.Text;
        }
    }
}
