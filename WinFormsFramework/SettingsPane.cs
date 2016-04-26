using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace WinFormsFramework
{
    public class SettingsPane
    {
        private CheckBox _protection;

        public bool ProtectionActive()
        {
            InitProtection();
            return _protection.IsSelected;
        }

        public void ProtectionSelect()
        {
            InitProtection();
            _protection.Select();
        }

        private void InitProtection()
        {
            _protection = App.MainWindow.Get<CheckBox>(SearchCriteria.ByText("Realtime Protection"));
        }
    }
}
