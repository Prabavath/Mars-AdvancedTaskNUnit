using Mars_SeleniumAutomation.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_SeleniumAutomation.Pages.Components.ProfilePageOverview
{
    public class ProfileAboutMe : Base
    {
#pragma warning disable
        private IWebElement enterFirstName;
        private IWebElement enterLastName;
        private IWebElement saveButton;
        private IWebElement addedUsername;
        private IWebElement availabilityType;
        private IWebElement availabilityHours;
        private IWebElement availabilityTarget;
        private IWebElement addedAvailability;
        private IWebElement addedHours;
        private IWebElement addedEarnTarget;
        private IWebElement message;
        public void renderComponents()
        {
            try
            {
                enterFirstName = driver.FindElement(By.Name("firstName"));
                enterLastName  = driver.FindElement(By.Name("lastName"));
                saveButton     = driver.FindElement(By.XPath("//button[normalize-space()='Save']"));          
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex);
            }
        }
        public void renderAvailabilityComponent()
        {
           availabilityType = driver.FindElement(By.Name("availabilityType")); 
        }
        public void renderHoursComponent()
        {
            availabilityHours = driver.FindElement(By.Name("availabilityHour"));
        }
        public void renderEarnTargetComponent()
        {
            availabilityTarget = driver.FindElement(By.Name("availabilityTarget"));
        }
        public void renderAddTestComponent() 
        {
            addedUsername = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]"));
        }
        public void renderAvailabilityTestComponent()
        {
            addedAvailability = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span"));
        }                                                    
        public void renderHoursTestComponent() 
        {
            addedHours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div"));
        }
        public void renderEarnTargetTestComponent()
        {
            addedEarnTarget = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div"));
        }
        public void renderMessageComponent()
        {
            message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        }
        public void usernameAvailabilityDetails(string firstName,string lastName)
        {
            Thread.Sleep(2000);
            renderComponents();
            enterFirstName.Clear();
            enterLastName.SendKeys(firstName);
            enterLastName.Clear();
            enterLastName.SendKeys(lastName);
            saveButton.Click();
        }
        public string getVerifyUsername()
        {
            renderAddTestComponent();
            return addedUsername.Text;
        }
       public void addAndUpdateAvailabilityDetails(string availability)
        {
            renderAvailabilityComponent();
            availabilityType.SendKeys(availability);
        }
        public string getAddedAvailability()
        {
            renderAvailabilityTestComponent();
            return addedAvailability.Text; 
        }
        public string getSuccessMessage()
        {
            renderMessageComponent();
            return message.Text;
        }
        public void addAndUpdateHoursDetails(string hours)
        {
            renderHoursComponent();
            availabilityHours.SendKeys(hours);       
        }
        public string getAddedHours()
        {
            renderHoursTestComponent();
            return addedHours.Text;
        }
        public void addAndUpdateEarnTargetDetails(string earnTarget)
        {
            renderEarnTargetComponent();
            availabilityTarget.SendKeys(earnTarget);
        }
        public string getAddedEarnTarget()
        {
            renderEarnTargetTestComponent();
            return addedEarnTarget.Text;
        }
    }
}
