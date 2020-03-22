using Xunit.Gherkin.Quick;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UItests_Moraru.PageTitle
{
    [FeatureFile("./PageTitle/TitleVerification.feature")]
    public class PageTitleVerification : Feature
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"A site with three pages")]
        public void Navigate_homepage()
        {
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
        }

        [When(@"asserting home page title with the example it coincides")]
        public void Assert_homepage_title()
        {
            try
            {
                Xunit.Assert.Equal("UI Testing Site", driver.Title);
            } catch
            {
                driver.Quit();
                throw;
            }       
        }

        [Then(@"navigate to Form page")]
        public void Nav_to_formpage()
        {
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/form.html");
        }

        [And(@"verify page2 title")]
        public void Verify_page2_title()
        {
            try
            {
                Xunit.Assert.Equal("UI Testing Site", driver.Title);
            }
            catch
            {
                driver.Quit();
                throw;
            }
        }

        [Then(@"navigate to error page")]
        public void Nav_to_error_page()
        {
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/error");
        }

        [And(@"verify error page title")]
        public void Verify_errorpage_title()
        {
            try
            {
                Xunit.Assert.Equal("UI Testing Site", driver.Title);
            } catch
            {
                driver.Quit();
                throw;
            }
        }

        [Then(@"close the browser")]
        public void Close_browser()
        {
            driver.Quit();
        }
    }
}
