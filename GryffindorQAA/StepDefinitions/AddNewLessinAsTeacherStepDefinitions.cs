using System;
using TechTalk.SpecFlow;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class AddNewLessinAsTeacherStepDefinitions
    {
        TeacherPage _teacherPage;
        public AddNewLessinAsTeacherStepDefinitions()
        {
            _teacherPage= new TeacherPage();
        }
        [When(@"Change role on teacher")]
        public void WhenChangeRoleOnTeacher()
        {
            _teacherPage.GetTextDropDownRole();
        }

        [Then(@"Add new lesson")]
        public void ThenAddNewLesson()
        {
            _teacherPage.ClickButtonAddLesson();
        }
    }
}
