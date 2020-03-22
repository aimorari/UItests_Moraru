using Xunit.Gherkin.Quick;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UItests_Moraru.FormButtonClick
{
    [FeatureFile("./FormButtonClick/FormButtonClick.feature")]
    public class UITButtonClick : Feature
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"a site with the FORM button")]
        public void Navigate_on_Site()
        {
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
        }

        [When(@"click on FORM button, HOME page displayed")]
        public void Click_formbutton_mainpage()
        {
            IWebElement form_button = driver.FindElement(By.Id("form"));
            form_button.Click();

            // Verification if FORM page displayed
            IWebElement elem = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/h1"));
            Xunit.Assert.Equal("Simple Form Submission", elem.Text);
        }

        [Then(@"on FORM page clicked on FORM button, the FORM page displayed")]
        public void Click_formbutton_formpage()
        {
            try
            {
                driver.FindElement(By.Id("form")).Click();

                // Verification if FORM page displayed
                IWebElement elem = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/h1"));
                Xunit.Assert.Equal("Simple Form Submission", elem.Text);
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