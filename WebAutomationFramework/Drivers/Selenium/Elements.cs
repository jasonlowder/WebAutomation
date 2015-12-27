using System.Collections.Generic;
using OpenQA.Selenium;
using WebAutomationFramework.Interfaces;

namespace WebAutomationFramework.Drivers.Selenium
{
    public class Elements : List<IElement>
    {
        public Elements()
        {
        }

        public Elements(IReadOnlyCollection<IWebElement> elements)
        {
            foreach (var webElement in elements)
            {
                Add(new Element(webElement));
            }
        }
    }
}
