using NUnit.Framework;

namespace WinFormsFramework
{
    [TestFixture]
    public class SmokeTests
    {
        [SetUp]
        public void Launch()
        {
            App.Init();
        }

        [TearDown]
        public void Close()
        {
            App.Close();
        }

        [Test]
        public void AppHasLaunched()
        {
            Assert.That(App.HasLaunched(), Is.True, "App has failed to launch.");
        }

        [Test]
        public void ProtectionIsActive()
        {
            SideBar.SettingsClick();
            Assert.That(Panes.Settings.ProtectionActive(), Is.True, "Protection was not active after app launch.");
        }

        [Test]
        public void ProtectionCanBeDeactivated()
        {
            SideBar.SettingsClick();
            Panes.Settings.ProtectionSelect();
            Assert.That(Panes.Settings.ProtectionActive(), Is.False, "Failed to disable protection in settings.");
        }

        [Test]
        public void SimpleScanCanBeLaunched()
        {
            SideBar.ScanClick();
            Panes.Scan.StartSimpleScan();
            Assert.That(Panes.Scan.ScanStarted(), Is.True, "Virus scan failed to start.");
        }
    }
}
