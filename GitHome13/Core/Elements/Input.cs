using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome13.Core.Elements
{
    public class Input : BaseElement
    {
        public Input(By locator) : base(locator)
        {
        }

        public Input(string locator) : base($"//input[@name='{locator}']")
        {
        }
    }
}
