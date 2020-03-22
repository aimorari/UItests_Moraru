using Xunit.Gherkin.Quick;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UItests_Moraru.FormPageUI
{
    [FeatureFile("./FormpageUI/FormpageUI.feature")]
    public class FormPageUI : Feature
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"FORM page with input box")]
        public void Navigate_to_Formpage()
        {
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/form.html");
            try
            {
                IWebElement inp_box = driver.FindElement(By.XPath("//*[@id='hello - input']"));
            }
            catch
            {
                driver.Quit();
            }
        }

        [And(@"submit button")]
        public void Button_prezent()
        {
            try
            {
                IWebElement btn = driver.FindElement(By.XPath("//*[@id='hello - submit']"));
            }
            catch
            {
                driver.Quit();
            }
        }
    }
}