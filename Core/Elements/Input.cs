using OpenQA.Selenium;

namespace GitHome13.Core.Elements
{
    public class Input : BaseElement
    {
        public Input(By locator) : base(locator)
        {
        }

        public Input(string name) : base($"//label[text()='{name}']/following-sibling::div/input")
        {
        }
    }
}
