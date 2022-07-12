using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowProject1.Features
//namespace OrangeHRM.App.UI.Tests.Features
{
    [Binding]
    public class CalculatorSteps

    {
        
       
            IWebDriver driver = new ChromeDriver();
        


        [Given(@"Connect to the url of '(.*)'")]
        public void GivenConnectToTheUrlOf(string p0)
        {
            driver.Navigate().GoToUrl(p0);
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/button[1]/span")).Click();

            
        }
        
       
        [Given(@"Enter postcode as '(.*)'")]
        public void GivenEnterPostcodeAs(string p0)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.FindElement(By.Id("location-finder__input-00000160-4eeb-de17-a579-dffb7ab70000")).Click();
            driver.FindElement(By.Id("location-finder__input-00000160-4eeb-de17-a579-dffb7ab70000")).Clear();
            driver.FindElement(By.Id("location-finder__input-00000160-4eeb-de17-a579-dffb7ab70000")).SendKeys(p0);
            
        }
        
        [Given(@"Select the first item at the list of addresses")]
        public void GivenSelectTheFirstItemAtTheListOfAddresses()
        {
            driver.FindElement(By.Id("location-finder__input-00000160-4eeb-de17-a579-dffb7ab70000")).Click();
            driver.FindElement(By.Id("location-finder__input-00000160-4eeb-de17-a579-dffb7ab70000")).SendKeys(Keys.Enter);

        }

        
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
