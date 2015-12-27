using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;

namespace WebAutomationFramework.Factories
{
    public static class SeleniumDriverFactory
    {
        public static IWebDriver ChromeDriver(DriverOptions options)
        {
            var chromeOptions = new ChromeOptions();
            foreach (var key in options.Preferences.Keys)
            {
                chromeOptions.AddUserProfilePreference(key, options.Preferences[key]);
            }
            
            var driver = new ChromeDriver(options.DriverDirectory, chromeOptions);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(TimeSpan.TicksPerSecond));

            return driver;
        }
        public static IWebDriver EdgeDriver()
        {
            return new EdgeDriver();
        }
        public static IWebDriver FirefoxDriver()
        {
            return new FirefoxDriver();
        }
        public static IWebDriver IEDriver()
        {
            return new InternetExplorerDriver();
        }
        public static IWebDriver OperaDriver()
        {
            return new OperaDriver();
        }
        public static IWebDriver PhantomJsDriver()
        {
            return new PhantomJSDriver();
        }
        public static IWebDriver RemoteWebDriver()
        {
            return new RemoteWebDriver();
        }
        public static IWebDriver SafariDriver()
        {
            return new SafariDriver();
        }
    }
}
