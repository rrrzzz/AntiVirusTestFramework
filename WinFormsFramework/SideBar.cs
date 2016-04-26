using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;

namespace WinFormsFramework
{
    public static class SideBar
    {
        private static Menu _settings = App.MainWindow.Get<Menu>(SearchCriteria.ByText("Settings"));
        private static Menu _scan = App.MainWindow.Get<Menu>(SearchCriteria.ByText("Scan"));

        public static void SettingsClick() => _settings.Click();
        public static void ScanClick() => _scan.Click();
    }
}
