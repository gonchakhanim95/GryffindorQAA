using System;
using TechTalk.SpecFlow;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class EditLinkToHomeworkAsStudentStepDefinitions
    {
        HomeworkViewPage _homeworkViewPage;
        public EditLinkToHomeworkAsStudentStepDefinitions()
        {
            _homeworkViewPage = new HomeworkViewPage();
        }
        [When(@"Edit Link")]
        public void WhenEditLink()
        {
            _homeworkViewPage.ClickEditHomework();
            _homeworkViewPage.EnterLinkInput("http://google.com");
            _homeworkViewPage.ClickButtonSendLink();
        }

        [Then(@"Must be Edited Link")]
        public void ThenMustBeEditedLink()
        {
            Thread.Sleep(3000);
            string expected = "http://google.com";
            string actual = "";
            Assert.Equal(expected, actual);
        }
    }
}
