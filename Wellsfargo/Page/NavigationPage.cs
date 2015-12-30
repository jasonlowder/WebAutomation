using WebAutomationFramework;
using WebAutomationFramework.Interfaces;

namespace Wellsfargo.Page
{
    public class NavigationPage : IPage
    {
        public IBrowser Browser { get; set; }

        public void GoTo(int attempt = 0)
        {
            throw new System.NotImplementedException();
        }

        public void AccountActivity()
        {
            Browser.FinElementByLinkText("Account Activity").Click();
        }

        public void DownloadCenter()
        {
            AccountActivity();
            Browser.FinElementByLinkText("Download Account Activity").Click();
        }
    }
}
