namespace GryffindorQAA.StepDefinitions
{
    [Binding]
    public class GetAllUsersStepDefinitions
    {
        ManagerPage _managerPage;
        public GetAllUsersStepDefinitions()
        {
            _managerPage = new ManagerPage();
        }
        [When(@"Click button all users")]
        public void WhenClickButtonAllUsers()
        {
           _managerPage.ClickButtonUsers();
        }

        [Then(@"Get all users")]
        public void ThenGetAllUsers()
        {
            DriverStorage storage = DriverStorage.GetInstance();
            string expected = Urls.AllUserPage;
            string actual = storage.Driver.Url;
            Assert.Equal(expected, actual);
        }
    }
}