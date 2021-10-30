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
        private readonly By _FieldPswd = By.XPath("//input[@name='password']");
        private readonly By _Enter = By.XPath("//span[@class='_6eb00b8e53--content--3t70w']");
        private readonly By _userLogin = By.XPath("//a[@class='user-name']");
        private readonly By _ClickOnAvatar = By.XPath("//div[@class='c-header-user-menu']");

        private const string _login = "foqnfi@yandex.ru";
        private const string _password = "ertfgQWER12er";
        private const string _expectedLogin = "ID 82147850";

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
            #region вход на сайт

            var singIn = driver.FindElement(_SignInnButton);
            singIn.Click();

            var email = driver.FindElement(_EmailField);
            email.SendKeys(_login);

            var go = driver.FindElement(_continueButton);
            go.Click();

            Thread.Sleep(600);

            

            Thread.Sleep(400);

            var Pswd = driver.FindElement(_FieldPswd);
            Pswd.SendKeys(_password);

            Thread.Sleep(400);

            var Enter = driver.FindElement(_Enter);
            Enter.Click();

            Thread.Sleep(400);

            

            var ShowPanel = driver.FindElement(_ClickOnAvatar);
            ShowPanel.Click();

            Thread.Sleep(400);

            var actualLogin = driver.FindElement(_userLogin).Text;

            Thread.Sleep(400);

            Assert.AreEqual(_expectedLogin, actualLogin, "Login is wrong or Enter was not completed");

            Thread.Sleep(400);

            #endregion


        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}