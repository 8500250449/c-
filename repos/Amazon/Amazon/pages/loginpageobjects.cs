using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.pages
{
    public class loginpageobjects
    {
        private IWebDriver driver;
        public loginpageobjects(IWebDriver driver1)
        {
            driver = driver1;
        }

        public void clickonmyaccountlink()
        {
            driver.FindElement(By.LinkText("My Account")).Click();
        }

        public void clickonloginlink()
        {
            
            driver.FindElement(By.LinkText("Login")).Click();
           
        }
        public void enteremail()
        {
            driver.FindElement(By.Id("input-email")).SendKeys("Divya@gmail.com");

        }

        public void enterpassword()
        {
            driver.FindElement(By.Id("input-password")).SendKeys("Divya@6155");
        }
        
        public void clickonsubmit()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }
          
    }
}
