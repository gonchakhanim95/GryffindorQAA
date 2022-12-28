﻿// ------------------------------------------------------------------------------
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
    public partial class FilterPaymentTableAsManagerFeature : object, Xunit.IClassFixture<FilterPaymentTableAsManagerFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "FilterPaymentTableAsManager.feature"
#line hidden
        
        public FilterPaymentTableAsManagerFeature(FilterPaymentTableAsManagerFeature.FixtureData fixtureData, GryffindorQAA_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "FilterPaymentTableAsManager", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [Xunit.SkippableFactAttribute(DisplayName="FilterPaymentTableAsManager")]
        [Xunit.TraitAttribute("FeatureTitle", "FilterPaymentTableAsManager")]
        [Xunit.TraitAttribute("Description", "FilterPaymentTableAsManager")]
        public virtual void FilterPaymentTableAsManager()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("FilterPaymentTableAsManager", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 3
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
                TechTalk.SpecFlow.Table table51 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email",
                            "Password"});
                table51.AddRow(new string[] {
                            "marina@example.com",
                            "marina123456"});
#line 4
 testRunner.And("Authoraized as admin", ((string)(null)), table51, "And ");
#line hidden
                TechTalk.SpecFlow.Table table52 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Description"});
                table52.AddRow(new string[] {
                            "dev",
                            "Budet polezno"});
#line 7
 testRunner.And("Create course", ((string)(null)), table52, "And ");
#line hidden
                TechTalk.SpecFlow.Table table53 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "GroupStatusId",
                            "StartDate",
                            "EndDate",
                            "Timetable",
                            "PaymentPerMonth",
                            "PaymentsCount"});
                table53.AddRow(new string[] {
                            "qaa",
                            "Forming",
                            "01.01.2023",
                            "05.05.2023",
                            "60",
                            "100",
                            "4"});
#line 10
 testRunner.And("Create group", ((string)(null)), table53, "And ");
#line hidden
                TechTalk.SpecFlow.Table table54 = new TechTalk.SpecFlow.Table(new string[] {
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
                table54.AddRow(new string[] {
                            "Абаев",
                            "Student",
                            "Fedor",
                            "23.12.1992",
                            "салам1салам",
                            "messi@gmail.com",
                            "+71113332255",
                            "sstudent",
                            "SaintPetersburg",
                            "StudentGit"});
#line 13
 testRunner.Given("Registration new Users for Students", ((string)(null)), table54, "Given ");
#line hidden
#line 16
 testRunner.And("Add New Students in Group", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table55 = new TechTalk.SpecFlow.Table(new string[] {
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
                table55.AddRow(new string[] {
                            "Бабиров",
                            "Student",
                            "Fedor",
                            "23.12.1993",
                            "салам1салам",
                            "ronaldo@gmail.com",
                            "+71113332256",
                            "studentt",
                            "SaintPetersburg",
                            "StudentGit"});
#line 17
 testRunner.And("Registration new Users for Students", ((string)(null)), table55, "And ");
#line hidden
#line 20
 testRunner.And("Add New Students in Group", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table56 = new TechTalk.SpecFlow.Table(new string[] {
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
                table56.AddRow(new string[] {
                            "Велиханов",
                            "Student",
                            "Fedor",
                            "23.12.1994",
                            "салам1салам",
                            "mbapppe@gmail.com",
                            "+71113332257",
                            "sstudentt",
                            "SaintPetersburg",
                            "StudentGit"});
#line 21
 testRunner.And("Registration new Users for Students", ((string)(null)), table56, "And ");
#line hidden
#line 24
 testRunner.And("Add New Students in Group", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table57 = new TechTalk.SpecFlow.Table(new string[] {
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
                table57.AddRow(new string[] {
                            "Джаббаров",
                            "Student",
                            "Fedor",
                            "23.12.1995",
                            "салам1салам",
                            "leletepe@gmail.com",
                            "+71113332258",
                            "student",
                            "SaintPetersburg",
                            "StudentGit"});
#line 25
 testRunner.And("Registration new Users for Students", ((string)(null)), table57, "And ");
#line hidden
#line 28
 testRunner.And("Add New Students in Group", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table58 = new TechTalk.SpecFlow.Table(new string[] {
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
                table58.AddRow(new string[] {
                            "Гаджиев",
                            "Manager",
                            "Федор",
                            "23.12.1992",
                            "салам1салам",
                            "managger@gmail.com",
                            "+71113332255",
                            "mmanagerr",
                            "SaintPetersburg",
                            "ManagerGit"});
#line 29
 testRunner.And("Registration new User for Manager", ((string)(null)), table58, "And ");
#line hidden
#line 32
 testRunner.And("Give role manager", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And("Add Manager in Group", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("Open auth Web page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table59 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email",
                            "Password"});
                table59.AddRow(new string[] {
                            "managger@gmail.com",
                            "салам1салам"});
#line 35
 testRunner.When("Authorized  as Manager", ((string)(null)), table59, "When ");
#line hidden
#line 38
 testRunner.And("Open Payment table page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.Then("Must be added Group in Payment page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                FilterPaymentTableAsManagerFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                FilterPaymentTableAsManagerFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
