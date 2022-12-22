using System;
using GryffindorQAA.Drivers;
using GryffindorQAA.Pages;
using TechTalk.SpecFlow;


namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class EditProfileAsStudentStepDefinitions
    {
        RegistrationPage _registrationPage;
        SettingPage _settingPage;
        AuthPage _authPage;
        StudentPage _studentPage;
        List<RegistrationModel> _table;
        public static string Email;
        public EditProfileAsStudentStepDefinitions(Table table)
        {
            _registrationPage = new RegistrationPage();
            _settingPage = new SettingPage();
            _authPage = new AuthPage();
            _studentPage = new StudentPage();
            _table = table.CreateSet<RegistrationModel>().ToList();
        }

        [Given(@"Open registration page")]
        public void GivenOpenRegistrationPage()
        {
            _registrationPage.Open();
            _authPage.SkipSecure();
            _authPage.ClickButtonChangePage();
        }

        [Given(@"Click to button Registration")]
        public void GivenClickToButtonRegistration()
        {
            _registrationPage.ClickButtonCheckBox();
            _registrationPage.ClickButtonRegistration();
            Thread.Sleep(500);
        }

        [Given(@"You have message ""([^""]*)""")]
        public void GivenYouHaveMessage(string expected)
        {
            DriverStorage storage = DriverStorage.GetInstance();
            string xpath = @"//p[@class='notification-text']";
            IWebElement button = storage.Driver.FindElement(By.XPath(xpath));
            string actual = button.Text;
            Assert.Equal(expected, actual);
        }

        [Given(@"Open autorization page")]
        public void GivenOpenAutorizationPage()
        {
            _authPage.Open();
            _registrationPage.ClickChangeButtonToAuth();
        }

        [Given(@"Click to button Войти")]
        public void GivenClickToButtonВойти()
        {
            _authPage.ClickButtonSignIn();

        }

        [When(@"Click to button Настройки")]
        public void WhenClickToButtonНастройки()
        {
            _studentPage.ClickSetting();
        }

        [When(@"Fill out form")]
        public void WhenFillOutForm()
        {
            _settingPage.EnterLastName(_table[2].LastName);
            _settingPage.EnterFirstName(_table[2].FirstName);
            _settingPage.EnterParonymic(_table[2].Patronymic);
            _settingPage.EnterBirthDate(_table[2].BirthDate);
            _settingPage.EnterOldPassword(_table[2].Password);
            _settingPage.EnterNewPassword(_table[2].Password);
            _settingPage.EnterRepeateNewPassword(_table[2].Password);
            _settingPage.EnterEmail(_table[2].Email);
            _settingPage.EnterGitHub(_table[2].GitHub);
            _settingPage.EnterPhone(_table[2].Phone);
        }

        [When(@"Click to change password")]
        public void WhenClickToChangePassword()
        {
            _settingPage.EnterChangeToPassword();
        }

        [When(@"Click to old password")]
        public void WhenClickToOldPassword()
        {
            _settingPage.EnterOldPassword(_table[2].OldPassword);
        }

        [When(@"Click new password")]
        public void WhenClickNewPassword()
        {
            _settingPage.EnterNewPassword(_table[2].NewPassword);
        }

        [When(@"Click repeat new password")]
        public void WhenClickRepeatNewPassword()
        {
            _settingPage.EnterNewPassword(_table[2].NewPassword);
        }

        [When(@"Click to button Сохранить Password")]
        public void WhenClickToButtonСохранитьPassword()
        {
            _settingPage.EnterSave();
        }

        [When(@"Click to button Back")]
        public void ClickToButtonBack()
        {
            _settingPage.EnterSave();
        }

        [When(@"Click to button Сохранить")]
        public void WhenClickToButtonСохранить()
        {
            _settingPage.EnterSave();
        }

        [Then(@"Must to change")]
        public void ThenMustToChange()
        {
            throw new PendingStepException();
        }
    }
}
