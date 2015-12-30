using System.Collections.ObjectModel;
using OpenQA.Selenium;
using WebAutomationFramework.Interfaces;

namespace WebAutomationFramework.Drivers.Selenium
{
    public class Element : IElement
    {
        private readonly IWebElement _element;

        public Element(IWebElement element)
        {
            _element = element;
        }

        public void Click()
        {
            _element.Click();
        }

        public void EnterText(string text)
        {
            _element.Clear();
            _element.SendKeys(text);
        }

        public void SelectByText(string text)
        {
            _element.SendKeys(text);
        }

        public IElement FinElementByClassName(string className)
        {
            return new Element(_element.FindElement(By.ClassName(className)));
        }

        public IElement FinElementByCss(string selector)
        {
            return new Element(_element.FindElement(By.CssSelector(selector)));
        }

        public IElement FinElementById(string id)
        {
            return new Element(_element.FindElement(By.Id(id)));
        }

        public IElement FinElementByLinkText(string text)
        {
            return new Element(_element.FindElement(By.LinkText(text)));
        }

        public IElement FinElementByName(string name)
        {
            return new Element(_element.FindElement(By.Name(name)));
        }

        public IElement FinElementByPartialLinkText(string partialText)
        {
            return new Element(_element.FindElement(By.PartialLinkText(partialText)));
        }

        public IElement FinElementByTagName(string tagName)
        {
            return new Element(_element.FindElement(By.TagName(tagName)));
        }

        public IElement FinElementByXPath(string path)
        {
            return new Element(_element.FindElement(By.XPath(path)));
        }

        public ReadOnlyCollection<IElement> FinElementsByClassName(string className)
        {
            return _element.FindElements(By.ClassName(className)).ConvertToIElements();
        }

        public ReadOnlyCollection<IElement> FinElementsByCss(string selector)
        {
            return _element.FindElements(By.CssSelector(selector)).ConvertToIElements();
        }

        public ReadOnlyCollection<IElement> FinElementsById(string id)
        {
            return _element.FindElements(By.Id(id)).ConvertToIElements();
        }

        public ReadOnlyCollection<IElement> FinElementsByLinkText(string text)
        {
            return _element.FindElements(By.LinkText(text)).ConvertToIElements();
        }

        public ReadOnlyCollection<IElement> FinElementsByName(string name)
        {
            return _element.FindElements(By.Name(name)).ConvertToIElements();
        }

        public ReadOnlyCollection<IElement> FinElementsByPartialLinkText(string partialText)
        {
            return _element.FindElements(By.PartialLinkText(partialText)).ConvertToIElements();
        }

        public ReadOnlyCollection<IElement> FinElementsByTagName(string tagName)
        {
            return _element.FindElements(By.TagName(tagName)).ConvertToIElements();
        }

        public ReadOnlyCollection<IElement> FinElementsByXPath(string path)
        {
            return _element.FindElements(By.XPath(path)).ConvertToIElements();
        }
    }
}
