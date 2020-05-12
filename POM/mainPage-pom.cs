using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace POM{
    public class mainPage
    {
        public IWebDriver driver;
        public WebDriverWait wait;

        public IWebElement FindElement(By by){
            return wait.Until(drv => drv.FindElement(by));
        }
    }
}