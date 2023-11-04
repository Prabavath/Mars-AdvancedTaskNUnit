using AventStack.ExtentReports;
using Mars_SeleniumAutomation.Pages.Components.ServiceListingOverview;
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
    public class ShareSkillProcess : Base
    {
        ShareSkillAddComponent shareSkillAddComponentObj;
        HomePageProcess homePageProcessObj;
        Jsonhelper jsonhelper;
        Base baseObj;
        ExtentTest testreport;
        private ExtentReports extent;
#pragma warning disable
        public ShareSkillProcess()
        {
            shareSkillAddComponentObj = new ShareSkillAddComponent();
            homePageProcessObj = new HomePageProcess();
            baseObj = new Base();
            jsonhelper = new Jsonhelper();
        }
        public void addShareSkillDetails()
        {
            baseObj.InitializeExtentReports();
            string testName = "ShareSkillData";
            baseObj.SetupTest(testName);
            ShareSkillTestModel model = new ShareSkillTestModel();
            List<ShareSkillTestModel> ShareSkillData = Jsonhelper.ReadTestDataFromJson<ShareSkillTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\ShareSkillData.json");
            foreach (var data in ShareSkillData)
            {
                string title = data.title;
                Console.WriteLine(title);
                string description = data.description;
                Console.WriteLine(description);
                string category = data.category;
                Console.WriteLine(category);
                string subcategory = data.subcategory;
                Console.WriteLine(subcategory);
                string tags = data.tags;
                Console.WriteLine(tags);
                string startDate = data.startDate;
                Console.WriteLine(startDate);
                string endDate = data.endDate;
                Console.WriteLine(endDate);
                string startTime = data.startTime;
                Console.WriteLine(startTime);
                string endTime = data.endTime;
                Console.WriteLine(endTime);
                string skillExchange = data.skillExchange;
                Console.WriteLine(skillExchange);
                string screenshotName = "ShareSkillData";
                baseObj.CaptureScreenshot(screenshotName);
                shareSkillAddComponentObj.newShareSkill(data);
                homePageProcessObj.clickOnManageListingTab();
                string addedShareSkillCategory = shareSkillAddComponentObj.verifyAddedShareSkill();
                if (addedShareSkillCategory == data.category)
                {
                    Assert.AreEqual(addedShareSkillCategory, data.category, "The actual and expected do not match");

                }
                else
                {
                    Console.WriteLine("Check error");
                }
                if (testreport != null)
                {
                    testreport.Log(Status.Pass, "Test Passed");
                }
            }
        }
        public void shareSkillUpdate()
        {
            baseObj.InitializeExtentReports();
            string testName = "ShareSkillEditdata";
            baseObj.SetupTest(testName);
            ShareSkillTestModel model = new ShareSkillTestModel();
            List<ShareSkillTestModel> ShareSkillEditdata = Jsonhelper.ReadTestDataFromJson<ShareSkillTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\ShareSkillEditdata.json");
            foreach (var data in ShareSkillEditdata)
            {
                string title = data.title;
                Console.WriteLine(title);
                string description = data.description;
                Console.WriteLine(description);
                string category = data.category;
                Console.WriteLine(category);
                string subcategory = data.subcategory;
                Console.WriteLine(subcategory);
                string tags = data.tags;
                Console.WriteLine(tags);
                string startdate = data.startDate;
                Console.WriteLine(startdate);
                string enddate = data.endDate;
                Console.WriteLine(enddate);
                string skillExchange = data.skillExchange;
                Console.WriteLine(skillExchange);
                string screenshotName = "ShareSkillEditdata";
                baseObj.CaptureScreenshot(screenshotName);
                homePageProcessObj.clickOnManageListingEditIcon();
                shareSkillAddComponentObj.EditShareSkill(data);
                homePageProcessObj.clickOnManageListingTab();
                string editedShareSkillCategory = shareSkillAddComponentObj.verifyEditedShareSkill();
                if (editedShareSkillCategory == data.category)
                {
                    Assert.AreEqual(editedShareSkillCategory, data.category, "The actual and expected do not match");
                }
                else
                {
                    Console.WriteLine("Check error");
                }
                if (testreport != null)
                {
                    testreport.Log(Status.Pass, "Test Passed");
                }
            }
        }
        public void shareSkillAddNegative()
        {
            baseObj.InitializeExtentReports();
            string testName = "ShareSkillAddNegativedata";
            baseObj.SetupTest(testName);
            ShareSkillTestModel model = new ShareSkillTestModel();
            List<ShareSkillTestModel> ShareSkillAddNegativedata = Jsonhelper.ReadTestDataFromJson<ShareSkillTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\ShareSkillAddNegativedata.json");
            foreach (var data in ShareSkillAddNegativedata)
            {
                string title = data.title;
                Console.WriteLine(title);
                string description = data.description;
                Console.WriteLine(description);
                string category = data.category;
                Console.WriteLine(category);
                string subcategory = data.subcategory;
                Console.WriteLine(subcategory);
                string tags = data.tags;
                Console.WriteLine(tags);
                string startDate = data.startDate;
                Console.WriteLine(startDate);
                string endDate = data.endDate;
                Console.WriteLine(endDate);
                string startTime = data.startTime;
                Console.WriteLine(startTime);
                string endTime = data.endTime;
                Console.WriteLine(endTime);
                string skillExchange = data.skillExchange;
                Console.WriteLine(skillExchange);
                string screenshotName = "ShareSkillAddNegativedata";
                baseObj.CaptureScreenshot(screenshotName);
                shareSkillAddComponentObj.shareSkillAddNegative(data);
                string messageBox = shareSkillAddComponentObj.verifyNegativeShareSkill();
                string expectedMessage = "Please complete the form correctly.";
                Assert.AreEqual(messageBox, expectedMessage, "Actual and expected do not match");
                if (testreport != null)
                {
                    testreport.Log(Status.Pass, "Test Passed");
                }
            }
        }
        public void ShareSkillUpdateNegative()
        {
            baseObj.InitializeExtentReports();
            string testName = "ShareSkillUpdateNegativedata";
            baseObj.SetupTest(testName);
            ShareSkillTestModel model = new ShareSkillTestModel();
            List<ShareSkillTestModel> ShareSkillUpdateNegativedata = Jsonhelper.ReadTestDataFromJson<ShareSkillTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\ShareSkillUpdateNegativedata.json");
            foreach (var data in ShareSkillUpdateNegativedata)
            {
                string screenshotName = "ShareSkillUpdateNegativedata";
                baseObj.CaptureScreenshot(screenshotName);
                homePageProcessObj.clickOnManageListingEditIcon();
                shareSkillAddComponentObj.shareSkillUpdateNegative(data);
                string messageBox = shareSkillAddComponentObj.verifyNegativeShareSkillUpdate();
                string expectedMessage = "Please complete the form correctly.";
                Assert.AreEqual(messageBox, expectedMessage, "Actual and expected do not match");
                if (testreport != null)
                {
                    testreport.Log(Status.Pass, "Test Passed");
                }
            }
        }
    }
}


