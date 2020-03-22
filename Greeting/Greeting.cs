using Xunit.Gherkin.Quick;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UItests_Moraru.Greeting
{
    [FeatureFile("./Greeting/Greeting.feature")]
    public class Greeting : Feature
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"an input value of name as (.+) and submitted")]
        public void Navigate_to_Formpage(string name)
        {
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/form.html");
            try
            {
                IWebElement inp_box = driver.FindElement(By.ClassName("form-control"));
                IWebElement go_btn = driver.FindElement(By.Id("hello-submit"));

                inp_box.SendKeys(name);
                go_btn.Click();

            }
            catch
            {
                driver.Quit();
                throw;
            }
        }

        [Then(@"the following greeting displayed (.+)")]
        public void Greering_result(string grtng)
        {
            try
            {
                IWebElement grtng_txt = driver.FindElement(By.XPath("//*[@id='hello - text']"));
                Xunit.Assert.Equal(grtng, grtng_txt.Text);
            }
            catch
            {
                driver.Quit();
            }
        }
    }
}