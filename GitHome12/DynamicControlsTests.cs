using GitHome13.Tests;
using GitHome13.Core;
using GitHome12.Pages;
using OpenQA.Selenium;
using GitHome13.Core.Elements;
using _Core;

namespace GitHome12
{
    internal class DynamicControlsTests : GitHome13.Tests.BaseTest
    {
        [Test]
        public void DynamicTest()
        {
            string url = "Dynamic Controls";

            Input checkoxInput = new(By.XPath("//input[@type='checkbox']"));
            Button removeButton = new(By.XPath("//form[@id='checkbox-example']/button"));
            Button enableButton = new(By.XPath("//form[@id='input-example']/button"));
            Input enableDisableInput = new(By.XPath("//form[@id='input-example']/input"));
            By message = By.CssSelector("p#message");

            string expectedMessageGone = "It's gone!";
            string expectedMessageEnabled = "It's enabled!";

            new HerokuAppPage().OpenPage().ClickExample(url);
            Assert.IsNotNull(checkoxInput.GetElement());

            removeButton.GetElement().Click();
            var textMessage = Browser.Instance.Driver.FindElement(message).Text;
            Assert.That(textMessage, Is.EqualTo(expectedMessageGone));

            //Assert.Catch<NoSuchElementException>(()=>Browser.Instance.Driver.FindElement(By.XPath("//input[@type='checkbox']")));
            Assert.Catch<NoSuchElementException>(()=>checkoxInput.GetElement());

            Assert.True(bool.Parse(enableDisableInput.GetElement().GetAttribute("disabled")));
            enableButton.GetElement().Click();

            textMessage = Browser.Instance.Driver.FindElement(By.CssSelector("form#input-example")).FindElement(message).Text;
            Assert.That(textMessage, Is.EqualTo(expectedMessageEnabled));

            Assert.IsNull(enableDisableInput.GetElement().GetAttribute("disabled"));
        }
    }
}
