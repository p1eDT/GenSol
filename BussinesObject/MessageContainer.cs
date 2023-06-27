using _Core;
using OpenQA.Selenium;

namespace _BussinesObject
{
    public class MessageContainer
    {
        public static string errorMessage = "Something went wrong!";
        private static By sucessAlert = By.XPath("//div[@data-key='success']/div/descendant::span");

        public static string AccountCreated(string name)
        {
            return string.Format($"Account \"{name}\" was created.");
        }

        public static string ContactCreated(string name)
        {
            return string.Format($"Contact \"{name}\" was created.");
        }

        public static string ExpectedAlert(string objectName, string name, State state)
        {
            return string.Format($"{objectName} \"{name}\" was {state}.");
        }

        public static string GetAlertText()
        {
            return Browser.Instance.Driver.FindElement(sucessAlert).Text;
        }
    }
}
