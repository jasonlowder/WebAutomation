using WebAutomationFramework;
using WebAutomationFramework.Interfaces;

namespace Wellsfargo.Page
{
    public class LoginPage : IPage
    {
        private const string usernameTextboxId = "userid";
        private const string passwordTextboxId = "password";
        private const string submitId = "btnSignon";

        public IBrowser Browser { get; set; }

        public void GoTo(int attempt = 0)
        {
            Browser.GoToUrl(Pages.HomePageUrl);
        }

        public void LoginAs(UserBase user)
        {
            Browser.FinElementById(usernameTextboxId).EnterText(user.UserName);
            Browser.FinElementById(passwordTextboxId).EnterText(user.Password);
            Browser.FinElementById(submitId).Click();
        }
    }
}
