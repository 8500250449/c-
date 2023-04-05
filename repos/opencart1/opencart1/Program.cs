using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;

namespace opencart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            excel.Application xlapp = new excel.Application();
            excel.Workbook xwb = xlapp.Workbooks.Open("C:\\Users\\Administrator\\Desktop\\logincsharp.xlsx");
            excel._Worksheet xws = xwb.Sheets[1];
            excel.Range r1 = xws.UsedRange;
            Console.WriteLine(r1);

            for (int i = 1; i <= 3; i++)
            {
                String username, password;

                username = r1.Cells[1][i].value;
                password = r1.Cells[2][i].value;
                Console.WriteLine("Hello World and Welcome to c#");
                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://demo.opencart.com/");
                driver.FindElement(By.LinkText("My Account")).Click();
                driver.FindElement(By.LinkText("Login")).Click();
                driver.FindElement(By.Id("input-email")).SendKeys(username);
                driver.FindElement(By.Id("input-password")).SendKeys(password);
                driver.FindElement(By.XPath("//button[@type='submit']")).Click();
                driver.Quit();
            }
        }
    }
}