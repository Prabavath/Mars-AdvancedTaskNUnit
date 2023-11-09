using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Mars_SeleniumAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V117.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_SeleniumAutomation.Utilities
{
    public class Base
    {
#pragma warning disable
        public static IWebDriver driver;
        private static ExtentReports extent;
        private static ExtentTest testreport;
        private static ExtentSparkReporter htmlReporter;
        [SetUp]
        public void startBrowser()
        {
            testreport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
        }
        [OneTimeSetUp]
        public void SetupReport()
        {
            if (extent == null)
            {
                extent = new ExtentReports();
                htmlReporter = new ExtentSparkReporter("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\Utilities\\Report.html"); // Path to the report file
                extent.AttachReporter(htmlReporter);     
            }
        }
        public void LogScreenshot(string ScreenshotName)
        {
            string screenshotPath = CaptureScreenshot(ScreenshotName);
            if (testreport != null)
            {
                testreport.Log(Status.Info, "Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            }
        }
        public static string CaptureScreenshot(string screenshotName)
        {
            ITakesScreenshot screenshotDriver = (ITakesScreenshot)driver;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            string screenshotPath = Path.Combine("ScreenshotReport", $"{screenshotName}_{DateTime.Now:yyyyMMddHHmmss}.png");
            string fullPath = Path.Combine("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation", screenshotPath);
#pragma warning disable
            screenshot.SaveAsFile(fullPath, ScreenshotImageFormat.Png);
            return fullPath;
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }
        [OneTimeTearDown]
        public void TearDownReport()
        {
            extent.Flush();
        }
    }
}
