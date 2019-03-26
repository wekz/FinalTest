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
        public void TestCase_4()
        {
            string stepName = "";
            string testname = "1.LogInForm";
            string datum = Time.GetFormatedDateNow(testname);
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            try
            {
                {
                    // 1. Navigacija drivera do 500pixel
                    driver.Url = "https://500px.com/richardberesfordharris";
                    driver.Manage().Window.Maximize();
                    Thread.Sleep(6000);

                    // 2. Click na prvu sliku
                    stepName = "Click na prvu sliku";
                    js.ExecuteScript("window.scrollBy(0,650);");
                    driver.FindElement(By.XPath("//a[@href='/photo/297850117/untitled-by-richard-beresford-harris']")).Click();
                    LogStatus.LogSuccess(stepName, testname, datum);
                    Thread.Sleep(6000);

                    //3. Zoom slike
                    stepName = "Zoom slike";
                    driver.FindElement(By.ClassName("")).Click();
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
