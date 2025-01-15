using E2EAutomationCSharp.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace E2EAutomationCSharp.Tests
{
    public class Tests : Base
    {


        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://ecommerce-playground.lambdatest.io/");
            string page_title = driver.Title;
            //TestContext.Progress.Write(page_title);
            Assert.That(page_title, Is.EqualTo("Your Store"));
            Assert.That(page_title, Is.Not.SameAs("Your Page"));

            driver.FindElement(By.Name("search")).SendKeys("Apple");
            Thread.Sleep(3000);
            //Fetching the text entered dynamically at run time
            String textEntered1 = driver.FindElement(By.Name("search")).GetDomProperty("value");
            TestContext.Progress.WriteLine("Fetching the text entered in text box");
            TestContext.Progress.WriteLine(textEntered1);

            //var temp = driver.FindElement(By.XPath("//span[@class='title' and contains(text(),' Mega Menu')]")).Text;
            //TestContext.Progress.Write(temp);
            //var temp = driver.FindElement(By.XPath("//span[@class='title' and contains(text(),' Mega Menu')]"));
            //temp.Click();

            //Assert.AreEqual(page_title, "Your Page");
            //Assert.Pass();
        }

        [Test]
        public void Test2() {
            driver.Navigate().GoToUrl("https://ecommerce-playground.lambdatest.io/");

            //Anyone of the below xpaths will work
            driver.FindElement(By.XPath("//a[@aria-label='Shop by Category' and contains(., 'Shop by Category')]")).Click();
            //driver.FindElement(By.XPath("//a[@aria-label='Shop by Category' and contains(string(.), 'Shop by Category')]")).Click();
            driver.FindElement(By.XPath("//span[contains(.,' Phone, Tablets & Ipod')]/ancestor::a")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(9));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//h4//a[contains(text(),'HTC')]/ancestor::div[@class='product-thumb']")));
            IWebElement productCount = driver.FindElement(By.XPath("//div[contains(@class,'entry-row row order')]//select[contains(@id,'input-limit-')]"));
            productCount.Click();
            SelectElement displayItemNumber = new SelectElement(productCount);
            displayItemNumber.SelectByText("100");
            Thread.Sleep(5000);
            IList<String> productList = ["Sony", "Samsung", "HTC"];
            //Implement the below method to fetch value from above array and add products to cart
            IList<IWebElement> productCarousel = driver.FindElements(By.XPath("//h4//a[contains(text(),'HTC')]/ancestor::div[@class='product-thumb']"));
            foreach (IWebElement item in productCarousel) {
                Actions action = new Actions(driver);
                action.MoveToElement(item).Perform();
                Thread.Sleep(2000);
                item.FindElement(By.XPath("div/div[@class='product-action']/button[@title='Add to Cart']")).Click();
                Thread.Sleep(2000);
            }
            Thread.Sleep(5000);
        }

        [Test]
        public void Test3()
        {
            driver.Navigate().GoToUrl("https://ecommerce-playground.lambdatest.io/");
            //TestContext.Progress.Write(page_title);
            IWebElement element = driver.FindElement(By.XPath("//h3[text()='Top Products']/ancestor::div[2]//div[2]//div[@class='swiper-slide'][1]"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true)", element);
            Thread.Sleep(5000);

        }

        [Test]
        public void Test4()
        {
            driver.Navigate().GoToUrl("https://ecommerce-playground.lambdatest.io/");

            driver.FindElement(By.XPath("//a[@aria-label='Shop by Category' and contains(., 'Shop by Category')]")).Click();
            driver.FindElement(By.XPath("//span[contains(.,' Phone, Tablets & Ipod')]/ancestor::a")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(9));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//h4//a[contains(text(),'HTC')]/ancestor::div[@class='product-thumb']")));
            IWebElement productCount = driver.FindElement(By.XPath("//div[contains(@class,'entry-row row order')]//select[contains(@id,'input-limit-')]"));
            productCount.Click();
            SelectElement displayItemNumber = new SelectElement(productCount);
            displayItemNumber.SelectByText("100");
            Thread.Sleep(5000);
            IList<String> productList = ["Sony", "Samsung", "HTC"];
            //Implement the below method to fetch value from above array and add products to cart
            foreach (String entry in productList) {
                IList<IWebElement> tempProductCarousel = driver.FindElements(By.XPath($"//h4//a[contains(text(),'{entry}')]/ancestor::div[@class='product-thumb']"));
                foreach (IWebElement item in tempProductCarousel)
                {
                    Actions action = new Actions(driver);
                    action.MoveToElement(item).Perform();
                    //Thread.Sleep(2000);
                    item.FindElement(By.XPath("div/div[@class='product-action']/button[@title='Add to Cart']")).Click();
                    //Thread.Sleep(2000);
                }
            }
            Thread.Sleep(5000);

            /*Code to checout by clicking the static checkout icon*/
            //{
            //    driver.FindElement(By.CssSelector(".cart-icon div svg use")).Click();
            //    IWebElement checkoutBtn = driver.FindElement(By.XPath("//a[text() =' Checkout']"));
            //    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[text() =' Checkout']")));
            //    checkoutBtn.Click();
            //}
            driver.FindElement(By.XPath("//a[@class = 'btn btn-secondary btn-block']")).Click();
            String shoppingCartTitle = driver.FindElement(By.CssSelector("#content h1")).Text;
            Assert.That(shoppingCartTitle, Does.Contain("shopping cart").IgnoreCase);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#content a.btn.btn-lg.btn-primary")));
            driver.FindElement(By.CssSelector("#content a.btn.btn-lg.btn-primary")).Click();

            //Page doesn't proceed further
        }


    }
}