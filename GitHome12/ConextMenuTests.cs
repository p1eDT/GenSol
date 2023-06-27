using GitHome12.Pages;
using GitHome13.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome12
{
    internal class ConextMenuTests: _Tests.TestsSwaglab.BaseTest
    {
        [Test]
        public void ContextTest()
        {
            string linkText = "Context Menu";
            string expectedTextAlert = "You selected a context menu";

            new HerokuAppPage().OpenPage().ClickExample(linkText);

            Browser.Instance.ContextClick(By.Id("hot-spot"));
            Assert.That(Browser.Instance.GetAlertText(), Is.EqualTo(expectedTextAlert));

            Assert.Throws<UnhandledAlertException>(() => Browser.Instance.Driver.FindElement(By.TagName("H3")));

            Browser.Instance.ContextClick(By.Id("hot-spot"));
            Browser.Instance.AcceptAllert();
            string titleH3 = Browser.Instance.Driver.FindElement(By.TagName("H3")).Text;
            Assert.That(linkText, Is.EqualTo(titleH3));
        }
    }
}
