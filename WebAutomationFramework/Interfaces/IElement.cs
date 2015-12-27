namespace WebAutomationFramework.Interfaces
{
    public interface IElement
    {
        void Click();
        IElement FindById(string elementId);
        IElement FindByText(string elementText);
        IElement FindByCss(string cssSelector);
        void EnterText(string text);
        void SelectByText(string text);
    }
}
