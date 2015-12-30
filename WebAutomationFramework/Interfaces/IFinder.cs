using System.Collections.ObjectModel;

namespace WebAutomationFramework.Interfaces
{
    public interface IFinder
    {
        IElement FinElementByClassName(string className);
        IElement FinElementByCss(string selector);
        IElement FinElementById(string id);
        IElement FinElementByLinkText(string text);
        IElement FinElementByName(string name);
        IElement FinElementByPartialLinkText(string partialText);
        IElement FinElementByTagName(string tagName);
        IElement FinElementByXPath(string path);
        ReadOnlyCollection<IElement> FinElementsByClassName(string className);
        ReadOnlyCollection<IElement> FinElementsByCss(string selector);
        ReadOnlyCollection<IElement> FinElementsById(string id);
        ReadOnlyCollection<IElement> FinElementsByLinkText(string text);
        ReadOnlyCollection<IElement> FinElementsByName(string name);
        ReadOnlyCollection<IElement> FinElementsByPartialLinkText(string partialText);
        ReadOnlyCollection<IElement> FinElementsByTagName(string tagName);
        ReadOnlyCollection<IElement> FinElementsByXPath(string path);
    }
}
