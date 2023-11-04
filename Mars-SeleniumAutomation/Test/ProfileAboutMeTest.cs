using Mars_SeleniumAutomation.Pages.Components.ProfilePageOverview;
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
    public class ProfileAboutMeTest : Base
    {
        LoginProcess loginProcessObj;
        HomePageProcess homePageProcessObj;
        ProfileAboutMeProcess profileAboutMeProcessObj;
        public ProfileAboutMeTest()
        {
            loginProcessObj = new LoginProcess();
            homePageProcessObj = new HomePageProcess();
            profileAboutMeProcessObj = new ProfileAboutMeProcess();
        }
        [Test,Order(1)]
        public void addAndUpdateUsernameTest()
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnUsernameAvailabilityDetails();
            profileAboutMeProcessObj.updateUsername();
        }
        [Test,Order(2)]
        public void addAndUpdateAvailabilityTest()
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnAvailabilityEditIcon();
            profileAboutMeProcessObj.updateAvailabilityType();
        }
        [Test,Order(3)]
        public void addAndupdateHoursTest()
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnHoursEditIcon();
            profileAboutMeProcessObj.updateAvailabilityHours();
        }
        [Test,Order(4)]
        public void addAndupdateEarnTargetTest() 
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnEarnTargetEditIcon();
            profileAboutMeProcessObj.updateAvailabilityEarnTarget();
        }
    }
}
