using System;
using WebAutomationFramework;
using WebAutomationFramework.Interfaces;

namespace Wellsfargo.Page
{
    public class DownloadCenterPage : IPage
    {
        public IBrowser Browser { get; set; }

        public void GoTo(int attempt = 0)
        {
            Pages.Navigation.DownloadCenter();
        }

        public void Download()
        {
            Browser.FinElementById("fromDate").EnterText(DateTime.Now.AddDays(-1).ToString("MM/dd/yy"));
            Browser.FinElementById("toDate").EnterText(DateTime.Now.ToString("MM/dd/yy"));
            Browser.FinElementById("quickenOFX").Click();
            Browser.FinElementByName("Download").Click();
        }
    }
}
