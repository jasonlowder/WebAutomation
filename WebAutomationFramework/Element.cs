using OpenQA.Selenium;
using WebAutomationFramework.Interfaces;

namespace WebAutomationFramework
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

        public IElement FindById(string elementId)
        {
            _element.FindElement(By.Id(elementId));
            return this;
        }

        public IElement FindByText(string elementText)
        {
            _element.FindElement(By.LinkText(elementText));
            return this;
        }

        public IElement FindByCss(string cssSelector)
        {
            _element.FindElement(By.CssSelector(cssSelector));
            return this;
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
    }
}
