using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace MoviesListTests
{
    [TestFixture]
    public class MoviesListTests
    {
        private IWebDriver _driver;
        private string _appBaseUrl;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");

            _driver = new ChromeDriver(options);

            _appBaseUrl = "https://localhost:7255/";

            _driver.Navigate().GoToUrl(_appBaseUrl + "Movies/");
        }

        [Test]
        public void MoviesPageTitleIsCorrect()
        {
            Assert.AreEqual("Movie", _driver.Title);
        }

        [Test]
        public void MoviesTableHasCorrectHeaders()
        {
            var tableHeaders = _driver.FindElements(By.TagName("th"));
            Assert.AreEqual(2, tableHeaders.Count);
        }

        [Test]
        public void LinkToCreateMovieWorks()
        {

            var createNewLink = _driver.FindElement(By.LinkText("Create New"));
            Assert.IsNotNull(createNewLink);
        }

        [Test]
        public void LinkToEditMovieWorks()
        {

            var firstEditLink = _driver.FindElement(By.CssSelector("table tbody tr:first-child td:nth-child(3) a:first-child"));
            firstEditLink.Click();
            Assert.AreEqual(_appBaseUrl + "Movies/Edit/1", _driver.Url);
        }


        [Test]
        public void LinkToMovieDetailsWorks()
        {
            _driver.Navigate().GoToUrl(_appBaseUrl + "Movies/");
            var firstDetailsLink = _driver.FindElement(By.CssSelector("table tbody tr:first-child td:nth-child(3) a:nth-child(2)"));
            firstDetailsLink.Click();
            Assert.AreEqual(_appBaseUrl + "Movies/Details/1", _driver.Url);
        }

        [Test]
        public void LinkToDeleteMovieWorks()
        {
            _driver.Navigate().GoToUrl(_appBaseUrl + "Movies/");
            var firstDeleteLink = _driver.FindElement(By.CssSelector("table tbody tr:first-child td:nth-child(3) a:nth-child(3)"));
            firstDeleteLink.Click();
            Assert.AreEqual(_appBaseUrl + "Movies/Delete/1", _driver.Url);
        }






        [TearDown]
        public void Teardown()
        {

            _driver.Quit();
        }
    }
}
