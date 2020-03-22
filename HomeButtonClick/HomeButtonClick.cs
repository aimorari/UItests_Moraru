using Xunit.Gherkin.Quick;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UItests_Moraru.HomeButtonClick
{
    [FeatureFile("./HomeButtonClick/HomeButton.feature")]
    public class FormButtonClick : Feature
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"a site with the HOME butoon")]
        public void Navigate_on_Site()
        {
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
        }

        [When(@"click on HOME button, HOME page displayed")]
        public void Click_homebutton_mainpage()
        {
            IWebElement home_button = driver.FindElement(By.Id("home"));
            home_button.Click();

            // Verifying if Home page is displayed
            IWebElement elem = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/h1"));
            Xunit.Assert.Equal("Welcome to the Docler Holding QA Department", elem.Text);
        }

        [Then(@"on FORM page clicked on HOME button, the HOME page displayed")]
        public void Click_homebutton_formpage()
        {
            try
            {
                // Navigate to FORM page
                driver.Navigate().GoToUrl("http://uitest.duodecadits.com/form.html");

                // Find and click on HOME button on form page
                driver.FindElement(By.Id("home")).Click();
                IWebElement elem = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/h1"));

                // Verification if HOME page dicplayed
                Xunit.Assert.Equal("Welcome to the Docler Holding QA Department", elem.Text);
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