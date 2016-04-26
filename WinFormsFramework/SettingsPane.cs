using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using WinFormsFramework;

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
