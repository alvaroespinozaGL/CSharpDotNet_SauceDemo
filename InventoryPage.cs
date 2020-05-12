using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM;

namespace C_testSuite
{
    [Collection ("Non-Paralell")]
    public class InventoryPageMain : mainTest{
        public InventoryPageMain(){
            //add methods here
        }
       
        [Theory]
        [InlineData("standard_user","secret_sauce")]
        [InlineData("problem_user","secret_sauce")]
        [InlineData("performance_glitch_user","secret_sauce")]
        public void InventoryTest(string username,string password){
          login(username,password);
          Assert.True(inventoryPage.ShoppingCartDisplayed());
          inventoryPage.AddFirstItemToCart();
          Assert.True(inventoryPage.IsItemCounterDisplayed());
          Assert.Equal("1",inventoryPage.CurrentItemsCart());
        }
    } 
}