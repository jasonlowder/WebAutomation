using System;
using WebAutomationFramework;

namespace Chase.Page
{
    public class Pages : PagesBase
    {
        public static Uri HomePageUrl = new Uri("https://www.chase.com");

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static NavigationPage Navigation
        {
            get { return GetPage<NavigationPage>(); }
        }

        public static AccountActivityPage AccountActivity
        {
            get { return GetPage<AccountActivityPage>(); }
        }

        public static DownloadCenterPage DownloadCenter
        {
            get { return GetPage<DownloadCenterPage>(); }
        }
    }
}
