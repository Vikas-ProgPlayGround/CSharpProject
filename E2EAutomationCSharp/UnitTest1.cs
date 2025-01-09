using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace E2EAutomationCSharp
{
    public class Tests
    {
        private IWebDriver driver; 
        
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            
        }

        [Test]
        public void Test1()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://ecommerce-playground.lambdatest.io/");
            String page_title = driver.Title;
            TestContext.Progress.Write(page_title);
            Assert.That(page_title, Is.EqualTo("Your Page"));
            //Assert.AreEqual(page_title, "Your Page");
            //Assert.Pass();
        }

        [TearDown]
        public void TearDown() {
            if (driver != null) {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}