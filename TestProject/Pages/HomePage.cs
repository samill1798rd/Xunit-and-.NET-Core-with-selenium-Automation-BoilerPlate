using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TestProject.Pages
{
    public class HomePage
    {
        private ChromeDriver _driver;

        By userName = By.Id("user-name");
        By passWord = By.Id("password");
        By btnLogin = By.Id("login-button");

        public HomePage(ChromeDriver driver)
        {
            _driver = driver;
        }

        public void setUserName(string userNameText)
        {
            Thread.Sleep(2000);
            _driver.FindElement(userName).SendKeys(userNameText);
        }

        public void setUserPassWord(string userPasswordText)
        {
            Thread.Sleep(2000);
            _driver.FindElement(passWord).SendKeys(userPasswordText);
        }

        public void clickBtnLogin()
        {
            Thread.Sleep(2000);
            _driver.FindElement(btnLogin).Click();
        }


    }
}
