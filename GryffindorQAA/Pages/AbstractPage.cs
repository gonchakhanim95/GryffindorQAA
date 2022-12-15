using GryffindorQAA.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryffindorQAA.Pages
{
    public abstract class AbstractPage
    {
        protected WebDriver _driver;

        public AbstractPage()
        {
            _driver = DriverStorage.GetDriverStorage().Driver;
        }

        public void Refresh()
        {
            _driver.Navigate().Refresh();
        }
        public abstract void Open();
    }
}
