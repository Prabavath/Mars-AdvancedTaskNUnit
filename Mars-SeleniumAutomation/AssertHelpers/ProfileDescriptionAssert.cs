using Mars_SeleniumAutomation.Pages.Components.ProfilePageOverview;
using Mars_SeleniumAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_SeleniumAutomation.AssertHelpers
{
    public class ProfileDescriptionAssert:Base
    {
        ProfileDescription profileDescriptionObj;
        public ProfileDescriptionAssert()
        {
            profileDescriptionObj = new ProfileDescription();
        }
        public string messageAssertion()
        {
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Wait.WaitToBeVisible(driver, "XPath", "", 30);
            string actualMessage = messageBox.Text;
            return actualMessage;
        }
    }
}
