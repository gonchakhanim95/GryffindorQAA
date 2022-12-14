// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GryffindorQAA.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CreateHomeworkFeature : object, Xunit.IClassFixture<CreateHomeworkFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CreateHomework.feature"
#line hidden
        
        public CreateHomeworkFeature(CreateHomeworkFeature.FixtureData fixtureData, GryffindorQAA_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "CreateHomework", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create HomeWork")]
        [Xunit.TraitAttribute("FeatureTitle", "CreateHomework")]
        [Xunit.TraitAttribute("Description", "Create HomeWork")]
        public virtual void CreateHomeWork()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create HomeWork", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                            "LastName",
                            "FirstName",
                            "Patronymic",
                            "BirthDate",
                            "Password",
                            "Email",
                            "PhoneNumber",
                            "Username",
                            "City",
                            "GitHubAccount"});
                table24.AddRow(new string[] {
                            "Галкин",
                            "Tutor1",
                            "Федор",
                            "23.12.1992",
                            "салам1салам",
                            "tutor@gmail.com",
                            "+75553332255",
                            "ttutorr",
                            "SaintPetersburg",
                            "TutorGit"});
#line 5
 testRunner.Given("Registration new User for Tutor", ((string)(null)), table24, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                            "LastName",
                            "FirstName",
                            "Patronymic",
                            "BirthDate",
                            "Password",
                            "Email",
                            "PhoneNumber",
                            "Username",
                            "City",
                            "GitHubAccount"});
                table25.AddRow(new string[] {
                            "Галкин",
                            "Teacher1",
                            "Федор",
                            "23.12.1992",
                            "салам1салам",
                            "teacher@gmail.com",
                            "+76663332255",
                            "tteacherr",
                            "SaintPetersburg",
                            "TeacherGit"});
#line 8
 testRunner.And("Registration new User for Teacher", ((string)(null)), table25, "And ");
#line hidden
                TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                            "LastName",
                            "FirstName",
                            "Patronymic",
                            "BirthDate",
                            "Password",
                            "Email",
                            "PhoneNumber",
                            "Username",
                            "City",
                            "GitHubAccount"});
                table26.AddRow(new string[] {
                            "Галкин",
                            "Student1",
                            "Федор",
                            "23.12.1992",
                            "салам1салам",
                            "student1@gmail.com",
                            "+71113332255",
                            "sstudentt1",
                            "SaintPetersburg",
                            "Student1Git"});
#line 11
 testRunner.And("Registration new Users for Students", ((string)(null)), table26, "And ");
#line hidden
                TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email",
                            "Password"});
                table27.AddRow(new string[] {
                            "marina@example.com",
                            "marina123456"});
#line 14
 testRunner.And("Authoraized as admin", ((string)(null)), table27, "And ");
#line hidden
                TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Description"});
                table28.AddRow(new string[] {
                            "Course1",
                            "Budet polezno"});
#line 17
 testRunner.And("Create course", ((string)(null)), table28, "And ");
#line hidden
                TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "GroupStatusId",
                            "StartDate",
                            "EndDate",
                            "Timetable",
                            "PaymentPerMonth",
                            "PaymentsCount"});
                table29.AddRow(new string[] {
                            "Group1",
                            "Forming",
                            "01.01.2023",
                            "03.03.2023",
                            "60",
                            "100",
                            "9"});
#line 20
 testRunner.And("Create group", ((string)(null)), table29, "And ");
#line hidden
#line 23
 testRunner.And("Give role Tutor to the new user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And("Give role Teacher to the new user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And("Add Tutor in Group", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("Add Teacher in Group", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And("Add Students in Group", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Description",
                            "Links",
                            "IsRequired"});
                table30.AddRow(new string[] {
                            "Task1",
                            "taskliviy den",
                            "github.com",
                            "true"});
#line 28
 testRunner.And("Create task as Teacher", ((string)(null)), table30, "And ");
#line hidden
#line 31
 testRunner.When("Open auuthorization page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.And("Skip bezopasnost", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email",
                            "Password"});
                table31.AddRow(new string[] {
                            "teacher@gmail.com",
                            "салам1салам"});
#line 33
 testRunner.And("Fill sign in form as teacher", ((string)(null)), table31, "And ");
#line hidden
#line 36
 testRunner.And("Click sign button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("Open NewHomeworkPage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                            "StartDate",
                            "EndDate",
                            "HomeworkName",
                            "HomeworkDescription",
                            "HomeworkLinks"});
                table32.AddRow(new string[] {
                            "01.01.2023",
                            "01.05.2023",
                            "50 Примеров",
                            "До среды заканчивайте",
                            "http://github.com, http://google.com"});
#line 38
 testRunner.And("Fill form for give  out Homework", ((string)(null)), table32, "And ");
#line hidden
#line 41
 testRunner.And("Click create button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.Then("Must be created Homework", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
 testRunner.And("goncha sravnenniye", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CreateHomeworkFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CreateHomeworkFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
