using Mars_SeleniumAutomation.Pages.Components.ProfilePageOverview;
using Mars_SeleniumAutomation.Process;
using Mars_SeleniumAutomation.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_SeleniumAutomation.Test
{
    [TestFixture]
    public class LanguageTest : Base
    {
        LoginProcess loginProcessObj;
        HomePageProcess homePageProcessObj;
        LanguageProcess languageProcessObj;
        AddUpdateLanguageComponent addUpdateLanguageComponentObj;
       public LanguageTest()
       {
           loginProcessObj = new LoginProcess();
           homePageProcessObj = new HomePageProcess();
           languageProcessObj = new LanguageProcess();
           addUpdateLanguageComponentObj = new AddUpdateLanguageComponent();
       }
        [Test,Order(1)]
        public void addLanguageTest()
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnLanguageTab();
            addUpdateLanguageComponentObj.clearExistingData();
            languageProcessObj.addedLanguageDetails();
        }
        [Test,Order(2)]
        public void updateLanguageTest() 
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnLanguageTab();
            homePageProcessObj.clickOnLanguageEditIcon();
            languageProcessObj.updatedLanguageDetails();
        }
        [Test, Order(3)]
        public void deleteLanguageTest()
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnLanguageTab();
            homePageProcessObj.clickOnDeleteIcon();
            languageProcessObj.deletedLanguageDetails();
        }
        [Test, Order(4)]
        public void addLanguageNegativeTest()
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnLanguageTab();
            addUpdateLanguageComponentObj.clearExistingData();
            languageProcessObj.negativeLanguageDetails();
        }
        [Test, Order(5)]
        public void updateLanguageNegativeTest()
        {
            loginProcessObj.doLogin();
            homePageProcessObj.clickOnLanguageTab();
            homePageProcessObj.clickOnLanguageEditIcon();
            languageProcessObj.negativeUpdateLanguageDetails();
        }
    }
}

    

