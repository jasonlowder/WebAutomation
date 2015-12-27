using WebAutomationFramework;
using WebAutomationFramework.Interfaces;

namespace Chase.Page
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
            MyAccount();
            Browser.FindByText("See activity ").Click();
        }

        public void DownloadCenter()
        {
            CustomerCenter();
            Browser.FindByText("Download activity").Click();
        }

        public void CustomerCenter()
        {
            Browser.FindById("megamenu-CustomerCenter").Click();
        }

        public void MyAccount()
        {
            Browser.FindById("megamenu-MyAccounts").Click();
        }
    }
}
