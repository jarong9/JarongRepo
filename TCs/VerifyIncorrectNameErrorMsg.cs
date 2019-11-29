using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace WSECU
{
    class VerifyIncorrectNameErrorMsg
    {
        private IWebDriver wd;

        [SetUp]
        public void startBrowser()
        {
            Driver.initChromeBrowser();
            wd = Driver.browserWin;
        }
        public static IEnumerable<string> GetTestData()
        {
            Utilities util = new Utilities();
            return util.LoadXMLdata();
        }
        
        [Test, TestCaseSource("GetTestData")]
        public void VerifyErrorMsg(string x)
        {
            // Go to homepage
            wd.Navigate().GoToUrl("https://wsecu.org/");
            
            Homepage objHome = new Homepage(wd);
            SignIn objSignIn = new SignIn(wd);
            
            // Enter username and click sign in button
            objHome.SetUserName(x);
            objHome.GetSignInButton().Click();
            // Verify it is redirected to sign in page
            Assert.AreEqual("Sign in to Online Banking", wd.Title.Trim());

            // Enter password and click sign in
            objSignIn.SetPassword("fakepwd");
            objSignIn.GetSignInButton().Click();

            // Verify error message of incorrect username
            String errorMsg = wd.FindElement(By.XPath("//div[@role='alert']/div/div")).Text;
            Assert.AreEqual("Sorry, incorrect username.", errorMsg);
        }
        [TearDown]
        public void closeBrowser()
        {
            wd.Close();
        }
    }
}
