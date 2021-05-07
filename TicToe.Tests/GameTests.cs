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
    internal class GameTests : SetUpsAndTearDownForTests
    {
          
        [Test]
        public void ChangeNumberOfPlayersFromOneToTwo()
        {
            MainPage.OpenMainPage()
                .SwapNumberOfPlayers();

            var actualResult = WebDriver.FindElement(MainPage.NumberOfPlayers2).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void ChangeNumberOfPlayersFromTwoToOne()
        {
            MainPage.OpenMainPage()
                .SwapNumberOfPlayers()
                .SwapNumberOfPlayers();

            var actualResult = WebDriver.FindElement(MainPage.NumberOfPlayers1).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_1_1()
        {
            MainPage.OpenMainPage()
                .MarkSquere_1_1();

            var actualResult = WebDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_2_1()
        {
            MainPage.OpenMainPage()
                .MarkSquere_2_1();

            var actualResult = WebDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_3_1()
        {
            MainPage.OpenMainPage()
                .MarkSquere_3_1();

            var actualResult = WebDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_1_2()
        {
            MainPage.OpenMainPage()
                .MarkSquere_1_2();

            var actualResult = WebDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_2_2()
        {
            MainPage.OpenMainPage()
                .MarkSquere_2_2();

            var actualResult = WebDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_3_2()
        {
            MainPage.OpenMainPage()
                .MarkSquere_3_2();

            var actualResult = WebDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_1_3()
        {
            MainPage.OpenMainPage()
                .MarkSquere_1_3();

            var actualResult = WebDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_2_3()
        {
            MainPage.OpenMainPage()
                .MarkSquere_2_3();

            var actualResult = WebDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void MarkSquare_3_3()
        {
            MainPage.OpenMainPage()
                .MarkSquere_3_3();

            var actualResult = WebDriver.FindElement(MainPage.XMark).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void FirstPlayerWinGame()
        {
            MainPage.OpenMainPage()
                .SwapNumberOfPlayers()
                .MarkSquere_1_1()
                .MarkSquere_1_2()
                .MarkSquere_2_1()
                .MarkSquere_3_3()
                .MarkSquere_3_1();

            var actualResult = WebDriver.FindElement(MainPage.FirstPlayerWins).Text;

            Assert.AreEqual("1", actualResult);
        }

        [Test]
        public void SecondPlayerWinGame()
        {
            MainPage.OpenMainPage()
                .SwapNumberOfPlayers()
                .MarkSquere_3_3()
                .MarkSquere_1_1()
                .MarkSquere_2_2()
                .MarkSquere_2_1()
                .MarkSquere_1_3()
                .MarkSquere_3_1();

            var actualResult = WebDriver.FindElement(MainPage.SecondPlayerWins).Text;

            Assert.AreEqual("1", actualResult);
        }

        [Test]
        public void SuccessfulDrawGame()
        {
            MainPage.OpenMainPage()
                .SwapNumberOfPlayers()
                .MarkSquere_1_1()
                .MarkSquere_1_3()
                .MarkSquere_1_2()
                .MarkSquere_2_1()
                .MarkSquere_2_3()
                .MarkSquere_2_2()
                .MarkSquere_3_1()
                .MarkSquere_3_2()
                .MarkSquere_3_3();

            var actualResult = WebDriver.FindElement(MainPage.Draws).Text;

            Assert.AreEqual("1", actualResult);
        }      
    }
}
