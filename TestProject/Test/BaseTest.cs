using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using System.Threading;
using TestProject.Pages;

namespace TestProject
{
    public class Tests
    {
        private ChromeDriver driver;
        public HomePage homePage;

        [SetUp]
        public void Setup()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            driver = new ChromeDriver(outPutDirectory);
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Thread.Sleep(2000);

            homePage = new HomePage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

      
    }
}