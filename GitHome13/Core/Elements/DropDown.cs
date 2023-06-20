using OpenQA.Selenium;

namespace GitHome13.Core.Elements
{
    internal class DropDown:BaseElement
    {
        public DropDown(By locator) : base(locator)
        {
        }

        public DropDown(string name) : base($"//button[contains(@aria-label,'{name}')]")
        {
        }

        public void Select(string option)
        {
            var dropDown = WebDriver.FindElement(locator);
            dropDown.Click();
            dropDown.SendKeys(option);
            dropDown.SendKeys(Keys.Enter);
        }
    }
}