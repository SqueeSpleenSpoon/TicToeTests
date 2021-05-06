using NUnit.Framework;
using OpenQA.Selenium;

namespace TicToe.Tests
{
    public class MainPage
    {
        private readonly IWebDriver _webDriver;

        private static readonly By _score = By.CssSelector("[class^=scores]");
        private static readonly By _swap = By.CssSelector("[class^=swap]");
        private static readonly By _twoPlayers = By.CssSelector("p[class^=p2]");

        public MainPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public MainPage OpenMainPage()
        {
            _webDriver.Navigate().GoToUrl("https://playtictactoe.org/");
            return this;
        }
        public MainPage SwapPayersNumber()
        {
            _webDriver.FindElement(_swap).Click();
            return this;
        }
    }
}