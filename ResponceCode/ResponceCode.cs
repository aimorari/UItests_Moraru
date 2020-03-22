using System;
using Xunit.Gherkin.Quick;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Net;
using System.IO;

namespace UItests_Moraru.ResponceCode
{
    [FeatureFile("./ResponceCode/ResponceCode.feature")]
    public class ResponceCode : Feature
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"a site")]
        public void open_site()
        {
            //Yes, you are right this step is worthless :-(
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
        }

        [When(@"clicked on ERROR button 404 HTTP response code retrieved")]
        public void error_page()
        {
            HttpWebResponse response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://uitest.duodecadits.com/error");
                request.Method = "GET";

                response = (HttpWebResponse)request.GetResponse();

                StreamReader sr = new StreamReader(response.GetResponseStream());
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    response = (HttpWebResponse)e.Response;
                }
                driver.Quit();
                throw;
            }
            finally
            {
                driver.Quit();
                if (response != null)
                {
                    response.Close();
                }
            }
        }
    }

}