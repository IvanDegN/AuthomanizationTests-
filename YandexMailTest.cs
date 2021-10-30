using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace AuthomanizationCianPageTests
{
    public class Tests
    {

        public void Enter()
        {
            var enter = driver.FindElement(_BtnEnter);
            enter.Click();
        }

        private IWebDriver driver;
        
        private const string _login = "foqnfi@yandex.ru";
        private const string _pswd = "qwertY34grv";
        private const string _someText = "Привет!";
        private const string _topic = "Тест";

        private readonly By _email = By.XPath("//input[@type='text']");
        private readonly By _BtnEnter = By.XPath("//button[@type='submit']");
        private readonly By _FieldPswd = By.XPath("//input[@name='passwd']");
        //private readonly By _notNowBtn = By.XPath("//button[@type='button']");
        private readonly By _write = By.XPath("//a[@class='mail-ComposeButton js-main-action-compose']");
        private readonly By _WriteTo = By.XPath("//div[@class='composeYabbles']");
        private readonly By _WriteYourSelf = By.XPath("//div[@class='ComposeContactsList-Item ContactsSuggestItemDesktop ContactsSuggestItemDesktop_active']");
        private readonly By _Topic = By.XPath("//input[@name='subject']");
        private readonly By _ClickToWrite = By.XPath("//div[@role='textbox']");
        private readonly By _WriteSomeText = By.XPath("//div[@role='textbox']");
        private readonly By _Send = By.XPath("//button[@class='Button2 Button2_pin_circle-circle Button2_view_default Button2_size_l']");
        private readonly By _Refresh = By.XPath("//span[@class='mail-ComposeButton-Refresh js-main-action-refresh ns-action']");

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://passport.yandex.ru/auth/add?origin=home_desktop_ru&retpath=https%3A%2F%2Fmail.yandex.ru%2F&backpath=https%3A%2F%2Fyandex.ru");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            #region Реализация входа в почту

            var email = driver.FindElement(_email);
            email.Click();
            email.SendKeys(_login);

            Enter();

            Thread.Sleep(400);

            var pswd = driver.FindElement(_FieldPswd);
            pswd.Click();
            pswd.SendKeys(_pswd);

            Enter();

            Thread.Sleep(600);

            //var NotNowBtn = driver.FindElement(_notNowBtn);
            //NotNowBtn.Click();
            #endregion

            #region Отправка письма самому себе

            Thread.Sleep(600);

            var WriteEmail = driver.FindElement(_write);
            WriteEmail.Click();

            Thread.Sleep(600);

            var WriteToEmail = driver.FindElement(_WriteTo);
            WriteToEmail.Click();

            Thread.Sleep(600);

            var WriteYourSelf = driver.FindElement(_WriteYourSelf);
            WriteYourSelf.Click();

            Thread.Sleep(600);

            var SelectTopic = driver.FindElement(_Topic);
            SelectTopic.Click();
            SelectTopic.SendKeys(_topic);

            Thread.Sleep(600);

            var ClickToWrite = driver.FindElement(_ClickToWrite);
            ClickToWrite.Click();

            Thread.Sleep(600);

            var WriteSomeText = driver.FindElement(_WriteSomeText);
            WriteSomeText.SendKeys(_someText);

            Thread.Sleep(600);

            var Send = driver.FindElement(_Send);
            Send.Click();

            Thread.Sleep(10000);

            var Refresh = driver.FindElement(_Refresh);
            Refresh.Click();

            #endregion

            
        }
    }
}