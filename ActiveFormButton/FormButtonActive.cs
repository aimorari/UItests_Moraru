using Xunit.Gherkin.Quick;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;

namespace UItests_Moraru.FormButtonActive
{
    [FeatureFile("./ActiveFormButton/ActiveFormButton.feature")]
    public class ActiveFormButton : Feature
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"HOME page with home button")]
        public void Navigate_Formpage()
        {
            string bnt_back_gnd = null;

            driver.Navigate().GoToUrl("http://uitest.duodecadits.com");

            try
            {
                IWebElement form_btn = driver.FindElement(By.XPath("//*[@id='form']"));

                bnt_back_gnd = form_btn.GetCssValue("background-color");
                //Insure that HOME button is not active
                Xunit.Assert.Equal("rgba(0, 0, 0, 0)", bnt_back_gnd);
                
                form_btn.Click();
            } catch
            {
                driver.Quit();
                throw;
            }
        }

        [When(@"click on FORM button it becomes active")]
        public void Formbutton_active()
        {
            string btn_back_gnd = null;

            try
            {
                IWebElement form_btn_active = driver.FindElement(By.XPath("//*[@id='form']"));
                btn_back_gnd = form_btn_active.GetCssValue("background-color");

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