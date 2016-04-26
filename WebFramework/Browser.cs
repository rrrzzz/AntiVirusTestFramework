using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;

namespace WebFramework
{
    public class Browser
    {
        public static IWebDriver Driver { get; private set; }
        
        public static void Start(Browsers browser = Browsers.Firefox)
        {
            switch (browser)
            {
                case Browsers.Firefox:
                    Driver = new FirefoxDriver();
                    break;
                case Browsers.Chrome:
                    Driver = new ChromeDriver();
                    break;
                case Browsers.InternetExplorer:
                    Driver = new InternetExplorerDriver();
                    break;
                case Browsers.Safari:
                    Driver = new SafariDriver();
                    break;
                case Browsers.Edge:
                    Driver = new EdgeDriver();
                    break;
                case Browsers.Opera:
                    Driver = new OperaDriver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browser),"This browser is not supported.");
            }
        }

        public static void GoTo(string url = Constants.Host)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public static void Quit()
        {
            Driver.Quit();
        }
    }

    public enum Browsers
    {
        Firefox,
        Chrome,
        InternetExplorer,
        Safari,
        Edge,
        Opera
    }
}
