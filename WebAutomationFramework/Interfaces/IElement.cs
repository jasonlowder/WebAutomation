namespace WebAutomationFramework.Interfaces
{
    public interface IElement : IFinder
    {
        void Click();
        void EnterText(string text);
        void SelectByText(string text);
    }
}
