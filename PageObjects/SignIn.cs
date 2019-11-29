using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSECU
{
    public class SignIn
    {
        IWebDriver wd;
        public SignIn(IWebDriver driver)
        {
            this.wd = driver;
        }
        // Define page objects
        public IWebElement GetPassword()
        {
            IWebElement passWord = wd.FindElement(By.Name("password"));
            return passWord;
        }
        public IWebElement GetSignInButton()
        {
            IWebElement signInButton = wd.FindElement(By.CssSelector("button[type=submit]"));
            return signInButton;
        }

        // Define page methods
        public void SetPassword(string sValue)
        {
            this.GetPassword().SendKeys(sValue);
        }
    }
}
