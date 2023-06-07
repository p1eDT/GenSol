using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome13.Core.Elements
{
    internal class PartialTextDropDown:BaseElement
    {
        string optionTemplate = "";
        string optionByPartTemplate = "";

        private By ClearSectionCross = By.CssSelector("");
        public PartialTextDropDown(By locator) : base(locator)
        {
        }

        public PartialTextDropDown(string locator) : base($"//label[text()='{locator}']/following-sibling::div/input")
        {
        }
        public void Clear()
        {
            WebDriver.FindElement(By.XPath("button")).Click();
        }

        public new void Select(string option)
        {
            WebDriver.FindElement(locator).Click();
            WebDriver.FindElement(By.XPath($"")).Click();
        }

        public void SelectByPartText(string option)
        {
            WebDriver.FindElement(locator).Click();
            WebDriver.FindElement(By.XPath($"containc")).Click();
        }
    }
}
