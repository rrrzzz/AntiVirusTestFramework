using OpenQA.Selenium.Support.PageObjects;

namespace WebFramework
{
    public static class Pages
    {

        private static Footer _footer;
        public static Footer Footer
        {
            get
            {
                if (_footer == null)
                {
                    _footer = new Footer();
                }
                PageFactory.InitElements(Browser.Driver, _footer);
                return _footer;
            }

        }

        private static LoginPage _loginPage;
        public static LoginPage LoginPage
        {
            get
            {
                if (_loginPage == null)
                {
                    _loginPage = new LoginPage();
                }
                PageFactory.InitElements(Browser.Driver, _loginPage);
                return _loginPage;
            }
        }

        private static ScanPage _scanPage;
        public static ScanPage ScanPage
        {
            get
            {
                if (_scanPage == null)
                {
                    _scanPage = new ScanPage();
                }
                PageFactory.InitElements(Browser.Driver, _scanPage);
                return _scanPage;
            }
        }

    }
}
