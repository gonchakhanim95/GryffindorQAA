using OpenQA.Selenium.Support.Extensions;
using System;
using TechTalk.SpecFlow;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class AddProfilePhotoStepDefinitions
    {
        SettingPage _settingPage;
        public AddProfilePhotoStepDefinitions()
        {
            _settingPage = new SettingPage();
        }
        [When(@"Open setting")]
        public void WhenOpenSetting()
        {
            _settingPage.ClickButtonSetting();
        }

        [When(@"Click on profile photo")]
        public void WhenClickOnProfilePhoto()
        {
            _settingPage.ClickButtonPhotoProfile();
        }

        [When(@"Select photo")]
        public void WhenSelectPhoto()
        {
            _settingPage.ClickButtonSelectPhoto();
        }

        [When(@"Change profile photo")]
        public void WhenChangeProfilePhoto()
        {
            Task.Delay(1000).Wait();
            var driver = DriverStorage.GetInstance().Driver;
            driver.Navigate().GoToUrl(driver.Url);
            Task.Delay(1000).Wait();
        }

        [Then(@"Photo profile should change")]
        public void ThenPhotoProfileShouldChange()
        {
            Assert.True(_settingPage.CheckProfilePhotoExists()); 
        }
    }
}
