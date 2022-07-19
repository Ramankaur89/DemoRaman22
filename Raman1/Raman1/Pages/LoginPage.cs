using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raman1.Pages
{
    public class LoginPage
    {
        public void LoginAction(google)
        {
            IWebDriver google = new ChromeDriver();
            google.Manage().Window.Maximize();

            // go to turnup portal
            global::System.Object value = google.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");


            // locate username text box and enter a valid user name
            IWebElement usernameTextbox = google.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");


            // locate a password text box and enter a valid password

            IWebElement passwordTextbox = google.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // locate a login button and click on it

            IWebElement LoginButton = google.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            LoginButton.Click();





        }
    }

    
}
