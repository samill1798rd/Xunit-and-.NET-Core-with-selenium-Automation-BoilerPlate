using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Test
{
    public  class TestHomePage : Tests
    {

        [Test]
        public void TestLoginSuccess()
        {
            homePage.setUserName("standard_user");
            homePage.setUserPassWord("secret_sauce");
            homePage.clickBtnLogin();

        }
    }
}
