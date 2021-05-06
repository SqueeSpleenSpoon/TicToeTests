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
        public void ChangeNumberOfPlayersFromOneToTwo()
        {
            _mainPage.OpenMainPage()
                .SwapNumberOfPlayers();

            var actualResult = _webDriver.FindElement(MainPage.NumberOfPlayers2).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void ChangeNumberOfPlayersFromTwoToOne()
        {
            _mainPage.OpenMainPage()
                .SwapNumberOfPlayers()
                .SwapNumberOfPlayers();

            var actualResult = _webDriver.FindElement(MainPage.NumberOfPlayers1).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_1_1()
        {
            _mainPage.OpenMainPage()
                .MarkSquere_1_1();

            var actualResult = _webDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_2_1()
        {
            _mainPage.OpenMainPage()
                .MarkSquere_2_1();

            var actualResult = _webDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_3_1()
        {
            _mainPage.OpenMainPage()
                .MarkSquere_3_1();

            var actualResult = _webDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_1_2()
        {
            _mainPage.OpenMainPage()
                .MarkSquere_1_2();

            var actualResult = _webDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_2_2()
        {
            _mainPage.OpenMainPage()
                .MarkSquere_2_2();

            var actualResult = _webDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_3_2()
        {
            _mainPage.OpenMainPage()
                .MarkSquere_3_2();

            var actualResult = _webDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_1_3()
        {
            _mainPage.OpenMainPage()
                .MarkSquere_1_3();

            var actualResult = _webDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_2_3()
        {
            _mainPage.OpenMainPage()
                .MarkSquere_2_3();

            var actualResult = _webDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_3_3()
        {
            _mainPage.OpenMainPage()
                .MarkSquere_3_3();

            var actualResult = _webDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void SuccessfulGame()
        {
            _mainPage.OpenMainPage()
                .SwapNumberOfPlayers()
                .MarkSquere_1_1()
                .MarkSquere_1_2()
                .MarkSquere_2_1()
                .MarkSquere_3_3()
                .MarkSquere_3_1();

            var actualResult = _webDriver.FindElement(MainPage.FirstPlayerWins).Text;

            Assert.AreEqual("1", actualResult);

        }
    }
}
