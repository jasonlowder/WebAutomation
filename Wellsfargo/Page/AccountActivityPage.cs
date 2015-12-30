using WebAutomationFramework;
using WebAutomationFramework.Interfaces;

namespace Wellsfargo.Page
{
    public class AccountActivityPage : IPage
    {
        public IBrowser Browser { get; set; }

        public void GoTo(int attempt = 0)
        {
            Pages.Navigation.AccountActivity();
        }
    }
}
