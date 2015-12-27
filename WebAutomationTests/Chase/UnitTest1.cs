using System;
using NUnit.Framework;
using Chase;

namespace WebAutomationTests.Chase
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
