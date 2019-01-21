using Nimble.Automation.Accelerators.Accelerators;
using NUnit.Framework;

namespace Nimble.Automation.FunctionalTest
{
    [SetUpFixture]
    public class SetUp
    {
        public string devicetype { get; set; } = "";

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            devicetype = TestEngine.DeviceType;
            GetBuildNumber _build = new GetBuildNumber();
          
            _build.GetConfigSettings(devicetype);

            //new Implementation
            TestEngine.BuildNo = _build.GetCurrentBuild();
            TestEngine.FinalReviewEnabled = _build.FinalReviewEnabled();
            TestEngine.FinalReviewLoanType = _build.FinalReviewLoanType();
            TestEngine.SelectedAccountCheckEnabled = _build.SelectedAccountCheckEnabled();
            TestEngine.onlineBpaymentsIsEnabled = _build.onlineBpaymentsIsEnabled();
            TestEngine.requestAmountRestriction = _build.requestAmountRestriction();
            TestEngine.workFlowManagerSTP2NewToProduct = _build.workFlowManagerNewToProduct();
            TestEngine.calculatorIsEnabled = _build.calculatorEnabledValue();
            TestEngine.ToManualOnUnmatched = _build.SelectedAccountCheckToManualOnUnmatchedValue();

            //Disabled to prevent errors on Trunk
            TestEngine.bsAutoRefresh = _build.bsAutoRefreshValue();

            //Prefail config Setting
            TestEngine.PrefailReschedule = _build.PrefailRescheduleValue();
            TestEngine.PrefailRescheduleTotalAllowed = _build.PrefailRescheduleTotalAllowedValue();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
           
        }
    }
}
