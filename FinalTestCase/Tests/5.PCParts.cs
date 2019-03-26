using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Drawing.Design;
using OpenQA.Selenium.Support.Events;

namespace FinalTestCase
{
    public partial class TestCase
    {
        [Test]
        public void TestCase_5()
        {
            string stepName = "";
            string testname = "3.PCParts";
            string datum = Time.GetFormatedDateNow(testname);
            // scroll down java
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            try
            {


                // 1.Navigacija drivera do PCPIKER-a
                stepName = "1.Navigacija drivera do PCPIKER-a";
                driver.Url = "https://pcpartpicker.com/";
                driver.Manage().Window.Maximize();
                Thread.Sleep(5000);
                LogStatus.LogSuccess(stepName, testname, datum);

                // 2.Klik na Listu
                stepName = "2.Klik na Listu";
                driver.FindElement(By.ClassName("nav-build")).Click();
                Thread.Sleep(2000);
                LogStatus.LogSuccess(stepName, testname, datum);

                // 3.Pick CPU
                stepName = "3.Pick Elements CPU";
                js.ExecuteScript("window.scrollBy(0,450);");
                Thread.Sleep(2000);
                driver.FindElement(By.ClassName("btn-mds")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("part_category_search")).SendKeys("4460");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("px_30757")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.LinkText("Add")).Click();
                Thread.Sleep(2000);
                LogStatus.LogSuccess(stepName, testname, datum);

                // 4.Pick GPU
                stepName = "4.Pick GPU";
                js.ExecuteScript("window.scrollBy(0,450);");
                Thread.Sleep(2000);
                driver.FindElement(By.LinkText("Choose A CPU Cooler")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("part_category_search")).SendKeys("Noctua NH-L9i");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("px_14597")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.LinkText("Add")).Click();
                Thread.Sleep(2000);
                LogStatus.LogSuccess(stepName, testname, datum);

                // 6. Pick RAM Memory
                stepName = "6. Pick RAM Memory";
                js.ExecuteScript("window.scrollBy(0,450);");
                Thread.Sleep(2000);
                driver.FindElement(By.LinkText("Choose Memory")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("part_category_search")).SendKeys("G.Skill Aegis");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("px_52162")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//a[@href='#YRvZxr']")).Click();
                Thread.Sleep(2000);
                LogStatus.LogSuccess(stepName, testname, datum);

                // 7. Pick Storage
                stepName = "6. Pick Element Memory";
                js.ExecuteScript("window.scrollBy(0,450);");
                Thread.Sleep(2000);
                driver.FindElement(By.LinkText("Choose Storage")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("part_category_search")).SendKeys("970 evo");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("px_174613")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//a[@href='#JLdxFT']")).Click();
                Thread.Sleep(2000);
                LogStatus.LogSuccess(stepName, testname, datum);

                // 8.Pick Video Card
                stepName = "8. Pick Video Card";
                js.ExecuteScript("window.scrollBy(0,450);");
                Thread.Sleep(2000);
                driver.FindElement(By.LinkText("Choose A Video Card")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("part_category_search")).SendKeys("1080ti");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("px_102640")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//a[@href='#YNVBD3']")).Click();
                Thread.Sleep(2000);
                LogStatus.LogSuccess(stepName, testname, datum);

                // 9. Pick Case
                stepName = "9.Pick Case";
                js.ExecuteScript("window.scrollBy(0,450);");
                Thread.Sleep(2000);
                driver.FindElement(By.LinkText("Choose A Case")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.LinkText("List")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("part_category_search")).SendKeys("NZXT H700i ATX Mid Tower");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("px_136584")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//a[@href='#CVtWGX']")).Click();
                Thread.Sleep(2000);
                LogStatus.LogSuccess(stepName, testname, datum);

                // 10. Pick Power Supply
                stepName = "Pick Power Supply";
                js.ExecuteScript("window.scrollBy(0,450);");
                Thread.Sleep(2000);
                driver.FindElement(By.LinkText("Choose A Power Supply")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("part_category_search")).SendKeys("EVGA SuperNOVA 850");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("px_69896")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.LinkText("Add")).Click();
                Thread.Sleep(2000);
                LogStatus.LogSuccess(stepName, testname, datum);

                // 11. Pick OS
                stepName = "Pick OS";
                js.ExecuteScript("window.scrollBy(0,450);");
                Thread.Sleep(2000);
                driver.FindElement(By.LinkText("Choose An Operating System")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("part_category_search")).SendKeys("Microsoft Windows 10 Pro (64-bit)");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("px_47046")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.LinkText("Add")).Click();
                Thread.Sleep(2000);
                LogStatus.LogSuccess(stepName, testname, datum);

                // 12. Pick Monitor
                stepName = "Pick Monitor";
                js.ExecuteScript("window.scrollBy(0,550);");
                Thread.Sleep(2000);
                driver.FindElement(By.LinkText("Monitor")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("part_category_search")).SendKeys("Acer Predator X34");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("px_163366")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.LinkText("Add")).Click();
                Thread.Sleep(2000);
                js.ExecuteScript("window.scrollBy(0,350);");
                Thread.Sleep(2000);
                driver.Manage().Window.FullScreen();
                Thread.Sleep(2000);
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile(@"D:\\PCParts.Jpeg", ScreenshotImageFormat.Jpeg);
                Thread.Sleep(5000);
                LogStatus.LogSuccess(stepName, testname, datum);


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
