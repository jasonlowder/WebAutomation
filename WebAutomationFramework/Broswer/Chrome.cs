using System;
using System.Collections.ObjectModel;
using WebAutomationFramework.Interfaces;

namespace WebAutomationFramework.Broswer
{
    public class Chrome : IBrowser
    {
        private readonly IDriver _driver;

        public Chrome(IDriver driver)
        {
            _driver = driver;
        }

        public IElement FinElementByClassName(string className)
        {
            return _driver.FinElementByClassName(className);
        }

        public IElement FinElementByCss(string selector)
        {
            return _driver.FinElementByCss(selector);
        }

        public IElement FinElementById(string id)
        {
            return _driver.FinElementById(id);
        }

        public IElement FinElementByLinkText(string text)
        {
            return _driver.FinElementByLinkText(text);
        }

        public IElement FinElementByName(string name)
        {
            return _driver.FinElementByName(name);
        }

        public IElement FinElementByPartialLinkText(string partialText)
        {
            return _driver.FinElementByPartialLinkText(partialText);
        }

        public IElement FinElementByTagName(string tagName)
        {
            return _driver.FinElementByTagName(tagName);
        }

        public IElement FinElementByXPath(string path)
        {
            return _driver.FinElementByXPath(path);
        }

        public ReadOnlyCollection<IElement> FinElementsByClassName(string className)
        {
            return _driver.FinElementsByClassName(className);
        }

        public ReadOnlyCollection<IElement> FinElementsByCss(string selector)
        {
            return _driver.FinElementsByCss(selector);
        }

        public ReadOnlyCollection<IElement> FinElementsById(string id)
        {
            return _driver.FinElementsById(id);
        }

        public ReadOnlyCollection<IElement> FinElementsByLinkText(string text)
        {
            return _driver.FinElementsByLinkText(text);
        }

        public ReadOnlyCollection<IElement> FinElementsByName(string name)
        {
            return _driver.FinElementsByName(name);
        }

        public ReadOnlyCollection<IElement> FinElementsByPartialLinkText(string partialText)
        {
            return _driver.FinElementsByPartialLinkText(partialText);
        }

        public ReadOnlyCollection<IElement> FinElementsByTagName(string tagName)
        {
            return _driver.FinElementsByTagName(tagName);
        }

        public ReadOnlyCollection<IElement> FinElementsByXPath(string path)
        {
            return _driver.FinElementsByXPath(path);
        }

        public void Close()
        {
            _driver.Close();
        }

        public void NavigateBack()
        {
            _driver.NavigateBack();
        }

        public void NavigateForward()
        {
            _driver.NavigateForward();
        }

        public void GoToUrl(string url)
        {
            _driver.GoToUrl(url);
        }

        public void GoToUrl(Uri url)
        {
            _driver.GoToUrl(url);
        }

        public void Refresh()
        {
            _driver.Refresh();
        }

        public void Quit()
        {
            _driver.Quit();
        }
    }
}
