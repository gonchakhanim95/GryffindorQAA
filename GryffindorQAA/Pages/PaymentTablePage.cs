using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryffindorQAA.Pages
{
    public class PaymentTablePage:AbstractPage
    {
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.PaymentTablePage);
        }
    }
}
