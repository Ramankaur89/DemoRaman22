using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raman1.Pages
{
    public class Homepage
    {
        public void GoToTMPage(IWebDriver google)
        {

            //go to "adminitration" tab and click on "time and material" tab
            IWebElement administrationtab = google.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationtab.Click();

            //select time and material from the drop down menu
            IWebElement tmoption = google.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoption.Click();

        }
    }
}
