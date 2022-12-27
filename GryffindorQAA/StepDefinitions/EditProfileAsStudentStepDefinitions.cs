using GryffindorQAA.Pages;
using System;
using TechTalk.SpecFlow;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class EditProfileAsStudentStepDefinitions
    {
        SettingPage _settingPage;
        RegistrationPage _registrationPage;

        public EditProfileAsStudentStepDefinitions()
        {
            _settingPage = new SettingPage();
            _registrationPage = new RegistrationPage();
        }
        [When(@"Click to button Настройки")]
        public void WhenClickToButtonНастройки()
        {
            _settingPage.ClickButtonSetting();
        }

        [When(@"Click to button Сохранить")]
        public void WhenClickToButtonСохранить()
        {
            _settingPage.EnterSave();
        }

        [When(@"Fill out forms")]
        public void WhenFillOutForms(Table table)
        {
            var tablic = table.CreateSet<SettingModel>().ToList();
            _settingPage.EnterEmail(tablic[0].Email);
            _settingPage.EnterFirstName(tablic[0].FirstName);
            _settingPage.EnterLastName(tablic[0].LastName);
            _settingPage.EnterParonymic(tablic[0].Patronymic);
            _settingPage.EnterGitHub(tablic[0].GitHub);
            _settingPage.EnterPhone(tablic[0].Phone);
            _settingPage.EnterOldPassword(tablic[0].Password);
            _settingPage.EnterNewPassword(tablic[0].Password);
            _settingPage.EnterRepeateNewPassword(tablic[0].RepeatPassword);
            _settingPage.EnterBirthDate(tablic[0].BirthDate);
        }

        [Then(@"Must to change")]
        public void ThenMustToChange()
        {
            throw new PendingStepException();
        }
    }
}
