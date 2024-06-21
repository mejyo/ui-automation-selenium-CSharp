using App_automation.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using static App_automation.utilities.GlobalDefinitions;

namespace App_automation.utilities
{
    class Base
    {
        #region To access URLs
        public static string URL = "https://www.jbhifi.com.au/";
        #endregion


        #region setup and tear down
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            NavigateUrl();
            ImplicitWaitTime(20);
            Login loginObj = new Login();
            loginObj.LoginSteps();
        }

        [TearDown]
        public void TearDown()
        {

            GlobalDefinitions.driver.Close();

        }
        #endregion

    }
}