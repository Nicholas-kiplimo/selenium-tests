using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumScript.Pages;

namespace SeleniumScript.Tests
{
    internal class LoginTest
    {
        IWebDriver webDriver =new  ChromeDriver();

        [SetUp]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Test]
        public void Login()
        {
            HomePage home = new HomePage(webDriver);
            home.ClickLogin();

            LoginPage login = new LoginPage(webDriver);
            login.Login("sample1234", "SampleKe@123");

            Assert.That(home.IsEmployeeDetailsExist, Is.True);
        }

        [TearDown]
        public void TearDown() => webDriver.Quit();

    }
}
