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
    public class ManageListingTest :Base
    {
        LoginProcess loginProcessObj;
        HomePageProcess homePageProcessObj;
        ManageListingProcess manageListingProcessObj;
        public ManageListingTest()
        {
            loginProcessObj = new LoginProcess();
            homePageProcessObj = new HomePageProcess();
            manageListingProcessObj = new ManageListingProcess();
        }
        [Test]
        public void DeleteManageListingTest()
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnManageListing();
            manageListingProcessObj.deleteManageListProcess();
        }
    }
}
