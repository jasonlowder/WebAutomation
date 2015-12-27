using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using WebAutomationFramework.Interfaces;

namespace WebAutomationFramework.Drivers.Selenium
{
    public class SeleniumDriver : IDriver
    {
        private readonly IWebDriver _driver;

        public string PageSource { get { return _driver.PageSource; } }
        public string Title { get { return _driver.Title; } }
        public string Url { get { return _driver.Url; } }

        public SeleniumDriver(IWebDriver driver)
        {
            _driver = driver;
            var window = _driver.Manage().Window;
            var handles = _driver.WindowHandles;
            var currentHandle = _driver.CurrentWindowHandle;
        }

        public void Close()
        {
            _driver.Close();
        }

        public IElement FinElementByClassName(string className)
        {
            return new Element(_driver.FindElement(By.ClassName(className)));
        }

        public IElement FinElementByCss(string selector)
        {
            return new Element(_driver.FindElement(By.CssSelector(selector)));
        }

        public IElement FinElementById(string id)
        {
            return new Element(_driver.FindElement(By.Id(id)));
        }

        public IElement FinElementByLinkText(string text)
        {
            return new Element(_driver.FindElement(By.LinkText(text)));
        }

        public IElement FinElementByName(string name)
        {
            return new Element(_driver.FindElement(By.Name(name)));
        }

        public IElement FinElementByPartialLinkText(string partialText)
        {
            return new Element(_driver.FindElement(By.PartialLinkText(partialText)));
        }

        public IElement FinElementByTagName(string tagName)
        {
            return new Element(_driver.FindElement(By.TagName(tagName)));
        }

        public IElement FinElementByXPath(string path)
        {
            return new Element(_driver.FindElement(By.XPath(path)));
        }

        public ReadOnlyCollection<IElement> FinElementsByClassName(string className)
        {
            return _driver.FindElements(By.ClassName(className)).ConvertToIElements();
        }

        public ReadOnlyCollection<IElement> FinElementsByCss(string selector)
        {
            return _driver.FindElements(By.CssSelector(selector)).ConvertToIElements();
        }

        public ReadOnlyCollection<IElement> FinElementsById(string id)
        {
            return _driver.FindElements(By.Id(id)).ConvertToIElements();
        }

        public ReadOnlyCollection<IElement> FinElementsByLinkText(string text)
        {
            return _driver.FindElements(By.LinkText(text)).ConvertToIElements();
        }

        public ReadOnlyCollection<IElement> FinElementsByName(string name)
        {
            return _driver.FindElements(By.Name(name)).ConvertToIElements();
        }

        public ReadOnlyCollection<IElement> FinElementsByPartialLinkText(string partialText)
        {
            return _driver.FindElements(By.PartialLinkText(partialText)).ConvertToIElements();
        }

        public ReadOnlyCollection<IElement> FinElementsByTagName(string tagName)
        {
            return _driver.FindElements(By.TagName(tagName)).ConvertToIElements();
        }

        public ReadOnlyCollection<IElement> FinElementsByXPath(string path)
        {
            return _driver.FindElements(By.XPath(path)).ConvertToIElements();
        }

        public void NavigateBack()
        {
            _driver.Navigate().Back();
        }

        public void NavigateForward()
        {
            _driver.Navigate().Forward();
        }

        public void GoToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void GoToUrl(Uri url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void Refresh()
        {
            _driver.Navigate().Refresh();
        }

        public void Quit()
        {
            _driver.Quit();
        }

        #region Advanced

        public void Cookies()
        {
            _driver.Manage().Cookies.AddCookie(new Cookie("", ""));
            var cookies = _driver.Manage().Cookies.AllCookies;
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Manage().Cookies.DeleteCookie(new Cookie("", ""));
            _driver.Manage().Cookies.DeleteCookieNamed("");
            _driver.Manage().Cookies.GetCookieNamed("");
        }

        public void Timeouts()
        {
            _driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan());
            _driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan());
            _driver.Manage().Timeouts().SetScriptTimeout(new TimeSpan());
        }

        public void Switchs()
        {
            _driver.SwitchTo().ActiveElement();
            _driver.SwitchTo().Alert();
            _driver.SwitchTo().DefaultContent();
            _driver.SwitchTo().Frame(0);
            _driver.SwitchTo().Frame("");
            _driver.SwitchTo().ParentFrame();
            _driver.SwitchTo().Window("");
        }

        #endregion
    }
}
