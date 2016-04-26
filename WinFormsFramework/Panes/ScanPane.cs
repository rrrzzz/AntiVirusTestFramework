using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;

namespace WinFormsFramework
{
    public class ScanPane
    {
        private ComboBox _scanOptions;
        private Button _startScan;
        private ProgressBar _scanProgress; 
        public void StartSimpleScan()
        {
            _scanOptions = App.MainWindow.Get<ComboBox>(SearchCriteria.ByAutomationId("3079"));
            _scanOptions.Select("Simple scan");
            _startScan = App.MainWindow.Get<Button>(SearchCriteria.ByText("Start"));
            _startScan.Click();
        }

        public bool ScanStarted()
        {
            _scanProgress = App.MainWindow.Get<ProgressBar>();
            return _scanProgress.Visible;
        }
    }
}