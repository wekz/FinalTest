using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace FinalTestCase

{
    public partial class TestCase
    {
        IWebDriver driver;
        int i = 0;

        [SetUp]
        public void InitialDriver()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void CloseDriver()
        {
            driver.Quit();
        }

    }
}
