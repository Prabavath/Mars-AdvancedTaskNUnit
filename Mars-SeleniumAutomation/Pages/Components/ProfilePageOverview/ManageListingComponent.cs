using Mars_SeleniumAutomation.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_SeleniumAutomation.Pages.Components.ProfilePageOverview
{
    public class ManageListingComponent :Base
    {
#pragma warning disable
        private IWebElement deleteIcon;
        private IWebElement yesButton;
        private IWebElement noButton;
        private IWebElement messageBox;
        public void renderDeleteComponent()
        {
            deleteIcon = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i"));
        }
        public void renderAlertWindow()
        {
            yesButton = driver.FindElement(By.XPath("//button[normalize-space()='Yes']"));
            noButton = driver.FindElement(By.XPath("//button[normalize-space()='No']"));
        }
        public void renderAlertMessageBox()
        {
            messageBox = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']"));
        }
        public void deleteManageListing()
        {
            Thread.Sleep(2000);
            renderDeleteComponent();
            deleteIcon.Click();
            renderAlertWindow();
            yesButton.Click();
        }
        public string verifyDeleteManageList()
        {
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']", 20);
            renderAlertMessageBox();
            return messageBox.Text;
        }
    }
}
