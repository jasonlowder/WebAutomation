using System;
using OpenQA.Selenium;
using WebAutomationFramework.Interfaces;

namespace WebAutomationFramework
{
    public class Browser
    {
        private readonly IBrowserDriver _browserDriver;
        //private static Browser _instance;

        //public static Browser Instance
        //{
        //    get
        //    {
        //        if (_instance != null) return _instance;
        //        using (var scope = Container)
        //        {
                    
        //        }
        //        return _instance ?? {_instance = new Browser()};
        //    }
        //}

        private Browser(IBrowserDriver browserDriver)
        {
            _browserDriver = browserDriver;
            //var downloadFilePath = @"c:\Users\jason\Documents\OFX\";
            //var options = new ChromeOptions();
            //options.AddUserProfilePreference("download.default_directory", downloadFilePath);

            //_driver = new ChromeDriver(@"C:\Users\jason\Documents\Visual Studio 2013\Projects\WebAutomation\", options);
            //_driver.Manage().Window.Maximize();
            //_driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(TimeSpan.TicksPerSecond));
        }

        public void GoTo(Uri url)
        {
            _browserDriver.Driver.Navigate().GoToUrl(url);
        }

        public IElement FindById(string elementId)
        {
            var element = _browserDriver.Driver.FindElement(By.Id(elementId));
            return new Element(element);
        }

        public IElement FindByText(string elementText)
        {
            var element = _browserDriver.Driver.FindElement(By.LinkText(elementText));
            return new Element(element);
        }

        public IElement FindByName(string elementName)
        {
            var element = _browserDriver.Driver.FindElement(By.Name(elementName));
            return new Element(element);
        }

        public void Cleanup()
        {
            _browserDriver.Driver.Quit();
        }
    }
}
