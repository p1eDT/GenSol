using GitHome13.Core;
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
        string additionalActionsMenuTemplate = "//a[text()='{0}']/ancestor::tr/descendant::span[contains(text(),'Show')]";
        Button delete = new(By.XPath("//a[@title='Delete']"));
        Button edit = new(By.XPath("//a[@title='Delete']"));
        Button deleteСonfirmation = new(By.XPath("//button[@title='Cancel']"));

        public void CreateAccount(string name, string listOption)
        {
            accountName.GetElement().SendKeys(name);
            type.Select(listOption);
            save.GetElement().Click();
        }

        public void DeleteAccount(string name)
        {
            OpenAdditionalMenu(name);
            delete.GetElement().Click();
            deleteСonfirmation.GetElement().Click();
        }

        public void EditAccount(string name, string listOption)
        {
            OpenAdditionalMenu(name);
            edit.GetElement().Click();
            CreateAccount(name, listOption);
        }

        private void OpenAdditionalMenu(string name)
        {
            var additionalActionsMenu = string.Format(additionalActionsMenuTemplate, name);
            Browser.Instance.Driver.FindElement(By.XPath(additionalActionsMenu)).Click();
        }
    }
}