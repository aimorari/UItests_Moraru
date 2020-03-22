using Xunit.Gherkin.Quick;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UItests_Moraru.CompanyLogo
{
    [FeatureFile("./CompanyLogo/LogoVisible.feature")]
    public class CompanyLogoVisible : Feature
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"A site with the company logo")]
        public void Navigate_homepage()
        {
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
        }

        [When(@"page displayed logo have to be visible")]
        public void Homepage_logo_visible()
        {
            try
            {
                _ = driver.FindElement(By.ClassName("img-responsive")).Displayed;
            } catch
            {
                driver.Quit();
                throw;
            }
            
        }

        [Then(@"on the FORM page logo have to visible")]
        public void Formpage_logo_visible()
        {
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/form.html");
            try
            {
                _ = driver.FindElement(By.Id("dh_logo")).Displayed;
            }
            catch
            {
                driver.Quit();
                throw;
            }
        }

        [And(@"on the ERROR page logo have to be visible")]
        public void Errorpage_logo_visible()
        {
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/error");
            try
            {
                _ = driver.FindElement(By.Id("dh_logo")).Displayed;
            }
            catch
            {
                driver.Quit();
                throw;
            }
        }
    }
}
