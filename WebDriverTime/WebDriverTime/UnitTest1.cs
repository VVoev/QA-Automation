using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriverTime
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        [TestInitialize]
        public void TestInit()
        {
            this.driver = new ChromeDriver();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            this.driver.Quit();
        }

        [TestMethod]
        public void TelerikLogoShouldBeDisplayed_WhenGoBackToMainPage()
        {
            HomePage homePage = new HomePage(this.driver);
            homePage.Navigate();
            homePage.fbButton.Click();
            this.driver.Navigate().Back();
            homePage.AssertHeadline();
        }

        [TestMethod]       
        public void UserCannotBeLogin_WhenPasswordIsLessThanSixSyboms()
        {
            RegisterPage registerPage = new RegisterPage(this.driver);
            registerPage.Navigate();
            registerPage.FullfillDetails("12");
            registerPage.SubmitButton.Click();
            Assert.AreEqual("Паролата трябва да е повече от 6 символа", registerPage.ErrorMessage.Text);
            
           
        }
    }
}
