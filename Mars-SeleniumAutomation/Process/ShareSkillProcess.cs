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
        ExtentTest testreport;
#pragma warning disable
        public ShareSkillProcess()
        {
            shareSkillAddComponentObj = new ShareSkillAddComponent();
            homePageProcessObj = new HomePageProcess();
        }
        
        public void addShareSkillDetails()
        {
            ShareSkillTestModel model = new ShareSkillTestModel();
            List<ShareSkillTestModel> ShareSkillData = Jsonhelper.ReadTestDataFromJson<ShareSkillTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\ShareSkillData.json");
            foreach (var data in ShareSkillData)
            {
                string title = data.title;
                string description = data.description;
                string category = data.category;
                string subcategory = data.subcategory;
                string tags = data.tags;
                string startDate = data.startDate;
                string endDate = data.endDate;
                string startTime = data.startTime;
                string endTime = data.endTime;
                string skillExchange = data.skillExchange;
                LogScreenshot("ShareSkillData");
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
            ShareSkillTestModel model = new ShareSkillTestModel();
            List<ShareSkillTestModel> ShareSkillEditdata = Jsonhelper.ReadTestDataFromJson<ShareSkillTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\ShareSkillEditdata.json");
            foreach (var data in ShareSkillEditdata)
            {
                string title = data.title;
                string description = data.description;
                string category = data.category;
                string subcategory = data.subcategory;
                string tags = data.tags;
                string startdate = data.startDate;
                string enddate = data.endDate;
                string skillExchange = data.skillExchange;
                LogScreenshot("ShareSkillEditdata");
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
            ShareSkillTestModel model = new ShareSkillTestModel();
            List<ShareSkillTestModel> ShareSkillAddNegativedata = Jsonhelper.ReadTestDataFromJson<ShareSkillTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\ShareSkillAddNegativedata.json");
            foreach (var data in ShareSkillAddNegativedata)
            {
                string title = data.title;
                string description = data.description;
                string category = data.category;
                string subcategory = data.subcategory;
                string tags = data.tags;
                string startDate = data.startDate;
                string endDate = data.endDate;
                string startTime = data.startTime;
                string endTime = data.endTime;
                string skillExchange = data.skillExchange;
                LogScreenshot("ShareSkillAddNegativedata");
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
            ShareSkillTestModel model = new ShareSkillTestModel();
            List<ShareSkillTestModel> ShareSkillUpdateNegativedata = Jsonhelper.ReadTestDataFromJson<ShareSkillTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\ShareSkillUpdateNegativedata.json");
            foreach (var data in ShareSkillUpdateNegativedata)
            {
                LogScreenshot("ShareSkillUpdateNegativedata");
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


