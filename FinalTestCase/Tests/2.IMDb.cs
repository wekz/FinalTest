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
using OpenQA.Selenium.Support.UI;

namespace FinalTestCase
{

    public partial class TestCase
    {
        [Test]
        public void TestCase_2()
        {
            string stepName = "";
            string testname = "2.IMDb";
            string datum = Time.GetFormatedDateNow(testname);

            try
            {
                //1. Navigacija drivera do IMDB-a
                stepName = "1. Navigacija drivera do IMDB-a";
                driver.Url = "https://www.imdb.com/";
                driver.Manage().Window.Maximize();
                Thread.Sleep(5000);
                LogStatus.LogSuccess(stepName, testname, datum);

                //2. Login na IMDb
                stepName = "2.Login na IMDb";
                driver.FindElement(By.Id("imdb-signin-link")).Click();
                Thread.Sleep(6000);
                LogStatus.LogSuccess(stepName, testname, datum);

                //3. Sing with IMDb Acc
                stepName = "3 IMDb Acc";
                driver.FindElement(By.XPath("//span[@class='auth-provider-text provider-imdb']")).Click();
                Thread.Sleep(6000);
                driver.FindElement(By.Id("ap_email")).SendKeys("anamarijakorkanovic@hotmail.com");
                Thread.Sleep(6000);
                driver.FindElement(By.Id("ap_password")).SendKeys("testuser2018");
                Thread.Sleep(6000);
                driver.FindElement(By.Id("signInSubmit")).Click();
                Thread.Sleep(6000);
                LogStatus.LogSuccess(stepName, testname, datum);

                //4. IMDb top 100
                stepName = "4. IMDb top 100";
                driver.FindElement(By.LinkText("Top Rated Movies")).Click();
                Thread.Sleep(6000);
                LogStatus.LogSuccess(stepName, testname, datum);

                //5. Pick a Movie
                stepName = "5 pick a Movie";
                driver.FindElement(By.LinkText("12 Angry Men")).Click();
                Thread.Sleep(6000);
                LogStatus.LogSuccess(stepName, testname, datum);

                //6. User Reviews
                stepName = "6 User Reviews";
                driver.FindElement(By.LinkText("USER REVIEWS")).Click();
                Thread.Sleep(6000);
                LogStatus.LogSuccess(stepName, testname, datum);

                //7. Sort byy Vote and Rating
                stepName = "7. Sort by Votes and Rating";
                driver.FindElement(By.XPath("//span[@class='faceter-facets-text']")).Click();
                Thread.Sleep(6000);

                //8. Drop down rating 
                stepName = "8. Drop down rating";
                var rating = driver.FindElement(By.Name("ratingFilter"));
                var select_rating = new SelectElement(rating);
                select_rating.SelectByValue("10");
                Thread.Sleep(6000);
                LogStatus.LogSuccess(stepName, testname, datum);


                //9. Drop down Sort by
                stepName = "9. Drop down Sort by";
                var sort = driver.FindElement(By.Name("sort"));
                var select_sort = new SelectElement(sort);
                select_sort.SelectByValue("totalVotes");
                Thread.Sleep(6000);
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
