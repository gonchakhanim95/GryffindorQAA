using System;
using TechTalk.SpecFlow;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class ReceiveNotificationsStepDefinitions
    {
        StudentPage _studentPage;
        public ReceiveNotificationsStepDefinitions()
        {
            _studentPage=new StudentPage();
        }

        [When(@"Select chapter notification")]
        public void WhenselectChapterNotifications()
        {
            _studentPage.Click
        }

        [Given(@"Must come out inscription ""([^""]*)""")]
        public void GivenMustComeOutInscription(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"Open Auth as student")]
        public void GivenOpenAuthAsStudent()
        {
            throw new PendingStepException();
        }

        [Given(@"Press button sign in")]
        public void GivenPressButtonSignIn()
        {
            throw new PendingStepException();
        }

        [When(@"Select chapter notification")]
        public void WhenSelectChapterNotification()
        {
            throw new PendingStepException();
        }

        [Then(@"Get all notifications")]
        public void ThenGetAllNotifications()
        {
            throw new PendingStepException();
        }
    }
}
