using Mars_SeleniumAutomation.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_SeleniumAutomation.Pages.Components.ProfilePageOverview
{
    public class ProfileDescription:Base
    {
#pragma warning disable
        private IWebElement enterDescription;
        private IWebElement saveBtn;
        private IWebElement addedDescription;
        private IWebElement messageBox;
        private IWebElement desDeleteMessage;
        public void renderDescriptionComponents()
        {
            try
            {
                enterDescription = driver.FindElement(By.Name("value"));
                saveBtn          = driver.FindElement(By.XPath("//button[@type='button']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderDescriptionTestComponent()
        {
            addedDescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"));
        }
        public void renderMessageBoxTestComponent()
        {
            messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        }
        public void renderDeleteComponent()
        {
            desDeleteMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-error ns-show']"));
        }
        public void addAndUpdateDescriptionDetails(string textArea)
        {
            renderDescriptionComponents();
            enterDescription.Clear();
            enterDescription.SendKeys(textArea);
            saveBtn.Click();
        }
        public string getVerifyAddedDescription() 
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span", 20);
            renderDescriptionTestComponent();
            return addedDescription.Text;
        }
        public string getMessage()
        {
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);
            renderMessageBoxTestComponent();
            return messageBox.Text;
        }
        public void addNegativeDescription(string textArea)
        {
            Thread.Sleep(2000);
            renderDescriptionComponents();
            enterDescription.Clear();
            enterDescription.SendKeys(textArea);
            saveBtn.Click();
        }
        public string negativeDescriptionMessage()
        {
            Wait.WaitToExist(driver, "XPath", "//div[@class='ns-box-inner']", 12);
            renderMessageBoxTestComponent();
            return messageBox.Text;
        }
        public void deleteDescription(string textArea)
        {
            renderDescriptionComponents();
            enterDescription.SendKeys(Keys.Control + "A");
            enterDescription.SendKeys(Keys.Delete);
            enterDescription.SendKeys(textArea);
            saveBtn.Click();
        }
        public string verifyDesDeleteMessage()
        {
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box ns-growl ns-effect-jelly ns-type-error ns-show']", 20);
            renderDeleteComponent();
            return desDeleteMessage.Text;
        }
    }
}
