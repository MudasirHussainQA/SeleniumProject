﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.PurchaseOrder_Decorators
{
    public class LoggingDriver : DriverDecorator
    {
        public LoggingDriver(Driver driver)
        : base(driver)
        {
        }

        public override void Start(Browser browser)
        {
            Console.WriteLine($"Start browser = {Enum.GetName(typeof(Browser), browser)}");
            Driver?.Start(browser);
        }

        public override void Quit()
        {
            Console.WriteLine("Close browser");
            Driver?.Quit();
        }

        public override void GoToUrl(string url)
        {
            Console.WriteLine($"Go to URL = {url}");
            Driver?.GoToUrl(url);
        }

        public override Element FindElement(By locator)
        {
            Console.WriteLine("Find Element");
            return Driver?.FindElement(locator);
        }

        public override List<Element> FindElements(By locator)
        {
            Console.WriteLine("Find elements");
            return Driver?.FindElements(locator);
        }
    }
}
