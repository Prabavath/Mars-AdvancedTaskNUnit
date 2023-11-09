using Mars_SeleniumAutomation.Utilities;//*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i
using Microsoft.CodeAnalysis.CSharp.Syntax;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using TechTalk.SpecFlow.Assist;

namespace Mars_SeleniumAutomation.Pages.Components.ProfilePageOverview
{
    public class ProfileMenuTab : Base
    {
#pragma warning disable
        private IWebElement userNameDropdownIcon;
        private IWebElement availabilityEditBtn;
        private IWebElement hoursEditBtn;
        private IWebElement earnTargetEditBtn;
        private IWebElement descriptionEditIcon;
        private IWebElement languagesTab;
        private IWebElement languageEditIcon;
        private IWebElement languageDeleteIcon;
        private IWebElement shareSkillTab;
        private IWebElement manageListingTab;
        private IWebElement manageListing;
        private IWebElement manageListingEditIcon;
        private IWebElement serviceShareSkillTab;
        public void renderComponents()
        {
            try
            {
                userNameDropdownIcon = driver.FindElement(By.XPath("//div[@class='title']//i[@class='dropdown icon']"));
                availabilityEditBtn  = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]//section[2]//div[2]//div[3]//div[2]/div/span/i"));
                hoursEditBtn         = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]//section[2]//div[2]//div/div/div[3]//div[3]/div/span/i"));
                earnTargetEditBtn    =  driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]//section[2]//div[2]//div[3]//div[4]/div/span/i"));
                descriptionEditIcon  = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex);
            }
        }
        public void renderLanguageComponent()
        {
            try 
            {
                languagesTab = driver.FindElement(By.XPath("//a[normalize-space()='Languages']"));
                languageEditIcon = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
        }
        public void renderLanguageDeleteComponent() 
        {
            languageDeleteIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr[last()]/td[3]/span[2]/i"));
        }
        public void renderShareSkillTabComponent()
        {
            shareSkillTab = driver.FindElement(By.XPath("//a[normalize-space()='Share Skill']"));
        }
        public void renderManageListingTab()
        {
            manageListingTab = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/section[1]/div/a[3]"));
        }
        public void renderProfileManageListingComponent()
        {
            manageListing = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]"));
        }
        public void renderManageListingEditIcon() 
        {
            manageListingEditIcon = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));
        }
        public void renderServiceShareSkill()
        {
            serviceShareSkillTab = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/section[1]/div/div[2]/a"));
        }
        public void clickUserNameIcon()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//div[@class='title']//i[@class='dropdown icon']", 20);
            renderComponents();
            userNameDropdownIcon.Click();
        }
        public void clickAvailabilityEditBtn() 
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]//section[2]//div[2]//div[3]//div[2]/div/span/i", 20);
            renderComponents();
            availabilityEditBtn.Click();
        }
        public void clickHoursEditBtn() 
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]//section[2]//div[2]//div/div/div[3]//div[3]/div/span/i", 20);
            renderComponents();
            hoursEditBtn.Click();
        }
        public void clickEarnTargetEditBtn() 
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]//section[2]//div[2]//div[3]//div[4]/div/span/i", 20);
            renderComponents();
            earnTargetEditBtn.Click();
        }
        public void clickDescriptionEditIcon()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 20);
            renderComponents();
            descriptionEditIcon.Click();
        }
        public void clickLanguagesTab()
        {
            renderLanguageComponent();
            languagesTab.Click();
        }
        public void clickLanguageEditIcon()
        {
            renderLanguageComponent();
            languageEditIcon.Click();
        }
        public void clickDeleteIcon()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr[last()]/td[3]/span[2]/i", 20);
            renderLanguageDeleteComponent();
            languageDeleteIcon.Click();
        }
        public void clickShareSkillTab()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//a[normalize-space()='Share Skill']", 20);
            renderShareSkillTabComponent();
            shareSkillTab.Click();
        }
        public void clickManageListingTab()
        {
            renderManageListingTab();
            manageListingTab.Click();
        }
        public void clickProfileManageListing()
        {
            Thread.Sleep(2000);
            renderProfileManageListingComponent();
            manageListing.Click();
            Wait.WaitToBeVisible(driver, "XPath", ".//i[@class='remove icon']", 20);
        }
        public void clickManageListingEditIcon()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i", 20);
            renderManageListingEditIcon();
            manageListingEditIcon.Click();
        }
        public void clickServiceShareSkill()
        {
            renderServiceShareSkill();
            serviceShareSkillTab.Click();
        }
    }
}
