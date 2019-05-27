using AutoTest.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Drawing.Imaging;
using System.Drawing.Design;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AutoTest
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public void TakeScreenshot(string saveLocation)
        {
            ITakesScreenshot ssdriver = PropertiesCollection.Driver as ITakesScreenshot;
            Screenshot screenshot = ssdriver.GetScreenshot();
            screenshot.SaveAsFile(saveLocation, ScreenshotImageFormat.Png);
        }

        [SetUp]
        public void Initilaze()
        {
            PropertiesCollection.Driver = new ChromeDriver();
            PropertiesCollection.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            PropertiesCollection.Driver.Url = ("https://www.trendyol.com/");
            PropertiesCollection.Driver.Manage().Window.Maximize();
        }


        [Test]
        public void ExecuteTest()
        {
            EAPageObject page = new EAPageObject();
            PropertiesCollection.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            #region Login

            #region Timer
            PropertiesCollection.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            Thread.Sleep(1000);
            #endregion 

            page.ImgClick.Click();

            page.SigninClick.Click();
            page.UserName.Click();
            page.UserName.SendKeys("el1f__n3w@hotmail.com");
            page.Password.Click();
            page.Password.SendKeys("elif1234???");
            page.SaveButton.Click();
            #region Timer
            PropertiesCollection.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Thread.Sleep(500);
            #endregion
            page.SelectBoutique.Click();
            #region Timer
            PropertiesCollection.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Thread.Sleep(400);
            #endregion
            page.SelectProduct.Click();
            #region Timer
            PropertiesCollection.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(800);
            #endregion
            page.ListSize.Click();
            #region Timer
            PropertiesCollection.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(800);
            #endregion
            page.SelectSize.Click();
            #region Timer
            PropertiesCollection.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(800);
            #endregion
            page.AddBasketProduct.Click();
            #endregion

            #region Timer
            PropertiesCollection.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            Thread.Sleep(1000);
            #endregion
           
            TakeScreenshot(@"d:\screen\SearchResults.png");

        }
    }
}
