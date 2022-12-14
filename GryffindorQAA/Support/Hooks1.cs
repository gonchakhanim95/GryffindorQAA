using TechTalk.SpecFlow;

namespace GryffindorQAA.Support
{
    [Binding]
    public sealed class Hooks1
    {

        /*[BeforeScenario]
        public void BeforeScenarioWithTag()
        {
        }*/

        [AfterScenario]
        public void AfterScenario()
        {

        }
    }
}