using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace WebFramework
{
    public class ScanPage
    {
        [FindsBy(How = How.Id, Using = "file_selector")]
        private IWebElement _chooseFileBtn;

        [FindsBy(How = How.ClassName, Using = "analyze")]
        private IWebElement _analyzeBtn;

        [FindsBy(How = How.Id, Using ="finished_message")]
        private IWebElement _scanFinishedMsg;

        [FindsBy(How = How.ClassName, Using = "result")]
        private IWebElement _resultMsg;

        private void ChooseFile(string path)
        {
            _chooseFileBtn.Click();
            var pathField = Browser.Driver.FindElement(By.Id("input"));
            pathField.SendKeys(path);
        }

        public void ScanCleanFile()
        {
            ChooseFile(Constants.CleanFile);
            _analyzeBtn.Click();
        }

        public void ScanInfectedFile()
        {
            ChooseFile(Constants.InfectedFile);
            _analyzeBtn.Click();
        }

        public bool ScanFinished()
        {
            var waiter = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(30));
            try
            {
                waiter.Until(x => _scanFinishedMsg.Displayed);
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

        public bool FileClean()
        {
            if (!ScanFinished())
            {
                throw new WebDriverTimeoutException("Failed to complete the scan.");
            }

            switch (_resultMsg.Text)
            {
                case "File is clean":
                    return true;
                case "File is infected":
                    return false;
            }
            throw new ArgumentException("Incorrect file");
        }
    }
}