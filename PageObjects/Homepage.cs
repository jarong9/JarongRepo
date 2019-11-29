using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSECU
{
    public class Homepage 
    {
        IWebDriver wd;
        
        public Homepage(IWebDriver driver)
        {
            this.wd = driver;
        }
        public IWebElement GetUserName()
        {
            IWebElement userName = wd.FindElement(By.Name("username"));
            return userName;
        }
        public IWebElement GetSignInButton()
        {
            IWebElement signInButton = wd.FindElement(By.CssSelector("input[type=submit]"));
            return signInButton;
        }
        public void SetUserName(string sValue)
        {
            this.GetUserName().SendKeys(sValue);   
        }
    }
}
