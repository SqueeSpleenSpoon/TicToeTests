using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicToe.Tests
{
    internal class PageInterfaceTests : SetUpsAndTearDownForTests
    {
        [Test]
        public void SoundOff()
        {
            MainPage.OpenMainPage()
                .SwithSound();

            var actualResult = WebDriver.FindElement(MainPage.SoundOn).Displayed;

            Assert.False(actualResult);
        }

        [Test]
        public void SoundOffThanOn()
        {
            MainPage.OpenMainPage()
                .SwithSound()
                .SwithSound();

            var actualResult = WebDriver.FindElement(MainPage.SoundOn).Displayed;

            Assert.True(actualResult);
        }

        [Test]
        public void RedirectToNeave()
        {           
            MainPage.OpenMainPage()
                .ClickNeaveButton();

           var actualResult = WebDriver.Url;

           Assert.AreNotEqual("https://playtictactoe.org/", actualResult);
        }
    }
}
