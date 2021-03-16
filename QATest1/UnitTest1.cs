using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace QATest1
{
    [TestClass]
    public class UnitTest1
    {
        public static IWebDriver driver;

        public static void setup(string website)
        {
            driver = new ChromeDriver(@"C:\Users\Johnny\source\repos\QATest1\QATest1\WebDrivers\chromedriver_win32");
            driver.Navigate().GoToUrl(website);
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void TestMethod1()
        {
            setup("http://automationpractice.com/index.php");

            Actions builder = new Actions(driver);
            IWebElement elemetBlouse = driver.FindElement(By.CssSelector("a[title='Blouse']"));
            builder.MoveToElement(elemetBlouse).Build().Perform();

            var addButton = driver.FindElement(By.CssSelector("a[data-id-product='2']"));
            addButton.Click();
        }

        public void TestVerifyEmail()
        {
            setup("http://automationpractice.com/index.php");
        }
    }
}
