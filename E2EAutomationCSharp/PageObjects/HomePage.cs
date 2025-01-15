using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;

namespace E2EAutomationCSharp.PageObjects
{

    //driver.FindElement(By.Name("search")).SendKeys("Apple");
    public class HomePage
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver)
        { 
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "search")]
        private IWebElement searchField;

        public IWebElement getSearchField() { 
            return searchField;
        }
    }

    ;



}
