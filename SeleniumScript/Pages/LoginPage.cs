using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumScript.Pages
{
    public class LoginPage
    {

        public LoginPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }


        IWebElement txtUsername => Driver.FindElement(By.Id("UserName"));
        IWebElement txtPassword => Driver.FindElement(By.Id("Password"));
        IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@value='Log in']"));

        public void Login(string userName, string Password)
        {
            txtUsername.SendKeys(userName);
            txtPassword.SendKeys(Password);
            btnLogin.Submit();
        }



    }
}
