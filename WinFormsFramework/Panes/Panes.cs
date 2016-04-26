namespace WinFormsFramework
{
    public static class Panes
    {
        private static SettingsPane _settings;
        public static SettingsPane Settings
        {
            get { return _settings ?? (_settings = new SettingsPane()); }
        }

        private static ScanPane _scan;
        public static ScanPane Scan
        {
            get { return _scan ?? (_scan = new ScanPane()); }
        }
    }
}