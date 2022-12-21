using System;
using GryffindorQAA.Pages;
using TechTalk.SpecFlow;


namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class EditProfileAsStudentStepDefinitions
    {
        RegistrationPage _registrationPage;
        AuthPage _authPage;
        public static string Email;
        public EditProfileAsStudentStepDefinitions()
        {
            _registrationPage = new RegistrationPage();
            _authPage = new AuthPage();
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

        [Given(@"You have message Добро пожаловать!")]
        public void GivenYouHaveMessageДоброПожаловать()
        {
            throw new PendingStepException();
        }

        [Given(@"Open autorization page")]
        public void GivenOpenAutorizationPage()
        {
            throw new PendingStepException();
        }

        [Given(@"Click to button Войти")]
        public void GivenClickToButtonВойти()
        {
            throw new PendingStepException();
        }

        [When(@"Click to button Настройки")]
        public void WhenClickToButtonНастройки()
        {
            throw new PendingStepException();
        }

        [When(@"Fill out form")]
        public void WhenFillOutForm(Table table)
        {
            var tablica = table.CreateSet<RegistrationModel>().ToList();
            _registrationPage.EnterLastName(tablica[0].LastName);
            _registrationPage.EnterFirstName(tablica[0].FirstName);
            _registrationPage.EnterParonymic(tablica[0].Patronymic);
            _registrationPage.EnterBrithDate(tablica[0].BirthDate);
            _registrationPage.EnterPassword(tablica[0].Password);
            _registrationPage.EnterRepeatPassword(tablica[0].RepeatPassword);
            _registrationPage.EnterEmail(tablica[0].Email);
            _registrationPage.EnterPhoneNumber(tablica[0].Phone);

            Email = tablica[0].Email;
        }

        [When(@"Click to password")]
        public void WhenClickToPassword()
        {
            throw new PendingStepException();
        }

        [When(@"Click to old password")]
        public void WhenClickToOldPassword()
        {
            throw new PendingStepException();
        }

        [When(@"Click new password")]
        public void WhenClickNewPassword()
        {
            throw new PendingStepException();
        }

        [When(@"Click repeat new password")]
        public void WhenClickRepeatNewPassword()
        {
            throw new PendingStepException();
        }

        [When(@"Click to button Сохранить")]
        public void WhenClickToButtonСохранить()
        {
            throw new PendingStepException();
        }

        [Then(@"Must to change")]
        public void ThenMustToChange()
        {
            throw new PendingStepException();
        }
    }
}
