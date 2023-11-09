using Mars_SeleniumAutomation.Pages.Components.ProfilePageOverview;
using Mars_SeleniumAutomation.TestModel;
using Mars_SeleniumAutomation.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_SeleniumAutomation.Process
{
    public class ProfileAboutMeProcess:Base
    {
#pragma warning disable
        ProfileAboutMe profileAboutMeObj;
        public ProfileAboutMeProcess()
        {
            profileAboutMeObj = new ProfileAboutMe();
        }
        public void updateUsername()
        {
            ProfileAvailabilityTestModel model = new ProfileAvailabilityTestModel();
            List<ProfileAvailabilityTestModel> ProfileAvailabilitydata = Jsonhelper.ReadTestDataFromJson<ProfileAvailabilityTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\UsernameDetaisdata.json");
            foreach (var profile in ProfileAvailabilitydata) 
            {
                string firstName = profile.firstName;
                string lastName = profile.lastName;
                profileAboutMeObj.usernameAvailabilityDetails(firstName, lastName);
                string addedUsername = profileAboutMeObj.getVerifyUsername();
                string expectedUsername = profile.firstName +" "+ profile.lastName;
                Assert.AreEqual(expectedUsername, addedUsername, "Actual Username do not match");               
            }
        }
        public void updateAvailabilityType()
        {
            ProfileAvailabilityTestModel model = new ProfileAvailabilityTestModel();
            List<ProfileAvailabilityTestModel> ProfileAvailabilitydata = Jsonhelper.ReadTestDataFromJson<ProfileAvailabilityTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\ProfileAvailabilitydata.Json");
            foreach (var profile in ProfileAvailabilitydata)
            {
                string availability = profile.availability;
                profileAboutMeObj.addAndUpdateAvailabilityDetails(availability);
                string addedAvailability = profileAboutMeObj.getAddedAvailability();
                string expectedAvailability = profile.availability;
                Assert.AreEqual(addedAvailability, expectedAvailability, "Actual availability do not match" );
            }
        }
        public void updateAvailabilityHours()
        {
            ProfileAvailabilityTestModel model = new ProfileAvailabilityTestModel();
            List<ProfileAvailabilityTestModel> ProfileAvailabilitydata = Jsonhelper.ReadTestDataFromJson<ProfileAvailabilityTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\ProfileHoursdata.json");
            foreach(var profile in ProfileAvailabilitydata)
            {
                string hours = profile.hours;
                profileAboutMeObj.addAndUpdateHoursDetails(hours);
                string addedHours = profileAboutMeObj.getAddedHours();
                Assert.AreEqual(addedHours, hours, "Actual hours do not match");
            }
        }
        public void updateAvailabilityEarnTarget()
        {
            ProfileAvailabilityTestModel model = new ProfileAvailabilityTestModel();
            List<ProfileAvailabilityTestModel> ProfileAvailabilitydata = Jsonhelper.ReadTestDataFromJson<ProfileAvailabilityTestModel>("D:\\IC Course\\AdvancedNUnit\\Mars-AdvancedTaskNUnit\\Mars-SeleniumAutomation\\JsonData\\ProfileEarnTargetdata.json");
            foreach (var profile in ProfileAvailabilitydata)
            {
                string earnTarget = profile.earnTarget;
                profileAboutMeObj.addAndUpdateEarnTargetDetails(earnTarget);
                string addedEarnTarget = profileAboutMeObj.getAddedEarnTarget();
                Assert.AreEqual(addedEarnTarget, earnTarget, "Actual earnTarget do not match");
            }
        }
    } 
}
