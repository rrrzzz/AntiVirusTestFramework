using System.Diagnostics;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace WinFormsFramework
{
    public static class App
    {
        private static Application _application;
        internal static Window MainWindow { get; private set; }

        public static void Init()
        {
            var process = new ProcessStartInfo(Constants.ExePath);
            _application = Application.AttachOrLaunch(process);
            MainWindow = _application.GetWindow(Constants.AppTitle);
        }

        public static void Close()
        {
            _application.Dispose();
            _application.Close();
        }

        public static bool HasLaunched() => MainWindow != null;
        
    }
}
