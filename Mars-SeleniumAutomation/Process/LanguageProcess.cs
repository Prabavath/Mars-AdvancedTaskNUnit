using AventStack.ExtentReports;
using Mars_SeleniumAutomation.Pages.Components.ProfilePageOverview;
using Mars_SeleniumAutomation.TestModel;
using Mars_SeleniumAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Mars_SeleniumAutomation.Process
{
    public class LanguageProcess : Base
    {
        AddUpdateLanguageComponent addUpdateLanguageComponentObj;
        Jsonhelper jsonhelperObj;
        Base baseObj;
        ExtentTest testreport;
        private ExtentReports extent;
#pragma warning disable
        public LanguageProcess()
        {
            addUpdateLanguageComponentObj = new AddUpdateLanguageComponent();
            baseObj = new Base();
            jsonhelperObj = new Jsonhelper();
        }
        public void addedLanguageDetails()
        {
            baseObj.InitializeExtentReports();
            string testName = "LanguageAddData";
            baseObj.SetupTest(testName);
            LanguageTestModel model = new LanguageTestModel();
            List<LanguageTestModel> LanguageAddData = Jsonhelper.ReadTestDataFromJson<LanguageTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\LanguageAddData.json");
            foreach (var data in LanguageAddData)
            {
                string language = data.language;
                Console.WriteLine(language);
                string level = data.level;
                Console.WriteLine(level);
                string screenshotName = "LanguageAddData";
                baseObj.CaptureScreenshot(screenshotName);
                addUpdateLanguageComponentObj.addLanguage(language, level);
                string newAddedLanguage = addUpdateLanguageComponentObj.verifyAddedLanguage();
                Assert.AreEqual(newAddedLanguage, language, "Actual language and expected language do not match");
                if (testreport != null)
                {
                    testreport.Log(Status.Pass, "Test Passed");
                }
            }
        }
        public void updatedLanguageDetails()
        {
            baseObj.InitializeExtentReports();
            string testName = "LanguageUpdateData";
            baseObj.SetupTest(testName);
            LanguageTestModel model = new LanguageTestModel();
            List<LanguageTestModel> LanguageUpdateData = Jsonhelper.ReadTestDataFromJson<LanguageTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\LanguageUpdateData.json");
            foreach (var data in LanguageUpdateData)
            {
                string language = data.language;
                Console.WriteLine(language);
                string level = data.level;
                Console.WriteLine(level);
                string screenshotName = "LanguageUpdateData";
                baseObj.CaptureScreenshot(screenshotName);
                addUpdateLanguageComponentObj.updateLanguage(language, level);
                string updatedLanguage = addUpdateLanguageComponentObj.verifyUpdatedLanguage();
                Assert.AreEqual(updatedLanguage, language, "Actual language and expected language do not match");
                if (testreport != null)
                {
                    testreport.Log(Status.Pass, "Test Passed");
                }
            }
        }
        public void deletedLanguageDetails()
        {
            addUpdateLanguageComponentObj.verifyDeletedLanguage();
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            var popupMessage = messageBox.Text;
            Console.WriteLine("messageBox.Text is: " + popupMessage);
            if (popupMessage.Contains("has been deleted from your languages"))
            {
                Console.WriteLine("Language has been deleted successfully");
            }
            else
            {
                Console.WriteLine("Check Error");
            }
            Assert.AreNotEqual(messageBox, popupMessage, "actual message and expected message do  match");
        }
        public void negativeLanguageDetails()
        {
            baseObj.InitializeExtentReports();
            string testName = "AddNegativeLanguagedata";
            baseObj.SetupTest(testName);
            LanguageTestModel model = new LanguageTestModel();
            List<LanguageTestModel> AddNegativeLanguagedata = Jsonhelper.ReadTestDataFromJson<LanguageTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\AddNegativeLanguagedata.json");
            foreach (var data in AddNegativeLanguagedata)
            {
                string language = data.language;
                Console.WriteLine(language);
                string level = data.level;
                Console.WriteLine(level);
                string screenshotName = "AddNegativeLanguagedata";
                baseObj.CaptureScreenshot(screenshotName);
                addUpdateLanguageComponentObj.addNegativeLanguage(language, level);
                string messageBox = addUpdateLanguageComponentObj.languageNegativeMessage();
                var popupMessageText = messageBox;
                string popupMessage = messageBox;
                Console.WriteLine("messageBox.Text is: " + popupMessage);
                string expectedMessage1 = "Duplicated data";
                string expectedMessage2 = "Please enter language and level";
                string expectedMessage3 = "This language is already exist in your language list.";
                if (popupMessage.Contains("has been added"))
                {
                    Console.WriteLine("Languages has been added successfully");
                }
                else if ((popupMessage == expectedMessage1 || popupMessage == expectedMessage2 || popupMessage == expectedMessage3))
                {
                    IWebElement cancelIcon = driver.FindElement(By.XPath("//input[@value='Cancel']"));
                    cancelIcon.Click();
                }
                else
                {
                    Console.WriteLine("Check Error");
                }
                Assert.AreEqual(messageBox, popupMessageText, "Actual message and expected message do not match");
                if (testreport != null)
                {
                    testreport.Log(Status.Pass, "Test Passed");
                }
            }
        }
        public void negativeUpdateLanguageDetails()
        {
            baseObj.InitializeExtentReports();
            string testName = "UpdateNegativeLanguagedata";
            baseObj.SetupTest(testName);
            LanguageTestModel model = new LanguageTestModel();
            List<LanguageTestModel> UpdateNegativeLanguagedata = Jsonhelper.ReadTestDataFromJson<LanguageTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\UpdateNegativeLanguagedata.json");
            foreach (var data in UpdateNegativeLanguagedata)
            {
                string language = data.language;
                Console.WriteLine(language);
                string level = data.level;
                Console.WriteLine(level);
                string screenshotName = "UpdateNegativeLanguagedata";
                baseObj.CaptureScreenshot(screenshotName);
                addUpdateLanguageComponentObj.negativeUpdateLanguage(language, level);
                string messageBox = addUpdateLanguageComponentObj.languageNegativeMessage();
                var popupMessageText = messageBox;
                string popupMessage = messageBox;
                Console.WriteLine("messageBox.Text is: " + popupMessage);
                string expectedMessage1 = "Please enter language and level";
                string expectedMessage2 = "This language is already exist in your language list.";
                if (popupMessage.Contains("has been added"))
                {
                    Console.WriteLine("Languages has been updated successfully");
                }
                else if ((popupMessage == expectedMessage1 || popupMessage == expectedMessage2 ))
                {
                    IWebElement cancelIcon = driver.FindElement(By.XPath("//input[@value='Cancel']"));
                    cancelIcon.Click();
                }
                else
                {
                    Console.WriteLine("Check Error");
                }
                Assert.AreEqual(messageBox, popupMessageText, "Actual message and expected message do not match");
                if (testreport != null)
                {
                    testreport.Log(Status.Pass, "Test Passed");
                }
            }
        }
    }
}

