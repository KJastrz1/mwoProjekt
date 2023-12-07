using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace CreateMovieTests
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
            options.AddArgument("--disable-gpu");  // Add this line for headless mode

            var service = ChromeDriverService.CreateDefaultService();
            service.Port = 4445;  // Set the port to a fixed value

            _driver = new ChromeDriver(service, options);

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
            wait.Until(driver => driver.Url.Contains("Movies"));


            Assert.AreEqual(_appBaseUrl + "Movies", _driver.Url);
        }

        [Test]
        public void CreateMovie_Cancel()
        {
            _driver.FindElement(By.Id("Title")).SendKeys("Test Movie");
            _driver.FindElement(By.Id("Director")).SendKeys("Test Director");


            _driver.FindElement(By.PartialLinkText("Back to List")).Click();

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.Url.Contains("Movies"));
            Assert.AreEqual(_appBaseUrl + "Movies", _driver.Url);
        }


        [TearDown]
        public void Teardown()
        {
            _driver.Quit();
        }
    }
}
