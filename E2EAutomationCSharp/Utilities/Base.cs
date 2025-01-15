using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System.Configuration;

namespace E2EAutomationCSharp.Utilities
{
    public class Base
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            //String browserName = ConfigurationManager.AppSettings["Browser"];
            // Above line failing as Configuration manager is not fetching the value
            String browserName = "Chrome";
            if (browserName != null) {
                InitBrowser(browserName);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.Manage().Window.Maximize();

            }

        }

        public void InitBrowser(String browserName) {
            switch(browserName){
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "Edge":
                    driver = new EdgeDriver();
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
            }
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}
