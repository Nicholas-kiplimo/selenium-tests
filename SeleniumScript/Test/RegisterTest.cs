using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumScript.Pages;


namespace SeleniumScript.Test
{
    
    internal class RegisterTest
    {
        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }
        [Test]
        public void Register()
        {
            HomePage home = new HomePage(webDriver);
            home.ClickRegister();

            RegisterPage register = new RegisterPage(webDriver);
            register.Register("sample1225", "SampleKe@123", "SampleKe@123", "sample7672587285@gmail.com");

            Assert.That(home.isAboutExist, Is.True);
        }
        //[TearDown]
        
    }
}
