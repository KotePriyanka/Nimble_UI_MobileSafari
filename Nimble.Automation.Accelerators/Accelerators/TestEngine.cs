using NUnit.Framework;
using System;
using System.Diagnostics;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Enums;
using System.Configuration;
using System.Threading;
using OpenQA.Selenium.Support.Extensions;

namespace Nimble.Automation.Accelerators.Accelerators
{
    [TestFixture]
    public class TestEngine
    {
        public static string MobileMode = ConfigurationManager.AppSettings.Get("MobileMode");
        public static string BuildNo { get; set; } = "";
        public static string FinalReviewEnabled { get; set; } = "";
        public static string FinalReviewLoanType { get; set; } = "";
        public static string SelectedAccountCheckEnabled { get; set; } = "";
        public static string onlineBpaymentsIsEnabled { get; set; } = "";
        public static string requestAmountRestriction { get; set; } = "";
        public static string workFlowManagerSTP2NewToProduct { get; set; } = "";
        public static string calculatorIsEnabled { get; set; } = "";
        public static bool bsAutoRefresh { get; set; }
        public static bool PrefailReschedule { get; set; }
        public static string PrefailRescheduleTotalAllowed { get; set; }
        public static string ToManualOnUnmatched { get; set; } = "";

        public static string Device { get; set; }
        public static string isTrunkUrlEnable = ConfigurationManager.AppSettings["isTrunkUrlEnable"];
        public static string isTestLiveEnable = ConfigurationManager.AppSettings["isTestLiveEnable"];
        public static string isStagingEnable = ConfigurationManager.AppSettings["isStagingEnable"];
        //websiterefresh enable
        public static string isWebSiteRefreshEnable = ConfigurationManager.AppSettings["isWebSiteRefreshEnable"];


        //Configuration URL of all environments
        public static string trunkURLConfiguration = ConfigurationManager.AppSettings["trunkDebugUrlConfiguration"];
        public static string stagingURLConfiguration = ConfigurationManager.AppSettings["stagingUrlConfiguration"];
        public static string testLiveURLConfiguration = ConfigurationManager.AppSettings["testLiveDebugUrlConfiguration"];
        public static string websiteRefreshDebugUrlConfiguration = ConfigurationManager.AppSettings["websiteRefreshDebugUrlConfiguration"];

        //TestClient URL of all environments
        public static string trunkURLTestClient = ConfigurationManager.AppSettings["trunkDebugUrlRLTestClient"];
        public static string stagingURLTestClient = ConfigurationManager.AppSettings["stagingDebugUrlRLTestClient"];
        public static string testLiveURLTestClient = ConfigurationManager.AppSettings["testLiveDebugUrlRLTestClient"];

        //Nimble URL of all environments
        public static string trunkURLNimble = ConfigurationManager.AppSettings["trunkBaseUrl"];
        public static string stagingURLNimble = ConfigurationManager.AppSettings["stagingBaseUrl"];
        public static string testLiveURLNimble = ConfigurationManager.AppSettings["testLiveBaseUrl"];
        public static string WebsiterefreshURLNimble = ConfigurationManager.AppSettings["websiteRefreshUrl"];

        public static string productId = ConfigurationManager.AppSettings["ProductID"];

        //Environment setup
        public static string configurationURL = isTrunkUrlEnable == "true" ? trunkURLConfiguration : isTestLiveEnable == "true" ? testLiveURLConfiguration : isWebSiteRefreshEnable == "true" ? websiteRefreshDebugUrlConfiguration : stagingURLConfiguration;
        public static string rlURLTestClient = isTrunkUrlEnable == "true" ? trunkURLTestClient : isTestLiveEnable == "true" ? testLiveURLTestClient : stagingURLTestClient;
        public static string WebuiURL = isTrunkUrlEnable == "true" ? trunkURLNimble : isTestLiveEnable == "true" ? testLiveURLNimble : isWebSiteRefreshEnable == "true" ? WebsiterefreshURLNimble : stagingURLNimble;

        public static string StagingProductID = ConfigurationManager.AppSettings["StagingProductID"];
        public static string TrunkProductID = ConfigurationManager.AppSettings["TrunkProductID"];
        public static string NearPrimeProductID = ConfigurationManager.AppSettings["NearPrimeProductID"];
        public static string TestLiveProductID = ConfigurationManager.AppSettings["TestLiveProductID"];

        // Suit ID set up
        public static string TestSuitID = ConfigurationManager.AppSettings["TestSuitID"];

        //Product id setup
        public static string ProductID = isTrunkUrlEnable == "true" ? TrunkProductID : isTestLiveEnable == "true" ? TestLiveProductID : StagingProductID;

        //device setup
        public static string devicemode = ConfigurationManager.AppSettings["DeviceMode"]; // false
        public static string androiddevice = ConfigurationManager.AppSettings["androiddevice"]; //android
        public static string iosdevice = ConfigurationManager.AppSettings["iosdevice"]; // ios
        public static string DeviceType = devicemode == "true" ? androiddevice : iosdevice;

        public string Env { get; set; } = "";
        public string Browser { get; set; } = "";

        //public bool Config => configurationbool;
        public bool Config { get; set; }

        public IWebDriver driver { get; set; }

        public enum browsertype
        {
            firefox,
            chrome,
            ie,
            android,
            ios,
            phantomjs,
            safari
        }

        public IWebDriver TestSetup(string strMobileDevice, bool iswebsiterefresh)
        {
            //Code in TestFixture
           DebugLocalMobile(strMobileDevice);
          
            if (iswebsiterefresh)
            {
                //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(120));
                VerifyPageIsLoaded();
                driver.Navigate().GoToUrl(WebsiterefreshURLNimble);
            }
            else
            {
                //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(120));
                VerifyPageIsLoaded();
                driver.Navigate().GoToUrl(stagingURLNimble);

            }
            return driver;
        }

        public IWebDriver GetConfigValues(string strMobileDevice)
        {       
            //Code in TestFixture
            DebugLocalMobile(strMobileDevice);          

          //  driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(180));
            VerifyPageIsLoaded();

            driver.Navigate().GoToUrl("https://staging.inator.com.au/debug/configuration");
            driver.Navigate().GoToUrl(configurationURL);
            return driver;
        }

        public IWebDriver TestSetup(string strMobileDevice, string nl)
        {
            DebugLocalMobile(strMobileDevice); 

            if (nl == "NL")
            {
               // driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(120));
                VerifyPageIsLoaded();
                driver.Navigate().GoToUrl(WebuiURL);
            }
            else
            {
               // driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(120));
                VerifyPageIsLoaded();
                driver.Navigate().GoToUrl(rlURLTestClient);
            }
            return driver;
        }

        public void VerifyPageIsLoaded()
        {
            var pageLoaded = false;

            for (var i = 0; i < 120000; i++)
            {
                Thread.Sleep(1000);

                if (driver.ExecuteJavaScript<string>("return document.readyState").Equals("complete"))
                //jQuery.active might cause problems on some browser or browserstack so I commented it out
                //&& WebDriver.ExecuteJavaScript<bool>("return jQuery.active == 0").Equals(true))
                {
                    pageLoaded = true;
                    break;
                }

                Thread.Sleep(1000);
            }

            if (!pageLoaded)
            {
                throw new Exception("Page was not with complete state)!");
            }
        }

        [Conditional("DEBUGLOCALMOBILE")]
        public void DebugLocalMobile(string strMobileDevice)
        {
            if (strMobileDevice == browsertype.android.ToString())
            {
                Browser = "Android";
                Env = "Android";
                Config = true;
                try
                {
                    //devicenamelocal = ConfigurationManager.AppSettings.Get("androiddeviceNameLocal");
                    //configurationbool = true;
                    //DesiredCapabilities capabilities = new DesiredCapabilities();
                    //capabilities.SetCapability(MobileCapabilityType.BrowserName, MobileBrowserType.Chrome);
                    //// capabilities.SetCapability(MobileCapabilityType.DeviceName, devicenamelocal);
                    //capabilities.SetCapability(MobileCapabilityType.DeviceName, "192.168.99.101:5555");
                    //capabilities.SetCapability(MobileCapabilityType.PlatformName, MobilePlatform.Android);
                    //capabilities.SetCapability("newCommandTimeout", TimeSpan.FromSeconds(200));
                    //driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
                    //// driver = new RemoteWebDriver(capabilities);
                    //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(Convert.ToInt32(ConfigurationManager.AppSettings.Get("ElementPageLoad"))));
                    //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(200));


                    //-------------- local chrome DEVICE Mode for chrome ------------------------

                    string path = TestUtility.GetAssemblyDirectory() + "//chromedriver.exe";
                    Environment.SetEnvironmentVariable("webdriver.chrome.driver", path);

                    DesiredCapabilities capabilities = new DesiredCapabilities();
                    capabilities.SetCapability(MobileCapabilityType.Orientation, MobileSelector.AndroidUIAutomator);
                    capabilities.SetCapability(MobileCapabilityType.BrowserName, "Android");
                    capabilities.SetCapability(MobileCapabilityType.DeviceName, "Galaxy S5");
                    capabilities.SetCapability(MobileCapabilityType.PlatformName, "Android");
                    capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "5.0.2");
                    capabilities.SetCapability(MobileBrowserType.Browser, "Android");


                    //Dictionary<String, String> mobileEmulation = new Dictionary<String, String>();
                    //mobileEmulation.Add("deviceName", "Galaxy S5");
                    //mobileEmulation.Add("height", "640");
                    //mobileEmulation.Add("width", "360");
                    //mobileEmulation.Add("pixelRatio", "3");
                    //mobileEmulation.Add("browserName", "Android");
                    //mobileEmulation.Add("platformName", MobilePlatform.Android);
                    ChromeOptions chrOpts = new ChromeOptions();
                    // chrOpts.AddAdditionalCapability("capabilityName", mobileEmulation);
                    chrOpts.EnableMobileEmulation("Galaxy S5");
                    // chrOpts.AddArguments("test-type");
                    // chrOpts.AddArguments("--disable-extensions");
                    chrOpts.AddArgument("incognito");
                    //chrOpts.AddUserProfilePreference("download.prompt_for_download", ConfigurationManager.AppSettings["ShowBrowserDownloadPrompt"]);
                    driver = new ChromeDriver(chrOpts);
                    driver.Manage().Window.Maximize();
                    //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(Convert.ToInt32(ConfigurationManager.AppSettings.Get("ElementPageLoad"))));

                    // Map<String, String> mobileEmulation = new HashMap<>();
                    // mobileEmulation.put("deviceName", "Nexus 5");
                    // ChromeOptions chromeOptions = new ChromeOptions();
                    // chromeOptions.setExperimentalOption("mobileEmulation", mobileEmulation);
                    //WebDriver driver = new ChromeDriver(chromeOptions);



                    //------------- Genymotion Local---------------------

                    //DesiredCapabilities capabilities = new DesiredCapabilities();
                    //capabilities.SetCapability("device", "Android");
                    //capabilities.SetCapability("browserName", "chrome");
                    //capabilities.SetCapability("deviceName", "192.168.99.101:5555");
                    //capabilities.SetCapability("platformName", "Android");
                    //capabilities.SetCapability("platformVersion", "5.0.2");

                    //driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities, TimeSpan.FromSeconds(180));
                    //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(Convert.ToInt32(ConfigurationManager.AppSettings.Get("ElementPageLoad"))));
                    //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(200));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (strMobileDevice == browsertype.ios.ToString())
            {
                DesiredCapabilities capabilities = new DesiredCapabilities();
                capabilities.SetCapability("platformName", "ios");
                capabilities.SetCapability("platformVersion", "11.0");
                capabilities.SetCapability("", "Mac");
                capabilities.SetCapability("deviceName", "iPhone SE");
                capabilities.SetCapability("automationplatformName", "XCUITest");
                capabilities.SetCapability("browserName", "Safari");

                Uri serverUri = new Uri("http://192.168.10.59:4723/wd/hub"); //192.168.10.41  192.168.1.6 192.168.10.46 10.37.110.228 192.168.10.60
                // driver = new IOSDriver<IWebElement>(serverUri, capabilities, TimeSpan.FromSeconds(500));
                driver = new RemoteWebDriver(serverUri, capabilities, TimeSpan.FromSeconds(1000));
            }
            else
            {
                driver = null;
            }
        }

        [Conditional("DEBUGLOCALSAFARI")]
        public void DebugLocalSafari()
        {
            try
            {
                //set configuration to be picked up and set Locator
                Config = false;
                Browser = "Safari";
                Env = "Desktop";

                string path = TestUtility.GetAssemblyDirectory() + "//chromedriver.exe";
                Environment.SetEnvironmentVariable("webdriver.chrome.driver", path);

                ChromeOptions chrOpts = new ChromeOptions();
                chrOpts.AddArguments("test-type");
                chrOpts.AddArguments("--disable-extensions");
                // chrOpts.AddArgument("incognito");
                chrOpts.AddUserProfilePreference("download.prompt_for_download", ConfigurationManager.AppSettings["ShowBrowserDownloadPrompt"]);
                driver = new ChromeDriver(chrOpts);
                driver.Manage().Window.Maximize();
                //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(Convert.ToInt32(ConfigurationManager.AppSettings.Get("ElementPageLoad"))));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool GetPlatform(IWebDriver driver)
        {
            bool flag = false;
            if (MobileMode == "true")
            {
                flag = true;
            }
            else
            {
                string strval = ((OpenQA.Selenium.Remote.DesiredCapabilities)((OpenQA.Selenium.Remote.RemoteWebDriver)driver).Capabilities).Platform.PlatformType.ToString();
                if (strval == "Android" || strval == "Mac")
                    flag = true;
                else flag = false;
            }
            return flag;
        }
    }
}
