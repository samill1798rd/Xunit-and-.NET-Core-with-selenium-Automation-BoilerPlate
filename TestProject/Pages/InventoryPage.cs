using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TestProject.Pages
{
    public class InventoryPage
    {
        private ChromeDriver driver;

        By homePageIcon = By.Id("react-burger-menu-btn");

        By filterNameHome = By.ClassName("active_option");

        public InventoryPage(ChromeDriver driver)
        {
            this.driver = driver;
        }

        public bool isVisibleHomeIcon()
        {
            return this.driver.FindElement(homePageIcon).Displayed;
        }

        public string getFilterName()
        {
            return this.driver.FindElement(filterNameHome).Text;
        }
    }
}
