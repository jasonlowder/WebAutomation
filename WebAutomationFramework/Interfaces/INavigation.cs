using System;

namespace WebAutomationFramework.Interfaces
{
    public interface INavigation
    {
        void Close();
        void NavigateBack();
        void NavigateForward();
        void GoToUrl(string url);
        void GoToUrl(Uri url);
        void Refresh();
        void Quit();
    }
}
