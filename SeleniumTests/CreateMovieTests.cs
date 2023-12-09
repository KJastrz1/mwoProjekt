using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTests
{
    [TestFixture]
    public class CreateMovieTests
    {
        private IWebDriver _driver;
        private string _appBaseUrl;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--no-sandbox");

            _driver = new ChromeDriver(options);

            _appBaseUrl = "http://localhost:7255/";
            _driver.Navigate().GoToUrl(_appBaseUrl + "Movies/Create");
        }

        [Test]
        public void CreateMovie_CorrectForm_Success()
        {
            _driver.FindElement(By.Id("Title")).SendKeys("Test Movie");
            _driver.FindElement(By.Id("Director")).SendKeys("Test Director");
            _driver.FindElement(By.CssSelector("input[type='submit']")).Click();

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.Title.Contains("Movies"));

            IWebElement addedMovieTitle = _driver.FindElement(By.XPath($"//*[contains(text(), 'Test Movie')]"));
            IWebElement addedMovieDirector = _driver.FindElement(By.XPath($"//*[contains(text(), 'Test Director')]"));


            Assert.AreEqual(_appBaseUrl + "Movies", _driver.Url);
            Assert.IsNotNull(addedMovieTitle);
            Assert.IsNotNull(addedMovieDirector);
        }



        [TearDown]
        public void Teardown()
        {
            _driver.Quit();
        }
    }
}
