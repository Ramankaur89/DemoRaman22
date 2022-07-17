// open Chrome Browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.ComponentModel;

IWebDriver google = new ChromeDriver();
google.Manage().Window.Maximize();

// go to turnup portal
google.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");


// locate username text box and enter a valid user name
IWebElement usernameTextbox = google.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");


// locate a password text box and enter a valid password

IWebElement passwordTextbox = google.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

// locate a login button and click on it

IWebElement LoginButton = google.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
LoginButton.Click();

// check if the user was able to log in sucessfully

Thread.Sleep(1000);
IWebElement helloHari = google.FindElement(By.XPath("//html/body/div[3]/div/div/form/ul/li/a"));

if(helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in successfulyy, test passed");
}
else
{
    Console.WriteLine("Login failed,test failed");
}



//create a new time and material record

//go to "adminitration" tab and click on "time and material" tab
IWebElement administrationtab = google.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationtab.Click();

//select time and material from the drop down menu
IWebElement tmoption = google.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmoption.Click();

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
