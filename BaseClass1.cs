using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class BaseClass1
    {
        private IWebDriver driver;

        public IWebDriver GetDriverInsance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }

            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.dcb.kg/ru/");
            return driver;
        }

        public void SaHello()
        {
            System.Console.WriteLine("hi");
        }
    }
}
