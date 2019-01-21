using Nimble.Automation.Accelerators.Accelerators;
using Nimble.Automation.Repository.Helper;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Nimble.Automation.FunctionalTest.RegressionTest.Milestone1
{
    [TestFixture]
    class TC001_Slider_Movement_On_LandingPage: TestEngine
    {
        private HomeDetails _homeDetails = null;
        private IWebDriver _driver = null;
        public TestEngine _testEngine = new TestEngine();
        string strUserType;

        [TearDown]
        public void CleanUp()
        {
            _driver.Quit();
        }

        [TestCase(1000,"ios",TestName = "TC001_Slider_Movement_On_LandingPage_1000")]
        public void TC001_Slider_Movement_On_LandingPage_NL(int loanAmount, string mobileDevice)
        {
            strUserType = "NL";

            try
            {
                _driver = _testEngine.TestSetup(mobileDevice, "NL");
                _homeDetails = new HomeDetails(_driver, "NL");
            }

            catch
            {

            }
        }
    }
}
