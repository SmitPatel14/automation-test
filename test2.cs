using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Finalproject
{
    public class Test2
    {
        IWebDriver driver;

        [SetUp]
       /* public void startbrowser()
        {
           // driver = new FirefoxDriver();
        }*/

        [Test]
        //this test is for checking the all the data are submitting or not
        public void Test1()
        {
            driver = new FirefoxDriver();
            driver.Url = "http://localhost/a/b/Home.html";
            driver.Manage().Window.Maximize();
           // driver.FindElement(By.LinkText("new")).Click();


             driver.FindElement(By.XPath(".//*[@class='button1']")).Click();
             driver.FindElement(By.CssSelector("input[name='firstname']")).SendKeys("Smit");
            driver.FindElement(By.Name("address")).SendKeys("abc");
            driver.FindElement(By.Name("city")).SendKeys("toronto");

            driver.FindElement(By.Name("number")).SendKeys("111-111-1111");

            driver.FindElement(By.Name("email")).SendKeys("a@gmail.com");
            driver.FindElement(By.Name("Vehiclemake")).SendKeys("honda");
            driver.FindElement(By.Name("Model")).SendKeys("civic");
            driver.FindElement(By.Name("Year")).SendKeys("2015");
            //driver.FindElement(By.Name("Submit")).Submit();
            driver.FindElement(By.CssSelector("input[type='Submit']")).Click();
            driver.Quit();

            /*driver.FindElement(By.CssSelector("input[name='address']")).SendKeys("Abc");;
            driver.FindElement(By.CssSelector("input[name='city']")).SendKeys("toronto");
             driver.FindElement(By.CssSelector("input[name='number']")).SendKeys("111-111-1111");
            driver.FindElement(By.CssSelector("input[name='email']")).SendKeys("a@gmail.com");
            driver.FindElement(By.CssSelector("input[name='Vehiclemake']")).SendKeys("honda");
            driver.FindElement(By.CssSelector("input[name='Model']")).SendKeys("civic");
            driver.FindElement(By.CssSelector("input[name='Year']")).SendKeys("2015");
           driver.FindElement(By.CssSelector("input[name='Submit']")).Click();driver.Quit();*/
            //sellername.SendKeys("Smit");
            /*address.SendKeys("Abc");
            city.SendKeys("toronto");
            phonenumber.SendKeys("111-111-1111");
            emailid.SendKeys("a@gmail.com");
            vehiclemake.SendKeys("honda");
            model.SendKeys("civic");
            year.SendKeys("2015");
            submitbutton.Click();*/



        }
        public void closebrowser()
        {
            driver.Close();
        }
    }
}