using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace AuthomanizationCianPageTestss
{
    public class Tests
    {


        private IWebDriver driver;
        private readonly By _SignInnButton = By.XPath("//span[text()='Войти']");
        private readonly By _EmailField = By.XPath("//input[@name ='username']");
        private readonly By _continueButton = By.XPath("//span[text()='Продолжить']");
        private readonly By _accept = By.XPath("//span[@class='_6eb00b8e53--box--3j1de _6eb00b8e53--box--1usiv']");
        private readonly By _continueButtonAccept = By.XPath("//span[text()='Продолжить']");
        private readonly By _FieldPswd = By.XPath("//input[@name='password']");
        private readonly By _BtnReg = By.XPath("//span[text()='Зарегистрироваться']");

        private const string _login = "foqnfi@yandex.ru";
        private const string _password = "ertfgQWER12er";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.cian.ru/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            #region регистрация нового пользователя

            var singIn = driver.FindElement(_SignInnButton);
            singIn.Click();

            var email = driver.FindElement(_EmailField);
            email.SendKeys(_login);

            var go = driver.FindElement(_continueButton);
            go.Click();

            Thread.Sleep(600);

            //var accept = driver.FindElement(_accept);
            //accept.Click();

            //var goAccept = driver.FindElement(_continueButtonAccept);
            //goAccept.Click();

            Thread.Sleep(400);

            var Pswd = driver.FindElement(_FieldPswd);
            Pswd.SendKeys(_password);

            Thread.Sleep(400);

            //var Reg = driver.FindElement(_BtnReg);
            //Reg.Click();

            #endregion


        }
    }
}