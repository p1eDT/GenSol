using OpenQA.Selenium;

namespace GitHome12
{
    internal class CheckBoxTests : BaseTest
    {
        [Test]
        public void CheckBox()
        {
            driver.FindElement(By.LinkText("Checkboxes")).Click();

            List<IWebElement> checkboxes = driver.FindElements(By.TagName("Input")).ToList();
            Assert.IsNotEmpty(checkboxes);

            var checkBoxOne = checkboxes[0];
            var checkBoxTwo = checkboxes[1];

            SetCheckBoxState(checkBoxOne, true);
            SetCheckBoxState(checkBoxOne, false);
            SetCheckBoxState(checkBoxTwo, false);
            SetCheckBoxState(checkBoxTwo, true);

            checkBoxOne.Click();
            var selected = checkBoxOne.Selected;
            var selectedByAttribute = checkBoxOne.GetAttribute("checked");

            selected = checkBoxTwo.Selected;
            selectedByAttribute = checkBoxTwo.GetAttribute("checked");
        }
        public void SetCheckBoxState(IWebElement element, bool flag)
        {
            var selected = element.Selected;
            bool.TryParse(element.GetAttribute("checked"),out bool selectedByAttribute);

            if((selected || selectedByAttribute) != flag)
            {
                element.Click();
            }
        }
    }
}