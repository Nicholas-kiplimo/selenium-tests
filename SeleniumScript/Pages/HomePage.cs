using OpenQA.Selenium;
using System;


namespace SeleniumScript.Pages
{
    //Home Page Operations
    public class HomePage
    {
        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver{ get; }

        public IWebElement LnkLogin => Driver.FindElement(By.LinkText("Login")); 
        IWebElement LnkEmployeeDetails => Driver.FindElement(By.LinkText("Employee Details"));
        IWebElement LnkAbout => Driver.FindElement(By.LinkText("About"));

        public void ClickLogin() => LnkLogin.Click();

        public bool IsEmployeeDetailsExist() => LnkEmployeeDetails.Displayed;

        public IWebElement LnkRegister => Driver.FindElement(By.LinkText("Register"));
        public void ClickRegister() => LnkRegister.Click();

        public bool isAboutExist() => LnkAbout.Displayed;

    }
}
