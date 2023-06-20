using GitHome13.Core;
using GitHome13.Core.Elements;
using OpenQA.Selenium;

namespace GitHome13.Salesforce.Pages
{
    public class NewContactModal
    {
        Input accountName = new("Last Name");
        PartialTextDropDown typeDropDowncs = new("Account Name");
        Button save = new("SaveEdit");
        Button cancel = new("CancelEdit");
        Button saveAndNew = new("SaveAndNew");
        string additionalActionsMenuTemplate="//a[text()='{0}']/ancestor::tr/descendant::span[contains(text(),'Show')]";
        Button delete = new(By.XPath("//a[@title='Delete']"));
        Button edit = new(By.XPath("//a[@title='Delete']"));
        Button deleteСonfirmation= new(By.XPath("//button[@title='Cancel']"));

        internal void CreateContact(string name, string listOption)
        {
            accountName.GetElement().SendKeys(name);
            typeDropDowncs.Select(listOption);
            typeDropDowncs.Clear();
            typeDropDowncs.SelectByPartText(name);
            save.GetElement().Click();
        }

        /// <summary>
        /// Delete by Name or Account Name.
        /// Name more priority.
        /// </summary>
        /// <param name="name"></param>
        public void DeleteContact(string name)
        {
            OpenAdditionalMenu(name);
            delete.GetElement().Click();
            deleteСonfirmation.GetElement().Click();
        }

        public void EditContact(string name, string listOption)
        {
            OpenAdditionalMenu(name);
            edit.GetElement().Click();
            CreateContact(name, listOption);
        }

        private void OpenAdditionalMenu(string name)
        {
            var additionalActionsMenu = string.Format(additionalActionsMenuTemplate, name);
            //Browser.Instance.Driver.FindElement(By.XPath(additionalActionsMenu)).Click();
            Browser.Instance.ExecuteScript("arguments[0].click();",additionalActionsMenu);
        }
    }
}