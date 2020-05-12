using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM;

namespace C_testSuite
{
    public class mainTest : IDisposable
    {
        public IWebDriver driver;
        public LoginPage loginPage;
        public InventoryPage inventoryPage;

        public mainTest(){
            driver = new ChromeDriver();
            loginPage =new LoginPage(driver);
            inventoryPage = new InventoryPage(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        
        public void login(string username,string password){
            loginPage.Login(username,password);
        }

        public void Dispose(){
            driver.Quit();
        }
    }
}