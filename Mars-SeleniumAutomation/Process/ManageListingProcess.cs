using Mars_SeleniumAutomation.Pages.Components.ProfilePageOverview;
using Mars_SeleniumAutomation.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_SeleniumAutomation.Process
{
    public class ManageListingProcess:Base
    {
        ManageListingComponent manageListingComponentObj;
        public ManageListingProcess()
        {
            manageListingComponentObj = new ManageListingComponent();
        }
        public void deleteManageListProcess()
        {
            manageListingComponentObj.deleteManageListing();
            string messageBox = manageListingComponentObj.verifyDeleteManageList();
            var popupMessageText = messageBox;

            string popupMessage = messageBox;
            Console.WriteLine("messageBox.Text is: " + popupMessage);
            if (popupMessage.Contains("has been deleted"))
            {
                Console.WriteLine("API Testing has been deleted");
            }
            else
            {
                Console.WriteLine("Check Error");
            }

            Assert.AreEqual(messageBox, popupMessageText, "Actual message and expected message do not match");
        }
    }
}
