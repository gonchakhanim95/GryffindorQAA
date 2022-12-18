using GryffindorQAA.Drivers;
using TechTalk.SpecFlow;

namespace GryffindorQAA.Support
{
    [Binding]
    public sealed class Hooks1
    {
        [AfterScenario]
        public void AfterScenario()
        {
            DriverStorage.GetDriverStorage().Driver.Close();
        }
    }
}