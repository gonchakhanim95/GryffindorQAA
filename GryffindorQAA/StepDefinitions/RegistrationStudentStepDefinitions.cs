using GryffindorQAA.Pages;
using System;
using TechTalk.SpecFlow;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class RegistrationStudentStepDefinitions
    {
        RegistrationPage _registrationPage;
        AuthPage _authPage;
        public static string Email;

        public RegistrationStudentStepDefinitions()
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

        [When(@"Fill out forms")]
        public void WhenFillOutForms(Table table)
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

        [When(@"Click to button Registration")]
        public void WhenClickToButtonRegistration()
        {
            _registrationPage.ClickButtonCheckBox();
            _registrationPage.ClickButtonRegistration();
        }

        [Then(@"You have successfully registreted")]
        public void ThenYouHaveSuccessfullyRegistreted()
        {
            string expected = Urls.HomePage;
            string actual = Urls.HomePage;
            Assert.Equal(expected, actual);
        }
    }
}
