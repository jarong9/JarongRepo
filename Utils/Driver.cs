using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WSECU
{
    class Driver
    {
        public static IWebDriver browserWin;
        private static string driverpath = Directory.GetCurrentDirectory();

        public static void initIEBrowser()
        {
            InternetExplorerOptions ieCapabilities = new InternetExplorerOptions();
            ieCapabilities.IgnoreZoomLevel = true;
            ieCapabilities.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            ieCapabilities.EnableNativeEvents = true;
            ieCapabilities.EnablePersistentHover = true;
            ieCapabilities.UnhandledPromptBehavior = UnhandledPromptBehavior.Accept;
            ieCapabilities.EnsureCleanSession = true;
            ieCapabilities.RequireWindowFocus = true;

            browserWin = new InternetExplorerDriver(driverpath, ieCapabilities);
            browserWin.Manage().Window.Maximize();
            browserWin.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void initFFBrowser()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(driverpath, "geckodriver.exe");
            
            browserWin = new FirefoxDriver((service));
            browserWin.Manage().Window.Maximize();
            browserWin.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void initChromeBrowser()
        {
            browserWin = new ChromeDriver(driverpath);
            browserWin.Manage().Window.Maximize();
            browserWin.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }
}
