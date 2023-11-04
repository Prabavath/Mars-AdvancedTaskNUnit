using Mars_SeleniumAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Configuration.JsonConfig;

namespace Mars_SeleniumAutomation.Pages.Components.ProfilePageOverview
{
    public class AddUpdateLanguageComponent : Base
    {
#pragma warning disable
        private IWebElement languageTextBox;
        private IWebElement chooseLevelDropdown;
        private IWebElement addButton;
        private IWebElement messageBox;
        private IWebElement updateButton;
        private IWebElement addNewLanguageButton;
        private IWebElement newAddedLanguage;
        private IWebElement newAddedLevel;
        private IWebElement updatedLanguage;
        private IWebElement updatedLevel;
        private IWebElement languageEditBox;
        private IWebElement levelEditBox;
        private IWebElement deleteIcon;
        public void renderAddComponents()
        {
            try
            {
                languageTextBox     = driver.FindElement(By.Name("name"));
                chooseLevelDropdown = driver.FindElement(By.Name("level"));
                addButton           = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderAddNewComponent()
        {
            addNewLanguageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        }
        public void renderAddedLanguageTestComponent()
        {
            newAddedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        }
        public void renderUpdateComponent()
        {
            languageEditBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            levelEditBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
        }
        public void renderUpdatedTestComponent()
        {
            updatedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
        }
        public void renderMessage()
        {
            try
            {
                messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void clearExistingData()
        {
            try
            {
                IWebElement deleteButton = driver.FindElement(By.XPath("//div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
                var deleteButtons = driver.FindElements(By.XPath("//div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
                foreach (var button in deleteButtons)
                {
                    button.Click();
                }
            }
            catch (NoSuchElementException)
            { 
                Console.WriteLine("no items to delete"); 
            }
        }
        public void addLanguage(string language, string level)
        { 
            renderAddNewComponent();
            addNewLanguageButton.Click();
            renderAddComponents();
            languageTextBox.SendKeys(language);
            chooseLevelDropdown.SendKeys(level);
            addButton.Click();
        }
        public string verifyAddedLanguage()
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 20);
            renderAddedLanguageTestComponent();
            return newAddedLanguage.Text;
        }
        public void updateLanguage(string language,string level)
        {
            renderUpdateComponent();
            languageEditBox.Clear();
            languageEditBox.SendKeys(language);
            levelEditBox.SendKeys(level) ;
            updateButton.Click();
        }
        public string verifyUpdatedLanguage()
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]", 20);
            renderUpdatedTestComponent();
            return updatedLanguage.Text;
        }
        public string verifyDeletedLanguage()
        {
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);
            renderMessage();
            return messageBox.Text;
        }
        public void addNegativeLanguage(string language,string level)
        {
            renderAddNewComponent();
            addNewLanguageButton.Click();
            renderAddComponents();
            languageTextBox.SendKeys(language);
            chooseLevelDropdown.SendKeys(level);
            Thread.Sleep(1000);
            addButton.Click();
        }
        public string languageNegativeMessage()
        {
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);
            renderMessage();
            return messageBox.Text;
        }
        public void negativeUpdateLanguage(string language, string level)
        {
            renderUpdateComponent();
            languageEditBox.Clear();
            languageEditBox.SendKeys(language);
            levelEditBox.SendKeys(level);
            updateButton.Click();
        }
        public string verifyNegativeLanguage()
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]", 20);
            renderUpdatedTestComponent();
            return messageBox.Text;
        }
    }
}




