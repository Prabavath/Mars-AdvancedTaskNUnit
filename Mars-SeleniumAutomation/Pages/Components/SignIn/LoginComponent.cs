using Mars_SeleniumAutomation.TestModel;
using Mars_SeleniumAutomation.Utilities;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_SeleniumAutomation.Pages.Components.SignIn
{
    public class LoginComponent:Base
    {
#pragma warning disable
        private IWebElement emailTextbox;
        private IWebElement passwordTextbox;
        private IWebElement loginButton;
        private IWebElement passwordAlertMessage;
        private IWebElement emailAlertMessage;
         public void renderComponents()
         {
                emailTextbox = driver.FindElement(By.XPath("//*[@placeholder='Email address']"));
                passwordTextbox = driver.FindElement(By.XPath("//*[@placeholder='Password']"));
                loginButton = driver.FindElement(By.XPath("//*[text()='Login']"));
         }
        public void renderPasswordMessage()
        {
            passwordAlertMessage = driver.FindElement(By.XPath("//div[contains(text(),'Password must be at least 6 characters')]"));
        }
        public void renderUsernameMessage()
        {
            emailAlertMessage = driver.FindElement(By.XPath("//div[contains(text(),'Please enter a valid email address')]"));
        }
        public void validLogin(LoginTestModel data)
        {
            renderComponents();
            emailTextbox.SendKeys(data.email);
            passwordTextbox.SendKeys(data.password);
            loginButton.Click();
        }
        public void validUserInvalidPassword(LoginTestModel data)
        {
            renderComponents();
            emailTextbox.SendKeys(data.email);
            passwordTextbox.SendKeys(data.password);
            loginButton.Click();
        }
        public string verifyPasswordMessage()
        {
            renderPasswordMessage();
            return passwordAlertMessage.Text;
        }
        public void invalidUsernameValidPassword(LoginTestModel data)
        {
            renderComponents();
            emailTextbox.SendKeys(data.email);
            passwordTextbox.SendKeys(data.password);
            loginButton.Click();
        }
        public string verifyUsernameMessage()
        {
            renderUsernameMessage();
            return emailAlertMessage.Text;
        }
    }
}


