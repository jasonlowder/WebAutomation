using WebAutomationFramework;
using WebAutomationFramework.Interfaces;

namespace Chase.Page
{
    public class LoginPage : IPage
    {
        private const string usernameTextboxId = "usr_name_home";
        private const string passwordTextboxId = "usr_password_home";
        private const string submitId = "Sign in";

        public IBrowser Browser { get; set; }

        public void GoTo(int attempt = 0)
        {
            Browser.GoToUrl(Pages.HomePageUrl);
        }

        public void LoginAs(UserBase user)
        {
            Browser.FinElementById(usernameTextboxId).EnterText(user.UserName);
            Browser.FinElementById(passwordTextboxId).EnterText(user.Password);
            Browser.FinElementByLinkText(submitId).Click();
        }
    }
}
