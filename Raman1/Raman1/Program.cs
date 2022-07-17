// open Chrome Browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

Thread.Sleep(1500);
IWebElement helloHari = google.FindElement(By.XPath("//html/body/div[3]/div/div/form/ul/li/a"));

if(helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in successfulyy, test passed");
}
else
{
    Console.WriteLine("Login failed,test failed");
}



