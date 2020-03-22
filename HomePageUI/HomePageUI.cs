using Xunit.Gherkin.Quick;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UItests_Moraru.HomePageUI
{
    [FeatureFile("./HomePageUI/HomepageUI.feature")]
    public class HomePageUI : Feature
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"HOME page with heading text")]
        public void Navigate_on_Site()
        {
            try
            {
                driver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
                IWebElement head_text = driver.FindElement(By.XPath(" / html / body / div[1] / div[1] / h1"));
                Xunit.Assert.Equal("Welcome to the Docler Holding QA Department", head_text.Text);
            } catch
            {
                driver.Quit();
                throw;
            }

        }

        [And(@"paragraph text")]
        public void Caragraph_text_verification()
        {
            try
            {
                IWebElement paragraph_text = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/p"));
                Xunit.Assert.Equal("This site is dedicated to perform some exercises and demonstrate automated web testing.",
                    paragraph_text.Text);
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