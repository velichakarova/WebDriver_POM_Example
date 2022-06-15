using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_POM_Example.Tests
{
    public class BaseTests
    {
       protected IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver();
        }
        [OneTimeTearDown]
        public void ShutDown()
        {
            driver.Quit();
        }
    }
}
