using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace TicToe.Tests
{
    class MainPageTests
    {
        private IWebDriver _webDriver;
        private MainPage _mainPage;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            _mainPage = new MainPage(_webDriver);
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
        [Test]
        public void ChangePayersNumberFromOneToTwo()
        {
            _mainPage.OpenMainPage()
                .SwapPayersNumber();

            var actualResult = _webDriver.FindElement(By.CssSelector("p[class^=p2]")).Displayed;

            Assert.True(actualResult);
        }
        [Test]
        public void ChangePayersNumberFromTwoToOne()
        {
            _mainPage.OpenMainPage()
                .SwapPayersNumber()
                .SwapPayersNumber();

            var actualResult = _webDriver.FindElement(By.CssSelector("p[class^=p1]")).Displayed;

            Assert.True(actualResult);
        }
    }
}
