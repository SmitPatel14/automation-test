using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Finalproject
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void startbrowser()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Url = "http://localhost/a/b/Home.html";
        }
        public void closebrowser()
        {
            driver.Close();
        }
    }
}