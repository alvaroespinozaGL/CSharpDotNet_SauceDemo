using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace POM{
public class LoginPage : mainPage
    {
         public LoginPage(IWebDriver driver){
              this.driver = driver;
              this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
         }
         private IWebElement usernameTextBox => this.FindElement(By.Id("user-name"));
         private IWebElement passwordTextBox => this.FindElement(By.Id("password"));
         private IWebElement loginButton => this.FindElement(By.ClassName("btn_action"));
         private IWebElement errorIcon => this.FindElement(By.ClassName("error-button"));
         private IWebElement ShoppingCartContainer => this.FindElement(By.Id("shopping_cart_container"));

         public bool ShoppingCartDisplayed(){
              return ShoppingCartContainer.Displayed;
         }
         public void Login(string username, string password){
              usernameTextBox.SendKeys(username);
              passwordTextBox.SendKeys(password);
              loginButton.Click();
         }
         public bool ErrorMessageDisplayed(){
              return errorIcon.Displayed;
         }

    }
}
