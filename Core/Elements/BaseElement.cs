﻿using OpenQA.Selenium;

namespace GitHome13.Core.Elements
{
    public class BaseElement
    {
        protected IWebDriver WebDriver => Browser.Instance.Driver;

        public IWebElement GetElement() => WebDriver.FindElement(locator);
        protected By locator;

        public BaseElement(By locator)
        {
            this.locator = locator;
        }

        public BaseElement(string xpath)
        {
            locator = By.XPath(xpath);
        }
        public object ClickElementViaJs()
        {
            return Browser.Instance.ExecuteScript("arguments[0].click();", contactTab);
        }
    }
}
