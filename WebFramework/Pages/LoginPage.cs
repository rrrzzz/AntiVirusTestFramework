using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace WebFramework
{
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "loginForm")]
        private IWebElement _loginField;

        [FindsBy(How = How.Id, Using = "passwordForm")]
        private IWebElement _passwordField;

        [FindsBy(How = How.ClassName, Using = "submitBtn")]
        private IWebElement _submitBtn;

        [FindsBy(How = How.ClassName, Using = "errorMessage")]
        private IWebElement _errorMsg;

        [FindsBy(How = How.ClassName, Using = "title")]
        private IWebElement _title;

        public void Login(string username = Constants.ValidUsername, string password = Constants.ValidPwd)
        {
            Browser.GoTo();
            var waiter = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(2));
            waiter.Until(x =>_loginField.Displayed);
            _loginField.SendKeys(username);
            _passwordField.SendKeys(password);
            _submitBtn.Click();
        }

        public bool LoginSuccessful()
        {
            var waiter = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(2));
            try
            {
                waiter.Until( d => !_errorMsg.Displayed);
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

        public bool AtLoginPage() => _title.Text == "LOGIN";
        
    }
}