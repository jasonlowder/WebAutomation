using System;
using WebAutomationFramework;
using WebAutomationFramework.Interfaces;

namespace Wellsfargo.Page
{
    public class DownloadCenterPage : IPage
    {
        public Browser Browser { get; set; }

        public void GoTo(int attempt = 0)
        {
            Pages.Navigation.DownloadCenter();
        }

        public void Download()
        {
            Browser.FindById("fromDate").EnterText(DateTime.Now.AddDays(-1).ToString("MM/dd/yy"));
            Browser.FindById("toDate").EnterText(DateTime.Now.ToString("MM/dd/yy"));
            Browser.FindById("quickenOFX").Click();
            Browser.FindByName("Download").Click();
        }
    }
}
