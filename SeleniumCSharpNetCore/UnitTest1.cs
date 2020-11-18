using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpNetCore
{
    public class Tests
    {
        public IWebDriver Driver;
        
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            
           
        }

        [Test]
        public void Test1()
        {
            Driver = new ChromeDriver(@"C:\Drivers");
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Hello");

            IWebElement comboControl = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));
            comboControl.Clear();
            comboControl.SendKeys("Almond");

            Driver.FindElement(By.XPath(("//div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']//li[text()='Almonds']"))).Click();

            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}
