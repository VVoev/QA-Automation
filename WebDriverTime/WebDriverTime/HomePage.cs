using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverTime
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id,Using = "FbLogin")]

        public IWebElement fbButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "H1")]

        public IWebElement MainHeadLine { get; set; }

        public string Url
        {
            get
            {
                return @"https://telerikacademy.com/";
            }
        }

        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(this.Url);
        }

        public void AssertHeadline()
        {
            Assert.AreEqual("Софтуерна академия на Телерик", this.MainHeadLine.Text);
        }
    }
}
