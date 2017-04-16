using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverTime
{
    class RegisterPage
    {
        private IWebDriver driver;

        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "Username")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='MainContent']/div/div/div/form/fieldset/div[9]/div/input")]
        public IWebElement SubmitButton { get; set; }


        [FindsBy(How = How.Id, Using = "Password-error")]
        public IWebElement ErrorMessage { get; set; }


        public string Url
        {
            get
            {
                return @"https://telerikacademy.com/Users/Auth/Registration";
            }
        }

        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(this.Url);
        }

        public void FullfillDetails(string password)
        {
            Username.SendKeys("Vlado");
            Password.SendKeys(password);
        }
    }
}
