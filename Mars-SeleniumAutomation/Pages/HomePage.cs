using Mars_SeleniumAutomation.Pages.Components.ProfilePageOverview;
using Mars_SeleniumAutomation.Utilities;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_SeleniumAutomation.Pages
{
    public class HomePage : Base
    {
#pragma warning disable
        private IWebElement userNameLabel;
        public void renderComponents()
        {
            userNameLabel = driver.FindElement(By.XPath("//span[contains(@class,'item ui')]"));
        }
        public string VerifyUserName()
        {
            Thread.Sleep(2000);
            renderComponents();
            return userNameLabel.Text;
        }
    }
}
