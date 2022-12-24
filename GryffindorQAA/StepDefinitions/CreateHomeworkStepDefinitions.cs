using System;
using TechTalk.SpecFlow;

namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class CreateHomeworkStepDefinitions
    {
        Clientt clientt;
        HomeworkAddPage _homeworkAddPage;
        AuthPage _authPage;
        StudentPage _studentPage;
        HomeworkViewPage _homeworkViewPage;
        public static List<string> Emails = new List<string>();

        public CreateHomeworkStepDefinitions()
        {
            clientt = new Clientt();
            _homeworkAddPage = new HomeworkAddPage();    
            _authPage = new AuthPage();
            _studentPage = new StudentPage();
            _homeworkViewPage = new HomeworkViewPage();

        }
        [Given(@"Registration new User for Tutor")]
        public void GivenRegistrationNewUserForTutor(Table table)
        {
            var tab = table.CreateSet<RequestRegistrationModel>().ToList();
            Emails.Add(tab[0].Email);
            Variables.GetInstance().TutorId=clientt.Registration(tab[0]);
            
        }

        [Given(@"Registration new User for Teacher")]
        public void GivenRegistrationNewUserForTeacher(Table table)
        {
            var tab = table.CreateSet<RequestRegistrationModel>().ToList();
            Emails.Add(tab[0].Email);
            Variables.GetInstance().TeacherId = clientt.Registration(tab[0]);
        }

        [Given(@"Registration new Users for Students")]
        public void GivenRegistrationNewUsersForStudents(Table table)
        {
            var tab = table.CreateSet<RequestRegistrationModel>().ToList();
            Emails.Add(tab[0].Email);
            Variables.GetInstance().StudentId = clientt.Registration(tab[0]);
        }

        [Given(@"Create course")]
        public void GivenCreateCourse(Table table)
        {
            var tab = table.CreateSet<CourseRequestModel>().ToList();
            Variables.GetInstance().CourseId = clientt.CreateCourse(tab[0], Variables.GetInstance().AdminToken);
        }
        
        [Given(@"Create group")]
        public void GivenCreateGroup(Table table)
        {
            var tab = table.CreateSet<GroupRequestModel>().ToList();
            tab[0].CourseId = Variables.GetInstance().CourseId;
            Variables.GetInstance().GroupId = clientt.CreateGroup(tab[0],Variables.GetInstance().AdminToken);
        }

        [Given(@"Add Tutor in Group")]
        public void GivenAddTutorInGroup()
        {
            clientt.AddUserInGroup(Variables.GetInstance().GroupId, Variables.GetInstance().TutorId, "Tutor",Variables.GetInstance().AdminToken);
        }

        [Given(@"Add Teacher in Group")]
        public void GivenAddTeacherInGroup()
        {
            clientt.AddUserInGroup(Variables.GetInstance().GroupId, Variables.GetInstance().TeacherId, "Teacher", Variables.GetInstance().AdminToken);
        }

        [Given(@"Add Students in Group")]
        public void GivenAddStudentsInGroup()
        {
            clientt.AddUserInGroup(Variables.GetInstance().GroupId, Variables.GetInstance().StudentId, "Student", Variables.GetInstance().AdminToken);
        }

        [Given(@"Create task as Teacher")]
        public void GivenCreateTaskAsTeacher(Table table) 
        {
            var tab = table.CreateSet<TaskRequestModel>().ToList();
            tab[0].GroupId = Variables.GetInstance().GroupId;
            Variables.GetInstance().TaskId = clientt.CreateTaskAsTeacher(tab[0],Variables.GetInstance().AdminToken);
        }
        [When(@"Open NewHomeworkPage")] 
        public void WhenOpenNewHomeworkPage()
        {
            _homeworkAddPage.Open();
        }
        [When(@"Fill form for give  out Homework")]
        public void WhenFillFormForGiveOutHomework(Table table)
        {
            var tab = table.CreateSet<NewHomeworkModel>().ToList();
            Variables.GetInstance().HomeworkName = tab[0].HomeworkName;
            _homeworkAddPage.ClickDropDownRole();
            _homeworkAddPage.ClickSwitchRole();
            _homeworkAddPage.ClickCheckGroup();
            _homeworkAddPage.EnterStartDate(tab[0].StartDate);
            _homeworkAddPage.EnterEndDate(tab[0].EndDate);
            _homeworkAddPage.EnterTaskName(tab[0].HomeworkName);
            _homeworkAddPage.EnterTaskDescription(tab[0].HomeworkDescription);
            _homeworkAddPage.AddTaskLinks(tab[0].HomeworkLinks);
            _homeworkAddPage.ClickLinkButton();
        }

        [When(@"Click create button")]
        public void WhenClickCreateButton()
        {
            _homeworkAddPage.ClickCreateButton();
        }

        [Then(@"Must be created Homework")]
        public void ThenMustBeCreatedHomework()
        {
            _authPage.Open();
            _authPage.EnterEmail("student1@gmail.com");
            _authPage.EnterPassword("салам1салам");
            _authPage.ClickButtonSignIn();
            _studentPage.ClickHomeWork();
        }

        [Then(@"goncha sravnenniye")]
        public void ThenGonchaSravnenniye()
        {
            string expected = Variables.GetInstance().HomeworkName;
            string actual = _homeworkViewPage.GetHomeworkName();
            Assert.Equal(expected, actual);
        }
    }
}
