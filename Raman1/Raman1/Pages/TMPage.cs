using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raman1.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver google)
        {
            //Select "create new" tab and click on it
            IWebElement createNewButton = google.FindElement(By.CssSelector("#container > p > a"));
            createNewButton.Click();
            Thread.Sleep(1500);


            //enter in code box
            IWebElement codeTextBox = google.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("Raman");

            //enter "test" in description box
            IWebElement descriptionTextBox = google.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("Try1");
            Thread.Sleep(1000);

            //making price tag interacible
            IWebElement priceTag = google.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
            priceTag.Click();


            //enter "$10.00" in price box
            IWebElement priceTextBox = google.FindElement(By.Id("Price"));
            priceTextBox.SendKeys("$10.00");


            //click on "save" button
            IWebElement saveButton = google.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1500);

            //go to the "last page"
            IWebElement goToLastPageButton = google.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();



            //check if material record has been created successfully
            IWebElement newCode = google.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));


            if (newCode.Text == "Raman")
            {
                Console.WriteLine("New material record created successfully");
            }
            else
            {
                Console.WriteLine("new material record hasn't been created");
            }

            google.Close();




        }

        public void EditTM()
        {
            //edit time and material code

        }

        public void DeleteTM()
        {
            //delete time and material code

        }
    
    
    
    
    
    
    
    
    }






















}

