using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryffindorQAA.Drivers
{
    public class DriverStorage
    {
        public WebDriver Driver { get; set; }

        private static DriverStorage _driverStorage;

        private DriverStorage()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        public static DriverStorage GetDriverStorage()
        {
            if (_driverStorage is null)
            {
                _driverStorage = new DriverStorage();
            }
            return _driverStorage;
        }
    }
}
