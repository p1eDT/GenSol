using GitHome13.Core.Elements;
using GitHome13.Pages;
using OpenQA.Selenium;

namespace GitHome13.Salesforce.Pages
{
    public class NewAccountModal
    {
        Input accountName = new("Account Name");
        DropDown type = new("Type");
        Button save = new("SaveEdit");
        Button cancel = new("CancelEdit");
        Button saveAndNew = new("SaveAndNew");

        public void CreateAccount(string name, string listOption)
        {
            accountName.GetElement().SendKeys(name);
            type.Select(listOption);
            save.GetElement().Click();
        }
    }
}