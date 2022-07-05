using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TestProject.Pages
{
    public class HomePage
    {
        private ChromeDriver driver;

        By userName = By.Id("user-name");

        By passWord = By.Id("password");

        By btnLogin = By.Id("login-button");

        By errorMsg = By.ClassName("error-message-container");

        public HomePage(ChromeDriver driver)
        {
            this.driver = driver;
        }

        public void setUserName(string userNameText)
        {
            this.driver.FindElement(userName).SendKeys(userNameText);
        }

        public void setUserPassWord(string userPasswordText)
        {
            this.driver.FindElement(passWord).SendKeys(userPasswordText);
        }

        public object clickBtnLogin()
        {
            this.driver.FindElement(btnLogin).Click();
            return chekLoginSucces() != true ? new InventoryPage(this.driver) : null ;
        }

        private bool chekLoginSucces()
        {
            return this.driver.FindElement(errorMsg).Displayed;
        }


    }
}
