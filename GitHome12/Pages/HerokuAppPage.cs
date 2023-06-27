﻿using _BussinesObject.Pages;
using GitHome13.Core;
using OpenQA.Selenium;

namespace GitHome12.Pages
{
    internal class HerokuAppPage : BasePage
    {
        public const string URL_INDEX = "https://the-internet.herokuapp.com/";

        public HerokuAppPage() 
        {
        }

        public override HerokuAppPage OpenPage()
        {
            Browser.Instance.NavigateToUrl(URL_INDEX);
            return this;
        }

        public void ClickExample(string linkText)
        {
            Browser.Instance.Driver.FindElement(By.LinkText(linkText)).Click();
        }
    }
}
