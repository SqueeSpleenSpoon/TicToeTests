using NUnit.Framework;
using OpenQA.Selenium;

namespace TicToe.Tests
{
    internal class MainPage
    {
        private readonly IWebDriver _webDriver;

        private static readonly By _swap = By.CssSelector("[class^=swap]");

        private static readonly By _square_1_1 = By.CssSelector("[class='square top left']");
        private static readonly By _square_2_1 = By.CssSelector("[class='square top']");    
        private static readonly By _square_3_1 = By.CssSelector("[class='square top right']");

        private static readonly By _square_1_2 = By.CssSelector("[class='square left']");
        private static readonly By _square_2_2 = By.CssSelector("[class='square']");
        private static readonly By _square_3_2 = By.CssSelector("[class='square right']");

        private static readonly By _square_1_3 = By.CssSelector("[class='square bottom left']");
        private static readonly By _square_2_3 = By.CssSelector("[class='square bottom']");
        private static readonly By _square_3_3 = By.CssSelector("[class='square bottom right']");

        private static readonly By _sound = By.CssSelector("[class=mute]");
        private static readonly By _neaveButton = By.CssSelector("a[class=neave]");

        public static readonly By NumberOfPlayers1 = By.CssSelector("p[class^=p1]");
        public static readonly By NumberOfPlayers2 = By.CssSelector("p[class^=p2]");

        public static readonly By XMark = By.CssSelector("div[class=x]");       
        public static readonly By SoundOn = By.CssSelector("path[d^=M67]");       

        public static readonly By FirstPlayerWins = By.CssSelector("[class=player1] span[class='score appear']");
        public static readonly By SecondPlayerWins = By.CssSelector("[class=player2] span[class='score appear']");
        public static readonly By Draws = By.CssSelector("[class=ties] span[class='score appear']");



        public MainPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainPage OpenMainPage()
        {
            _webDriver.Navigate().GoToUrl("https://playtictactoe.org/");
            return this;
        }

        public MainPage SwapNumberOfPlayers()
        {
            _webDriver.FindElement(_swap).Click();
            return this;
        }

        public MainPage MarkSquere_1_1()
        {
            _webDriver.FindElement(_square_1_1).Click();
            return this;
        }

        public MainPage MarkSquere_2_1()
        {
            _webDriver.FindElement(_square_2_1).Click();
            return this;
        }

        public MainPage MarkSquere_3_1()
        {
            _webDriver.FindElement(_square_3_1).Click();
            return this;
        }

        public MainPage MarkSquere_1_2()
        {
            _webDriver.FindElement(_square_1_2).Click();
            return this;
        }

        public MainPage MarkSquere_2_2()
        {
            _webDriver.FindElement(_square_2_2).Click();
            return this;
        }

        public MainPage MarkSquere_3_2()
        {
            _webDriver.FindElement(_square_3_2).Click();
            return this;
        }

        public MainPage MarkSquere_1_3()
        {
            _webDriver.FindElement(_square_1_3).Click();
            return this;
        }

        public MainPage MarkSquere_2_3()
        {
            _webDriver.FindElement(_square_2_3).Click();
            return this;
        }

        public MainPage MarkSquere_3_3()
        {
            _webDriver.FindElement(_square_3_3).Click();
            return this;
        }
        public MainPage SwithSound()
        {
            _webDriver.FindElement(_sound).Click();
            return this;
        }

        public MainPage ClickNeaveButton()
        {
            _webDriver.FindElement(_neaveButton).Click();
            return this;
        }
    }
}