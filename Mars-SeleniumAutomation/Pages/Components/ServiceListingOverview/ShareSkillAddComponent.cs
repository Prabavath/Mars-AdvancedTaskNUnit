using Mars_SeleniumAutomation.TestModel;
using Mars_SeleniumAutomation.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_SeleniumAutomation.Pages.Components.ServiceListingOverview
{
    public class ShareSkillAddComponent : Base
    {
#pragma warning disable
        private IWebElement addTitle;
        private IWebElement addDescription;
        private IWebElement chooseCategory;
        private IWebElement chooseSubcategory;
        private IWebElement addTag;
        private IWebElement serviceTypeBtn;
        private IWebElement locationTypeBtn;
        private IWebElement availableDaysStartDate;
        private IWebElement availableDaysEndDate;
        private IWebElement availableDays;
        private IWebElement selectStartTime;
        private IWebElement selectEndTime;
        private IWebElement skillTradeBtn;
        private IWebElement skillExchangeTag;
        private IWebElement activeButton;
        private IWebElement saveButton;
        private IWebElement messageBox;
        private IWebElement availableSunday;
        private IWebElement addedShareSkillCategory;
        private IWebElement editedShareSkillCategory;
        private IWebElement cancelButton;
        
        public void renderComponents()
        {
              try
              {
                  addTitle         = driver.FindElement(By.Name("title"));
                  addDescription   = driver.FindElement(By.Name("description"));
                  chooseCategory   = driver.FindElement(By.Name("categoryId"));              
              }
              catch (Exception ex)
              {
                  Console.WriteLine(ex);
              }
          }
          public void renderSubcategoryComponent()
          {
              chooseSubcategory = driver.FindElement(By.Name("subcategoryId"));
          }
          public void renderTagComponent()
          {
              addTag = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
          }
          public void renderTypeComponents()
          {
              serviceTypeBtn = driver.FindElement(By.XPath("//input[@name='serviceType' and @value='1']"));
              locationTypeBtn = driver.FindElement(By.Name("locationType"));
          }
          public void renderDaysComponents()
          {
              availableDaysStartDate = driver.FindElement(By.Name("startDate"));
              availableDaysEndDate = driver.FindElement(By.Name("endDate"));
              
          }
          public void renderTimeComponents()
          {
             availableSunday = driver.FindElement(By.Name("Available"));
             selectStartTime = driver.FindElement(By.Name("StartTime"));
             selectEndTime = driver.FindElement(By.Name("EndTime"));
          }
          public void renderTradeComponents()
          {
              skillTradeBtn = driver.FindElement(By.XPath("//input[@name='skillTrades' and @value='true']"));
              skillExchangeTag = driver.FindElement(By.XPath("//div[@class='form-wrapper']//input[@placeholder='Add new tag']"));
          }
          public void renderActiveComponent()
          {
              activeButton = driver.FindElement(By.Name("isActive"));
          }
          public void renderSaveComponent()
          {
            saveButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
          }
          public void renderCancelComponent()
          {
            cancelButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[2]"));
          }
          public void renderAddedShareSkill()
          {
            addedShareSkillCategory = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]"));
          }
          public void renderEditedShareSkill()
          {
            editedShareSkillCategory = driver.FindElement(By.XPath("//td[normalize-space()='Digital Marketing']"));
          }
          public void renderErrorMessageBox()
          {
            messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
          }
          public void addShareSkill(ShareSkillTestModel addSkill)
          {
              Thread.Sleep(2000);
              renderComponents();
              Thread.Sleep(2000);
              addTitle.SendKeys(addSkill.title);
              addDescription.SendKeys(addSkill.description);
              chooseCategory.SendKeys(addSkill.category);
              renderSubcategoryComponent();
              Thread.Sleep(2000);
              chooseSubcategory.SendKeys(Keys.Tab);
              chooseSubcategory.SendKeys(addSkill.subcategory);
          }
          public void addShareSkillTag(ShareSkillTestModel addSkill)
          {
              Thread.Sleep(2000);
              renderTagComponent();
              addTag.SendKeys(addSkill.tags);
              addTag.SendKeys(Keys.Enter);
          }
          public void addShareSkillType()
          {
              Thread.Sleep(2000);
              renderTypeComponents();
              Thread.Sleep(2000);
              serviceTypeBtn.Click();
              locationTypeBtn.Click();
          }
          public void addShareSkillDays(ShareSkillTestModel addSkill)
          {
              Thread.Sleep(2000);
              renderDaysComponents();
              availableDaysStartDate.SendKeys(addSkill.startDate);
              availableDaysEndDate.SendKeys(addSkill.endDate);
          }
          public void addShareSkillTime(ShareSkillTestModel addSkill)
          {
              renderTimeComponents();
              availableSunday.Click();
              selectStartTime.SendKeys(addSkill.startTime);
              selectEndTime.SendKeys(addSkill.endTime);
          }
          public void addShareSkillTrade(ShareSkillTestModel addSkill)
          {
              renderTradeComponents();
              Thread.Sleep(2000);
              skillTradeBtn.Click();
              skillExchangeTag.SendKeys(addSkill.skillExchange);
              skillExchangeTag.SendKeys(Keys.Enter);
          }
         public void addShareSkillActive()
         {
             renderActiveComponent();
             activeButton.Click();
             renderSaveComponent();          
             saveButton.SendKeys(Keys.Enter);
             driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
             saveButton.Submit();
         }
        public void newShareSkill(ShareSkillTestModel addSkill)
        {
             addShareSkill(addSkill);
             addShareSkillTag(addSkill);
             addShareSkillType();
             addShareSkillDays(addSkill);
             addShareSkillTime(addSkill);
             addShareSkillTrade(addSkill);
             addShareSkillActive();               
        }
        public string verifyAddedShareSkill()
        {
            Thread.Sleep(2000);
            renderAddedShareSkill();
            return addedShareSkillCategory.Text;
        }
        public void EditShareSkill(ShareSkillTestModel addSkill)
        {
            Thread.Sleep(2000);
            renderComponents();
            addTitle.SendKeys(Keys.Control + "A");
            addTitle.SendKeys(Keys.Delete);
            addTitle.SendKeys(addSkill.title);
            addDescription.SendKeys(Keys.Control + "A");
            addDescription.SendKeys(Keys.Delete);
            addDescription.SendKeys(addSkill.description);
            chooseCategory.SendKeys(addSkill.category);
            renderSubcategoryComponent();
            chooseSubcategory.SendKeys(Keys.Tab);
            chooseSubcategory.SendKeys(addSkill.subcategory);
            Thread.Sleep(2000);
            renderTagComponent();
            addTag.SendKeys(addSkill.tags);
            addTag.SendKeys(Keys.Enter);
            renderTypeComponents();
            serviceTypeBtn.Click();
            locationTypeBtn.Click();
            Thread.Sleep(2000);
            renderDaysComponents();
            availableDaysStartDate.SendKeys(addSkill.startDate);
            availableDaysEndDate.SendKeys(addSkill.endDate);
            renderTimeComponents();
            availableSunday.Click();
            selectStartTime.SendKeys(addSkill.startTime);
            selectEndTime.SendKeys(addSkill.endTime);
            Thread.Sleep(3000);
            renderTradeComponents();
            skillTradeBtn.Click();
            skillExchangeTag.SendKeys(addSkill.skillExchange);
            skillExchangeTag.SendKeys(Keys.Enter);
            renderActiveComponent();
            activeButton.Click();
            renderSaveComponent();
            saveButton.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            saveButton.Submit();
        }
        public string verifyEditedShareSkill()
        {
            Thread.Sleep(2000);
            renderEditedShareSkill();
            return editedShareSkillCategory.Text;
        }
        public void shareSkillAddNegative(ShareSkillTestModel addSkill)
        {
            Thread.Sleep(2000);
            renderComponents();
            addTitle.SendKeys(Keys.Control + "A");
            addTitle.SendKeys(Keys.Delete);
            addDescription.SendKeys(Keys.Control + "A");
            addDescription.SendKeys(Keys.Delete);
            chooseCategory.SendKeys(addSkill.category);
            renderSubcategoryComponent();
            chooseSubcategory.SendKeys(Keys.Tab);
            chooseSubcategory.SendKeys(addSkill.subcategory);
            Thread.Sleep(2000);
            renderTagComponent();
            addTag.SendKeys(addSkill.tags);
            addTag.SendKeys(Keys.Enter);
            renderTypeComponents();
            serviceTypeBtn.Click();
            locationTypeBtn.Click();
            Thread.Sleep(2000);
            renderDaysComponents();
            availableDaysStartDate.SendKeys(addSkill.startDate);
            availableDaysEndDate.SendKeys(addSkill.endDate);
            renderTimeComponents();
            availableSunday.Click();
            selectStartTime.SendKeys(addSkill.startTime);
            selectEndTime.SendKeys(addSkill.endTime);
            Thread.Sleep(2000);
            renderTradeComponents();
            skillTradeBtn.Click();
            skillExchangeTag.SendKeys(addSkill.skillExchange);
            skillExchangeTag.SendKeys(Keys.Enter);
            renderActiveComponent();
            activeButton.Click();
            renderSaveComponent();
            saveButton.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            saveButton.Submit();
            Thread.Sleep(2000);
            renderCancelComponent();
            cancelButton.Click();
        }
        public string verifyNegativeShareSkill()
        {
            Thread.Sleep(2000);
            renderErrorMessageBox();
            return messageBox.Text;
        }
        public void shareSkillUpdateNegative(ShareSkillTestModel addSkill)
        {
            Thread.Sleep(2000);
            renderComponents();
            addTitle.SendKeys(Keys.Control + "A");
            addTitle.SendKeys(Keys.Delete);
            addTitle.SendKeys(addSkill.title);
            addDescription.SendKeys(Keys.Control + "A");
            addDescription.SendKeys(Keys.Delete);
            addDescription.SendKeys(addSkill.description);
            chooseCategory.SendKeys(addSkill.category);
            renderSubcategoryComponent();
            chooseSubcategory.SendKeys(Keys.Tab);
            chooseSubcategory.SendKeys(addSkill.subcategory);
            Thread.Sleep(2000);
            renderTagComponent();
            addTag.SendKeys(addSkill.tags);
            addTag.SendKeys(Keys.Enter);
            renderTypeComponents();
            serviceTypeBtn.Click();
            locationTypeBtn.Click();
            Thread.Sleep(2000);
            renderDaysComponents();
            availableDaysStartDate.SendKeys(addSkill.startDate);
            availableDaysEndDate.SendKeys(addSkill.endDate);
            renderTimeComponents();
            availableSunday.Click();
            selectStartTime.SendKeys(addSkill.startTime);
            selectEndTime.SendKeys(addSkill.endTime);
            Thread.Sleep(3000);
            renderTradeComponents();
            skillTradeBtn.Click();
            skillExchangeTag.SendKeys(addSkill.skillExchange);
            skillExchangeTag.SendKeys(Keys.Enter);
            renderActiveComponent();
            activeButton.Click();
            renderSaveComponent();
            saveButton.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            saveButton.Submit();
            renderCancelComponent();
            cancelButton.Click();
        }
        public string verifyNegativeShareSkillUpdate()
        {
            Thread.Sleep(2000);
            renderErrorMessageBox();
            return messageBox.Text;
        }
    }
}
    

