using System;
using OpenQA.Selenium;
using WebAutomationFramework;
using WebAutomationFramework.Interfaces;

namespace Chase.Page
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
            Browser.FinElementById("SelectDateRange").Click();
            Browser.FinElementById("FromDate_Value").EnterText(DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy"));
            Browser.FinElementById("ToDate_Value").EnterText(DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy"));
            Browser.FinElementById("DownloadType").SelectByText("Intuit");
            try
            {
                Browser.FinElementByName("BtnDownloadActivity").Click();
            }
            catch (WebDriverException ex)
            {
            }
        }
    }
}
