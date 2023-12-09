using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTests
{
    [TestFixture]
    public class UpdateMovieTests
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
        public void UpdateMovie_Success()
        {
            _driver.Navigate().GoToUrl(_appBaseUrl + "Movies/Create");
            string movieTitle = "Test Movie to Update";
            string movieDirector = "Test Director to Update";
            _driver.FindElement(By.Id("Title")).SendKeys(movieTitle);
            _driver.FindElement(By.Id("Director")).SendKeys(movieDirector);
            _driver.FindElement(By.CssSelector("input[type='submit']")).Click();

            new WebDriverWait(_driver, TimeSpan.FromSeconds(10)).Until(driver => driver.Title.Contains("Movies"));

            Assert.AreEqual(_appBaseUrl + "Movies", _driver.Url);
            Assert.IsNotNull(_driver.FindElement(By.XPath($"//*[contains(text(), '{movieTitle}')]")));
            Assert.IsNotNull(_driver.FindElement(By.XPath($"//*[contains(text(), '{movieDirector}')]")));

            IWebElement row = _driver.FindElements(By.XPath("//table/tbody/tr")).Where(x => x.Text.Contains(movieTitle) && x.Text.Contains(movieDirector)).FirstOrDefault();
            Assert.IsNotNull(row);
            IWebElement updateLink = row.FindElements(By.TagName("a")).Where(x => x.Text.Contains("Edit")).FirstOrDefault();
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", updateLink);
            Task.Delay(2000).Wait();
            updateLink.Click();


            new WebDriverWait(_driver, TimeSpan.FromSeconds(10)).Until(driver => driver.Title.Contains("Edit"));
            IWebElement titleEdit=_driver.FindElement(By.Id("Title"));
            IWebElement directorEdit=_driver.FindElement(By.Id("Director"));
            titleEdit.Clear();
            directorEdit.Clear();
            titleEdit.SendKeys("Updated title");
            directorEdit.SendKeys("Updated director");
            _driver.FindElement(By.XPath("//input[@type='submit']")).Click();

            new WebDriverWait(_driver, TimeSpan.FromSeconds(10)).Until(driver => driver.Title.Contains("Movies"));

            Assert.AreEqual(_appBaseUrl + "Movies", _driver.Url);
            Assert.IsFalse(_driver.FindElements(By.XPath($"//*[contains(text(),'{movieTitle}')]")).Any());
            Assert.IsFalse(_driver.FindElements(By.XPath($"//*[contains(text(),'{movieDirector}')]")).Any());
            Assert.IsTrue(_driver.FindElements(By.XPath($"//*[contains(text(),'Updated title')]")).Any());
            Assert.IsTrue(_driver.FindElements(By.XPath($"//*[contains(text(),'Updated director')]")).Any());

        }

        [TearDown]
        public void Teardown()
        {
            _driver.Quit();
        }
    }
}
