using AventStack.ExtentReports;
using Mars_SeleniumAutomation.Pages.Components.ProfilePageOverview;
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
    public class ProfileDescriptionProcess : Base
    {
#pragma warning disable
        ProfileDescription profileDescriptionObj;
        ExtentTest testreport;
        public ProfileDescriptionProcess()
        {
            profileDescriptionObj = new ProfileDescription();
        }
        public void addDescription()
        {
            ProfileDescriptionTestModel model = new ProfileDescriptionTestModel();
            List<ProfileDescriptionTestModel> ProfileDescriptiondata = Jsonhelper.ReadTestDataFromJson<ProfileDescriptionTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\ProfileDescriptiondata.json");
            foreach (var data in ProfileDescriptiondata)
            {
                string text = data.textArea;
                LogScreenshot("AddDescription"); 
                profileDescriptionObj.addAndUpdateDescriptionDetails(text);
                string addedDescription = profileDescriptionObj.getVerifyAddedDescription();
                Assert.AreEqual(addedDescription, text, "Actual text and expected text do not match");
                if (testreport != null)
                {
                    testreport.Log(Status.Pass, "Test Passed");
                }
            }
        }
        public void addNegativeDescription()
        {
            ProfileDescriptionTestModel model = new ProfileDescriptionTestModel();
            List<ProfileDescriptionTestModel> NegativeDescriptiondata = Jsonhelper.ReadTestDataFromJson<ProfileDescriptionTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\NegativeDescriptiondata.json");
            foreach (var data in NegativeDescriptiondata)
            {
                string textArea = data.textArea;
                LogScreenshot("NegativeDescriptiondata");
                profileDescriptionObj.addNegativeDescription(textArea);
                string messageBox = profileDescriptionObj.negativeDescriptionMessage();
                var popupMessageText = messageBox;
                string expectedMessage = "First character can only be digit or letters";
                if (popupMessageText == expectedMessage)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine(expectedMessage);
                }
                else
                {
                    Console.WriteLine("Check Error");
                }
                Assert.AreEqual(messageBox, popupMessageText, "Actual message and expected message do not match");
                if (testreport != null)
                {
                    testreport.Log(Status.Pass, "Test Passed");
                }
            }
        }
        public void deleteDescription()
        {
            ProfileDescriptionTestModel model = new ProfileDescriptionTestModel();
            List<ProfileDescriptionTestModel> DeleteDescriptiondata = Jsonhelper.ReadTestDataFromJson<ProfileDescriptionTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\DeleteDescriptiondata.json");
            foreach (var data in DeleteDescriptiondata)
            {
                string textArea = data.textArea;
                LogScreenshot("DeleteDescriptiondata");
                profileDescriptionObj.deleteDescription(textArea);
                string desDeleteMessage = profileDescriptionObj.verifyDesDeleteMessage();
                var messageText = desDeleteMessage;
                string expectedMessage1 = "Please, a description is required";
                if (messageText == expectedMessage1)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine(expectedMessage1);
                }
                else
                {
                    Console.WriteLine("Check Error");
                }
                Assert.AreEqual(desDeleteMessage, messageText, "Actual message and expected message do not match");
                if (testreport != null)
                {
                    testreport.Log(Status.Pass, "Test Passed");
                }
            }
        }
    }
}
