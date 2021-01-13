using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWithCore
{
    public class CustomControl : DriverHelper
    {
        public static void ComboBox(string controlName, string value)
        {
            var comboElement = Driver.FindElement(By.XPath($"//input[@id = '{controlName}-awed']"));

            comboElement.Clear();
            comboElement.SendKeys(value);

            Driver.FindElement(By.XPath($"//div[@id = '{controlName}-dropmenu']//li[text()='{value}']")).Click();
        }

    }
}
