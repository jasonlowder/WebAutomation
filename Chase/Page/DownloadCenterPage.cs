using System;
using OpenQA.Selenium;
using WebAutomationFramework;
using WebAutomationFramework.Interfaces;

namespace Chase.Page
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
            Browser.FindById("SelectDateRange").Click();
            Browser.FindById("FromDate_Value").EnterText(DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy"));
            Browser.FindById("ToDate_Value").EnterText(DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy"));
            Browser.FindById("DownloadType").SelectByText("Intuit");
            try
            {
                Browser.FindByName("BtnDownloadActivity").Click();
            }
            catch (WebDriverException ex)
            {
            }
        }
    }
}
