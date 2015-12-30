using WebAutomationFramework;
using WebAutomationFramework.Interfaces;

namespace Chase.Page
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
            MyAccount();
            Browser.FinElementByLinkText("See activity ").Click();
        }

        public void DownloadCenter()
        {
            CustomerCenter();
            Browser.FinElementByLinkText("Download activity").Click();
        }

        public void CustomerCenter()
        {
            Browser.FinElementById("megamenu-CustomerCenter").Click();
        }

        public void MyAccount()
        {
            Browser.FinElementById("megamenu-MyAccounts").Click();
        }
    }
}
