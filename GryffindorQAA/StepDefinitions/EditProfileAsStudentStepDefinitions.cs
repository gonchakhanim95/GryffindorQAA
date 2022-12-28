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

        [When(@"Fill out form for edit")]
        public void WhenFillOutFormForEdit(Table table)
        {
            _settingPage.ClickButtonSave();
        }

        [When(@"Fill out forms")]
        public void WhenFillOutForms(Table table)
        {
            var tablic = table.CreateSet<SettingModel>().ToList();
            _settingPage.EnterEmail(tablic[0].Email);
            _settingPage.EnterFirstName(tablic[0].FirstName);
            _settingPage.EnterLastName(tablic[0].LastName);
            _settingPage.EnterFirstName(tablic[0].FirstName);
            _settingPage.EnterParonymic(tablic[0].Patronymic);
            _settingPage.ClickkChangeToPassword();
            _settingPage.EnterOldPassword(tablic[0].OldPassword);
            Thread.Sleep(1500);
            _settingPage.EnterNewPassword(tablic[0].NewPassword);
            _settingPage.EnterRepeateNewPassword(tablic[0].RepeatPassword);
            _settingPage.ClickButtonSave();
            _settingPage.ClickButtonBack();
            _settingPage.EnterEmail(tablic[0].Email);
            _settingPage.EnterGitHub(tablic[0].GitHub);
            _settingPage.EnterPhone(tablic[0].Phone);

        }

        [When(@"Click to button Сохранить")]
        public void WhenClickToButtonСохранить()
        {
            _settingPage.ClickButtonSave();
        }

        [Then(@"Must to change")]
        public void ThenMustToChange()
        {
            throw new PendingStepException();
        }
    }
}
