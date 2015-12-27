using WebAutomationFramework;
using WebAutomationFramework.Interfaces;

namespace Wellsfargo.Page
{
    public class AccountActivityPage : IPage
    {
        public Browser Browser { get; set; }

        public void GoTo(int attempt = 0)
        {
            Pages.Navigation.AccountActivity();
        }
    }
}
