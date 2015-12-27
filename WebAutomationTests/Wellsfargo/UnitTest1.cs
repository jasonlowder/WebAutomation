using System;
using NUnit.Framework;
using Wellsfargo;

namespace WebAutomationTests.Wellsfargo
{
    [TestFixture]
    public class UnitTest1
    {
        [TearDown]
        public void Cleanup()
        {
            Workflows.Cleanup();
        }

        [Test]
        public void CanLogin()
        {
            Workflows.Login();
        }

        [Test]
        public void DownloadOfxFileForYesterdaysTransactions()
        {
            Workflows.DownLoadTransactions();
        }
    }
}
