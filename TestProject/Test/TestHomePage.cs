using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Pages;

namespace TestProject.Test
{
    public  class TestHomePage : Tests
    {

        [Test]
        public void LoginSuccess()
        {
            var invertaryPage = getLogin("standard_user", "secret_sauce");
            Assert.AreEqual(invertaryPage.isVisibleHomeIcon(), true);
            Assert.AreEqual(invertaryPage.getFilterName(),"NAME (A TO Z)");
        }

        [Test]
        public void LoginWront()
        {
            
        }



        private InventoryPage getLogin(string userName, string password)
        {
            homePage.setUserName(userName);
            homePage.setUserPassWord(password);
            return homePage.clickBtnLogin();
        }
    }
}
