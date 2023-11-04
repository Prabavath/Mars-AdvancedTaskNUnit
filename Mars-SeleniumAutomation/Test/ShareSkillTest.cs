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
        public ShareSkillTest()
        {
            loginProcessObj = new LoginProcess();
            homePageProcessObj = new HomePageProcess();
            shareSkillProcessObj = new ShareSkillProcess();
        }
        [Test,Order(1)]
        public void ShareSkillAddTest()
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnShareSkillTab();
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
