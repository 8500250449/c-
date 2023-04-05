using Amazon.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Amazon
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

            loginpageobjects lp = new loginpageobjects(driver);

            driver.Navigate().GoToUrl("https://demo.opencart.com/");

            lp.clickonmyaccountlink();
            lp.clickonloginlink();
            lp.enteremail();
            lp.enterpassword();
            lp.clickonsubmit();

            /*driver.FindElement(By.LinkText("My Account")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("input-email")).SendKeys("Divya@gmail.com");
            driver.FindElement(By.Id("input-password")).SendKeys("Divya@6155");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();*/
            driver.Quit();
            Assert.Pass();
        }
    }
}