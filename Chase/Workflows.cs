using Chase.Page;
using WebAutomationFramework;

namespace Chase
{
    public class Workflows
    {
        private static bool LoggedIn { get; set; }

        public static void Login()
        {
            if (LoggedIn) return;

            Pages.Login.GoTo();
            Pages.Login.LoginAs(User.Chase);
            LoggedIn = true;
        }

        public static void ViewTransactions()
        {
            Login();
            Pages.AccountActivity.GoTo();
        }

        public static void DownLoadTransactions()
        {
            Login();
            Pages.Navigation.DownloadCenter();
            Pages.DownloadCenter.Download();
        }

        public static void Cleanup()
        {
            Browser.Instance.Cleanup();
        }
    }
}
