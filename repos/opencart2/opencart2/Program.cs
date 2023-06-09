﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;

namespace opencart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            excel.Application xlapp = new excel.Application();
            excel.Workbook xwb = xlapp.Workbooks.Open("C:\\Users\\Administrator\\Desktop\\registercsharp.xlsx");
            excel._Worksheet xws = xwb.Sheets[1];
            excel.Range r1 = xws.UsedRange;
            Console.WriteLine(r1);

            for (int i = 1; i <= 4; i++)
            {
                String email, password, firstname, lastname;

                firstname = r1.Cells[1][i].value;
                lastname = r1.Cells[2][i].value;
                email = r1.Cells[3][i].value;
                password = r1.Cells[4][i].value;
                Console.WriteLine("Hello World and Welcome to c#");
                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://demo.opencart.com/");
                driver.FindElement(By.LinkText("My Account")).Click();
                driver.FindElement(By.LinkText("Register")).Click();
                driver.FindElement(By.Id("input-firstname")).SendKeys(firstname);
                driver.FindElement(By.Id("input-lastname")).SendKeys(lastname);
                driver.FindElement(By.Id("input-email")).SendKeys(email);
                driver.FindElement(By.Id("input-password")).SendKeys(password);
                driver.FindElement(By.Id("input-newsletter-yes")).Click();
                driver.FindElement(By.XPath("//input[@type='checkbox']")).Click();
                driver.FindElement(By.XPath("//button[@type='submit']")).Click();
                driver.Quit();
            }
        }
    }
}