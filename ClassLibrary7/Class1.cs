﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ClassLibrary7
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void tcLogin()
        {
            string url = "172.16.51.47/WebApplicationMsois/Login.aspx";
            string Username = "admin";
            string Password = "admin@123";
            
            IWebDriver oWD = new ChromeDriver();
            oWD.Navigate().GoToUrl(url);
            oWD.FindElement(By.Id("inputEmail")).SendKeys(Username);
            oWD.FindElement(By.Id("inputPassword")).SendKeys(Password);
            oWD.FindElement(By.Id("btnLogin")).Click();

            //oWD.Close();
        }

    }
}
