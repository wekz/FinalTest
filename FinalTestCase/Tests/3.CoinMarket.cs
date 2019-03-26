using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace FinalTestCase
{
    public partial class TestCase
    {
        [Test]
        public void TestCase_3()
        {
            string stepName = "";
            string testname = "4.CoinMarket";
            string datum = Time.GetFormatedDateNow(testname);
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            try
            {
                {
                    // 1. Navigacija drivera do CoinMarket
                    driver.Url = "https://coinmarketcap.com/";
                    driver.Manage().Window.Maximize();
                    Thread.Sleep(6000);

                    // 2. Click na day/night mode.
                    stepName = "Click na day/night mode.";
                    driver.FindElement(By.XPath("//button[@title='Day/Night Mode']")).Click();
                    Thread.Sleep(6000);

                    // 2. Click na EOS
                    stepName = "Click na EOS";
                    js.ExecuteScript("window.scrollBy(0,550);");
                    driver.FindElement(By.LinkText("EOS")).Click();
                    LogStatus.LogSuccess(stepName, testname, datum);
                    Thread.Sleep(6000);

                    // 3. Click na Linkove u isto vreme 7 linka
                    stepName = "Click na linkove";
                    driver.FindElement(By.XPath("//a[@href='https://github.com/EOSIO/Documentation/blob/master/TechnicalWhitePaper.md']")).Click();
                    driver.FindElement(By.XPath("//a[@href='https://bitcointalk.org/index.php?topic=1904415.0']")).Click();
                    driver.FindElement(By.XPath("//a[@href='https://bloks.io/']")).Click();
                    driver.FindElement(By.XPath("//a[@href='https://eospark.com/']")).Click();
                    driver.FindElement(By.XPath("//a[@href='https://t.me/joinchat/AAAAAEQbOeucnaMWN0A9dQ']")).Click();
                    driver.FindElement(By.XPath("//a[@href='https://github.com/eosio']")).Click();
                    driver.FindElement(By.XPath("//a[@href='https://eos.io/']")).Click();
                    LogStatus.LogSuccess(stepName, testname, datum);
                    Thread.Sleep(6000);


                }

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                LogStatus.LogError(stepName, testname, datum, msg);
                Assert.Fail(msg);
            }

        }


    }

}