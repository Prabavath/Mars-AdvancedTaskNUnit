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
    public class ProfileDescriptionTest:Base
    {
#pragma warning disable
        LoginProcess loginProcessObj;
        HomePageProcess homePageProcessObj;
        ProfileDescriptionProcess profileDescriptionProcessObj;
        public ProfileDescriptionTest()
        {
            loginProcessObj = new LoginProcess();
            homePageProcessObj = new HomePageProcess();
            profileDescriptionProcessObj = new ProfileDescriptionProcess();
        }
        [Test,Order(1)]
        public void addAndUpdateDescriptionTest()
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnDescriptionEditIcon();
            profileDescriptionProcessObj.addDescription();
        }
        [Test, Order(2)]
        public void negativeDescriptionTest()
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnDescriptionEditIcon();
            profileDescriptionProcessObj.addNegativeDescription();
        }
        [Test,Order(3)]
        public void deleteDescriptionTest()
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnDescriptionEditIcon();
            profileDescriptionProcessObj.deleteDescription();
        }
    }
}
