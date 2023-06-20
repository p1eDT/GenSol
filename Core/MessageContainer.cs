using OpenQA.Selenium.DevTools.V111.ServiceWorker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome13.Core
{
    internal class MessageContainer
    {
        public static string errorMessage = "Something went wrong!";

        public static string AccountCreated(string name)
        {
            return string.Format($"Account \"{name}\" was created.");
        }
    }
}
