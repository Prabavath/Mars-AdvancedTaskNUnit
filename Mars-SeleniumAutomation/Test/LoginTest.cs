using Mars_SeleniumAutomation.Pages;
using Mars_SeleniumAutomation.Pages.Components.SignIn;
using Mars_SeleniumAutomation.Process;
using Mars_SeleniumAutomation.TestModel;
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
    public class LoginTest:Base
    {
        HostPage hostPageObj;
        LoginProcess loginProcessObj;
        public LoginTest() 
        {
            loginProcessObj = new LoginProcess();
            hostPageObj = new HostPage();
        }
        [Test,Order(1)]
        public void givenValidLoginTest()
        {
            loginProcessObj.doLogin();
        }
        [Test, Order(2)]
        public void givenValidUserInvalidPasswordTest()
        {
            hostPageObj.clickSignIn();
            loginProcessObj.validUserInvalidPasswordProcess();
        }
        [Test, Order(3)]
        public void givenInValidUsernameTest()
        {
            hostPageObj.clickSignIn();
            loginProcessObj.invalidUsernameValidPasswordProcess();
        }
    }
}


