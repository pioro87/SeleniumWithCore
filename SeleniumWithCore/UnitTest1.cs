using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWithCore
{
    public class Tests : DriverHelper
    {

        [SetUp]
        public void Setup()
        {          
            Driver = new ChromeDriver("C:\\chromeDriver87");
            // ChromeOptions chromeOptions = new ChromeOptions();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

            Driver.FindElement(By.XPath("//input[@name = 'ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();
            
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

            //Driver.Quit();

        }

        //xpath find element net to chck box like Celery f12 find element
        // w przegl�darce wcisna� tab console
        // wpisa� (aby znale�� xpath) $x("//input(bo Celery jest w klasie input)")
        // $x("//input[@name = 'ctl00$ContentPlaceHolder1$ChildMeal1']")
        //Aby znale�� dzieci tego elementu w tym przypadku checkboxa 
        // $x("//input[@name = 'ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div")
        // poka�a si� wszystkie inputy z tym xpathem, po wpisaniu 
        // $x("//input[@name = 'ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")
        // znajdziemy jeden pasuj�cy element

    }
}