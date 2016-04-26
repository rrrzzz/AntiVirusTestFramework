using NUnit.Framework;
using WebFramework;


namespace WebTests
{
    [TestFixture]
    public class SmokeTests
    {
        [SetUp]
        public void OpenBrowser()
        {
            Browser.Start();
        }

        [TearDown]
        public void CloseBrowser()
        {
            Browser.Quit();
        }

        [Test]
        public void SiteResponds()
        {
            Browser.GoTo();
            Assert.That(Pages.LoginPage.AtLoginPage(), Is.True);
        } 

        [Test]
        public void CanLogin()
        {
            Pages.LoginPage.Login();
            Assert.That(Pages.LoginPage.LoginSuccessful, Is.True, "Couldn't login with valid username and password.");
        }

        [Test]
        public void CanScanFiles()
        {
            Pages.LoginPage.Login();
            Pages.Footer.ScanClick();
            Pages.ScanPage.ScanCleanFile();
            Assert.That(Pages.ScanPage.ScanFinished, Is.True, "Virus scan couldn't complete.");
        }
        [Test]
        public void ScansCleanFileCorrectly()
        {
            Pages.LoginPage.Login();
            Pages.Footer.ScanClick();
            Pages.ScanPage.ScanCleanFile();
            Assert.That(Pages.ScanPage.FileClean(), Is.True, "Incorrectly scanned a clean file.");
        }

        [Test]
        public void ScansInfectedFileCorrectly()
        {
            Pages.LoginPage.Login();
            Pages.Footer.ScanClick();
            Pages.ScanPage.ScanCleanFile();
            Assert.That(Pages.ScanPage.FileClean(), Is.False, "Incorrectly scanned an infected file.");
        }
    }
}
