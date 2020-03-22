using Xunit.Gherkin.Quick;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;

namespace UItests_Moraru.HomeButtonActive
{
    [FeatureFile("./ActiveHomeButton/ActiveHomeButton.feature")]
    public class ActiveHomeButton : Feature
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"FORM page with home button")]
        public void Navigate_Formpage()
        {
            string bnt_back_gnd = null;

            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/form.html");

            try
            {
                IWebElement home_btn = driver.FindElement(By.XPath("//*[@id='home']"));

                bnt_back_gnd = home_btn.GetCssValue("background-color");
                //Insure that HOME button is not active
                Xunit.Assert.Equal("rgba(0, 0, 0, 0)", bnt_back_gnd);
                
                home_btn.Click();
            } catch
            {
                driver.Quit();
                throw;
            }
        }

        [When(@"click on HOME button it becomes active")]
        public void Homebutton_active()
        {
            string btn_back_gnd = null;

            try
            {
                IWebElement home_btn_active = driver.FindElement(By.XPath("//*[@id='home']"));
                btn_back_gnd = home_btn_active.GetCssValue("background-color");

                Xunit.Assert.Equal("rgba(8, 8, 8, 1)", btn_back_gnd);
            } catch
            {
                driver.Quit();
                throw;
            } finally
            {
                driver.Quit();
            }
            
        }
    }
}

//Given FORM page with home button
//	When click on HOME button it becomes active