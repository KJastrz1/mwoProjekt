using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTests
{
    [TestFixture]
    public class DeleteMovieTests
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

        }

        [Test]
        public void DeleteMovie_Success()
        {
            _driver.Navigate().GoToUrl(_appBaseUrl + "Movies/Create");
            string movieTitle = "Test Movie Delete";
            string movieDirector = "Test Director Delete";
            _driver.FindElement(By.Id("Title")).SendKeys(movieTitle);
            _driver.FindElement(By.Id("Director")).SendKeys(movieDirector);
            _driver.FindElement(By.CssSelector("input[type='submit']")).Click();

            new WebDriverWait(_driver, TimeSpan.FromSeconds(10)).Until(driver => driver.Title.Contains("Movies"));

            Assert.AreEqual(_appBaseUrl + "Movies", _driver.Url);
            Assert.IsNotNull(_driver.FindElement(By.XPath($"//*[contains(text(), '{movieTitle}')]")));
            Assert.IsNotNull(_driver.FindElement(By.XPath($"//*[contains(text(), '{movieDirector}')]")));

            IWebElement row = _driver.FindElements(By.XPath("//table/tbody/tr")).Where(x => x.Text.Contains(movieTitle) && x.Text.Contains(movieDirector)).FirstOrDefault();
            Assert.IsNotNull(row);
            IWebElement deleteLink = row.FindElements(By.TagName("a")).Where(x => x.Text.Contains("Delete")).FirstOrDefault();
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", deleteLink);
            Task.Delay(2000).Wait();
            deleteLink.Click();
            new WebDriverWait(_driver, TimeSpan.FromSeconds(10)).Until(driver => driver.Title.Contains("Delete"));
            _driver.FindElement(By.XPath("//input[@type='submit']")).Click();

            new WebDriverWait(_driver, TimeSpan.FromSeconds(10)).Until(driver => driver.Title.Contains("Movies"));

            Assert.AreEqual(_appBaseUrl + "Movies", _driver.Url);
            Assert.IsFalse(_driver.FindElements(By.XPath($"//*[contains(text(),'{movieTitle}')]")).Any());
            Assert.IsFalse(_driver.FindElements(By.XPath($"//*[contains(text(),'{movieDirector}')]")).Any());


        }




        [TearDown]
        public void Teardown()
        {
            _driver.Quit();
        }
    }
}
