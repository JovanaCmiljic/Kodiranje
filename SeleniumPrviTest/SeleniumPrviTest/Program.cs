using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPrviTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            driver.Manage().Window.Maximize();

            IWebElement userName = driver.FindElement(By.Id("user-name"));
            userName.SendKeys("standard_user");
            
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("secret_sauce");

            IWebElement loginButton = driver.FindElement(By.Id("login-button"));
            loginButton.Submit();

            driver.Quit();
        }
    }
}
