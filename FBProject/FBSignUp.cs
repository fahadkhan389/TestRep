using System;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace FBProject
{
    [TestClass]
    public class FBSignUp
    {

        [TestMethod]
        public void FBSignUpPositive()
        {
            ExcelLib.PopulateInCollection(@"C:\Users\fukha\documents\visual studio 2017\Projects\FinSuite\FinSuite\ExcelFile\FB.xlsx");
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().i(TimeSpan.FromSeconds(10));
            driver.FindElement(By.Id("u_0_l")).SendKeys(ExcelLib.ReadData(1, "FirstName"));
            driver.FindElement(By.Id("u_0_n")).SendKeys(ExcelLib.ReadData(1, "LastName"));
            driver.FindElement(By.Id("u_0_q")).SendKeys(ExcelLib.ReadData(1, "MobileNo"));
            driver.FindElement(By.Id("u_0_x")).SendKeys(ExcelLib.ReadData(1, "Password"));

            SelectElement day = new SelectElement(driver.FindElement(By.Id("day")));
            day.SelectByText("3");
            SelectElement month = new SelectElement(driver.FindElement(By.Id("month")));
            month.SelectByIndex(1);
            SelectElement year = new SelectElement(driver.FindElement(By.Id("year")));
            year.SelectByText("1980");
            driver.FindElement(By.XPath("//div[@id='reg_form_box']//span[@class='_5k_3']/span[1]/input[@name='sex']")).Click();
            Thread.Sleep(3000);
            //driver.FindElement(By.Id("u_0_15")).Click();
            Thread.Sleep(2000);
            driver.Close();
            driver.Quit();

        }

        [TestMethod]
        public void FBSignUpNegative()
        {
            ExcelLib.PopulateInCollection(@"C:\Users\fukha\documents\visual studio 2017\Projects\FinSuite\FinSuite\ExcelFile\FB.xlsx");
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().i(TimeSpan.FromSeconds(10));
            driver.FindElement(By.Id("u_0_l")).SendKeys(ExcelLib.ReadData(2, "FirstName"));
            driver.FindElement(By.Id("u_0_n")).SendKeys(ExcelLib.ReadData(2, "LastName"));
            driver.FindElement(By.Id("u_0_q")).SendKeys(ExcelLib.ReadData(2, "MobileNo"));
            driver.FindElement(By.Id("u_0_x")).SendKeys(ExcelLib.ReadData(2, "Password"));

            SelectElement day = new SelectElement(driver.FindElement(By.Id("day")));
            day.SelectByText("3");
            SelectElement month = new SelectElement(driver.FindElement(By.Id("month")));
            month.SelectByIndex(1);
            SelectElement year = new SelectElement(driver.FindElement(By.Id("year")));
            year.SelectByText("1980");
            driver.FindElement(By.XPath("//div[@id='reg_form_box']//span[@class='_5k_3']/span[1]/input[@name='sex']")).Click();
            Thread.Sleep(3000);
            //driver.FindElement(By.Id("u_0_15")).Click();
            Thread.Sleep(2000);
            driver.Close();
            driver.Quit();

        }

    }
}
