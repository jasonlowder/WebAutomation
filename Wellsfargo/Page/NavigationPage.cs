using WebAutomationFramework;
using WebAutomationFramework.Interfaces;

namespace Wellsfargo.Page
{
    public class NavigationPage : IPage
    {
        public Browser Browser { get; set; }

        public void GoTo(int attempt = 0)
        {
            throw new System.NotImplementedException();
        }

        public void AccountActivity()
        {
            Browser.FindByText("Account Activity").Click();
        }

        public void DownloadCenter()
        {
            AccountActivity();
            Browser.FindByText("Download Account Activity").Click();
        }
    }
}
