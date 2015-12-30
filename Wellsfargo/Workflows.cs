using WebAutomationFramework;
using Wellsfargo.Page;

namespace Wellsfargo
{
    public static class Workflows
    {
        private static bool LoggedIn { get; set; }

        public static void Login()
        {
            if (LoggedIn) return;

            Pages.Login.GoTo();
            Pages.Login.LoginAs(User.Wellsfargo);
            LoggedIn = true;
        }

        public static void ViewTransactions()
        {
            Login();
            Pages.AccountActivity.GoTo();
        }

        public static void DownLoadTransactions()
        {
            ViewTransactions();
            Pages.DownloadCenter.GoTo();
            Pages.DownloadCenter.Download();
        }

        public static void Cleanup()
        {
            //Browser.Instance.Cleanup();
        }
    }
}
