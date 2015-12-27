using WebAutomationFramework;
using WebAutomationFramework.Interfaces;

namespace Chase.Page
{
    public class LoginPage : IPage
    {
        private const string usernameTextboxId = "usr_name_home";
        private const string passwordTextboxId = "usr_password_home";
        private const string submitId = "Sign in";

        public Browser Browser { get; set; }
        public void GoTo(int attempt = 0)
        {
            Browser.GoTo(Pages.HomePageUrl);
        }

        public void LoginAs(UserBase user)
        {
            Browser.FindById(usernameTextboxId).EnterText(user.UserName);
            Browser.FindById(passwordTextboxId).EnterText(user.Password);
            Browser.FindByText(submitId).Click();
        }
    }
}
