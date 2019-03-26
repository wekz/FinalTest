using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;

namespace FinalTestCase
{
    public partial class TestCase
    {
        [Test]
        public void TestCase_1()
        {
            string stepName = "";
            string testname = "1.LogInForm";
            string datum = Time.GetFormatedDateNow(testname);
            try
            {
                {
                    // 1. Navigacija drivera do Chess.com
                    driver.Url = "https://www.chess.com/login";
                    driver.Manage().Window.Maximize();
                    Thread.Sleep(6000);

                    // 2. Login Forma samo klik
                    stepName = "2.Login forma";
                    driver.FindElement(By.Id("username")).SendKeys(" ");
                    Thread.Sleep(6000);
                    driver.FindElement(By.Id("password")).SendKeys("");
                    Thread.Sleep(6000);
                    driver.FindElement(By.Id("login")).Click();
                    Thread.Sleep(6000);
                    LogStatus.LogSuccess(stepName, testname, datum);

                    // 3. Login forma pogresna
                    stepName = "3.Login forma";
                    driver.FindElement(By.Id("username")).SendKeys("");
                    Thread.Sleep(6000);
                    driver.FindElement(By.Id("password")).SendKeys("pogresanipass");
                    Thread.Sleep(6000);
                    driver.FindElement(By.Id("login")).Click();
                    Thread.Sleep(6000);
                    LogStatus.LogSuccess(stepName, testname, datum);


                    // 4. Login Forma tacna
                    stepName = "4.Login forma";
                    driver.FindElement(By.Id("username")).SendKeys("Testuser2019");
                    Thread.Sleep(6000);
                    driver.FindElement(By.Id("password")).SendKeys("testuser2018");
                    Thread.Sleep(6000);
                    driver.FindElement(By.Id("login")).Click();
                    Thread.Sleep(6000);
                    LogStatus.LogSuccess(stepName, testname, datum);

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
