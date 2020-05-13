using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM;

namespace C_testSuite
{
    public class LoginPageMain : mainTest {
    public LoginPageMain(){
        //initalize any test
    }
      //[Fact]
      //[Trait("Category","SmokeTest")]
    [Theory]
    [InlineData("standard_user","secret_sauce")]
    [InlineData("problem_user","secret_sauce")]
    [InlineData("performance_glitch_user","secret_sauce")]
      public void positiveTestLogin(string username,string password){
          login(username,password);
          Assert.True(inventoryPage.ShoppingCartDisplayed());
      }
      /*[Fact]
      [Trait("Category","SmokeTest")]*/
      [Theory]
      [InlineData("standard_user","fsfsd")]
      [InlineData("problem_user","fsdfsdf")]
      [InlineData("performance_glitch_user","fdsfs")]
      [InlineData("locked_out_user","secret_sauce")]
      [InlineData("#@EWRERERWERW$#*4839","#@EWRERERWERW$#*4839")]
      [InlineData("12345645789","12345645789")]
      [InlineData("standard_user"," ")]
      [InlineData(" ","secret_sauce")]
      [InlineData(" "," ")]
      public void negativeTestLogin(string username,string password){
          //loginPage.Login("standard_user","secret_sauc");
          login(username,password);
          Assert.True(loginPage.ErrorMessageDisplayed());
      }

    }
}