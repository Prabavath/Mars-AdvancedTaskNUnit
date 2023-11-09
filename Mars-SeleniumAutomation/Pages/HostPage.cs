using Mars_SeleniumAutomation.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_SeleniumAutomation.Pages
{
    public class HostPage:Base
    {
#pragma warning disable
        private IWebElement signInButton;
        public void renderComponents()
        {
            signInButton = driver.FindElement(By.XPath("//*[text()='Sign In']"));
        }
        public void clickSignIn() 
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[text()='Sign In']", 10);
            renderComponents();
            signInButton.Click();
        }
    }
}
