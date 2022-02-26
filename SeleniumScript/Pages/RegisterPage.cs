using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumScript.Pages
{
    public class RegisterPage
    {

        public RegisterPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }


        IWebElement txtUsername => Driver.FindElement(By.Name("UserName"));
        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        IWebElement txtCpassword => Driver.FindElement(By.Name("ConfirmPassword"));
        IWebElement txtEmail => Driver.FindElement(By.Name("Email"));
        IWebElement BtnRegister => Driver.FindElement(By.XPath("//input[@value='Register']"));


        public void Register(string UserName, string Password, string cPassword, string Email)
        {
            txtUsername.SendKeys(UserName);
            txtPassword.SendKeys(Password);
            txtCpassword.SendKeys(cPassword);
            txtEmail.SendKeys(Email);
            BtnRegister.Submit();
        }

    }
}
