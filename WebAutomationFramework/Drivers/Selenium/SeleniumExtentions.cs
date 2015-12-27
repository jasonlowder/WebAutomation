using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;
using WebAutomationFramework.Interfaces;

namespace WebAutomationFramework.Drivers.Selenium
{
    public static class SeleniumExtentions
    {
        public static ReadOnlyCollection<IElement> ConvertToIElements(this ReadOnlyCollection<IWebElement> elements)
        {
            var webElements = elements.Select(webElement => new Element(webElement)).Cast<IElement>().ToList();
            return webElements.AsReadOnly();
        }
    }
}
