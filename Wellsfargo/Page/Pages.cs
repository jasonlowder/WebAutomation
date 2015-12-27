using System;

namespace Wellsfargo.Page
{
    public class Pages : WebAutomationFramework.PagesBase
    {
        public static Uri HomePageUrl = new Uri("https://www.wellsfargo.com");

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
