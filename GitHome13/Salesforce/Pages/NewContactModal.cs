using GitHome13.Core.Elements;
using OpenQA.Selenium;

namespace GitHome13.Salesforce.Pages
{
    public class NewContactModal
    {
        Input accountName = new("Account Name");
        PartialTextDropDown typeDropDowncs = new("Account Name");
        Button save = new("SaveEdit");
        Button cancel = new("CancelEdit");
        Button saveAndNew = new("SaveAndNew");

        internal void CreateContact(string name, string listOption)
        {
            accountName.GetElement().SendKeys(name);
            typeDropDowncs.Select(listOption);
            typeDropDowncs.GetElement().Clear();
            typeDropDowncs.SelectByPartText("adfg");
            save.GetElement().Click();
        }
    }
}