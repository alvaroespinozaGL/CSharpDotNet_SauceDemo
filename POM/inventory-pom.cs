using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace POM{
public class InventoryPage : mainPage
    {
    public InventoryPage(IWebDriver driver){
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
     }      
        private IWebElement ShoppingCartContainer => this.FindElement(By.Id("shopping_cart_container"));
         private IWebElement addToCartButton => this.FindElement(By.CssSelector(".btn_primary.btn_inventory"));
         private IWebElement ShoppingCartCounter => this.FindElement(By.CssSelector(".fa-layers-counter.shopping_cart_badge"));
         public bool ShoppingCartDisplayed(){
             return ShoppingCartContainer.Displayed;
         }
         public void AddFirstItemToCart(){
             addToCartButton.Click();
         }
         public bool IsItemCounterDisplayed(){
             return ShoppingCartCounter.Displayed;
         }
         public string CurrentItemsCart(){
             return ShoppingCartCounter.Text;
         }
    }
}