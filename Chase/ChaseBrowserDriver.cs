using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebAutomationFramework.Interfaces;

namespace Chase
{
    public class ChaseBrowserDriver : IBrowserDriver
    {

        public IWebDriver Driver { get; private set; }

        public ChaseBrowserDriver()
        {
            const string downloadFilePath = @"c:\Users\jason\Documents\OFX\";
            var options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", downloadFilePath);

            Driver = new ChromeDriver(@"C:\Users\jason\Documents\Visual Studio 2013\Projects\WebAutomation\", options);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(TimeSpan.TicksPerSecond));
        }
    }
}
