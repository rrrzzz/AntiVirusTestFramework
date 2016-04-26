using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebFramework
{
    public class Footer
    {
        [FindsBy(How = How.LinkText, Using = "Virus Scan")]
        private IWebElement _scanLink;

        [FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement _homeLink;

        public void ScanClick() => _scanLink.Click();
        public void HomeClick() => _homeLink.Click();
    }
}