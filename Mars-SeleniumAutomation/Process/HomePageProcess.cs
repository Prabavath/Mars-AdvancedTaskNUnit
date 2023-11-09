using Mars_SeleniumAutomation.Pages;
using Mars_SeleniumAutomation.Pages.Components.ProfilePageOverview;
using Mars_SeleniumAutomation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_SeleniumAutomation.Process
{
    public class HomePageProcess:Base
    {
        private ProfileMenuTab profileMenuTabObj;
#pragma warning disable 
        public HomePageProcess()
        {
            profileMenuTabObj = new ProfileMenuTab();
        }
        public void clickOnUsernameAvailabilityDetails()
        {
            profileMenuTabObj.clickUserNameIcon();
        }
        public void clickOnAvailabilityEditIcon()
        {
            profileMenuTabObj.clickAvailabilityEditBtn();
        }
        public void clickOnHoursEditIcon() 
        {
            profileMenuTabObj.clickHoursEditBtn();
        }
        public void clickOnEarnTargetEditIcon() 
        {
            profileMenuTabObj.clickEarnTargetEditBtn();
        }
        public void clickOnDescriptionEditIcon()
        {
            profileMenuTabObj.clickDescriptionEditIcon();
        }
        public void clickOnLanguageTab()
        {
            profileMenuTabObj.clickLanguagesTab();
        }
        public void clickOnLanguageEditIcon() 
        {
            profileMenuTabObj.clickLanguageEditIcon();
        }
        public void clickOnDeleteIcon()
        {
            profileMenuTabObj.clickDeleteIcon();
        }
        public void clickOnShareSkillTab()
        {
            profileMenuTabObj.clickShareSkillTab();
        }
        public void clickOnManageListingTab()
        {
            profileMenuTabObj.clickManageListingTab();
        }
        public void clickOnManageListing()
        {
            profileMenuTabObj.clickProfileManageListing();
        }
        public void clickOnManageListingEditIcon()
        {
            profileMenuTabObj.clickManageListingEditIcon();
        }
        public void clickOnManageShareskillTab()
        {
            profileMenuTabObj.clickServiceShareSkill();
        }
    }
}
