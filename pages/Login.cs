using App_automation.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace App_automation.Pages

{
    class Login
    {
        public Login()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Element for My Account button
        [FindsBy(How = How.CssSelector, Using = "div[id='header-account'] button[type='button']")]
        private IWebElement MyAccount { get; set; }

        //Element for Email Field
        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement Email { get; set; }

        //Element for Password field
        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement Password { get; set; }

        //Element for login button
        [FindsBy(How = How.Id, Using = "continueProxy")]
        private IWebElement LoginButton { get; set; }
        #endregion

        internal void LoginSteps()
        {
            GlobalDefinitions.NavigateUrl();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.CssSelector("div[id='header-account'] button[type='button']"), 10);
            MyAccount.Click();
            Email.SendKeys("hi.its.jyo123@gmail.com");
            Password.SendKeys("Testabc123");
            GlobalDefinitions.ImplicitWaitTime(20);
            LoginButton.Click();
        }
    }
}
