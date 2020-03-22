using Xunit.Gherkin.Quick;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UItests_Moraru.UITButtonClick
{
    [FeatureFile("./UITButtonClick/UITButtonClick.feature")]
    public class UITButtonClick : Feature
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"a site with the UI Testing button")]
        public void Navigate_on_Site()
        {
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
        }

        [When(@"click on UI Testing button, HOME page displayed")]
        public void Click_uitbutton_mainpage()
        {
            IWebElement uit_button = driver.FindElement(By.XPath("//*[@id='site']"));
            uit_button.Click();

            // Verification if HOME page displayed
            IWebElement elem = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/h1"));
            Xunit.Assert.Equal("Welcome to the Docler Holding QA Department", elem.Text);
        }

        [Then(@"on FORM page clicked on UI Testing button, the HOME page displayed")]
        public void Click_uitbutton_formpage()
        {
            try
            {
                driver.FindElement(By.XPath("//*[@id='site']")).Click();

                // Verification if HOME page displayed
                IWebElement elem = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/h1"));
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