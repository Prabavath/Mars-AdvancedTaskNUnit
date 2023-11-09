using Mars_SeleniumAutomation.Pages.Components.ServiceListingOverview;
using Mars_SeleniumAutomation.Process;
using Mars_SeleniumAutomation.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_SeleniumAutomation.Test
{
    [TestFixture]
    public class ShareSkillTest : Base
    {
        LoginProcess loginProcessObj;
        HomePageProcess homePageProcessObj;
        ShareSkillProcess shareSkillProcessObj;
        ShareSkillAddComponent shareSkillAddComponentObj;
#pragma warning disable
        public ShareSkillTest()
        {
            loginProcessObj = new LoginProcess();
            homePageProcessObj = new HomePageProcess();
            shareSkillProcessObj = new ShareSkillProcess();
            shareSkillAddComponentObj = new ShareSkillAddComponent();
        }
        [Test,Order(1)]
        public void ShareSkillAddTest()
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnManageListing();
            shareSkillAddComponentObj.clearExistingData();
            homePageProcessObj.clickOnManageShareskillTab();
            shareSkillProcessObj.addShareSkillDetails();
        }
        [Test,Order(2)]
        public void UpdateShareSkill_Test()
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnManageListing();
            shareSkillProcessObj.shareSkillUpdate();

        }
        [Test,Order(3)]
        public void AddNegativeShareSkillTest() 
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnShareSkillTab();
            shareSkillProcessObj.shareSkillAddNegative();
        }
        [Test,Order(4)]
        public void UpdateNegativeShareSkillTest() 
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnManageListing();
            shareSkillProcessObj.ShareSkillUpdateNegative();
        }
    }
}
