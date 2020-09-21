using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.PurchaseOrder_Decorators
{
    public abstract class DriverDecorator : Driver
    {
        protected readonly Driver Driver;

        protected DriverDecorator(Driver driver)
        {
            Driver = driver;
        }

        public override void Start(Browser browser)
        {
            Driver?.Start(browser);
        }

        public override void Quit()
        {
            Driver?.Quit();
        }

        public override void GoToUrl(string url)
        {
            Driver?.GoToUrl(url);
        }

        public override Element FindElement(By locator)
        {
            return Driver?.FindElement(locator);
        }

        public override List<Element> FindElements(By locator)
        {
            return Driver?.FindElements(locator);
        }
    }
}
