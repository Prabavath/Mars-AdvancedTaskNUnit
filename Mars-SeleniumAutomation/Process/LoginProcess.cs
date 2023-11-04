using AventStack.ExtentReports;
using Mars_SeleniumAutomation.Pages;
using Mars_SeleniumAutomation.Pages.Components.SignIn;
using Mars_SeleniumAutomation.TestModel;
using Mars_SeleniumAutomation.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_SeleniumAutomation.Process
{
    public class LoginProcess:Base
    {
#pragma warning disable
        HostPage hostPageObj;
        HomePage homePageObj;
        LoginComponent loginComponentObj;
        Base baseObj;
        ExtentTest testreport;
        Jsonhelper jsonhelperObj;
        private ExtentReports extent;
        public LoginProcess()
        {
            hostPageObj = new HostPage();
            homePageObj = new HomePage();
            loginComponentObj = new LoginComponent();
            baseObj = new Base();
            jsonhelperObj = new Jsonhelper();
        }
        public void doLogin()
        {
            baseObj.InitializeExtentReports();
            string testName = "Logindata";
            baseObj.SetupTest(testName);
            LoginTestModel model = new LoginTestModel();
            List<LoginTestModel> Logindata = Jsonhelper.ReadTestDataFromJson<LoginTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\Logindata.json");
            foreach (var data in Logindata)
            {
                string screenshotName = "Logindata";
                baseObj.CaptureScreenshot(screenshotName);
                hostPageObj.clickSignIn();
                loginComponentObj.validLogin(data);
                string userNameLabel = homePageObj.VerifyUserName();
                string expectedUserName = "Hi " + data.firstname;
                Assert.AreEqual(userNameLabel, expectedUserName, "Actual and expected do not match");
                if (testreport != null)
                {
                    testreport.Log(Status.Pass, "Test Passed");
                }
            }
        }
        public void validUserInvalidPasswordProcess()
        {
            baseObj.InitializeExtentReports();
            string testName = "InvalidPasswordLogindata";
            baseObj.SetupTest(testName);
            LoginTestModel model = new LoginTestModel();
            List<LoginTestModel> InvalidPasswordLogindata = Jsonhelper.ReadTestDataFromJson<LoginTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\InvalidPasswordLogindata.json");
            foreach (var data in InvalidPasswordLogindata)
            {
                string email = data.email;
                string password = data.password;
                string screenshotName = "InvalidPasswordLogindata";
                baseObj.CaptureScreenshot(screenshotName);
                loginComponentObj.validUserInvalidPassword(data);
                string passwordAlertMessageBox = loginComponentObj.verifyPasswordMessage();
                var errorMessage = passwordAlertMessageBox;
                string alertMessage = passwordAlertMessageBox;
                Console.WriteLine("messagebox.Text is:" + passwordAlertMessageBox);
                if (passwordAlertMessageBox.Contains("Password must be at least 6 characters"))
                {
                    Console.WriteLine("Password must be at least 6 characters");
                }
                else
                {
                    Console.WriteLine("Check Error");
                }
                Assert.AreEqual(alertMessage, passwordAlertMessageBox, "actual message and expected message do not match");
                if (testreport != null)
                {
                    testreport.Log(Status.Pass, "Test Passed");
                }
            }
        }
        public void invalidUsernameValidPasswordProcess()
        {
            baseObj.InitializeExtentReports();
            string testName = "InvalidUsernameData";
            baseObj.SetupTest(testName);
            LoginTestModel model = new LoginTestModel();
            List<LoginTestModel> InvalidUsernameData = Jsonhelper.ReadTestDataFromJson<LoginTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\InvalidUsernameData.json");
            foreach (var data in InvalidUsernameData)
            {
                string email = data.email;
                string password = data.password;
                string screenshotName = "InvalidUsernameData";
                baseObj.CaptureScreenshot(screenshotName);
                loginComponentObj.invalidUsernameValidPassword(data);
                string userNameAlertMessageBox = loginComponentObj.verifyUsernameMessage();
                var errorMessage = userNameAlertMessageBox;
                string alertMessage = userNameAlertMessageBox;
                Console.WriteLine("messagebox.Text is:" + userNameAlertMessageBox);
                if (userNameAlertMessageBox.Contains("Please enter a valid email address"))
                {
                    Console.WriteLine("Please enter a valid email address");
                }
                else
                {
                    Console.WriteLine("Check Error");
                }
                Assert.AreEqual(alertMessage, userNameAlertMessageBox, "actual message and expected message do not match");
                if (testreport != null)
                {
                    testreport.Log(Status.Pass, "Test Passed");
                }
            }

        }
    }
}
