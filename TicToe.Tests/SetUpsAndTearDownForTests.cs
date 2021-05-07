using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace TicToe.Tests
{
    internal class SetUpsAndTearDownForTests
    {
        public IWebDriver WebDriver;
        public MainPage MainPage;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            WebDriver = new ChromeDriver();
            WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            MainPage = new MainPage(WebDriver);
        }

        [TearDown]
        public void TearDown()
        {
            WebDriver.Quit();
        }
    }
}
