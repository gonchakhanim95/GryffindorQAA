namespace GryffindorQAA.Pages
{
    public abstract class AbstractPage
    {
        protected WebDriver _driver;
        public AbstractPage()
        {
            _driver = DriverStorage.GetInstance().Driver;
        }
        public void Refresh()
        {
            _driver.Navigate().Refresh();
        }
        public abstract void Open();
    }
}
