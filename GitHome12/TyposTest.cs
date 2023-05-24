using OpenQA.Selenium;

namespace GitHome12
{
    public class TyposTests : BaseTest
    {
        [Test]
        public void CheckTableValue()
        {
            driver.FindElement(By.LinkText("Typos")).Click();

            List<string> expectedText = new List<string>
                { "This example demonstrates a typo being introduced. It does it randomly on each page load.",
                  "Sometimes you'll see a typo, other times you won't." 
                };

            var paragraphs = driver.FindElements(By.TagName("p")).ToList();
            Assert.Multiple(() =>
                {
                    for (int i = 0; i < expectedText.Count; i++)
                    {
                        Assert.That(paragraphs[i].Text, Is.EqualTo(expectedText[i]));
                    }
                });
        }
    }
}