using System;
using TechTalk.SpecFlow;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class AddLinktoHomeworkAsStudentStepDefinitions
    {
        AuthPage _authPage;
        StudentPage _studentPage;
        HomeworkViewPage _homeworkView;
        public AddLinktoHomeworkAsStudentStepDefinitions()
        {
            _authPage = new AuthPage();
            _studentPage = new StudentPage();
            _homeworkView = new HomeworkViewPage();
        }
        [When(@"Authorized as Student")]
        public void WhenAuthorizedAsStudent()
        {
            _authPage.Open();
            _authPage.EnterEmail("student1@gmail.com");
            _authPage.EnterPassword("салам1салам");
            _authPage.ClickButtonSignIn();
        }

        [When(@"Go to Homework")]
        public void WhenGoToHomework()
        {
            Thread.Sleep(3000);
            _studentPage.ClickHomeWork();
            _homeworkView.ClickButtonInHomework();
        }
        [When(@"Add link")]
        public void WhenAddLink()
        {
            _homeworkView.EnterLinkInput("http://github.com");
            _homeworkView.ClickButtonSendLink();
        }

        [Then(@"Must be Added Link")]
        public void ThenMustBeAddedLink()
        {
            string expected = "Выполненное задание";
            string actual = _homeworkView.GetHomeworkCompleted();
            Assert.Equal(expected, actual);
        }
    }
}
