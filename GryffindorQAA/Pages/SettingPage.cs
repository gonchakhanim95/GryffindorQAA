using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryffindorQAA.Pages
{
    public class SettingPage : AbstractPage
    {
        public IWebElement ButtonForPersonalDatas => _driver.FindElement(By.XPath(@"//span[@class='avatar-name transition-styles']"));
        public IWebElement ButtonPhotoProfile => _driver.FindElement(By.XPath(@"//img[@class='avatar-photo']"));
        public IWebElement ButtonSelectPhoto => _driver.FindElement(By.XPath(@"//label[text()='Выбрать файл']"));
        public override void Open()
        {
        }
        public void ClickButtonPesronalDatas()
        {
            ButtonForPersonalDatas.Click();
        }
        public void ClickButtonPhotoProfile()
        {
            ButtonPhotoProfile.Click();
        }
        public void ClickButtonSelectPhoto()
        {
            ButtonSelectPhoto.Click();
        }
    }
}
