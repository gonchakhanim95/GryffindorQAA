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
            _settingPage.ClickButtonPesronalDatas();
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
            throw new PendingStepException();
        }

        [Then(@"Photo profile should change")]
        public void ThenPhotoProfileShouldChange()
        {
            throw new PendingStepException();
        }
    }
}
