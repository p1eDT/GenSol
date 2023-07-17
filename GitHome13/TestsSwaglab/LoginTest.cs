using _Core;
using Allure.Net.Commons;
using GitHome13.Pages;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GitHome13.Tests
{
    internal class LoginTest : SaleforceBaseTest
    {
        [Test]
        public void Login_StandartUser()
        {
            var inventoryPage = new LoginPage().OpenPage().LoginAsStandartUser();
        }

        [Test]
        public void Login_PerformanceGlitchUser()
        {
            var InventoryPage = new LoginPage().OpenPage().LoginAsPerformanceGlitchUser();
        }

        [Test]
        public void test32()
        {
            Pen pen = new Pen(System.Drawing.Color.DarkRed, 3);

            var page = new LoginPage().OpenPage();

            //размеры всего окна
            var windowWidth = Browser.Instance.Driver.Manage().Window.Size.Width;
            var windowHeight = Browser.Instance.Driver.Manage().Window.Size.Height;

            //размеры рабочей области страницы
            var contentWidth = ExecutreJS("return window.innerWidth");
            var contentHeight = ExecutreJS("return window.innerHeight");

            //создание пустого объекта с заданными размерами
            Bitmap bmpScreenshot = new Bitmap(contentWidth, contentHeight);

            //объект Griphics, без него не получить доступ к методу "скриншота" CopyFromScreen
            var g = Graphics.FromImage(bmpScreenshot);

            //копируем с экрана в созданный ранее объект
            //прописываю левый верхний угол
            g.CopyFromScreen(0, (windowHeight - contentHeight)/2, 0, 0, Browser.Instance.Driver.Manage().Window.Size);

            By PasswordInput = By.XPath("//*[@data-test='password']");
            var element = Browser.Instance.Driver.FindElement(PasswordInput);

            //рисуем рамочку по параметрам: левый верхний угол(x,y), ширина, высота
            g.DrawRectangle(pen, element.Location.X, element.Location.Y, element.Size.Width, element.Size.Height);

            bmpScreenshot.Save("Rectangle.png");
        }

        public int ExecutreJS(string jsCode)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser.Instance.Driver;
            var result = (Int64)js.ExecuteScript(jsCode);

            return (int)result;
        }
    }
}
