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
            throw new System.NotImplementedException();
        }

        public IElement FindById(string elementId)
        {
            throw new System.NotImplementedException();
        }

        public IElement FindByText(string elementText)
        {
            throw new System.NotImplementedException();
        }

        public IElement FindByCss(string cssSelector)
        {
            throw new System.NotImplementedException();
        }

        public void EnterText(string text)
        {
            throw new System.NotImplementedException();
        }

        public void SelectByText(string text)
        {
            throw new System.NotImplementedException();
        }
    }
}
